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
      DocApi docraptor = new DocApi();
      docraptor.Configuration.Username = "YOUR_API_KEY_HERE"; // this key works for test documents

      Doc doc = new Doc(
        test: true,                                                    // test documents are free but watermarked
        documentContent: "<html><body>Hello World</body></html>",      // supply content directly
        // documentUrl: "http://docraptor.com/examples/invoice.html",  // or use a url
        name: "docraptor-csharp.pdf",                                  // help you find a document later
        documentType: Doc.DocumentTypeEnum.Pdf                         // pdf or xls or xlsx
        // javascript: true,                                           // enable JavaScript processing
        // princeOptions: new PrinceOptions(
        //   media: "screen",                                          // use screen styles instead of print styles
        //   baseurl: "http://hello.com"                               // pretend URL when using document_content
        // )
      );

      AsyncDoc response = docraptor.CreateAsyncDoc(doc);

      DocStatus statusResponse;
      Boolean done = false;
      while(!done) {
        statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
        Console.WriteLine("doc status: " + statusResponse.Status);
        switch(statusResponse.Status) {
          case "completed":
            done = true;
            byte[] docResponse = docraptor.GetAsyncDoc(statusResponse.DownloadId);
            File.WriteAllBytes("/tmp/docraptor-csharp.pdf", docResponse);
            Console.WriteLine("Wrote PDF to /tmp/docraptor-csharp.pdf");
            break;
          case "failed":
            done = true;
            Console.WriteLine("FAILED");
            Console.WriteLine(statusResponse);
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
