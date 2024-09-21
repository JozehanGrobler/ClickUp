using System.Text.Json.Serialization;

namespace ClickUp.ClickUpCustomField;

public record GetCustomFieldResponse(
    [property: JsonPropertyName("fields")] List<GetCustomFieldResponseField> Fields
)
{
    public GetCustomFieldResponseField GetField(string fieldName)
    {
        return this.Fields.SingleOrDefault(f => f.Name.Contains(fieldName)) ??
               throw new Exception("Field not found");
    }
}