using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class XlsxTest {
  static void Main(string[] args) {
    Configuration.Default.Username = "YOUR_API_KEY_HERE";
    // Configuration.Default.Debug = true; // Not supported in Csharp
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = "csharp-xlsx.xlsx";
    doc.Test = true;
    doc.DocumentContent = "<html><body><table><tr><td>Hello from C#</td></tr></table></body></html>";
    doc.DocumentType = "xlsx";

    docraptor.CreateDoc(doc);
  }
}
