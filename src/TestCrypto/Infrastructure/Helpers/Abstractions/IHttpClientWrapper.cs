namespace TestCrypto.Infrastructure.Helpers.Abstractions;

public interface IHttpClientWrapper
{
    Task<HttpResponseMessage> GetAsync(string url);
}