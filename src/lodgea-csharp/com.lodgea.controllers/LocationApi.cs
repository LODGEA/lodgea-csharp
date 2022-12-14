/*
 * lodgea-csharp
 *
 * LODGEA SDK for CSharp. Check out https://docs.lodgea.io for more information.
 *
 * The version of the OpenAPI document: 1.0.2
 * Contact: support@lodgea.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using RestSharp;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace lodgea-csharp.com.lodgea.controllers
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILocationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Search for Location
        /// </summary>
        /// <remarks>
        /// Get a location by search text in free from. This parameter is required.
        /// </remarks>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <returns>V1LocationSearchPost200Response</returns>
        V1LocationSearchPost200Response V1LocationSearchPost (LocationSearch locationSearch);

        /// <summary>
        /// Search for Location
        /// </summary>
        /// <remarks>
        /// Get a location by search text in free from. This parameter is required.
        /// </remarks>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <returns>ApiResponse of V1LocationSearchPost200Response</returns>
        ApiResponse<V1LocationSearchPost200Response> V1LocationSearchPostWithHttpInfo (LocationSearch locationSearch);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Search for Location
        /// </summary>
        /// <remarks>
        /// Get a location by search text in free from. This parameter is required.
        /// </remarks>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of V1LocationSearchPost200Response</returns>
        System.Threading.Tasks.Task<V1LocationSearchPost200Response> V1LocationSearchPostAsync (LocationSearch locationSearch, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Search for Location
        /// </summary>
        /// <remarks>
        /// Get a location by search text in free from. This parameter is required.
        /// </remarks>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (V1LocationSearchPost200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<V1LocationSearchPost200Response>> V1LocationSearchPostWithHttpInfoAsync (LocationSearch locationSearch, CancellationToken cancellationToken = default(CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LocationApi : ILocationApi
    {
        private lodgea-csharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LocationApi(String basePath)
        {
            this.Configuration = new lodgea-csharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = lodgea-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// </summary>
        /// <returns></returns>
        public LocationApi()
        {
            this.Configuration = lodgea-csharp.Client.Configuration.Default;

            ExceptionFactory = lodgea-csharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LocationApi(lodgea-csharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = lodgea-csharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = lodgea-csharp.Client.Configuration.DefaultExceptionFactory;
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public lodgea-csharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public lodgea-csharp.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Search for Location Get a location by search text in free from. This parameter is required.
        /// </summary>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <returns>V1LocationSearchPost200Response</returns>
        public V1LocationSearchPost200Response V1LocationSearchPost (LocationSearch locationSearch)
        {
             ApiResponse<V1LocationSearchPost200Response> localVarResponse = V1LocationSearchPostWithHttpInfo(locationSearch);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for Location Get a location by search text in free from. This parameter is required.
        /// </summary>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <returns>ApiResponse of V1LocationSearchPost200Response</returns>
        public ApiResponse<V1LocationSearchPost200Response> V1LocationSearchPostWithHttpInfo (LocationSearch locationSearch)
        {
            // verify the required parameter 'locationSearch' is set
            if (locationSearch == null)
                throw new ApiException(400, "Missing required parameter 'locationSearch' when calling LocationApi->V1LocationSearchPost");

            var localVarPath = "/v1/location/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locationSearch != null && locationSearch.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(locationSearch); // http body (model) parameter
            }
            else
            {
                localVarPostBody = locationSearch; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarHeaderParams["apiKey"] = this.Configuration.GetApiKeyWithPrefix("apiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1LocationSearchPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1LocationSearchPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (V1LocationSearchPost200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1LocationSearchPost200Response)));
        }

        /// <summary>
        /// Search for Location Get a location by search text in free from. This parameter is required.
        /// </summary>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of V1LocationSearchPost200Response</returns>
        public async System.Threading.Tasks.Task<V1LocationSearchPost200Response> V1LocationSearchPostAsync (LocationSearch locationSearch, CancellationToken cancellationToken = default(CancellationToken))
        {
             ApiResponse<V1LocationSearchPost200Response> localVarResponse = await V1LocationSearchPostWithHttpInfoAsync(locationSearch, cancellationToken);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for Location Get a location by search text in free from. This parameter is required.
        /// </summary>
        /// <exception cref="lodgea-csharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="locationSearch">Free-text search criteria</param>
        /// <param name="cancellationToken">Cancellation Token to cancel request (optional) </param>
        /// <returns>Task of ApiResponse (V1LocationSearchPost200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<V1LocationSearchPost200Response>> V1LocationSearchPostWithHttpInfoAsync (LocationSearch locationSearch, CancellationToken cancellationToken = default(CancellationToken))
        {
            // verify the required parameter 'locationSearch' is set
            if (locationSearch == null)
                throw new ApiException(400, "Missing required parameter 'locationSearch' when calling LocationApi->V1LocationSearchPost");

            var localVarPath = "/v1/location/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (locationSearch != null && locationSearch.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(locationSearch); // http body (model) parameter
            }
            else
            {
                localVarPostBody = locationSearch; // byte array
            }

            // authentication (ApiKeyAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarHeaderParams["apiKey"] = this.Configuration.GetApiKeyWithPrefix("apiKey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType, cancellationToken);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("V1LocationSearchPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<V1LocationSearchPost200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (V1LocationSearchPost200Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(V1LocationSearchPost200Response)));
        }

    }
}
