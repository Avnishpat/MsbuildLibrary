var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "FLEXDEPLOY-3859 Publish Profile Test");

app.Run();
