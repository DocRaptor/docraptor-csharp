# DocRaptor - the C# library for the DocRaptor

A native client library for the DocRaptor HTML to PDF/XLS service.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.0
- SDK version: 2.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

## Installation

Run the following command to generate the DLL

- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

```


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out DocRaptor.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var doc = new Doc(); // Doc | The document to be created.

            try
            {
                AsyncDoc result = apiInstance.CreateAsyncDoc(doc);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.CreateAsyncDoc: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Documentation for API Endpoints

All URIs are relative to *https://api.docraptor.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DocApi* | [**CreateAsyncDoc**](docs/DocApi.md#createasyncdoc) | **POST** /async_docs | 
*DocApi* | [**CreateDoc**](docs/DocApi.md#createdoc) | **POST** /docs | 
*DocApi* | [**CreateHostedAsyncDoc**](docs/DocApi.md#createhostedasyncdoc) | **POST** /hosted_async_docs | 
*DocApi* | [**CreateHostedDoc**](docs/DocApi.md#createhosteddoc) | **POST** /hosted_docs | 
*DocApi* | [**Expire**](docs/DocApi.md#expire) | **PATCH** /expire/{id} | 
*DocApi* | [**GetAsyncDoc**](docs/DocApi.md#getasyncdoc) | **GET** /download/{id} | 
*DocApi* | [**GetAsyncDocStatus**](docs/DocApi.md#getasyncdocstatus) | **GET** /status/{id} | 


## Documentation for Models

 - [Model.AsyncDoc](docs/AsyncDoc.md)
 - [Model.Doc](docs/Doc.md)
 - [Model.DocStatus](docs/DocStatus.md)
 - [Model.PrinceOptions](docs/PrinceOptions.md)


## Documentation for Authorization


### basicAuth


- **Type**: HTTP basic authentication
