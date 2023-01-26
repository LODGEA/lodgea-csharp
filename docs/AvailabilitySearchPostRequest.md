
# lodgea-csharp.com.lodgea.model.AvailabilitySearchPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdultCount** | **int** | The amount of adults that will stay at the property. | [optional] [default to 2]
**ChildCount** | **int** | The amount of children that will stay at the property. | [optional] 
**ChildAgeList** | **List&lt;int&gt;** | A list describing the ages of the children that will stay at the property. If &lt;code&gt;childAgeList&lt;/code&gt; is set &lt;code&gt;childCount&lt;/code&gt; has to be set as well. If &lt;code&gt;childAgeList&lt;/code&gt; and &lt;code&gt;childCount&lt;/code&gt; are set, &lt;code&gt;childCount&lt;/code&gt; must be equal to the length of &lt;code&gt;childAgeList&lt;/code&gt;. | [optional] 
**CurrencyCode** | **string** | The currency code of the currency in which the lowest price for each found location should be returned.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**LanguageCode** | **string** | The language code of the language in which the descriptive texts for each found property should be returned.&lt;p&gt;Please note that beside the general restrictions listed below only languages configured during system setup for your respective tenant are allowed.&lt;/p&gt;&lt;p&gt;See also &lt;a href&#x3D;\&quot;#isolanguage-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**UnitSystem** | **string** | The unit system to use in the result. | [optional] [default to UnitSystemEnum.Metric]
**MinLengthOfStay** | **int** | The desired minimum length of stay in nights. | [optional] 
**MaxLengthOfStay** | **int** | The desired maximum length of stay in nights. | [optional] 
**LocationName** | **string** | The name of a location the properties should be located in.If &lt;code&gt;locationType&lt;/code&gt; is set, &lt;code&gt;locationName&lt;/code&gt; has to bet set as well. | [optional] 
**LocationType** | **string** | Defines the type of&lt;code&gt;locationName&lt;/code&gt;. If &lt;code&gt;locationType&lt;/code&gt; is set, &lt;code&gt;locationName&lt;/code&gt; has to bet set as well.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#locationtypes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 
**EarliestArrival** | **string** | The earliest possible arrival date. Expects exactly the format of \&quot;YYYY-MM-DD\&quot;. | [optional] 
**LatestReturn** | **string** | The latest possible departure date. Expects exactly the format of \&quot;YYYY-MM-DD\&quot;. | [optional] 
**Sort** | **string** | The criteria to order the results by. Sort order for price is ascending, sort order for quality is always descending. Quality is an internally calculated score for the property.&#39;,           )} | [optional] 
**ServiceList** | **List&lt;decimal&gt;** | A list of service codes indicating which services and amenities the entire property should offer. The codes are AND chained.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#servicecodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 
**TypeList** | **List&lt;decimal&gt;** | A list of property class type codes specifying the desired property classes. The codes are OR chained.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#propertyclass-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 
**UnitTypeList** | **List&lt;decimal&gt;** | A list of unit and room type codes indicating which kinds of unit/room type is desired.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#unitand-room-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 
**UnitAmenityList** | **List&lt;decimal&gt;** | A list of room amenity type codes indicating which room level amenities are desired. The codes are AND chained.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#unitand-room-amenity-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 
**MealPlanList** | **List&lt;decimal&gt;** | A list of meal plan type codes indicating which kinds of meal plan type is desired.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#mealplan-type-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

