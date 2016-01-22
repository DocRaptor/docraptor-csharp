// This example demonstrates creating a PDF using common options and saving it
// to a place on the filesystem.
//
// It is created asynchronously, which means DocRaptor will render it for up to
// 10 minutes. This is useful when creating many documents in parallel, or very
// large documents with lots of assets.
//
// DocRaptor supports many options for output customization, the full list is
// https://docraptor.com/documentation/api#api_general
//
// You can run this example with: ./script/run_csharp_file examples/async.cs

using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class AsyncTest {
  static void Main(string[] args) {
    try {
      Configuration.Default.Username = "YOUR_API_KEY_HERE"; // this key works for test documents
      ClientApi docraptor = new ClientApi();

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

      AsyncDoc response = docraptor.CreateAsyncDoc(doc);

      AsyncDocStatus status_response;
      Boolean done = false;
      while(!done) {
        status_response = docraptor.GetAsyncDocStatus(response.StatusId);
        Console.WriteLine("doc status: " + status_response.Status);
        switch(status_response.Status) {
          case "completed":
            done = true;
            byte[] doc_response = docraptor.GetAsyncDoc(status_response.DownloadId);
            File.WriteAllBytes("/tmp/docraptor-csharp.pdf", doc_response);
            Console.WriteLine("Wrote PDF to /tmp/docraptor-csharp.pdf");
            break;
          case "failed":
            done = true;
            Console.WriteLine("FAILED");
            Console.WriteLine(status_response);
            break;
          default:
            Thread.Sleep(1000);
            break;
        }
      }
    } catch (DocRaptor.Client.ApiException error) {
      Console.WriteLine(error);
    }
  }
}
