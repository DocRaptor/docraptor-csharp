using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using DocRaptor.Client;
using DocRaptor.Model;

namespace DocRaptor.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDocApi
    {
        #region Synchronous Operations

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        AsyncDoc CreateAsyncDoc (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of AsyncDoc</returns>
        ApiResponse<AsyncDoc> CreateAsyncDocWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>byte[]</returns>
        byte[] CreateDoc (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> CreateDocWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>byte[]</returns>
        byte[] GetAsyncDoc (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> GetAsyncDocWithHttpInfo (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        AsyncDocStatus GetAsyncDocStatus (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>ApiResponse of AsyncDocStatus</returns>
        ApiResponse<AsyncDocStatus> GetAsyncDocStatusWithHttpInfo (string id);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (AsyncDoc)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncDoc>> CreateAsyncDocAsyncWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> CreateDocAsync (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> CreateDocAsyncWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> GetAsyncDocAsync (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> GetAsyncDocAsyncWithHttpInfo (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of AsyncDocStatus</returns>
        System.Threading.Tasks.Task<AsyncDocStatus> GetAsyncDocStatusAsync (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of ApiResponse (AsyncDocStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncDocStatus>> GetAsyncDocStatusAsyncWithHttpInfo (string id);

        #endregion Asynchronous Operations

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DocApi : IDocApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DocApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DocApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }


        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        public AsyncDoc CreateAsyncDoc (Doc doc)
        {
             ApiResponse<AsyncDoc> localVarResponse = CreateAsyncDocWithHttpInfo(doc);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of AsyncDoc</returns>
        public ApiResponse< AsyncDoc > CreateAsyncDocWithHttpInfo (Doc doc)
        {

            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling DocApi->CreateAsyncDoc");


            var localVarPath = "/async_docs";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                localVarPostBody = doc; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateAsyncDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateAsyncDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncDoc>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDoc) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncDoc)));

        }


        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        public async System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc)
        {
             ApiResponse<AsyncDoc> localVarResponse = await CreateAsyncDocAsyncWithHttpInfo(doc);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (AsyncDoc)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncDoc>> CreateAsyncDocAsyncWithHttpInfo (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling CreateAsyncDoc");


            var localVarPath = "/async_docs";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                localVarPostBody = doc; // byte array
            }


            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateAsyncDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateAsyncDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncDoc>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDoc) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncDoc)));

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>byte[]</returns>
        public byte[] CreateDoc (Doc doc)
        {
             ApiResponse<byte[]> localVarResponse = CreateDocWithHttpInfo(doc);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > CreateDocWithHttpInfo (Doc doc)
        {

            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling DocApi->CreateDoc");


            var localVarPath = "/docs";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                localVarPostBody = doc; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));

        }


        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> CreateDocAsync (Doc doc)
        {
             ApiResponse<byte[]> localVarResponse = await CreateDocAsyncWithHttpInfo(doc);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> CreateDocAsyncWithHttpInfo (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling CreateDoc");


            var localVarPath = "/docs";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                localVarPostBody = doc; // byte array
            }


            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling CreateDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling CreateDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>byte[]</returns>
        public byte[] GetAsyncDoc (string id)
        {
             ApiResponse<byte[]> localVarResponse = GetAsyncDocWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > GetAsyncDocWithHttpInfo (string id)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocApi->GetAsyncDoc");


            var localVarPath = "/download/{id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));

        }


        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> GetAsyncDocAsync (string id)
        {
             ApiResponse<byte[]> localVarResponse = await GetAsyncDocAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> GetAsyncDocAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAsyncDoc");


            var localVarPath = "/download/{id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter







            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDoc: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDoc: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));

        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        public AsyncDocStatus GetAsyncDocStatus (string id)
        {
             ApiResponse<AsyncDocStatus> localVarResponse = GetAsyncDocStatusWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>ApiResponse of AsyncDocStatus</returns>
        public ApiResponse< AsyncDocStatus > GetAsyncDocStatusWithHttpInfo (string id)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocApi->GetAsyncDocStatus");


            var localVarPath = "/status/{id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDocStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDocStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncDocStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDocStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncDocStatus)));

        }


        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of AsyncDocStatus</returns>
        public async System.Threading.Tasks.Task<AsyncDocStatus> GetAsyncDocStatusAsync (string id)
        {
             ApiResponse<AsyncDocStatus> localVarResponse = await GetAsyncDocStatusAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <exception cref="DocRaptor.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of ApiResponse (AsyncDocStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncDocStatus>> GetAsyncDocStatusAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAsyncDocStatus");


            var localVarPath = "/status/{id}";

            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {

            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter







            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                localVarHeaderParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDocStatus: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAsyncDocStatus: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AsyncDocStatus>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDocStatus) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AsyncDocStatus)));

        }

    }

}
