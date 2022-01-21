using System.Net.Http.Headers;

namespace Core.Request.Models;

public class BaseHttpRequest
{
    public string Url { get; set; }
    public Dictionary<string, string> Headers { get; set; }
}