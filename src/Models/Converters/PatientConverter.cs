using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CDSService.Models.Converters
{
    public class PatientConverter : JsonConverter<Patient>
    {
        public override Patient ReadJson(JsonReader reader, Type objectType, Patient? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var valStr = JRaw.Create(reader).ToString();
            return FhirJsonNode.Parse(valStr).ToPoco<Patient>();
        }

        public override void WriteJson(JsonWriter writer, Patient? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }        
    }    

}
