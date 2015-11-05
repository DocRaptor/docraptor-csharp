using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using DocRaptor.Client;
using DocRaptor.Model;

namespace DocRaptor.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        AsyncDoc AsyncDocsPost (Doc doc);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        System.Threading.Tasks.Task<AsyncDoc> AsyncDocsPostAsync (Doc doc);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Stream</returns>
        Stream DocsPost (Doc doc);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Stream</returns>
        System.Threading.Tasks.Task<Stream> DocsPostAsync (Doc doc);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Stream</returns>
        Stream DownloadIdGet (string id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Stream</returns>
        System.Threading.Tasks.Task<Stream> DownloadIdGetAsync (string id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        AsyncDocStatus StatusIdGet (string id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Check on the status of an asynchronously created document.
        /// </remarks>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        System.Threading.Tasks.Task<AsyncDocStatus> StatusIdGetAsync (string id);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ClientApi : IClientApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ClientApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param> 
        /// <returns>AsyncDoc</returns>            
        public AsyncDoc AsyncDocsPost (Doc doc)
        {
            
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling AsyncDocsPost");
            
    
            var path = "/async_docs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(doc); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AsyncDocsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AsyncDocsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AsyncDoc) ApiClient.Deserialize(response.Content, typeof(AsyncDoc), response.Headers);
        }
    
        /// <summary>
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>AsyncDoc</returns>
        public async System.Threading.Tasks.Task<AsyncDoc> AsyncDocsPostAsync (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling AsyncDocsPost");
            
    
            var path = "/async_docs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(doc); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AsyncDocsPost: " + response.Content, response.Content);

            return (AsyncDoc) ApiClient.Deserialize(response.Content, typeof(AsyncDoc), response.Headers);
        }
        
        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param> 
        /// <returns>Stream</returns>            
        public Stream DocsPost (Doc doc)
        {
            
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling DocsPost");
            
    
            var path = "/docs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(doc); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DocsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DocsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
    
        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Stream</returns>
        public async System.Threading.Tasks.Task<Stream> DocsPostAsync (Doc doc)
        {
            // verify the required parameter 'doc' is set
            if (doc == null) throw new ApiException(400, "Missing required parameter 'doc' when calling DocsPost");
            
    
            var path = "/docs";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(doc); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DocsPost: " + response.Content, response.Content);

            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
        
        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param> 
        /// <returns>Stream</returns>            
        public Stream DownloadIdGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DownloadIdGet");
            
    
            var path = "/download/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
    
        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Stream</returns>
        public async System.Threading.Tasks.Task<Stream> DownloadIdGetAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DownloadIdGet");
            
    
            var path = "/download/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DownloadIdGet: " + response.Content, response.Content);

            return (Stream) ApiClient.Deserialize(response.Content, typeof(Stream), response.Headers);
        }
        
        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param> 
        /// <returns>AsyncDocStatus</returns>            
        public AsyncDocStatus StatusIdGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StatusIdGet");
            
    
            var path = "/status/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StatusIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StatusIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (AsyncDocStatus) ApiClient.Deserialize(response.Content, typeof(AsyncDocStatus), response.Headers);
        }
    
        /// <summary>
        ///  Check on the status of an asynchronously created document.
        /// </summary>
        /// <param name="id">The status_id returned when creating an asynchronous document.</param>
        /// <returns>AsyncDocStatus</returns>
        public async System.Threading.Tasks.Task<AsyncDocStatus> StatusIdGetAsync (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StatusIdGet");
            
    
            var path = "/status/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json", "application/xml", "application/pdf", "application/vnd.ms-excel", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "basicAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StatusIdGet: " + response.Content, response.Content);

            return (AsyncDocStatus) ApiClient.Deserialize(response.Content, typeof(AsyncDocStatus), response.Headers);
        }
        
    }
    
}
