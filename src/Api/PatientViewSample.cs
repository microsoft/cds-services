using System.Collections.Generic;
using System.Net;
using CDSService.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

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
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "patient-view-sample")] HttpRequestData req)
        {
            _logger.LogInformation("PatientViewSample function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);

            var cardResponse = new CardResponse
            {
                Cards = new List<Card>
                {
                    new Card
                    {
                        Summary = "SMART App Success Card",
                        Indicator = "success",
                        Detail = "This is an example SMART App success card.",
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

            response.WriteAsJsonAsync(cardResponse);
            return response;
        }
    }
}
