using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Linq;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    string api_key = File.ReadAllText(@".docraptor_key").Trim();
    Configuration.Default.Username = api_key;
    // Configuration.Default.Debug = true; // Not supported in Csharp
    DocApi docraptor = new DocApi();

    Doc doc = new Doc(
      name: "csharp-hosted-sync.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    DocStatus statusResponse = docraptor.CreateHostedDoc(doc);
    byte[] data = docraptor.GetAsyncDoc(statusResponse.DownloadId);
    File.WriteAllBytes("/tmp/the-file-name.pdf", data);

    string line = File.ReadLines("/tmp/the-file-name.pdf").First();
    if(!line.Contains("%PDF-1.5")) {
      Console.WriteLine("unexpected file header: " + line);
      Environment.Exit(1);
    }

    docraptor.Expire(statusResponse.DownloadId);

    try {
      docraptor.GetAsyncDoc(statusResponse.DownloadId);
      Console.WriteLine("Document should not exist");
      Environment.Exit(1);
    } catch (DocRaptor.Client.ApiException) {
      Environment.Exit(0);
    }
  }
}
