using ImageOrFileUploadAPI.Responses.Models;

namespace ImageOrFileUploadAPI.Responses
{
    public class PostResponse:BaseResponse
    {
        public PostModel Post { get; set; }
    }
}
