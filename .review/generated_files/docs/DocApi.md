# DocRaptor.Api.DocApi

All URIs are relative to *https://api.docraptor.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateAsyncDoc**](DocApi.md#createasyncdoc) | **POST** /async_docs | 
[**CreateDoc**](DocApi.md#createdoc) | **POST** /docs | 
[**CreateHostedAsyncDoc**](DocApi.md#createhostedasyncdoc) | **POST** /hosted_async_docs | 
[**CreateHostedDoc**](DocApi.md#createhosteddoc) | **POST** /hosted_docs | 
[**Expire**](DocApi.md#expire) | **PATCH** /expire/{id} | 
[**GetAsyncDoc**](DocApi.md#getasyncdoc) | **GET** /download/{id} | 
[**GetAsyncDocStatus**](DocApi.md#getasyncdocstatus) | **GET** /status/{id} | 



## CreateAsyncDoc

> AsyncDoc CreateAsyncDoc (Doc doc)



Creates a document asynchronously. You must use a callback url or the returned status id and the status API to find out when it completes. Then use the download API to get the document. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class CreateAsyncDocExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var doc = new Doc(); // Doc | 

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

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **doc** | [**Doc**](Doc.md)|  | 

### Return type

[**AsyncDoc**](AsyncDoc.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateDoc

> byte[] CreateDoc (Doc doc)



Creates a document synchronously. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class CreateDocExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var doc = new Doc(); // Doc | 

            try
            {
                byte[] result = apiInstance.CreateDoc(doc);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.CreateDoc: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **doc** | [**Doc**](Doc.md)|  | 

### Return type

**byte[]**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateHostedAsyncDoc

> AsyncDoc CreateHostedAsyncDoc (Doc doc)



Creates a hosted document asynchronously. You must use a callback url or the returned status id and the status API to find out when it completes. Then use the download API to get the document. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class CreateHostedAsyncDocExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var doc = new Doc(); // Doc | 

            try
            {
                AsyncDoc result = apiInstance.CreateHostedAsyncDoc(doc);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.CreateHostedAsyncDoc: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **doc** | [**Doc**](Doc.md)|  | 

### Return type

[**AsyncDoc**](AsyncDoc.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## CreateHostedDoc

> DocStatus CreateHostedDoc (Doc doc)



Creates a hosted document synchronously. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class CreateHostedDocExample
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
                DocStatus result = apiInstance.CreateHostedDoc(doc);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.CreateHostedDoc: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **doc** | [**Doc**](Doc.md)| The document to be created. | 

### Return type

[**DocStatus**](DocStatus.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## Expire

> void Expire (string id)



Expires a previously created hosted doc. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class ExpireExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var id = "id_example";  // string | The download_id returned from status request or hosted document response.

            try
            {
                apiInstance.Expire(id);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.Expire: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The download_id returned from status request or hosted document response. | 

### Return type

void (empty response body)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAsyncDoc

> byte[] GetAsyncDoc (string id)



Downloads a finished document. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class GetAsyncDocExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var id = "id_example";  // string | The download_id returned from an async status request or callback.

            try
            {
                byte[] result = apiInstance.GetAsyncDoc(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.GetAsyncDoc: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The download_id returned from an async status request or callback. | 

### Return type

**byte[]**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetAsyncDocStatus

> DocStatus GetAsyncDocStatus (string id)



Check on the status of an asynchronously created document. 

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DocRaptor.Api;
using DocRaptor.Client;
using DocRaptor.Model;

namespace Example
{
    public class GetAsyncDocStatusExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.docraptor.com";
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DocApi(Configuration.Default);
            var id = "id_example";  // string | The status_id returned when creating an asynchronous document.

            try
            {
                DocStatus result = apiInstance.GetAsyncDocStatus(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DocApi.GetAsyncDocStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The status_id returned when creating an asynchronous document. | 

### Return type

[**DocStatus**](DocStatus.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: */*


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful response |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **500** | Server Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

