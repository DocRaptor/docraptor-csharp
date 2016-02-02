# DocRaptor C# Native Client Library

This is a DLL and NuGet package for using [DocRaptor API](https://docraptor.com/documentation) to convert [HTML to PDF and XLSX](https://docraptor.com).


## Installation

**Command line**:

```powershell
nuget.exe install DocRaptor
```

**[Package Manager Console](http://docs.nuget.org/consume/package-manager-console)**:

```powershell
Install-Package DocRaptor
```

**Download DLLs**: get `DocRaptor.dll` from [GitHub](https://github.com/DocRaptor/docraptor-csharp/releases)


## Usage

See [examples](examples/) for runnable examples with file output, error handling, etc.

```csharp
using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System.IO;

class Example {
  static void Main(string[] args) {
    Configuration.Username = "YOUR_API_KEY_HERE"; // this key works for test documents
    DocApi docraptor = new DocApi();

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

    byte[] create_response = docraptor.CreateDoc(doc);
  }
}
```

Docs created like this are limited to 60 seconds to render, check out the [async example](examples/Async.cs) which allows 10 minutes.

We have guides for doing some of the common things:

* [Headers and Footers](https://docraptor.com/documentation/style#pdf-headers-footers) including page skipping
* [CSS Media Selector](https://docraptor.com/documentation/api#api_basic_pdf) to make the page look exactly as it does in your browser
* Protect content with [HTTP authentication](https://docraptor.com/documentation/api#api_http_user) or [proxies](https://docraptor.com/documentation/api#api_http_proxy) so only DocRaptor can access them


## More Help

DocRaptor has a lot of more [styling](https://docraptor.com/documentation/style) and [implementation options](https://docraptor.com/documentation/api).

Stuck? We're experts at using DocRaptor so please [email us](mailto:support@docraptor.com) if you run into trouble.


## Development

The majority of the code in this repo is generated using swagger-codegen on [docraptor.yaml](docraptor.yaml). You can modify this file and regenerate the client using `script/generate_language csharp`.

The generated client needed a few fixes
- `Base64Encoded` needed to be called on `ApiClient`
- `Configuration` had to be set on `ApiClient`
- User agent had to be set


## Release Process

1. `script/test`
2. Increment version in code
  - `swagger-config.json`
  - `DocRaptor.nuspec`
  - `src/properties/AssemblyInfo.cs`
  - `src/main/csharp/DocRaptor/Client/Configuration.cs` (2 places)
3. Update [CHANGELOG.md](CHANGELOG.md)
4. Tag version: `git tag 'v0.0.x' && git push --tags`
5. Push to GitHub
6. Build package using `script/build`
7. `mono vendor/nuget.exe push bin/DocRaptor.x.x.x.nupkg`
8. Use the git tag and make a new release with `bin/*.dll` attached, https://github.com/DocRaptor/docraptor-csharp/tags
9. Update documentation on docraptor.com


## Version Policy

This library follows [Semantic Versioning 2.0.0](http://semver.org).
