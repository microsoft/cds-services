using System.Collections.Generic;
using System.Net;
using CDSService.Models;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Api
{
    public class PatientViewSample
    {
        private readonly ILogger _logger;

        public PatientViewSample(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<PatientViewSample>();
        }

        [Function("PatientViewSample")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "cds-services/patient-view-sample")] HttpRequestData req)
        {
            _logger.LogInformation("PatientViewSample function processed a request.");

            try
            {
                var reqPayload = await req.ReadFromJsonAsync<PatientViewSampleRequest>();
                
                string patientFullName = $"{reqPayload.Prefetch.Patient.Name[0].Given.First()} {reqPayload.Prefetch.Patient.Name[0].Family}";

                var cardResponse = new CardResponse
                {
                    Cards = new List<Card>
                {
                    new Card
                    {
                        Summary = "SMART App Success Card",
                        Indicator = "success",
                        Detail = $"We received data for {patientFullName}.",
                        Source = new Source
                        {
                            Label = "Static CDS Service Example",
                            Url = "https://example.com"
                        },
                        Links = new List<Link>
                        {
                            new Link
                            {
                                Label = "SMART Example App",
                                Url = "https://smart.example.com/launch",
                                Type = "smart"
                            }
                        }
                    }
                }
                };

                var response = req.CreateResponse(HttpStatusCode.OK);
                await response.WriteAsJsonAsync(cardResponse);
                return response;

            }
            catch (Exception ex)
            {
                _logger.LogError("Something went kaboom");
                throw ex;
            }
        }
    }
}
