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
// DocRaptor supports many CSS and API options for output customization. Visit
// https://docraptor.com/documentation/ for full details.
// 
// You can run this example with: ./script/run_csharp_file examples/HostedSync.cs

using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System;
using System.IO;

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
                name: "github-hosted-sync",
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

            // different method than the non-hosted documents
            DocStatus statusResponse = docraptor.CreateHostedDoc(doc);
            Console.WriteLine("The PDF is hosted at " + statusResponse.DownloadUrl);
        } catch (DocRaptor.Client.ApiException error) {
            Console.Write(error.ErrorContent);
        }
    }
}