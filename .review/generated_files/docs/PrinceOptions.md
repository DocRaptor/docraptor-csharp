
# DocRaptor.Model.PrinceOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Baseurl** | **string** | Set the baseurl for assets. | [optional] 
**NoXinclude** | **bool** | Disable XML inclusion. | [optional] 
**NoNetwork** | **bool** | Disable network access. | [optional] 
**NoParallelDownloads** | **bool** | Disables parallel fetching of assets during PDF creation. Useful if your asset host has strict rate limiting. | [optional] 
**HttpUser** | **string** | Set the user for HTTP authentication. | [optional] 
**HttpPassword** | **string** | Set the password for HTTP authentication. | [optional] 
**HttpProxy** | **string** | Set the HTTP proxy server. | [optional] 
**HttpTimeout** | **int** | Set the HTTP request timeout. | [optional] 
**Insecure** | **bool** | Disable SSL verification. | [optional] 
**Media** | **string** | Specify the CSS media type. Defaults to \&quot;print\&quot; but you may want to use \&quot;screen\&quot; for web styles. | [optional] 
**NoAuthorStyle** | **bool** | Ignore author stylesheets. | [optional] 
**NoDefaultStyle** | **bool** | Ignore default stylesheets. | [optional] 
**NoEmbedFonts** | **bool** | Disable font embedding in PDFs. | [optional] 
**NoSubsetFonts** | **bool** | Disable font subsetting in PDFs. | [optional] 
**NoCompress** | **bool** | Disable PDF compression. | [optional] 
**Encrypt** | **bool** | Encrypt PDF output. | [optional] 
**KeyBits** | **int** | Set encryption key size. | [optional] 
**UserPassword** | **string** | Set the PDF user password. | [optional] 
**OwnerPassword** | **string** | Set the PDF owner password. | [optional] 
**DisallowPrint** | **bool** | Disallow printing of this PDF. | [optional] 
**DisallowCopy** | **bool** | Disallow copying of this PDF. | [optional] 
**DisallowAnnotate** | **bool** | Disallow annotation of this PDF. | [optional] 
**DisallowModify** | **bool** | Disallow modification of this PDF. | [optional] 
**Debug** | **bool** | Enable Prince debug mode. | [optional] 
**Input** | **string** | Specify the input format, defaults to html. | [optional] 
**_Version** | **string** | Deprecated, use the appropriate &#x60;pipeline&#x60; version. Specify a specific verison of PrinceXML to use. | [optional] 
**Javascript** | **bool** | Enable PrinceXML JavaScript. DocRaptor JavaScript parsing is also available elsewhere. | [optional] 
**CssDpi** | **int** | Set the DPI when rendering CSS. Defaults to 96 but can be set with Prince 9.0 and up. | [optional] 
**Profile** | **string** | In Prince 9.0 and up you can set the PDF profile. | [optional] 
**PdfTitle** | **string** | Specify the PDF title, part of the document&#39;s metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

