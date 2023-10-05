using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Drawing;
using System.Collections;
using DocumentGenerator.API.Models;
using DocumentGenerator.API.Infrastructure.Services;

namespace DocumentGenerator.API.Core.Services
{
  public class DocumentGeneratorService : IDocumentGeneratorService
  {
    private readonly ILogger _logger;
    private readonly IConfiguration _config;
    private ResponseModel _responseModel;

    public DocumentGeneratorService(ILogger<DocumentGeneratorService> logger, IConfiguration config)
    {
      _logger = logger;
      _config = config;
      _responseModel = new ResponseModel();
    }
    public async Task<ResponseModel> GenerateDocument(DocumentRequest documentRequest)
    {
      MailMergeService mailMergeService = new MailMergeService(_logger, _config);
      await mailMergeService.BuildReport(documentRequest);
      return _responseModel;
    }
    public async Task<Stream> GenerateDocument(DocumentStreamRequest documentRequest)
    {
      MailMergeService mailMergeService = new MailMergeService(_logger, _config);
      //byte[] document = await mailMergeService.BuildReport(documentRequest);
      Stream document = await mailMergeService.BuildReport(documentRequest);
      return document;
    }
    //public async Task<ResponseModel> GenerateDocumentsByDocGroup(DocumentRequest documentRequest)
    //{
    //  MailMergeService mailMergeService = new MailMergeService(_logger, _config);
    //  await mailMergeService.BuildReport(documentRequest);
    //  return _responseModel;
    //}
  }
}
