
# lodgea-csharp.com.lodgea.model.PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TypeCode** | **decimal** | The code that represents the type of tax.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#taxtype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**Percent** | **decimal** | The charged percentage if applicable. | [optional] 
**ChargeType** | **string** | The type of charge. | 
**ChargeFrequencyCode** | **decimal** | The code that represents the frequency of charge.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#chargetype-codes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**CurrencyCode** | **string** | The currency code of the currency in that the charge is applied.&lt;p&gt;See also &lt;a href&#x3D;\&quot;#currencycodes\&quot;&gt;in the appendix&lt;/a&gt;.&lt;/p&gt; | 
**ConditionList** | **List&lt;PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner.ConditionListEnum&gt;** | A list of conditions for the tax. Is empty if &lt;code&gt;chargeType&lt;/code&gt; is not &lt;code&gt;conditional&lt;/code&gt;. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

