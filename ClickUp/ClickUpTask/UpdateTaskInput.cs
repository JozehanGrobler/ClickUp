using System.Text.Json.Serialization;

namespace ClickUp.ClickUpTask;

// TODO
public record UpdateTaskInput(
    [property: JsonPropertyName("name")]
    string Name,
    [property: JsonPropertyName("status")]
    string Status,
    [property: JsonPropertyName("description")]
    string? Description = null,
    [property: JsonPropertyName("custom_fields")]
    List<CustomTextInput>? CustomFields = null);