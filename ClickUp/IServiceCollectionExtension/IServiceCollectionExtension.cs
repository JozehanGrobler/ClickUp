using ClickUp.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClickUp.IServiceCollectionExtension;

public static class IServiceCollectionExtension
{
    public static void ConfigureClickUp(
        IServiceCollection services,Func<string> getApiKey)
    {
        services.AddHttpClient("ClickUp", client =>
        {
            client.BaseAddress = new Uri("https://api.clickup.com/api/v2/");
            client.DefaultRequestHeaders.Add("Authorization", getApiKey());
        });
        services.AddSingleton<ClickUpClientService>();
        services.AddSingleton<ClickUpCustomFieldService>();
        services.AddSingleton<ClickUpTaskService>();
    }
}