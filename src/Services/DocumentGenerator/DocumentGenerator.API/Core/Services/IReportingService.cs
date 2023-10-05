using DocumentGenerator.API.Models;

namespace DocumentGenerator.API.Core.Services
{
  public interface IReportingService
  {
    Task BuildReport(DocumentRequest documentRequest);
    //Task<byte[]> BuildReport(DocumentStreamRequest documentRequest);
    Task<Stream> BuildReport(DocumentStreamRequest documentRequest);
    //Task BuildReportsByDocGroup(DocumentRequest documentRequest);
  }
}
