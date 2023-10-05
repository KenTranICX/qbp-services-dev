namespace DocumentGenerator.API.Models
{
  public class ResponseModel
  {
    public string Result { get; set; } = string.Empty;
    public int ResponseCode { get; set; }
    //public DocumentGenerator.API.Models.InsurancePremium[] ResponseResult { get; set; }
    //public int TotalRecords { get; set; }
  }
}
