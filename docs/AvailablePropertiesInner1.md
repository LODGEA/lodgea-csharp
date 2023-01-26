
# lodgea-csharp.com.lodgea.model.AvailablePropertiesInner1

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The properties unique code/ID. | 
**LanguageCode** | **string** | The language code of the language in which the property description is written.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**CurrencyCode** | **string** | The currency code for the currency in which prices are returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**UnitSystem** | **string** | The unit system (either \&quot;metric\&quot; or \&quot;imperial\&quot;) used for measurements. | 
**Name** | **string** | The name of the property. | 
**Uri** | **string** | A URI for the property. | 
**ServiceList** | **List&lt;decimal&gt;** | A list of service codes indicating the services and amenities the property has.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#servicecodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**CategoryList** | **List&lt;decimal&gt;** | A list of property class type codes indicating the types of the property.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#propertyclass-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**UriPath** | **string** | A URI path for the property. | 
**Text** | **string** | A description of the property. | 
**Geo** | [**AvailablePropertiesInner1Geo**](AvailablePropertiesInner1Geo.md) |  | [optional] 
**MediaList** | [**List&lt;AvailablePropertiesInner1MediaListInner&gt;**](AvailablePropertiesInner1MediaListInner.md) | A list of media objects for the property. | 
**AttractionList** | [**List&lt;AvailablePropertiesInner1AttractionListInner&gt;**](AvailablePropertiesInner1AttractionListInner.md) | A list of objects describing the attractions available at the property. | 
**LowestPrice** | [**AvailablePropertiesInner1LowestPrice**](AvailablePropertiesInner1LowestPrice.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

