using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Linq;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-sync.pdf",
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    byte[] document = docraptor.CreateDoc(doc);
    string output_file = Environment.GetEnvironmentVariable("TEST_OUTPUT_DIR") +
      "/" + Environment.GetEnvironmentVariable("TEST_NAME") + "_csharp_" +
      Environment.GetEnvironmentVariable("RUNTIME_ENV") + ".pdf";
    File.WriteAllBytes(output_file, document);

    string line = File.ReadLines(output_file).First();
    if(!line.Contains("%PDF-1.5")) {
      Console.WriteLine("unexpected file header: " + line);
      Environment.Exit(1);
    }
  }
}
