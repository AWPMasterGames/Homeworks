using Microsoft.AspNetCore.Http.Metadata;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/upload", async (HttpContext context) =>
{
    IFormFileCollection files = context.Request.Form.Files;
    var uploadFiles = $"{Directory.GetCurrentDirectory()}/uploads";
    Directory.CreateDirectory(uploadFiles);

    foreach (var file in files)
    {
        string filePath = $"{uploadFiles}/{file.FileName}";

        using var fileStream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(fileStream);
    }

    await context.Response.WriteAsync("файл успешно отправлен");
});
app.Run();
