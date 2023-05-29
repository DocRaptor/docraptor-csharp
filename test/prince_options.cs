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


    // Verify the test works as expected by confirming that this url will fail
    // without prince_options[insecure]=true.
    Doc doc = new Doc(
      name: "csharp-sync.pdf",
      test: true,
      documentUrl: "https://expired.badssl.com/",
      documentType: Doc.DocumentTypeEnum.Pdf
    );

    try {
      docraptor.CreateDoc(doc);
    } catch (DocRaptor.Client.ApiException ex) {
      string expected_message = "SSL Error downloading document content from supplied url.";
      if (!ex.Message.Contains(expected_message)) {
        Console.WriteLine("Wrong exception, expected: " + expected_message + ", got: " + ex.Message);
        Environment.Exit(1);
      }
    }


    // Verify prince_options works by testing a url that will fail without
    // prince_options[insecure]=true.
    doc = new Doc(
      name: "csharp-sync.pdf",
      test: true,
      documentUrl: "https://expired.badssl.com/",
      documentType: Doc.DocumentTypeEnum.Pdf,
      princeOptions: new PrinceOptions(
        insecure: true
      )
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
