using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;
using Azure;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;
//using Azure.Storage.Blobs.Specialized;
using Azure.Storage.Files.Shares;
//using Azure.Storage.Files.Shares.Models;
//using Azure.Storage.Sas;

namespace DocumentGenerator.API.Infrastructure.Services
{
  public class AzureStorageContainers
  {
    private readonly IConfiguration _config;
    private BlobServiceClient _blobServiceClient;
    private BlobContainerClient _containerClient;

    public AzureStorageContainers(IConfiguration config)
    {
      _config = config ?? throw new ArgumentNullException();
      string connectionString = _config.GetConnectionString("ContainersConnectionString");

      try
      {
        _blobServiceClient = new BlobServiceClient(connectionString);
        //_containerClient = _blobServiceClient.GetBlobContainerClient("$web");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    }

    public async Task<bool> UploadBlobStreamAsync(string fileLocation, Stream content)
    {
      try
      {
        var rootContainer = fileLocation.Split('/')[0];
        if (_containerClient == null)
        {
          _containerClient = _blobServiceClient.GetBlobContainerClient(rootContainer);
        }

        string _fileLocation = fileLocation;
        if (fileLocation.StartsWith(rootContainer))
        {
          _fileLocation = fileLocation.Replace(rootContainer, "");
        }

        BlobClient blobClient = _containerClient.GetBlobClient(_fileLocation);
        content.Position = 0;
        await blobClient.UploadAsync(content, overwrite: true);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }

      return true;
    }

    public async Task<Stream> DownloadBlobStreamAsync(string fileLocation)
    {
      try
      {
        var rootContainer = fileLocation.Split('/')[0];
        if (_containerClient == null)
        {
          _containerClient = _blobServiceClient.GetBlobContainerClient(rootContainer);
        }

        string _fileLocation = fileLocation;
        if (fileLocation.StartsWith(rootContainer))
        {
          _fileLocation = fileLocation.Replace(rootContainer, "");
        }

        BlobClient blobClient = _containerClient.GetBlobClient(_fileLocation);

        if (await blobClient.ExistsAsync())
        {
          MemoryStream stream = new MemoryStream();
          await blobClient.DownloadToAsync(stream);
          return stream;
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }

      return null;
    }

    //public async Task<byte[]?> DownloadBlobAsync(string fileName)
    //{
    //  //BlobClient blobClient = _containerClient.GetBlobClient(fileLocation);
    //  BlobClient blobClient1 = _containerClient.GetBlobClient("qpb/ci/dev/" + fileName);
    //  //https://stspwrprdciauest01.blob.core.windows.net/$web/qpb/ci/dev/AsposeTemplatePolicy.docx

    //  //if (await blobClient.ExistsAsync())
    //  //{
    //  //  using MemoryStream stream = new MemoryStream();
    //  //  await blobClient.DownloadToAsync(stream);
    //  //  return stream.ToArray();
    //  //}

    //  if (await blobClient1.ExistsAsync())
    //  {
    //    using MemoryStream stream = new MemoryStream();
    //    await blobClient1.DownloadToAsync(stream);
    //    return stream.ToArray();
    //  }

    //  return null;
    //}

    //public List<string> GetDocumentList(string path)
    //{
    //  List<string> files = new List<string>();
    //  try
    //  {
    //    foreach (BlobItem blob1 in _containerClient.GetBlobs())
    //    {
    //      if (blob1.Name.StartsWith(path))
    //      {
    //        files.Add(blob1.Name);
    //      }
    //    }

    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.ToString());
    //  }

    //  return files;
    //}

    //public void Test()
    //{
    //  try
    //  {
    //    //List<string> names0 = new List<string>();
    //    //var resultSegment = _containerClient.GetBlobsByHierarchy(prefix: "qbp/ci/templates/dev/nb", delimiter: "/").ToList();
    //    //foreach (BlobHierarchyItem blob1 in resultSegment)
    //    //{
    //    //  if (blob1.IsBlob && blob1.Blob.Name.Equals("qbp/ci/templates/dev/nb"))
    //    //  {
    //    //    names0.Add(blob1.Blob.Name);
    //    //    Console.WriteLine(blob1.Blob.Name);
    //    //  }
    //    //}

    //    //BlobClient blob = _containerWeb.GetBlobClient("qbp/ci/dev");
    //    //BlockBlobClient _blockBlobClient = _containerWeb.GetBlockBlobClient("qbp/ci/dev");

    //    //ListBlobsHierarchicalListing(_containerClient, "qbp", null);

    //    //List<string> names = new List<string>();

    //    //var blobfiles = _containerClient.GetBlobs();
    //    //List<string> _fileList = _containerClient.GetBlobs().Select(b => b.Name).ToList();
    //    //BlobClient blobClient = _containerClient.GetBlobClient("/qbp/ci/templates/dev/nb/");

    //    //BlobContainerClient _rtest = _blobServiceClient.GetBlobContainerClient("/qbp/ci/templates/dev/nb/");
    //    ////List<string> _fileList1 = _rtest.GetBlobs().Select(b => b.Name).ToList();

    //    //foreach (BlobItem blob1 in _rtest.GetBlobs())
    //    //{
    //    //  if (blob1.Name.Equals("qbp/ci/templates/dev/nb/"))
    //    //  {
    //    //    names.Add(blob1.Name);
    //    //    Console.WriteLine(blob1.Name);
    //    //  }
    //    //}

    //    List<string> names1 = new List<string>();
    //    foreach (BlobItem blob1 in _containerClient.GetBlobs())
    //    {
    //      if (blob1.Name.StartsWith("qbp/ci/templates/dev/nb/"))
    //      {
    //        names1.Add(blob1.Name);
    //        Console.WriteLine(blob1.Name);
    //      }
    //    }

    //  }
    //  catch (Exception ex)
    //  {
    //    Console.WriteLine(ex.ToString());
    //  }
    //}

    //private static async Task ListBlobsHierarchicalListing(BlobContainerClient container,
    //                                                       string prefix,
    //                                                       int? segmentSize)
    //{
    //  try
    //  {
    //    // Call the listing operation and return pages of the specified size.
    //    var resultSegment = container.GetBlobsByHierarchyAsync(prefix: prefix, delimiter: "/")
    //        .AsPages(default, segmentSize);

    //    // Enumerate the blobs returned for each page.
    //    await foreach (Page<BlobHierarchyItem> blobPage in resultSegment)
    //    {
    //      // A hierarchical listing may return both virtual directories and blobs.
    //      foreach (BlobHierarchyItem blobhierarchyItem in blobPage.Values)
    //      {
    //        if (blobhierarchyItem.IsPrefix)
    //        {
    //          // Write out the prefix of the virtual directory.
    //          Console.WriteLine("Virtual directory prefix: {0}", blobhierarchyItem.Prefix);

    //          // Call recursively with the prefix to traverse the virtual directory.
    //          await ListBlobsHierarchicalListing(container, blobhierarchyItem.Prefix, null);
    //        }
    //        else
    //        {
    //          // Write out the name of the blob.
    //          Console.WriteLine("Blob name: {0}", blobhierarchyItem.Blob.Name);
    //        }
    //      }

    //      Console.WriteLine();
    //    }
    //  }
    //  catch (RequestFailedException e)
    //  {
    //    Console.WriteLine(e.Message);
    //    Console.ReadLine();
    //    throw;
    //  }
    //}

  }
}
