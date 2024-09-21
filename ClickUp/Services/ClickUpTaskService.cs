using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ClickUp.ClickUpTask;
using Microsoft.Extensions.Logging;

namespace ClickUp.Services;

public class ClickUpTaskService(
    ILogger<ClickUpTaskService> logger,
    IHttpClientFactory httpClientFactory)
{
    public async Task<CreateTaskResponse?> CreateTask(string listId, CreateTaskInput input)
    {
        var client = httpClientFactory.CreateClient("ClickUp");
        var json = JsonSerializer.Serialize(input);
        var postData = new StringContent(json, Encoding.UTF8, "application/json");
        var request = await client.PostAsync("https://api.clickup.com/api/v2/list/" + listId + "/task", postData);
        var jsonResponse = await request.Content.ReadAsStringAsync();
        logger.LogDebug(json);
        logger.LogDebug("===========");
        logger.LogDebug(jsonResponse);

        try
        {
            var response = await request.Content.ReadFromJsonAsync<CreateTaskResponse>();
            return response;
        }
        catch(Exception ex)
        {
            logger.LogDebug(ex.Message);
            throw new Exception("Unable to parse Json", ex);
        }
    }
    
    public async Task<CreateTaskResponse?> UpdateTask(string taskId, UpdateTaskInput input)
    {
        var client = httpClientFactory.CreateClient("ClickUp");
        var json = JsonSerializer.Serialize(input);
        var postData = new StringContent(json, Encoding.UTF8, "application/json");
        var request = await client.PutAsync(
            "https://api.clickup.com/api/v2/task/" + taskId, postData);
        var response = await request.Content.ReadFromJsonAsync<CreateTaskResponse>();
        return response;
    }
    
    public async Task<GetTasksTask?> GetTask(
        string taskId)
    {
        logger.LogDebug("Task ID:" + taskId);
        var client = httpClientFactory.CreateClient("ClickUp");
        var request = await client.GetAsync(
            "https://api.clickup.com/api/v2/task/" + taskId +
            // "?custom_task_ids=false" +
            // "&team_id=123" +
            // "&include_subtasks=true" +
            // "&include_markdown_description=true" +
            // "&custom_fields=string" +
            "");
        var jsonResponse = await request.Content.ReadAsStringAsync();
        logger.LogDebug("RESPONSE");
        logger.LogDebug(jsonResponse);

        try
        {
            var response = await request.Content.ReadFromJsonAsync<GetTasksTask>();
            logger.LogDebug("===========");
            return response;
        }
        catch(Exception ex)
        {
            logger.LogDebug(ex.Message);
            throw new Exception("Unable to parse Json", ex);
        }
    }
    
    public async Task<GetTasksResponse?> GetTasks(
        string listId,
        int first,
        int? after = 0)
    {
        var client = httpClientFactory.CreateClient("ClickUp");
        var request = await client.GetAsync("https://api.clickup.com/api/v2/list/"
                                            + listId + "/task?archived=false" +
                                            "&include_markdown_description=true" +
                                            "&page="+after +
                                            // "&order_by=string" +
                                            // "&reverse=true" +
                                            // "&subtasks=true" +
                                            // "&statuses=string" +
                                            "&include_closed=true" +
                                            // "&assignees=string" +
                                            // "&watchers=string" +
                                            // "&tags=string" +
                                            // "&due_date_gt=0" +
                                            // "&due_date_lt=0" +
                                            // "&date_created_gt=0" +
                                            // "&date_created_lt=0" +
                                            // "&date_updated_gt=0" +
                                            // "&date_updated_lt=0" +
                                            // "&date_done_gt=0" +
                                            // "&date_done_lt=0" +
                                            // "&custom_fields=string" +
                                            // "&custom_field=string" +
                                            // "&custom_items=0" +
                                            "");
        var jsonResponse = await request.Content.ReadAsStringAsync();
        logger.LogDebug("RESPONSE");
        logger.LogDebug(jsonResponse);

        try
        {
            var response = await request.Content.ReadFromJsonAsync<GetTasksResponse>();
            logger.LogDebug("===========");
            return response;
        }
        catch(Exception ex)
        {
            logger.LogDebug(ex.Message);
            throw new Exception("Unable to parse Json", ex);
        }
    }
}