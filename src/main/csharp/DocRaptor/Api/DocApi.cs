using System;
using System.IO;
using System.Collections.Generic;
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

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        AsyncDoc CreateAsyncDoc (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of AsyncDoc</returns>
        ApiResponse<AsyncDoc> CreateAsyncDocWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (AsyncDoc)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncDoc>> CreateAsyncDocAsyncWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>byte[]</returns>
        byte[] CreateDoc (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> CreateDocWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> CreateDocAsync (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> CreateDocAsyncWithHttpInfo (Doc doc);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>byte[]</returns>
        byte[] GetAsyncDoc (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>ApiResponse of byte[]</returns>
        ApiResponse<byte[]> GetAsyncDocWithHttpInfo (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of byte[]</returns>
        System.Threading.Tasks.Task<byte[]> GetAsyncDocAsync (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        System.Threading.Tasks.Task<ApiResponse<byte[]>> GetAsyncDocAsyncWithHttpInfo (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        AsyncDocStatus GetAsyncDocStatus (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>ApiResponse of AsyncDocStatus</returns>
        ApiResponse<AsyncDocStatus> GetAsyncDocStatusWithHttpInfo (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of AsyncDocStatus</returns>
        System.Threading.Tasks.Task<AsyncDocStatus> GetAsyncDocStatusAsync (string id);

        /// <summary>
        ///
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of ApiResponse (AsyncDocStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<AsyncDocStatus>> GetAsyncDocStatusAsyncWithHttpInfo (string id);

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
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        public AsyncDoc CreateAsyncDoc (Doc doc)
        {
             ApiResponse<AsyncDoc> response = CreateAsyncDocWithHttpInfo(doc);
             return response.Data;
        }

        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of AsyncDoc</returns>
        public ApiResponse< AsyncDoc > CreateAsyncDocWithHttpInfo (Doc doc)
        {

            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling DocApi->CreateAsyncDoc");


            var path_ = "/async_docs";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                postBody = doc; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateAsyncDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateAsyncDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AsyncDoc>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDoc) Configuration.ApiClient.Deserialize(response, typeof(AsyncDoc)));

        }

        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        public async System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc)
        {
             ApiResponse<AsyncDoc> response = await CreateAsyncDocAsyncWithHttpInfo(doc);
             return response.Data;

        }

        /// <summary>
        ///  Creates a document asynchronously. You must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (AsyncDoc)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncDoc>> CreateAsyncDocAsyncWithHttpInfo (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling CreateAsyncDoc");


            var path_ = "/async_docs";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");




            postBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateAsyncDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateAsyncDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AsyncDoc>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDoc) Configuration.ApiClient.Deserialize(response, typeof(AsyncDoc)));

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>byte[]</returns>
        public byte[] CreateDoc (Doc doc)
        {
             ApiResponse<byte[]> response = CreateDocWithHttpInfo(doc);
             return response.Data;
        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > CreateDocWithHttpInfo (Doc doc)
        {

            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling DocApi->CreateDoc");


            var path_ = "/docs";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");




            if (doc.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter
            }
            else
            {
                postBody = doc; // byte array
            }

            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<byte[]>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(response, typeof(byte[])));

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> CreateDocAsync (Doc doc)
        {
             ApiResponse<byte[]> response = await CreateDocAsyncWithHttpInfo(doc);
             return response.Data;

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> CreateDocAsyncWithHttpInfo (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling CreateDoc");


            var path_ = "/docs";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");




            postBody = Configuration.ApiClient.Serialize(doc); // http body (model) parameter



            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_,
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<byte[]>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(response, typeof(byte[])));

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>byte[]</returns>
        public byte[] GetAsyncDoc (string id)
        {
             ApiResponse<byte[]> response = GetAsyncDocWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>ApiResponse of byte[]</returns>
        public ApiResponse< byte[] > GetAsyncDocWithHttpInfo (string id)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocApi->GetAsyncDoc");


            var path_ = "/download/{id}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAsyncDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAsyncDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<byte[]>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(response, typeof(byte[])));

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of byte[]</returns>
        public async System.Threading.Tasks.Task<byte[]> GetAsyncDocAsync (string id)
        {
             ApiResponse<byte[]> response = await GetAsyncDocAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (byte[])</returns>
        public async System.Threading.Tasks.Task<ApiResponse<byte[]>> GetAsyncDocAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAsyncDoc");


            var path_ = "/download/{id}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter







            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAsyncDoc: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAsyncDoc: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<byte[]>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[]) Configuration.ApiClient.Deserialize(response, typeof(byte[])));

        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        public AsyncDocStatus GetAsyncDocStatus (string id)
        {
             ApiResponse<AsyncDocStatus> response = GetAsyncDocStatusWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>ApiResponse of AsyncDocStatus</returns>
        public ApiResponse< AsyncDocStatus > GetAsyncDocStatusWithHttpInfo (string id)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DocApi->GetAsyncDocStatus");


            var path_ = "/status/{id}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter






            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAsyncDocStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAsyncDocStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AsyncDocStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDocStatus) Configuration.ApiClient.Deserialize(response, typeof(AsyncDocStatus)));

        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of AsyncDocStatus</returns>
        public async System.Threading.Tasks.Task<AsyncDocStatus> GetAsyncDocStatusAsync (string id)
        {
             ApiResponse<AsyncDocStatus> response = await GetAsyncDocStatusAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>Task of ApiResponse (AsyncDocStatus)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AsyncDocStatus>> GetAsyncDocStatusAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAsyncDocStatus");


            var path_ = "/status/{id}";

            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {

            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter







            // authentication (basicAuth) required

            // http basic authentication required
            if (!String.IsNullOrEmpty(Configuration.Username) || !String.IsNullOrEmpty(Configuration.Password))
            {
                headerParams["Authorization"] = "Basic " + ApiClient.Base64Encode(Configuration.Username + ":" + Configuration.Password);
            }


            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_,
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;

            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAsyncDocStatus: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAsyncDocStatus: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AsyncDocStatus>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AsyncDocStatus) Configuration.ApiClient.Deserialize(response, typeof(AsyncDocStatus)));

        }

    }

}
