namespace TestCrypto.Infrastructure.Helpers;

public class HttpClientWrapper(HttpClient httpClient) : IHttpClientWrapper
{
    private readonly HttpClient _httpClient = httpClient;

    public Task<HttpResponseMessage> GetAsync(string url)
    {
        return _httpClient.GetAsync(url);
    }
}
