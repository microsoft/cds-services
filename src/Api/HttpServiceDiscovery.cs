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
            //response.Headers.Add("Content-Type", "application/json; charset=utf-8");

            var services = new List<Service>();
            services.Add(new Service
            {
                Hook = "cds-service-sample",
                Id = "cds-service-sample",
                Description = "Sample CDS Hook Service",
                Title = "CDS Service Sample"
            });

            response.WriteAsJsonAsync(services);

            return response;
        }
    }
}
