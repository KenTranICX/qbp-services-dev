namespace DocumentGenerator.API.Models
{
  public enum eSaveFormat
  {
    pdf,
    html,
  }

  public class DocumentRequest
  {
    public string name {  get; set; }
    public string templateFileLocation { get; set; }
    public string documentFileLocation { get; set; }
    public string jsonData { get; set; }
    public string saveFormat { get; set; }
  }

  public class DocumentStreamRequest
  {
    public byte[] documentTemplate { get; set; }
    public string jsonData { get; set; }
    public string saveFormat { get; set; }
  }
}
