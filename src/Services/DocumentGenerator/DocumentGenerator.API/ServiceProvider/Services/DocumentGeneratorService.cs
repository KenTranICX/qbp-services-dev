using DocumentGenerator.API.ServiceProvider.Interfaces;
//using qpbwebapi.ServiceProvider.Requests;
//using qpbwebapi.ServiceProvider.Responses;
//using Newtonsoft.Json;
//using DocumentGenerator.API.Repository.Interfaces;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Net.Http.Json;
using System.Collections.Generic;
//using Microsoft.Identity.Client;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Drawing;
using System.Collections;


namespace DocumentGenerator.API.ServiceProvider.Services
{
  public class DocumentGeneratorService : IDocumentGeneratorService
  {
    private IDictionary liabilityInsured = new Dictionary<string, string>();
    private readonly ILogger _logger;
    //private ResponseModel _responseModel;
    //private IInsurancePremiumRepository? _insurancePremiumRepository;


  }
}
