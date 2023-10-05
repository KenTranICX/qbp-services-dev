using System;
using System.IO;
using Aspose.Words;
using Aspose.Words.Reporting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Xml;
using System.Linq;
using Aspose.Words.MailMerging;
using System.Xml.Linq;
using DocumentGenerator.API.Core.Models.Test;
using DocumentGenerator.API.Infrastructure.Services;
using static System.Net.Mime.MediaTypeNames;
using DocumentGenerator.API.Models;

namespace DocumentGenerator.API.Core.Services
{
  public class LinqReportingService: IReportingService
  {
    private readonly ILogger _logger;
    private readonly IConfiguration _config;
    static Aspose.Words.License asposelicense = new Aspose.Words.License();

    public LinqReportingService(ILogger logger, IConfiguration config)
    {
      _logger = logger;
      _config = config;
    }

    public async Task BuildReport(DocumentRequest documentRequest)
    {
    }
    //public async Task<byte[]> BuildReport(DocumentStreamRequest documentRequest)
    public async Task<Stream> BuildReport(DocumentStreamRequest documentRequest)
    {
      return null;
    }
    //public async Task BuildReportsByDocGroup(DocumentRequest documentRequest)
    //{
    //  Document oPolicyTemplate = null;
    //  Document oClientTemplate = null;
    //  Document oVehicleTemplate = null;
    //  JObject oPolicyJson = null;
    //  Policy oPolicy = null;

    //  try
    //  {
    //    SetLicenseFromStream();

    //    AzureStorageContainers _azureStorage = new AzureStorageContainers(_config);

    //    var oPolicyFile = await _azureStorage.DownloadBlobStreamAsync("AsposeTemplatePolicy.docx");
    //    var oClientFile = await _azureStorage.DownloadBlobStreamAsync("AsposeTemplateClient.docx");
    //    var oVehicleFile = await _azureStorage.DownloadBlobStreamAsync("AsposeTemplateVehicle.docx");

    //    oPolicyTemplate = new Document(oPolicyFile);
    //    oClientTemplate = new Document(oClientFile);
    //    oVehicleTemplate = new Document(oVehicleFile);

    //    //var oPolicyFileTest = await _azureStorage.DownloadBlobStreamAsync("AsposeTemplatePolicy-test.docx");
    //    //oPolicyTemplate = new Document(oPolicyFileTest);

    //    //Document oPolicyTemplate1 = new Document("AsposeTemplatePolicy.docx");
    //    //Document oClientTemplate1 = new Document("AsposeTemplateClient.docx");
    //    //oVehicleTemplate1 = new Document("AsposeTemplateVehicle.docx");

    //    //oClientTemplate.FirstSection.PageSetup.SectionStart = SectionStart.NewPage; // Set the appended document to appear on a new page.
    //    oClientTemplate.FirstSection.PageSetup.SectionStart = SectionStart.Continuous; // Set the appended document to appear continuously.
    //    oPolicyTemplate.AppendDocument(oClientTemplate, ImportFormatMode.UseDestinationStyles);

    //    oVehicleTemplate.FirstSection.PageSetup.SectionStart = SectionStart.Continuous;
    //    oPolicyTemplate.AppendDocument(oVehicleTemplate, ImportFormatMode.UseDestinationStyles);

    //    oPolicyJson = JObject.Parse(File.ReadAllText(".\\policy.json"));
    //    oPolicy = oPolicyJson.ToObject<Policy>();

    //    ReportingEngine engine = new ReportingEngine();
    //    engine.BuildReport(oPolicyTemplate, oPolicy);

    //    //Test
    //    //dynamic tesObj = JObject.Parse(File.ReadAllText(".\\policy.json"));
    //    //dynamic dynamicDataObject = JsonConvert.DeserializeObject(File.ReadAllText(".\\policy.json"));
    //    //engine.BuildReport(oPolicyTemplate, dynamicDataObject);
    //    //engine.BuildReport(oPolicyTemplate, tesObj);
    //    //engine.BuildReport(oPolicyTemplate, oPolicyJson);

    //    //Require new update
    //    //JsonDataLoadOptions options = new JsonDataLoadOptions();
    //    //options.AlwaysGenerateRootObject = true;
    //    //JsonDataSource dataSource = new JsonDataSource(..., options);

    //    MemoryStream pdfStream = new MemoryStream();
    //    oPolicyTemplate.Save(pdfStream, SaveFormat.Pdf);
    //    await _azureStorage.UploadBlobStreamAsync("AsposeReportBuilder-policy.pdf", pdfStream);

    //    MemoryStream htmlStream = new MemoryStream();
    //    oPolicyTemplate.Save(htmlStream, SaveFormat.Html);
    //    await _azureStorage.UploadBlobStreamAsync("AsposeReportBuilder-policy.html", htmlStream);

    //    //oPolicyTemplate.Save("Output\\AsposeReportBuilder-policy.doc");
    //    //oPolicyTemplate.Save("Output\\AsposeReportBuilder-policy.pdf", SaveFormat.Pdf);
    //    //oPolicyTemplate.Save("Output\\AsposeReportBuilder-policy.Html", SaveFormat.Html);
    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.Message);
    //  }
    //  finally
    //  {
    //    oPolicyTemplate = null;
    //    oClientTemplate = null;
    //    oVehicleTemplate = null;
    //    oPolicyJson = null;
    //    oPolicy = null;
    //  }
    //}

    private void SetLicenseFromStream()
    {
      System.IO.FileStream licenceStream = null;
      try
      {
        // Load license from the file stream
        licenceStream =
           new System.IO.FileStream(
               "Aspose.Total.NET.lic",
               System.IO.FileMode.Open);

        asposelicense.SetLicense(licenceStream);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      finally
      {
        licenceStream.Dispose();
      }
    }
  }
}

