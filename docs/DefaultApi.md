# lodgea-csharp.com.lodgea.controllers.DefaultApi

All URIs are relative to *https://api.eu.lodgea.io/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AvailabilitySearchPost**](DefaultApi.md#availabilitysearchpost) | **POST** /availability/search | Search for availability
[**LocationSearchPost**](DefaultApi.md#locationsearchpost) | **POST** /location/search | Search for location
[**PropertiesGet**](DefaultApi.md#propertiesget) | **GET** /properties | List (filtered) properties
[**PropertiesPropertyIdAvailabilityGet**](DefaultApi.md#propertiespropertyidavailabilityget) | **GET** /properties/{propertyId}/availability | Get a properties availability
[**PropertiesPropertyIdGet**](DefaultApi.md#propertiespropertyidget) | **GET** /properties/{propertyId} | Get a properties details



## AvailabilitySearchPost

> AvailabilitySearchPost200Response AvailabilitySearchPost (AvailabilitySearchPostRequest availabilitySearchPostRequest = null)

Search for availability

Get availability information based on search criteria.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class AvailabilitySearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var availabilitySearchPostRequest = new AvailabilitySearchPostRequest(); // AvailabilitySearchPostRequest |  (optional) 

            try
            {
                // Search for availability
                AvailabilitySearchPost200Response result = apiInstance.AvailabilitySearchPost(availabilitySearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AvailabilitySearchPost: " + e.Message );
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
 **availabilitySearchPostRequest** | [**AvailabilitySearchPostRequest**](AvailabilitySearchPostRequest.md)|  | [optional] 

### Return type

[**AvailabilitySearchPost200Response**](AvailabilitySearchPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful, a list of available properties matching the given criteria is returned. |  -  |
| **400** | We validate all calls to our API in a strict manner using Zod. In case of any validation errors, we send back a 400 response with a list of all validation errors. For more info see https://github.com/colinhacks/zod/blob/master/ERROR_HANDLING.md. |  -  |
| **403** | Unauthorized, the api key in the \&quot;apiKey\&quot; header field is invalid. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## LocationSearchPost

> LocationSearchPost200Response LocationSearchPost (LocationSearchPostRequest locationSearchPostRequest = null)

Search for location

Get a list of locations and their lowest available rate related to a given keyword.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class LocationSearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var locationSearchPostRequest = new LocationSearchPostRequest(); // LocationSearchPostRequest |  (optional) 

            try
            {
                // Search for location
                LocationSearchPost200Response result = apiInstance.LocationSearchPost(locationSearchPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.LocationSearchPost: " + e.Message );
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
 **locationSearchPostRequest** | [**LocationSearchPostRequest**](LocationSearchPostRequest.md)|  | [optional] 

### Return type

[**LocationSearchPost200Response**](LocationSearchPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful, a list of locations matching the given location search text is returned. |  -  |
| **400** | We validate all calls to our API in a strict manner using Zod. In case of any validation errors, we send back a 400 response with a list of all validation errors. For more info see https://github.com/colinhacks/zod/blob/master/ERROR_HANDLING.md. |  -  |
| **403** | Unauthorized, the api key in the \&quot;apiKey\&quot; header field is invalid. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesGet

> PropertiesGet200Response PropertiesGet (string keyword = null, string pageToken = null)

List (filtered) properties

List properties, optionally filtered by a keyword.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class PropertiesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var keyword = Strandresidenz Sylt;  // string |  (optional) 
            var pageToken = eyJ0ZW5hbnRDb2RlIjoiZG1vLWRlbW8iLCJuYW1lIjoiTGFuZGhhdXMgVHJlc2tlcnNhbmQiLCJwcm9wZXJ0eUlkIjoibGFuZGhhdXMtdHJlc2tlcnNhbmQifQ==;  // string |  (optional) 

            try
            {
                // List (filtered) properties
                PropertiesGet200Response result = apiInstance.PropertiesGet(keyword, pageToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PropertiesGet: " + e.Message );
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
 **keyword** | **string**|  | [optional] 
 **pageToken** | **string**|  | [optional] 

### Return type

[**PropertiesGet200Response**](PropertiesGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful, a list of properties matching the given keyword is returned. |  -  |
| **400** | We validate all calls to our API in a strict manner using Zod. In case of any validation errors, we send back a 400 response with a list of all validation errors. For more info see https://github.com/colinhacks/zod/blob/master/ERROR_HANDLING.md. |  -  |
| **403** | Unauthorized, the api key in the \&quot;apiKey\&quot; header field is invalid. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesPropertyIdAvailabilityGet

> PropertiesPropertyIdAvailabilityGet200Response PropertiesPropertyIdAvailabilityGet (string propertyId, string currencyCode)

Get a properties availability

Get detailed availability information for a specific property.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class PropertiesPropertyIdAvailabilityGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var propertyId = strandresidenz-sylt;  // string | 
            var currencyCode = EUR;  // string | 

            try
            {
                // Get a properties availability
                PropertiesPropertyIdAvailabilityGet200Response result = apiInstance.PropertiesPropertyIdAvailabilityGet(propertyId, currencyCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PropertiesPropertyIdAvailabilityGet: " + e.Message );
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
 **propertyId** | **string**|  | 
 **currencyCode** | **string**|  | 

### Return type

[**PropertiesPropertyIdAvailabilityGet200Response**](PropertiesPropertyIdAvailabilityGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful, a list of properties matching the given keyword is returned. |  -  |
| **400** | We validate all calls to our API in a strict manner using Zod. In case of any validation errors, we send back a 400 response with a list of all validation errors. For more info see https://github.com/colinhacks/zod/blob/master/ERROR_HANDLING.md. |  -  |
| **403** | Unauthorized, the api key in the \&quot;apiKey\&quot; header field is invalid. |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## PropertiesPropertyIdGet

> PropertiesPropertyIdGet200Response PropertiesPropertyIdGet (string propertyId)

Get a properties details

Get all information about a specific property by its ID.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class PropertiesPropertyIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io/v1";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new DefaultApi(Configuration.Default);
            var propertyId = strandresidenz-sylt;  // string | 

            try
            {
                // Get a properties details
                PropertiesPropertyIdGet200Response result = apiInstance.PropertiesPropertyIdGet(propertyId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.PropertiesPropertyIdGet: " + e.Message );
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
 **propertyId** | **string**|  | 

### Return type

[**PropertiesPropertyIdGet200Response**](PropertiesPropertyIdGet200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful, property found, the whole property object is returned. |  -  |
| **400** | We validate all calls to our API in a strict manner using Zod. In case of any validation errors, we send back a 400 response with a list of all validation errors. For more info see https://github.com/colinhacks/zod/blob/master/ERROR_HANDLING.md. |  -  |
| **403** | Unauthorized, the api key in the \&quot;apiKey\&quot; header field is invalid. |  -  |
| **404** | The requested resource was not found |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

