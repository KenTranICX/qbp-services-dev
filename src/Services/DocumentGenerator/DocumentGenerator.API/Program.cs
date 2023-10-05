using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Logging.AzureAppServices;
using Azure.Identity;
using Azure.Core.Diagnostics;
using DocumentGenerator.API.Core.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDocumentGeneratorService, DocumentGeneratorService>();

builder.Services.Configure<RouteOptions>(options =>
{
  options.LowercaseUrls = true;
});

builder.Services.AddApiVersioning(config =>
{
  config.DefaultApiVersion = new ApiVersion(1, 0);
  config.AssumeDefaultVersionWhenUnspecified = true;
  config.ReportApiVersions = true;
});

if (!builder.Environment.IsDevelopment())
{
  builder.Logging.AddAzureWebAppDiagnostics();

  builder.Services.Configure<AzureFileLoggerOptions>(options =>
  {
    options.FileName = "DocumentGeneratorLog";
    options.FileSizeLimit = 50 * 1024;
    options.RetainedFileCountLimit = 5;
  });
  builder.Services.Configure<AzureBlobLoggerOptions>(options =>
  {
    options.BlobName = "DocumentGeneratorLog.txt";
  });

  // Setup a listener to monitor logged events.
  using AzureEventSourceListener listener = AzureEventSourceListener.CreateConsoleLogger();
  DefaultAzureCredentialOptions options = new DefaultAzureCredentialOptions()
  {
    Diagnostics =
            {
                LoggedHeaderNames = { "x-ms-request-id" },
                LoggedQueryParameters = { "api-version" },
                IsLoggingContentEnabled = true
            }
  };
}

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
