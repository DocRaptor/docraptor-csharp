using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class XlsxTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: "csharp-xlsx.xlsx",
      test: true,
      documentContent: "<html><body><table><tr><td>Hello from C#</td></tr></table></body></html>",
      documentType: Doc.DocumentTypeEnum.Xlsx
    );

    byte[] document = docraptor.CreateDoc(doc);
    string output_file = Environment.GetEnvironmentVariable("TEST_OUTPUT_DIR") +
      "/" + Environment.GetEnvironmentVariable("TEST_NAME") + "_csharp_" +
      Environment.GetEnvironmentVariable("RUNTIME_ENV") + ".xlsx";
    File.WriteAllBytes(output_file, document);
  }
}
