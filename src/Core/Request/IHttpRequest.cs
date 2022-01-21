using Core.Request.Models;

namespace Core.Request;

public interface IHttpRequest
{
    public Task<string> GetRequest(BaseHttpRequest baseRequest);
    Task<string> PostRequest(PostHttpRequest request);
    Task<string> PutRequest(PostHttpRequest request);
}