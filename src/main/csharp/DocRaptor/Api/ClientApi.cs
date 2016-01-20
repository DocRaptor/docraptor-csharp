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
        AsyncDoc CreateAsyncDoc (Doc doc);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of AsyncDoc</returns>
        ApiResponse<AsyncDoc> CreateAsyncDocWithHttpInfo (Doc doc);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
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
        /// <returns>Stream</returns>
        Stream CreateDoc (Doc doc);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> CreateDocWithHttpInfo (Doc doc);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> CreateDocAsync (Doc doc);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a document synchronously.
        /// </remarks>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> CreateDocAsyncWithHttpInfo (Doc doc);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Stream</returns>
        Stream GetAsyncDoc (string id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>ApiResponse of Stream</returns>
        ApiResponse<Stream> GetAsyncDocWithHttpInfo (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of Stream</returns>
        System.Threading.Tasks.Task<Stream> GetAsyncDocAsync (string id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Downloads a document.
        /// </remarks>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<Stream>> GetAsyncDocAsyncWithHttpInfo (string id);
        
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
    public class ClientApi : IClientApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ClientApi(Configuration configuration = null)
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
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param> 
        /// <returns>AsyncDoc</returns>
        public AsyncDoc CreateAsyncDoc (Doc doc)
        {
             ApiResponse<AsyncDoc> response = CreateAsyncDocWithHttpInfo(doc);
             return response.Data;
        }

        /// <summary>
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param> 
        /// <returns>ApiResponse of AsyncDoc</returns>
        public ApiResponse< AsyncDoc > CreateAsyncDocWithHttpInfo (Doc doc)
        {
            
            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling ClientApi->CreateAsyncDoc");
            
    
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of AsyncDoc</returns>
        public async System.Threading.Tasks.Task<AsyncDoc> CreateAsyncDocAsync (Doc doc)
        {
             ApiResponse<AsyncDoc> response = await CreateAsyncDocAsyncWithHttpInfo(doc);
             return response.Data;

        }

        /// <summary>
        ///  Creates a document asynchronously.\nYou must use a callback url or the the returned status id and the status api to find out when it completes. Then use the download api to get the document.
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
        /// <returns>Stream</returns>
        public Stream CreateDoc (Doc doc)
        {
             ApiResponse<Stream> response = CreateDocWithHttpInfo(doc);
             return response.Data;
        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param> 
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > CreateDocWithHttpInfo (Doc doc)
        {
            
            // verify the required parameter 'doc' is set
            if (doc == null)
                throw new ApiException(400, "Missing required parameter 'doc' when calling ClientApi->CreateDoc");
            
    
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> CreateDocAsync (Doc doc)
        {
             ApiResponse<Stream> response = await CreateDocAsyncWithHttpInfo(doc);
             return response.Data;

        }

        /// <summary>
        ///  Creates a document synchronously.
        /// </summary>
        /// <param name="doc">The document to be created.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> CreateDocAsyncWithHttpInfo (Doc doc)
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
        
        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param> 
        /// <returns>Stream</returns>
        public Stream GetAsyncDoc (string id)
        {
             ApiResponse<Stream> response = GetAsyncDocWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param> 
        /// <returns>ApiResponse of Stream</returns>
        public ApiResponse< Stream > GetAsyncDocWithHttpInfo (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ClientApi->GetAsyncDoc");
            
    
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
    
            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
        }
    
        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of Stream</returns>
        public async System.Threading.Tasks.Task<Stream> GetAsyncDocAsync (string id)
        {
             ApiResponse<Stream> response = await GetAsyncDocAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Downloads a document.
        /// </summary>
        /// <param name="id">The download_id returned from status request or a callback.</param>
        /// <returns>Task of ApiResponse (Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Stream>> GetAsyncDocAsyncWithHttpInfo (string id)
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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

            return new ApiResponse<Stream>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Stream) Configuration.ApiClient.Deserialize(response, typeof(Stream)));
            
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
                throw new ApiException(400, "Missing required parameter 'id' when calling ClientApi->GetAsyncDocStatus");
            
    
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
                headerParams["Authorization"] = "Basic " + Base64Encode(Configuration.Username + ":" + Configuration.Password);
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
