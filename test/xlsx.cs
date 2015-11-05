using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class XlsxTest {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE";
    // Configuration.Debug = true; // Not supported in Csharp
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = "swagger-csharp.xlsx";
    doc.Test = true;
    doc.DocumentContent = "<html><body><table><tr><td>Swagger C#</td></tr></table></body></html>";
    doc.DocumentType = "xlsx";

    Stream response = docraptor.DocsPost(doc);
  }
}
