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
  public class MailMergeService: IReportingService
  {
    private readonly ILogger _logger;
    private readonly IConfiguration _config;
    static Aspose.Words.License asposelicense = new Aspose.Words.License();

    public MailMergeService(ILogger logger, IConfiguration config)
    {
      _logger = logger;
      _config = config;
    }

    public async Task BuildReport(DocumentRequest documentRequest)
    {
      try
      {
        SetLicenseFromStream();

        AzureStorageContainers _azureStorageContainers = new AzureStorageContainers(_config);

        var oTemplateDoc = await _azureStorageContainers.DownloadBlobStreamAsync(documentRequest.templateFileLocation);
        Document oPolicyTemplate = new Document(oTemplateDoc);

        // Trim trailing and leading whitespaces mail merge values
        oPolicyTemplate.MailMerge.TrimWhitespaces = true;

        DataSet ds = new DataSet();
        var xd = (XmlDocument)JsonConvert.DeserializeXmlNode(documentRequest.jsonData, "root");
        ds.ReadXml(new XmlNodeReader(xd));

        oPolicyTemplate.MailMerge.FieldMergingCallback = new Handle_MergeField();
        oPolicyTemplate.MailMerge.UseNonMergeFields = true;
        foreach (DataTable table in ds.Tables)
        {
          oPolicyTemplate.MailMerge.Execute(table);
        }
        //oPolicyTemplate.MailMerge.Execute(ds.Tables["root"]);
        oPolicyTemplate.MailMerge.ExecuteWithRegions(ds);

        string documentFile = documentRequest.documentFileLocation;

        if (documentFile.EndsWith("/"))
        {
          documentFile = documentFile.Substring(0, documentFile.Length - 1);
        }

        documentFile += "/" + documentRequest.name;

        if (documentRequest.saveFormat.ToLower() == SaveFormat.Html.ToString().ToLower())
        {
          MemoryStream htmlStream1 = new MemoryStream();
          oPolicyTemplate.Save(htmlStream1, SaveFormat.Html);
          await _azureStorageContainers.UploadBlobStreamAsync(documentFile + ".html", htmlStream1);
        }
        else
        {
          MemoryStream pdfStream1 = new MemoryStream();
          oPolicyTemplate.Save(pdfStream1, SaveFormat.Pdf);
          await _azureStorageContainers.UploadBlobStreamAsync(documentFile + ".pdf", pdfStream1);
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public async Task<Stream> BuildReport(DocumentStreamRequest documentRequest)
    {
      try
      {
        SetLicenseFromStream();

        MemoryStream memoryStream = new MemoryStream(documentRequest.documentTemplate);
        Document oPolicyTemplate = new Document(memoryStream);
        //Document oPolicyTemplate = new Document(documentRequest.documentTemplate);

        // Trim trailing and leading whitespaces mail merge values
        oPolicyTemplate.MailMerge.TrimWhitespaces = true;

        DataSet ds = new DataSet();
        var xd = (XmlDocument)JsonConvert.DeserializeXmlNode(documentRequest.jsonData, "root");
        ds.ReadXml(new XmlNodeReader(xd));

        oPolicyTemplate.MailMerge.FieldMergingCallback = new Handle_MergeField();
        oPolicyTemplate.MailMerge.UseNonMergeFields = true;
        foreach (DataTable table in ds.Tables)
        {
          oPolicyTemplate.MailMerge.Execute(table);
        }
        //oPolicyTemplate.MailMerge.Execute(ds.Tables["root"]);
        oPolicyTemplate.MailMerge.ExecuteWithRegions(ds);

        if (documentRequest.saveFormat.ToLower() == SaveFormat.Html.ToString().ToLower())
        {
          MemoryStream htmlStream1 = new MemoryStream();
          oPolicyTemplate.Save(htmlStream1, SaveFormat.Html);
          return htmlStream1;
          //return htmlStream1.ToArray();
        }
        else
        {
          MemoryStream pdfStream1 = new MemoryStream();
          oPolicyTemplate.Save(pdfStream1, SaveFormat.Pdf);
          return pdfStream1;
          //return pdfStream1.ToArray();
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      return null;
    }
    //public async Task BuildReportsByDocGroup(DocumentRequest documentRequest)
    //{
    //  Document oPolicyTemplate = null;
    //  Document oClientTemplate = null;
    //  Document oVehicleTemplate = null;

    //  try
    //  {
    //    SetLicenseFromStream();

    //    AzureStorageContainers _azureStorageContainers = new AzureStorageContainers(_config);

    //    var oPolicyFile = await _azureStorageContainers.DownloadBlobStreamAsync("AsposeMailMergeTemplatePolicy.docx");
    //    var oClientFile = await _azureStorageContainers.DownloadBlobStreamAsync("AsposeMailMergeTemplateClient.docx");

    //    oPolicyTemplate = new Document(oPolicyFile);
    //    oClientTemplate = new Document(oClientFile);

    //    ////oClientTemplate.FirstSection.PageSetup.SectionStart = SectionStart.NewPage; // Set the appended document to appear on a new page.
    //    oClientTemplate.FirstSection.PageSetup.SectionStart = SectionStart.Continuous; // Set the appended document to appear continuously.
    //    oPolicyTemplate.AppendDocument(oClientTemplate, ImportFormatMode.UseDestinationStyles);

    //    // Trim trailing and leading whitespaces mail merge values
    //    oPolicyTemplate.MailMerge.TrimWhitespaces = true;

    //    DataSet ds = new DataSet();
    //    string sJson = File.ReadAllText(".\\policy.json");
    //    var xd = (XmlDocument)JsonConvert.DeserializeXmlNode(sJson, "root");
    //    ds.ReadXml(new XmlNodeReader(xd));

    //    oPolicyTemplate.MailMerge.FieldMergingCallback = new Handle_MergeField();
    //    oPolicyTemplate.MailMerge.UseNonMergeFields = true;
    //    oPolicyTemplate.MailMerge.Execute(ds.Tables["root"]);
    //    oPolicyTemplate.MailMerge.ExecuteWithRegions(ds);

    //    MemoryStream pdfStream1 = new MemoryStream();
    //    oPolicyTemplate.Save(pdfStream1, SaveFormat.Pdf);
    //    await _azureStorageContainers.UploadBlobStreamAsync("Policy.pdf", pdfStream1);

    //    MemoryStream htmlStream1 = new MemoryStream();
    //    oPolicyTemplate.Save(htmlStream1, SaveFormat.Html);
    //    await _azureStorageContainers.UploadBlobStreamAsync("Policy.html", htmlStream1);
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
    private class Handle_MergeField : IFieldMergingCallback
    {
      /// <summary>
      /// This is called when merge field is actually merged with data in the document.
      /// </summary>
      void IFieldMergingCallback.FieldMerging(FieldMergingArgs e)
      {
        //Code
      }

      void IFieldMergingCallback.ImageFieldMerging(ImageFieldMergingArgs e)
      {
        if (e.FieldName.Equals("Image"))
        {
          if (e.FieldValue != null)
          {
            e.ImageFileName = e.FieldValue.ToString();
          }
        }
      }
    }

  }
}
