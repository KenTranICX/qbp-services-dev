using DocumentGenerator.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.API.Core.Services
{
  public interface IDocumentGeneratorService
  {
    Task<ResponseModel> GenerateDocument(DocumentRequest documentRequest);
    Task<Stream> GenerateDocument(DocumentStreamRequest documentRequest);
    //Task<byte[]> GenerateDocument(DocumentStreamRequest documentRequest);
    //Task<ResponseModel> GenerateDocumentsByDocGroup(DocumentRequest documentRequest);
  }
}
