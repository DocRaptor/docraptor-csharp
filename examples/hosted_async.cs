// As a paid add-on, DocRaptor can provide long-term, publicly-accessible hosting for your documents.
// This allows you to provide a URL to your end users, third party tools like Zapier and Salesforce,
// or anyone else. We'll host the document on your behalf at a completely unbranded URL for as long
// as you want, or within the limits you specify.
//
// This example demonstrates creating a PDF using common options that DocRaptor will host for you.
// By default, hosted documents do not have limits on downloads or hosting time, though you may
// pass additional parameters to the document generation call to set your own limits. Learn more
// about the specific options in the hosted API documentation.
// https://docraptor.com/documentation/api#api_hosted
//
// The document is created asynchronously, which means DocRaptor will allow it to generate for up to
// 10 minutes. This is useful when creating many documents in parallel, or very large documents with
// lots of assets.
//
// DocRaptor supports many options for output customization, the full list is
// https://docraptor.com/documentation/api#api_general
//
// You can run this example with: ./script/run_csharp_file examples/hosted_async.cs


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
      docraptor.Configuration.Username = "YOUR_API_KEY_HERE";

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

      AsyncDoc response = docraptor.CreateHostedAsyncDoc(doc);

      DocStatus statusResponse;
      Boolean done = false;
      while(!done) {
        statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
        Console.WriteLine("doc status: " + statusResponse.Status);
        switch(statusResponse.Status) {
          case "completed":
            done = true;
            Console.WriteLine("Hosted Async Download URL: " + statusResponse.DownloadUrl);
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
