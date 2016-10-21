using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.Threading;

class InvalidAsyncTest {
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

    AsyncDoc response = docraptor.CreateAsyncDoc(doc);

    AsyncDocStatus status_response;
    for(int i=0; i<30; i++) {
      status_response = docraptor.GetAsyncDocStatus(response.StatusId);
      if (status_response.Status == "failed") {
        Environment.Exit(0);
      }
      Thread.Sleep(1000);
    }
    Console.WriteLine("Did not receive failed validation within 30 seconds.");
    Environment.Exit(1);
  }
}
