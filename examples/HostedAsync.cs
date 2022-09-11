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
// DocRaptor supports many CSS and API options for output customization. Visit
// https://docraptor.com/documentation/ for full details.
// 
// You can run this example with: ./script/run_csharp_file examples/HostedAsync.cs

using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;
using System.Threading;

class Example
{
    static void Main(string[] args)
    {
        DocApi docraptor = new DocApi();
        // this key works in test mode!
        docraptor.Configuration.Username = "YOUR_API_KEY_HERE";

        try
        {
            Doc doc = new Doc(
                name: "github-hosted-async",
                test: true, // test documents are free but watermarked
                documentType: Doc.DocumentTypeEnum.Pdf,
                documentContent: "<html><body>Hello World!</body></html>" 
                // documentUrl: "https://docraptor.com/examples/invoice.html", 
                // javascript: true, 
                // princeOptions: new PrinceOptions(
                //     media: "print", // @media 'screen' or 'print' CSS
                //     baseurl: "https://yoursite.com" // the base URL for any relative URLs
                // )
            );

            // different method than synchronous or non-hosted documents
            AsyncDoc response = docraptor.CreateHostedAsyncDoc(doc);

            DocStatus statusResponse;
            Boolean done = false;
            while(!done) {
              statusResponse = docraptor.GetAsyncDocStatus(response.StatusId);
              Console.WriteLine("doc status: " + statusResponse.Status);
              switch(statusResponse.Status) {
                case "completed":
                  done = true;
                  Console.WriteLine("The asynchronously-generated PDF is hosted at " + statusResponse.DownloadUrl);
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
            Console.Write(error.ErrorContent);
        }
    }
}