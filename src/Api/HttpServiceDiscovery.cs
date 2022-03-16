using System.Collections.Generic;
using System.Net;
using CDSService.Models;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace CDSService.Api
{
    public class HttpServiceDiscovery
    {
        private readonly ILogger _logger;

        public HttpServiceDiscovery(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HttpServiceDiscovery>();
        }

        [Function("HttpServiceDiscovery")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "cds-services")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);

            var services = new List<Service>();
            services.Add(new Service
            {
                Hook = "order-sign",
                Id = "cdc-opioid-overdose",
                Description = "CDC Opioid Overdose Sample",
                Title = "CDC Opioid Overdose Sample"                
            });

            services.Add(new Service
            {
                Hook = "patient-view",
                Id = "patient-view-sample",
                Description = "Sample Patient View CDS Hook Service",
                Title = "Patient View Sample Service"
            });

            var result = new ServicePayload
            {
                Services = services
            };

            response.WriteAsJsonAsync(result);

            return response;
        }
    }
}
