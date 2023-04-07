using System.Text.Json.Serialization;

namespace ImageOrFileUploadAPI.Requests
{
    public class PostRequest
    {
        public int UserId { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Always)]
        public string? ImagePath { get; set; }
    }
}
