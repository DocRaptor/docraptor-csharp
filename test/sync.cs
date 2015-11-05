using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE";
    // Configuration.Debug = true; // Not supported in Csharp
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = "swagger-csharp.pdf";
    doc.Test = true;
    doc.DocumentContent = "<html><body>Swagger C#</body></html>";
    doc.DocumentType = "pdf";

    Stream response = docraptor.DocsPost(doc);
  }
}
