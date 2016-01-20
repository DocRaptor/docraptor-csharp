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
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = "csharp-sync.pdf";
    doc.Test = true;
    doc.DocumentContent = "<html><body>Hello from C#</body></html>";
    doc.DocumentType = "pdf";

    docraptor.CreateDoc(doc);
  }
}
