using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.Threading;

class InvalidAsyncTest {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE";
    // Configuration.Debug = true; // Not supported in Csharp
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Name = new String('s', 201);
    doc.Test = true;
    doc.DocumentContent = "<html><body>Swagger C#</body></html>";
    doc.DocumentType = "pdf";

    AsyncDoc response = docraptor.AsyncDocsPost(doc);

    AsyncDocStatus status_response;
    for(int i=0; i<30; i++) {
      status_response = docraptor.StatusIdGet(response.StatusId);
      Console.WriteLine(status_response);
      if (status_response.Status == "failed") {
        Environment.Exit(0);
      }
      Thread.Sleep(1000);
    }
    Console.WriteLine("Did not receive failed validation within 30 seconds.");
    Environment.Exit(1);
  }
}
