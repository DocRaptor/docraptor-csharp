// This example demonstrates creating a PDF using common options and saving it
// to a place on the filesystem.
// 
// It is created asynchronously, which means DocRaptor will render it for up to
// 10 minutes. This is useful when creating many documents in parallel, or very
// large documents with lots of assets.
// 
// DocRaptor supports many CSS and API options for output customization. Visit
// https://docraptor.com/documentation/ for full details.
// 
// You can run this example with: ./script/run_csharp_file examples/Async.cs

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
                name: "github-async",
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

            // different method than the synchronous documents
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
                  File.WriteAllBytes("github-async.pdf", docResponse);
                  Console.WriteLine("Successfully created github-async.pdf!");
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