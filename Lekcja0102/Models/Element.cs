using Newtonsoft.Json;

namespace Lekcja0102.Models
{
    public class Element
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        [JsonProperty(PropertyName = "isCompleted")]
        public string Completed { get; set; }
    }
}
