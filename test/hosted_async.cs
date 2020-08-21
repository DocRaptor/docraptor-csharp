using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class HostedAsyncTest {
  static void Main(string[] args) {
    string api_key = File.ReadAllText(@".docraptor_key").Trim();
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = api_key;
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-hosted-async.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    AsyncDoc response = docraptor.CreateHostedAsyncDoc(doc);

    DocStatus statusResponse;
    while(true) {
      statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
      if (statusResponse.Status == "completed") {
        break;
      } else if(statusResponse.Status == "failed") {
        Console.WriteLine("Failed creating hosted async document");
        Environment.Exit(1);
      }
      Thread.Sleep(1000);
    }

    byte[] data = docraptor.GetAsyncDoc(statusResponse.DownloadId);
    File.WriteAllBytes("/tmp/the-file-name.pdf", data);

    string line = File.ReadLines("/tmp/the-file-name.pdf").First();
    if(!line.Contains("%PDF-1.5")) {
      Console.WriteLine("unexpected file header: " + line);
      Environment.Exit(1);
    }
  }
}
