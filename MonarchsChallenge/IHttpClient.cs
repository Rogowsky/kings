namespace MonarchsChallenge;

internal interface IHttpClient
{
    public Task<HttpResponseMessage> GetAsync(string url);
}

internal class CustomClient : IHttpClient
{
    private static readonly HttpClient _httpClient = new HttpClient();

    public Task<HttpResponseMessage> GetAsync(string url) => _httpClient.GetAsync(url);
}