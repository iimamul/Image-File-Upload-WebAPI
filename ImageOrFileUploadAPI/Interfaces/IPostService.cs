using ImageOrFileUploadAPI.Requests;
using ImageOrFileUploadAPI.Responses;

namespace ImageOrFileUploadAPI.Interfaces
{
    public interface IPostService
    {
        Task SavePostImageAsync(PostRequest postRequest);
        Task<PostResponse> CreatePostAsync(PostRequest postRequest);
    }
}
