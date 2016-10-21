using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class InvalidSyncTest {
  static void Main(string[] args) {
    Configuration.Default.Username = "YOUR_API_KEY_HERE";
    // Configuration.Default.Debug = true; // Not supported in Csharp
    DocApi docraptor = new DocApi();

    Doc doc = new Doc(
      Name: new String('s', 201), // limit is 200 characters
      Test: true,
      DocumentContent: "<html><body>Hello from C#</body></html>",
      Type: Doc.TypeEnum.Pdf
    );

    try {
      docraptor.CreateDoc(doc);
    } catch (DocRaptor.Client.ApiException) {
      Environment.Exit(0);
    }
    Console.WriteLine("Exception expected, but not raised");
    Environment.Exit(1);
  }
}
