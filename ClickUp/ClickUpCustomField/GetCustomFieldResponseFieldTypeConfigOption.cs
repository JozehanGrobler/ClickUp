using System.Text.Json.Serialization;

namespace ClickUp.ClickUpCustomField;

public record GetCustomFieldResponseFieldTypeConfigOption(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("color")] string Color,
    [property: JsonPropertyName("orderindex")]
    int OrderIndex
);