// This example demonstrates creating a PDF using common options and saving it
// to a place on the filesystem.
// 
// It is created synchronously, which means DocRaptor will render it for up to
// 60 seconds. It is slightly simpler than making documents using the async
// interface but making many documents in parallel or very large documents with
// lots of assets will require the async api.
// 
// DocRaptor supports many CSS and API options for output customization. Visit
// https://docraptor.com/documentation/ for full details.
// 
// You can run this example with: ./script/run_csharp_file examples/Sync.cs

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
                name: "github-sync",
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

            byte[] document = docraptor.CreateDoc(doc);
            File.WriteAllBytes("github-sync.pdf", document);
            Console.WriteLine("Successfully created github-sync.pdf!");
        } catch (DocRaptor.Client.ApiException error) {
            Console.Write(error.ErrorContent);
        }
    }
}