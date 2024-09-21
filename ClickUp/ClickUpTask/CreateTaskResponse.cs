using System.Text.Json.Serialization;

namespace ClickUp.ClickUpTask;

public record CreateTaskResponse(
    [property: JsonPropertyName("id")]string Id,
    [property: JsonPropertyName("name")]string Name,
    [property: JsonPropertyName("text_content")]string TextContent,
    [property: JsonPropertyName("description")]string Description,
    [property: JsonPropertyName("status")]CreateTaskResponseStatus Status,
    [property: JsonPropertyName("order_index")]string Orderindex,
    [property: JsonPropertyName("date_created")]long DateCreated,
    [property: JsonPropertyName("date_updated")]long DateUpdated,
    [property: JsonPropertyName("date_closed")]long? DateClosed,
    [property: JsonPropertyName("date_done")]long? DateDone,
    [property: JsonPropertyName("archived")]bool Archived,
    [property: JsonPropertyName("creator")]Creator Creator,
    [property: JsonPropertyName("assignee")]List<Assignee> Assignees,
    [property: JsonPropertyName("watchers")]List<Watcher> Watchers,
    // [property: JsonPropertyName("check_lists")]List<object> Checklists,
    // [property: JsonPropertyName("tags")]List<object> Tags,
    // [property: JsonPropertyName("parent")]object Parent,
    // [property: JsonPropertyName("priority")]object Priority,
    // [property: JsonPropertyName("due_date")]object DueDate,
    // [property: JsonPropertyName("start_date")]object StartDate,
    // [property: JsonPropertyName("points")]object Points,
    // [property: JsonPropertyName("time_estimates")]object TimeEstimate,
    [property: JsonPropertyName("time_spent")]int TimeSpent,
    [property: JsonPropertyName("custom_fields")]List<CustomField> CustomFields,
    // [property: JsonPropertyName("dependencies")]List<object> Dependencies,
    // [property: JsonPropertyName("linked_tasks")]List<object> LinkedTasks,
    // [property: JsonPropertyName("locations")]List<object> Locations,
    [property: JsonPropertyName("team_id")]string TeamId,
    [property: JsonPropertyName("url")]string Url,
    [property: JsonPropertyName("sharing")]Sharing Sharing,
    [property: JsonPropertyName("permission_level")]string PermissionLevel,
    [property: JsonPropertyName("list")]ListObject List,
    [property: JsonPropertyName("project")]Project Project,
    [property: JsonPropertyName("folder")]Folder Folder,
    [property: JsonPropertyName("space")]Space Space);

public record CustomField(
    [property: JsonPropertyName("id")]string Id,
    [property: JsonPropertyName("name")]string Name,
    [property: JsonPropertyName("type")]string Type,
    [property: JsonPropertyName("date_created")]long DateCreated,
    [property: JsonPropertyName("hide_from_guests")]bool HideFromGuests,
    [property: JsonPropertyName("value")]string Value,
    [property: JsonPropertyName("required")]bool Required
);

public record CreateTaskResponseStatus(
    string Id,
    string Status,
    string Color,
    int Orderindex, 
    string Type);

public record Creator(
    int Id,
    string Username,
    string Color,
    string Email
    // object ProfilePicture
    );

public record Assignee(
    string Id); // Placeholder, adjust based on actual JSON structure if needed

public record Watcher(
    int Id, string Username, string Color, string Initials, string Email, object ProfilePicture);

public record Sharing(
    bool Public, object PublicShareExpiresOn, List<string> PublicFields, object Token, bool SeoOptimized);

public record ListObject(
    string Id, string Name, bool Access);

public record Project(
    string Id, string Name, bool Hidden, bool Access);

public record Folder(
    string Id, string Name, bool Hidden, bool Access);

public record Space(
    string Id);
