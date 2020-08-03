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
    Configuration.Default.Username = api_key;
    // Configuration.Default.Debug = true; // Not supported in Csharp
    DocApi docraptor = new DocApi();

    Doc doc = new Doc(
      name: "csharp-hosted-async.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    AsyncDoc response = docraptor.CreateHostedAsyncDoc(doc);

    DocStatus status_response;
    while(true) {
      status_response = docraptor.GetAsyncDocStatus(response.StatusId);
      if (status_response.Status == "completed") {
        break;
      } else if(status_response.Status == "failed") {
        Console.WriteLine("Failed creating hosted async document");
        Environment.Exit(1);
      }
      Thread.Sleep(1000);
    }

    byte[] data = docraptor.GetAsyncDoc(status_response.DownloadId);
    File.WriteAllBytes("/tmp/the-file-name.pdf", data);

    string line = File.ReadLines("/tmp/the-file-name.pdf").First();
    if(!line.Contains("%PDF-1.5")) {
      Console.WriteLine("unexpected file header: " + line);
      Environment.Exit(1);
    }
  }
}
