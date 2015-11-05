using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class InvalidSyncTest {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE";
    // Configuration.Debug = true; // Not supported in Csharp
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = new String('s', 201);
    doc.Test = true;
    doc.DocumentContent = "<html><body>Swagger C#</body></html>";
    doc.DocumentType = "pdf";

    try {
      Stream response = docraptor.DocsPost(doc);
    } catch (DocRaptor.Client.ApiException error) {
      Environment.Exit(0);
    }
    Console.WriteLine("Exception expected, but not raised");
    Environment.Exit(1);
  }
}
