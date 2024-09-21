using System.Net.Http.Json;
using ClickUp.ClickUpCustomField;
using ClickUp.Services;

namespace ClickUp.Services;

public class ClickUpCustomFieldService(ClickUpClientService clientService)
{
    public async Task<GetCustomFieldResponse?> GetCustomFields(string listId)
    {
        var client = clientService.CreateAuthedClient();
        var request = await client
            .GetAsync("list/" + listId + "/field");
        var response = await request.Content.ReadFromJsonAsync<GetCustomFieldResponse>();
        
        return response;
    }
}