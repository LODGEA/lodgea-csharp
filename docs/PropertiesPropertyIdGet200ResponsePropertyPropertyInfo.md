
# lodgea-csharp.com.lodgea.model.PropertiesPropertyIdGet200ResponsePropertyPropertyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnitCount** | **decimal** | The amount of units the property has. | [optional] 
**MessageList** | [**List&lt;PropertiesPropertyIdGet200ResponsePropertyPropertyInfoMessageListInner&gt;**](PropertiesPropertyIdGet200ResponsePropertyPropertyInfoMessageListInner.md) | Contains a descriptive message for this property in all supported languages. | 
**CategoryList** | **List&lt;PropertiesPropertyIdGet200ResponsePropertyPropertyInfo.CategoryListEnum&gt;** | A list of code of the property class types that apply to the property. | 
**LanguageList** | **List&lt;PropertiesPropertyIdGet200ResponsePropertyPropertyInfo.LanguageListEnum&gt;** | The codes of languages the staff of this property can speak. Please note that these codes partially differ from the two character ISO language codes widely used throughout the API as they partially include country specific language code.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#languagecountry-code\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**Location** | [**AvailablePropertiesInner1GeoLocation**](AvailablePropertiesInner1GeoLocation.md) |  | [optional] 
**AcceptedPaymentList** | [**List&lt;PropertiesPropertyIdGet200ResponsePropertyPropertyInfoAcceptedPaymentListInner&gt;**](PropertiesPropertyIdGet200ResponsePropertyPropertyInfoAcceptedPaymentListInner.md) | A list of the accepted payment methods. Payment methods might subject to frequent change as payment providers come and go. You should always implement a way to handle new, unexpected payment methods.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#paymenttypes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

