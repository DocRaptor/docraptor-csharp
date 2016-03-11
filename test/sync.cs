using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    Configuration.Default.Username = "YOUR_API_KEY_HERE";
    // Configuration.Default.Debug = true; // Not supported in Csharp
    DocApi docraptor = new DocApi();

    Doc doc = new Doc(
      Name: "csharp-sync.pdf",
      Test: true,
      DocumentContent: "<html><body>Hello from C#</body></html>",
      DocumentType: Doc.DocumentTypeEnum.Pdf
    );

    docraptor.CreateDoc(doc);
  }
}
