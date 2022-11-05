using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Linq;
using System.Threading;

class AsyncTest
{
  static void Main(string[] args)
  {
    DocApi docraptor = new DocApi();
    // this key works in test mode!
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";

    Doc doc = new Doc(
      name: "csharp-async.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    AsyncDoc response = docraptor.CreateAsyncDoc(doc);

    DocStatus statusResponse;
    Boolean done = false;
    while(!done) {
      statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
      switch(statusResponse.Status) {
        case "completed":
          done = true;
          byte[] docResponse = docraptor.GetAsyncDoc(statusResponse.DownloadId);
          string output_file = Environment.GetEnvironmentVariable("TEST_OUTPUT_DIR") +
            "/" + Environment.GetEnvironmentVariable("TEST_NAME") + "_csharp_" +
            Environment.GetEnvironmentVariable("RUNTIME_ENV") + ".pdf";
          File.WriteAllBytes(output_file, docResponse);

          string line = File.ReadLines(output_file).First();
          if(!line.Contains("%PDF-1.5")) {
            Console.WriteLine("unexpected file header: " + line);
            Environment.Exit(1);
          }

          break;
        case "failed":
          Console.WriteLine("Failed creating hosted async document");
          Environment.Exit(1);
          break;
        default:
          Thread.Sleep(1000);
          break;
      }
    }
  }
}
