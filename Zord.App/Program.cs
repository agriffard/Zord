using Zord.App.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOrchardCms()
    .ConfigureServices(svc => {
        svc.AddServerSideBlazor();
        svc.AddSingleton<WeatherForecastService>();
    })
    .Configure((a, b, c) => {
        b.MapBlazorHub();
        a.UseStaticFiles();
        //b.MapFallbackToAreaPage("/_Host", "Zord.App");
    });

var app = builder.Build();

app.UseOrchardCore();

app.Run();
