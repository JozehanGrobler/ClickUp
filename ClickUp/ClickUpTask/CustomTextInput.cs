using System.Text.Json.Serialization;

namespace ClickUp.ClickUpTask;

public record CustomTextInput(
    [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("value")] object Value);