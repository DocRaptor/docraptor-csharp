using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-hosted-sync.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    DocStatus statusResponse = docraptor.CreateHostedDoc(doc);

    WebClient webClient = new WebClient();
    webClient.DownloadFile(statusResponse.DownloadUrl, @"/tmp/the-file-name.pdf");

    string line = File.ReadLines("/tmp/the-file-name.pdf").First();
    if(!line.Contains("%PDF-1.5")) {
      Console.WriteLine("unexpected file header: " + line);
      Environment.Exit(1);
    }

    docraptor.Expire(statusResponse.DownloadId);

    try {
      webClient.DownloadFile(statusResponse.DownloadUrl, @"/tmp/the-file-name.pdf");
      Console.WriteLine("Document should not exist");
      Environment.Exit(1);
    } catch (System.Net.WebException) {
      Environment.Exit(0);
    }
  }
}
