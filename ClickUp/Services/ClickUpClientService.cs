namespace ClickUp.Services;

public class ClickUpClientService(
    IHttpClientFactory httpClientFactory)
{
    public HttpClient CreateAuthedClient()
        => httpClientFactory.CreateClient("ClickUp");
}