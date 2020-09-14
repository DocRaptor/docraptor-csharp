using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class InvalidSyncTest {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE";
    // docraptor.Configuration.Debug = true; // Not supported in Csharp

    Doc doc = new Doc(
      name: new String('s', 201), // limit is 200 characters
      test: true,
      documentContent: "<html><body>Hello from C#</body></html>",
      documentType: Doc.DocumentTypeEnum.Pdf
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
