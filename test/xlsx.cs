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
    DocApi docraptor = new DocApi();

    Doc doc = new Doc(
      Name: "csharp-xlsx.xlsx",
      Test: true,
      DocumentContent: "<html><body><table><tr><td>Hello from C#</td></tr></table></body></html>",
      Type: Doc.TypeEnum.Xlsx
    );

    docraptor.CreateDoc(doc);
  }
}
