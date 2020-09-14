using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.Threading;

class InvalidAsyncTest {
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

    AsyncDoc response = docraptor.CreateAsyncDoc(doc);

    DocStatus statusResponse;
    for(int i=0; i<30; i++) {
      statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
      if (statusResponse.Status == "failed") {
        Environment.Exit(0);
      }
      Thread.Sleep(1000);
    }
    Console.WriteLine("Did not receive failed validation within 30 seconds.");
    Environment.Exit(1);
  }
}
