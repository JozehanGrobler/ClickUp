using System.Text.Json.Serialization;

namespace ClickUp.ClickUpTask;

public record GetTasksResponse(
    [property: JsonPropertyName("tasks")]List<GetTasksTask> Tasks,
    [property: JsonPropertyName("last_page")]bool LastPage);
public record GetTasksTask(
    [property: JsonPropertyName("id")]string Id,
    [property: JsonPropertyName("name")]string Name,
    [property: JsonPropertyName("custom_fields")]List<CustomFieldResponse> CustomFields
);

public record CustomFieldResponse(
    [property: JsonPropertyName("id")]string Id,
    [property: JsonPropertyName("name")]string Name,
    [property: JsonPropertyName("type")]string Type
);