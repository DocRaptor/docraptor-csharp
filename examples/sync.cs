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
                name: "docraptor-hello",
                test: true, // test documents are free but watermarked
                documentType: Doc.DocumentTypeEnum.Pdf,
                documentContent: "<html><body>Hello World!</body></html>" 
                // documentUrl: "http://docraptor.com/examples/invoice.html", 
                // javascript: false, 
                // princeOptions: new PrinceOptions(
                //     media: "print", // @media 'screen' or 'print' CSS
                //     baseurl: "https://yoursite.com" // the base URL for any relative URLs
                // )
            );

            byte[] pdf = docraptor.CreateDoc(doc);
            File.WriteAllBytes("docraptor-hello.pdf", pdf);
            Console.WriteLine("Successfully created docraptor-hello.pdf!");
        } catch (DocRaptor.Client.ApiException error) {
            Console.Write(error.ErrorContent);
        }
    }
}
