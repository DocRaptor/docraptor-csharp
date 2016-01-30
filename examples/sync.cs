// This example demonstrates creating a PDF using common options and saving it
// to a place on the filesystem.
//
// It is created synchronously, which means DocRaptor will render it for up to
// 60 seconds. It is slightly simpler than making documents using the async
// interface but making many documents in parallel or very large documents with
// lots of assets will require the async api.
//
// DocRaptor supports many options for output customization, the full list is
// https://docraptor.com/documentation/api#api_general
//
// You can run this example with: ./script/run_csharp_file examples/sync.cs

using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    try {
      Configuration.Default.Username = "YOUR_API_KEY_HERE"; // this key works for test documents
      DocApi docraptor = new DocApi();

      Doc doc = new Doc();
      doc.Test = true;                                                        // test documents are free but watermarked
      doc.DocumentContent = "<html><body>Hello World</body></html>";          // supply content directly
      // doc.DocumentUrl     = "http://docraptor.com/examples/invoice.html";  // or use a url
      doc.Name = "docraptor-csharp.pdf";                                      // help you find a document later
      doc.DocumentType = "pdf";                                               // pdf or xls or xlsx
      // doc.Javascript = true;                                               // enable JavaScript processing
      // doc.PrinceOptions = new PrinceOptions();
      // doc.PrinceOptions.Media = "screen";                                  // use screen styles instead of print styles
      // doc.PrinceOptions.Baseurl = "http://hello.com";                      // pretend URL when using document_content

      byte[] create_response = docraptor.CreateDoc(doc);
      File.WriteAllBytes("/tmp/docraptor-csharp.pdf", create_response);
      Console.WriteLine("Wrote PDF to /tmp/docraptor-csharp.pdf");
    } catch (DocRaptor.Client.ApiException error) {
      Console.WriteLine(error);
    }
  }
}
