

// using QuestPDF.Fluent;
// using QuestPDF.Helpers;
// using QuestPDF.Infrastructure;

namespace ClickUp.Services;

public class ClickUpService()
{
    // public async Task<GetTasksResponse?> FindTaskByBarcode(
    //     string listId,
    //     string barcodeId)
    // {
    //     Console.WriteLine("Barcode:" + barcodeId);
    //     var client = CreateAuthedClient();
    //     var fields = await this.GetCustomFields(listId);
    //     var barcodeFieldId = fields?.GetField("BarcodeId").Id;
    //     Console.WriteLine("BarcodeFieldId:" + barcodeFieldId);
    //     var inputString = "https://api.clickup.com/api/v2/list/"
    //                       + listId + "/task?archived=false" +
    //                       "&include_markdown_description=true" +
    //                       "&page=" + 0 +
    //                       // "&order_by=string" +
    //                       // "&reverse=true" +
    //                       // "&subtasks=true" +
    //                       // "&statuses=string" +
    //                       "&include_closed=true" +
    //                       // "&assignees=string" +
    //                       // "&watchers=string" +
    //                       // "&tags=string" +
    //                       // "&due_date_gt=0" +
    //                       // "&due_date_lt=0" +
    //                       // "&date_created_gt=0" +
    //                       // "&date_created_lt=0" +
    //                       // "&date_updated_gt=0" +
    //                       // "&date_updated_lt=0" +
    //                       // "&date_done_gt=0" +
    //                       // "&date_done_lt=0" +
    //                       // "&custom_fields=string" +
    //                       "&custom_fields=[{\"field_id\":\"" +
    //                       barcodeFieldId +
    //                       "\",\"operator\":\"=\",\"value\":\"" +
    //                       barcodeId +
    //                       "\"}]" +
    //                       // "&custom_items=0" +
    //                       "";
    //     Console.WriteLine("INPUT STRING"+inputString);
    //     var request = await client.GetAsync(inputString);
    //     var jsonResponse = await request.Content.ReadAsStringAsync();
    //     Console.WriteLine("RESPONSE");
    //     Console.WriteLine(jsonResponse);
    //
    //     try
    //     {
    //         var response = await request.Content.ReadFromJsonAsync<GetTasksResponse>();
    //         Console.WriteLine("===========");
    //         return response;
    //     }
    //     catch(Exception ex)
    //     {
    //         Console.WriteLine(ex.Message);
    //         throw new Exception("Unable to parse Json", ex);
    //     }
    // }

    
    // public async Task<ClickUpQueryResponseTaskItem?> FindTaskIdFromCustomId(
    //     string listId,
    //     Guid fieldId,
    //     string value)
    // {
    //     var client = CreateAuthedClient();
    //     var request = await client.GetAsync(
    //         @"https://api.clickup.com/api/v2/list/"
    //         + listId + "/task?archived=false&page=0&include_closed=true&custom_fields=?custom_fields=[{\"field_id\":\""
    //         + fieldId + "\",\"operator\":\"=\",\"value\":\""
    //         + value + "\"}");
    //     var response = await request.Content.ReadFromJsonAsync<ClickUpQueryResponse>();
    //     return response?.Tasks.SingleOrDefault() ?? throw new Exception("Task not found");
    // }
    //
    // public record GetTasksTask(
    //     [property: JsonPropertyName("id")]string Id,
    //     [property: JsonPropertyName("name")]string Name,
    //     [property: JsonPropertyName("custom_fields")]List<CustomFieldResponse> CustomFields
    //     );
    //
    // public record CustomFieldResponse(
    //     [property: JsonPropertyName("id")]string Id,
    //     [property: JsonPropertyName("name")]string Name,
    //     [property: JsonPropertyName("type")]string Type
    //     );
    //
    // public record GetTasksTaskCustomField();

    
    // public async Task UploadFileToTask(string taskId, Stream stream, string fileName)
    // {
    //     Console.WriteLine("Invoice Upload Started");
    //     var client = CreateAuthedClient();
    //     var postData = new MultipartFormDataContent();
    //     var pdfStreamContent = new StreamContent(stream);
    //     pdfStreamContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");
    //     postData.Add(pdfStreamContent, "attachment", fileName);
    //
    //     var request = await client.PostAsync("https://api.clickup.com/api/v2/task/" + taskId + "/attachment", postData);
    //     var response = await request.Content.ReadAsStringAsync();
    // }


    // public byte[] CreatePdfStream()
    // {
    //     QuestPDF.Settings.License = LicenseType.Community;
    //     var bytes = Document.Create(container =>
    //     {
    //         container.Page(page =>
    //         {
    //             page.Size(PageSizes.A4);
    //             page.Margin(2, Unit.Centimetre);
    //             page.PageColor(Colors.White);
    //             page.DefaultTextStyle(x => x.FontSize(20));
    //             page.Header().Text("Hello From Rider")
    //                 .SemiBold().FontSize(30);
    //             page.Content()
    //                 .PaddingVertical(1, Unit.Centimetre)
    //                 .Column(x =>
    //                 {
    //                     x.Spacing(20);
    //                     x.Item().Text(Placeholders.LoremIpsum());
    //                     x.Item().Image(Placeholders.Image(200, 100));
    //                 });
    //             page.Footer().AlignCenter()
    //                 .Text(x =>
    //                 {
    //                     x.Span("Page ");
    //                     x.CurrentPageNumber();
    //                 });
    //         });
    //     }).GeneratePdf();
    //     return bytes;
    // }
}