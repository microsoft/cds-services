using CDSService.Models.PatientView;
using Hl7.Fhir.Model;
using Models.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TestPatientViewSampleRequestJsonConverter
    {
        private FhirResourceConverter<Patient> _patientConverter;
        private string _patientViewSampleRequestJson;

        [SetUp]
        public void Setup()
        {
            _patientConverter = new FhirResourceConverter<Patient>();
            _patientViewSampleRequestJson = File.ReadAllText("TestData/PatientViewSampleRequest.json");
        }

        [Test]
        public void PatientViewSampleRequestShouldDeserializePrefetch()
        {
            PatientViewSampleRequest req = JsonConvert.DeserializeObject<PatientViewSampleRequest>(_patientViewSampleRequestJson, _patientConverter);

            Assert.AreEqual("c20ccf5d-19ac-4dfe-bdc3-3d1d6344facc", req.Prefetch.Patient.Id);
        }

        [Test]
        public void FhirResourceConverterShouldSerializePatient()
        {
            var p = new Patient
            {
                Id = "c20ccf5d-19ac-4dfe-bdc3-3d1d6344facc"
            };

            string result = JsonConvert.SerializeObject(p, _patientConverter);

            var json = JObject.Parse(result);

            Assert.AreEqual("c20ccf5d-19ac-4dfe-bdc3-3d1d6344facc", json.SelectToken("id").ToString());
        }
    }
}
