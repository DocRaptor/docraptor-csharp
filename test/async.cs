using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.Threading;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class AsyncTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-async.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    AsyncDoc response = docraptor.CreateAsyncDoc(doc);

    DocStatus statusResponse;
    while(true) {
      statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
      if (statusResponse.Status == "completed") {
        break;
      }
      Thread.Sleep(1000);
    }

    docraptor.GetAsyncDoc(statusResponse.DownloadId);
  }
}
