# DocRaptor C# Native Client Library

**WARNING: This code is not production ready, you should use [this](http://docraptor.com/documentation/dotnet).**

This is a DLL for using [DocRaptor API](http://docraptor.com/documentation) to convert HTML to PDF and XLSX.

## Installation

TODO

## Usage

```csharp
using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System.IO;

class Example {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE"; /// this key works for test documents
    ClientApi docraptor = new ClientApi();

    Doc doc = new Doc();
    doc.Test = true;                                                        /// test documents are free but watermarked
    doc.DocumentContent = "<html><body>Swagger C#</body></html>";           /// supply content directly
    /// doc.DocumentUrl     = "http://docraptor.com/examples/invoice.html"; /// or use a url
    doc.Name = "swagger-csharp.pdf";                                        /// help you find a document later
    doc.DocumentType = "pdf";                                               /// pdf or xls or xlsx
    /// doc.Javascript = true;                                              /// enable JavaScript processing
    /// doc.PrinceOptions = new PrinceOptions();
    /// doc.PrinceOptions.Media = "screen";                                 /// use screen styles instead of print styles
    /// doc.PrinceOptions.Baseurl = "http://hello.com";                     /// pretend URL when using document_content

    Stream response = docraptor.CreateDoc(doc);
  }
}
```

If your document will take longer than 60 seconds to render to PDF you will need to use our async api which allows up to 10 minutes, check out the [example](example/async.cs).


We have guides for doing some of the common things:
* [Headers and Footers](https://docraptor.com/documentation/style#pdf-headers-footers) including page skipping
* [CSS Media Selector](https://docraptor.com/documentation/api#api_basic_pdf) to make the page look exactly as it does in your browser
* [Protected Content](https://docraptor.com/documentation/api#api_advanced_pdf) to secure your URLs so only DocRaptor can access them

## More Help

DocRaptor has a lot of more [styling](https://docraptor.com/documentation/style) and [implementation options](https://docraptor.com/documentation/api).

Stuck? We're experts at using DocRaptor so please [email us](mailto:support@docraptor.com) if you run into trouble.


## Development

The majority of the code in this repo is generated using swagger-codegen on [docraptor.yaml](docraptor.yaml). You can modify this file and regenerate the client using `script/generate_language csharp`.

## Release Process

1. Merge code
2. `script/test`
3. Increment version in code
4. Update [CHANGELOG.md](CHANGELOG.md)
5. Push to GitHub
6. Build DLLs using `script/build`
7. Relase TODO

## Version Policy

This library follows [Semantic Versioning 2.0.0](http://semver.org).
