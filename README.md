# DocRaptor C# Native Client Library

This is a DLL and NuGet package for using [DocRaptor API](https://docraptor.com/documentation) to convert [HTML to PDF and XLSX](https://docraptor.com).

## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.2.3 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later


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


## Basic Usage

```csharp
using DocRaptor.Client;
using DocRaptor.Model;
using DocRaptor.Api;
using System.IO;

class Example {
  static void Main(string[] args) {
    DocApi docraptor = new DocApi();
    docraptor.Configuration.Username = "YOUR_API_KEY_HERE"; // this key works for test documents

    Doc doc = new Doc(
      test: true,                                                    // test documents are free but watermarked
      documentContent: "<html><body>Hello World</body></html>",      // supply content directly
      // documentUrl: "http://docraptor.com/examples/invoice.html",  // or use a url
      name: "docraptor-csharp.pdf",                                  // help you find a document later
      documentType: Doc.DocumentTypeEnum.Pdf                         // pdf or xls or xlsx
      // Javascript: true,                                           // enable javaScript processing
      // princeOptions: new PrinceOptions(
      //   media: "screen",                                          // use screen styles instead of print styles
      //   baseurl: "http://hello.com"                               // pretend URL when using document_content
      // )
    );

    byte[] createResponse = docraptor.CreateDoc(doc);
  }
}
```

## Next Steps

- Optionally store and get a URL for your converted document with [document hosting](https://docraptor.com/document-hosting)
- View more [code examples](examples) with error handling, asynchronous creation, file saving, and document hosting.
- Perfect your document styling with our [style and formatting reference](https://docraptor.com/documentation/style), and [API reference](https://docraptor.com/documentation/api). Easily add headers and footers, page breaks, page numbers, table of contents, and much more!

## More Help

Stuck? We're experts at turning HTML into PDFs so please [email us](mailto:support@docraptor.com) if you run into trouble.


## Development

The majority of the code in this repo is generated using swagger-codegen on [docraptor.yaml](docraptor.yaml). You can modify this file and regenerate the client using `script/generate_language csharp`.

Don't let swagger downgrade RestSharp to 105.1.0; it will try.


## Release Process

1. Pull latest master
2. Merge feature branch(es) into master
3. `script/test`
4. Increment version in code:
  - `swagger-config.json`
  - `DocRaptor.nuspec`
  - `src/main/csharp/DocRaptor/Properties/AssemblyInfo.cs`
  - `src/main/csharp/DocRaptor/Client/Configuration.cs` (2 places)
5. Update [CHANGELOG.md](CHANGELOG.md)
6. Commit "Release vX.Y.Z"
7. Push to GitHub
8. Tag version: `git tag 'vX.Y.Z' && git push --tags`
9. Build package using `script/build`
10. `script/nuget push bin/DocRaptor.X.Y.Z.nupkg <api_key> -Source https://api.nuget.org/v3/index.json`
11. Verify package release at https://www.nuget.org/packages
12. Open https://github.com/DocRaptor/docraptor-csharp/tags and make a new release for the version. Use the git tag as the name, CHANGELOG entries as the description, and attach `bin/*.dll` and `bin/*.xml` to the release
13. Refresh documentation on docraptor.com


## Version Policy

This library follows [Semantic Versioning 2.0.0](http://semver.org).
