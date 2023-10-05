using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DocumentGenerator.API.Models;
using DocumentGenerator.API.Core.Services;
using System.Net;
using System.Net.Http.Headers;

namespace DocumentGenerator.API.Controllers.V1
{
  [ApiController]
  [Route("v{version:apiVersion}/[controller]")]
  [ApiVersion("1")]
  public class DocumentGeneratorController : ControllerBase
  {
    private readonly IDocumentGeneratorService _documentGeneratorService;
    private readonly ILogger<DocumentGeneratorController> _logger;

    public DocumentGeneratorController(
      IDocumentGeneratorService service,
      ILogger<DocumentGeneratorController> logger)
    {
      _documentGeneratorService = service;
      _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("GenerateDocumentByFileLocation")]
    public async Task<IActionResult> GenerateDocumentAsync([FromBody] DocumentRequest documentRequest)
    {
      try
      {
        await _documentGeneratorService.GenerateDocument(documentRequest);
        return Ok();
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }

    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [Route("GenerateDocumentByStream")]
    public async Task<IActionResult> GenerateDocumentAsync([FromBody] DocumentStreamRequest stream)
    {
      try
      {
        Stream docStream = await _documentGeneratorService.GenerateDocument(stream);
        docStream.Position = 0;
        if (stream.saveFormat.ToLower().Equals(eSaveFormat.html.ToString().ToLower()))
        {
          return File(docStream, "text/html", "Report.html");
        }
        else
        {
          return File(docStream, "application/pdf", "Report.pdf");
        }
      }
      catch (Exception ex)
      {
        return BadRequest(ex.Message);
      }
    }

    //[HttpPost]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[Route("GenerateDocumentsByGroup")]
    //public async Task<IActionResult> GenerateDocumentsByGroupAsync([FromBody] DocumentRequest documentRequest)
    //{
    //  await _documentGeneratorService.GenerateDocumentsByDocGroup(documentRequest);
    //  return NotFound();
    //}
  }
}
