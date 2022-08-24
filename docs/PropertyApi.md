# lodgea-csharp.com.lodgea.controllers.PropertyApi

All URIs are relative to *https://api.eu.lodgea.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1PropertyGetPost**](PropertyApi.md#v1propertygetpost) | **POST** /v1/property/get | Get Property by ID



## V1PropertyGetPost

> V1PropertyGetPost200Response V1PropertyGetPost (PropertyGet propertyGet)

Get Property by ID

Get all information about a specific property by its ID. This parameter is required.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.com.lodgea.controllers;
using lodgea-csharp.Client;
using lodgea-csharp.com.lodgea.model;

namespace Example
{
    public class V1PropertyGetPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new PropertyApi(Configuration.Default);
            var propertyGet = new PropertyGet(); // PropertyGet | Provide the property ID to get more information about it

            try
            {
                // Get Property by ID
                V1PropertyGetPost200Response result = apiInstance.V1PropertyGetPost(propertyGet);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling PropertyApi.V1PropertyGetPost: " + e.Message );
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
 **propertyGet** | [**PropertyGet**](PropertyGet.md)| Provide the property ID to get more information about it | 

### Return type

[**V1PropertyGetPost200Response**](V1PropertyGetPost200Response.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful operation |  -  |
| **400** | Bad request - missing parameter |  * apiKey -  <br>  |
| **401** | API Key is missing or invalid |  * apiKey -  <br>  |
| **403** | Forbidden |  * apiKey -  <br>  |
| **404** | Not Found |  * apiKey -  <br>  |
| **405** | Invalid input |  * apiKey -  <br>  |
| **429** | Rate Limiting |  * apiKey -  <br>  |
| **500** | Internal server error |  * apiKey -  <br>  |
| **503** | Server error |  * apiKey -  <br>  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

