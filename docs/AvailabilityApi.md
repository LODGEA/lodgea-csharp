# lodgea-csharp.Api.AvailabilityApi

All URIs are relative to *https://api.eu.lodgea.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AvailabilitySearchPost**](AvailabilityApi.md#v1availabilitysearchpost) | **POST** /v1/availability/search | Search for Availability



## V1AvailabilitySearchPost

> V1AvailabilitySearchPost200Response V1AvailabilitySearchPost (AvailabilitySearch availabilitySearch = null)

Search for Availability

Get availability information based on search criteria. The possible values for the different content parameters are listed below. All parameters are optional.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using lodgea-csharp.Api;
using lodgea-csharp.Client;
using lodgea-csharp.Model;

namespace Example
{
    public class V1AvailabilitySearchPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.eu.lodgea.io";
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new AvailabilityApi(Configuration.Default);
            var availabilitySearch = new AvailabilitySearch(); // AvailabilitySearch | Search Criteria, all parameters are optional (optional) 

            try
            {
                // Search for Availability
                V1AvailabilitySearchPost200Response result = apiInstance.V1AvailabilitySearchPost(availabilitySearch);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AvailabilityApi.V1AvailabilitySearchPost: " + e.Message );
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
 **availabilitySearch** | [**AvailabilitySearch**](AvailabilitySearch.md)| Search Criteria, all parameters are optional | [optional] 

### Return type

[**V1AvailabilitySearchPost200Response**](V1AvailabilitySearchPost200Response.md)

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

