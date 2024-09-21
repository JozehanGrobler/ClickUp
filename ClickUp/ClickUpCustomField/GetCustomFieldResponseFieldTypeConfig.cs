using System.Text.Json.Serialization;

namespace ClickUp.ClickUpCustomField;

public record GetCustomFieldResponseFieldTypeConfig(
    [property: JsonPropertyName("options")]
    List<GetCustomFieldResponseFieldTypeConfigOption> Options);