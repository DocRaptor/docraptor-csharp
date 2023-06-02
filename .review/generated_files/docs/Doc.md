
# DocRaptor.Model.Doc

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A name for identifying your document. | 
**DocumentType** | **string** | The type of document being created. | 
**DocumentContent** | **string** | The HTML data to be transformed into a document. You must supply content using document_content or document_url.  | [optional] 
**DocumentUrl** | **string** | The URL to fetch the HTML data to be transformed into a document. You must supply content using document_content or document_url.  | [optional] 
**Test** | **bool** | Enable test mode for this document. Test documents are not charged for but include a watermark. | [optional] [default to true]
**Pipeline** | **string** | Specify a specific verison of the DocRaptor Pipeline to use. | [optional] 
**Strict** | **string** | Force strict HTML validation. | [optional] 
**IgnoreResourceErrors** | **bool** | Failed loading of images/javascripts/stylesheets/etc. will not cause the rendering to stop. | [optional] [default to true]
**IgnoreConsoleMessages** | **bool** | Prevent console.log from stopping document rendering during JavaScript execution. | [optional] [default to false]
**Tag** | **string** | A field for storing a small amount of metadata with this document. | [optional] 
**Help** | **bool** | Request support help with this request if it succeeds. | [optional] [default to false]
**Javascript** | **bool** | Enable DocRaptor JavaScript parsing. PrinceXML JavaScript parsing is also available elsewhere. | [optional] [default to false]
**Referrer** | **string** | Set HTTP referrer when generating this document. | [optional] 
**CallbackUrl** | **string** | A URL that will receive a POST request after successfully completing an asynchronous document. The POST data will include download_url and download_id similar to status API responses. WARNING: this only works on asynchronous documents.  | [optional] 
**HostedDownloadLimit** | **int** | The number of times a hosted document can be downloaded.  If no limit is specified, the document will be available for an unlimited number of downloads. | [optional] 
**HostedExpiresAt** | **string** | The date and time at which a hosted document will be removed and no longer available. Must be a properly formatted ISO 8601 datetime, like 1981-01-23T08:02:30-05:00. | [optional] 
**PrinceOptions** | [**PrinceOptions**](PrinceOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

