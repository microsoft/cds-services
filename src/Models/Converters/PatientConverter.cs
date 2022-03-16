using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CDSService.Models.Converters
{
    public class PatientConverter : JsonConverter<Patient>
    {
        public override Patient Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
                reader.Read();
                return FhirJsonNode.Parse(reader.GetString()).ToPoco<Patient>();

        }

        public override void Write(
            Utf8JsonWriter writer,
            Patient patientValue,
            JsonSerializerOptions options) =>
                throw new NotImplementedException();
    }
}
