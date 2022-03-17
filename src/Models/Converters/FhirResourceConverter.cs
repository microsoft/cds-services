using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Models.Converters
{
    public class FhirResourceConverter<T> : JsonConverter<T> where T : Hl7.Fhir.Model.Base
    {
        public override T ReadJson(JsonReader reader, Type objectType, T? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var valStr = JRaw.Create(reader).ToString();
            return FhirJsonNode.Parse(valStr).ToPoco<T>();
        }

        public override void WriteJson(JsonWriter writer, T? value, JsonSerializer serializer)
        {
            var fhirSerializer = new FhirJsonSerializer();
            writer.WriteRaw(fhirSerializer.SerializeToString(value));
        }
    }
}
