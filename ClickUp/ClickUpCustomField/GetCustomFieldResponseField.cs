using System.Text.Json.Serialization;

namespace ClickUp.ClickUpCustomField;

public record GetCustomFieldResponseField(
    [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("type_config")]
    GetCustomFieldResponseFieldTypeConfig TypeConfig,
    [property: JsonPropertyName("date_created")]
    long DateCreated,
    [property: JsonPropertyName("hide_from_guests")]
    bool HideFromGuests,
    [property: JsonPropertyName("required")]
    bool Required
);