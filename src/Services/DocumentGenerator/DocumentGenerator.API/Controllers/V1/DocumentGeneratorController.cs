using Microsoft.AspNetCore.Mvc;
using DocumentGenerator.API.ServiceProvider.Interfaces;

namespace DocumentGenerator.API.Controllers.V1
{
  [ApiController]
  [Route("v{version:apiVersion}/[controller]")]
  [ApiVersion("1")]
  public class DocumentGeneratorController : ControllerBase
  {
    private readonly IDocumentGeneratorService _documentGeneratorService;

    public DocumentGeneratorController(IDocumentGeneratorService service)
    {
      _documentGeneratorService = service;
    }

    [HttpGet]
    [Route("GenerateDocumentAsync")]
    public async Task<ActionResult> GenerateDocumentAsync()
    {
      return NotFound();
    }

    [HttpGet]
    [Route("GenerateDocumentsByGroupAsync")]
    public async Task<ActionResult> GenerateDocumentsByGroupAsync()
    {
      return NotFound();
    }
  }
}
