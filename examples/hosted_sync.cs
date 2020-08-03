// As a paid add-on, DocRaptor can provide long-term, publicly-accessible hosting for your documents.
// This allows you to provide a URL to your end users, third party tools like Zapier and Salesforce,
// or anyone else. We'll host the document on your behalf at a completely unbranded URL for as long
// as you want, or within the limits you specify.
//
// This example demonstrates creating a PDF that DocRaptor will host for you using common options.
// By default, hosted documents do not have limits on downloads or hosting time, though you may
// pass additional parameters to the document generation call to set your own limits. Learn more
// about the specific options in the hosted API documentation.
// https://docraptor.com/documentation/api#api_hosted
//
// It is created synchronously, which means DocRaptor will allow it to generate for up to 60 seconds.
// Since this document will be hosted by DocRaptor the response from this request will return a JSON
// formatted object containing public URL where the document can be downloaded from.
//
// DocRaptor supports many options for output customization, the full list is
// https://docraptor.com/documentation/api#api_general
//
// You can run this example with: ./script/run_csharp_file examples/hosted_sync.cs

using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class SyncTest {
  static void Main(string[] args) {
    try {
      Configuration.Default.Username = "YOUR_API_KEY_HERE"; // you will need a real api key to test hosted documents
      DocApi docraptor = new DocApi();

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

      DocStatus status_response = docraptor.CreateHostedDoc(doc);
      byte[] data = docraptor.GetAsyncDoc(status_response.DownloadId);
      File.WriteAllBytes("/tmp/docraptor-csharp.pdf", data);
      Console.WriteLine("Wrote PDF to /tmp/docraptor-csharp.pdf");
    } catch (DocRaptor.Client.ApiException error) {
      Console.WriteLine(error);
    }
  }
}
