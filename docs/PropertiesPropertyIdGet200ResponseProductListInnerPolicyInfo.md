
# lodgea-csharp.com.lodgea.model.PropertiesPropertyIdGet200ResponseProductListInnerPolicyInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CheckInTime** | **decimal** | Check-in time (unix timestamp in ms). | 
**CheckOutTime** | **decimal** | Check-out time (unix timestamp in ms). | 
**TotalGuestCount** | **decimal** | The maximum number of guests allowed. | [optional] 
**CancellationPolicyList** | [**List&lt;PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerCancellationPolicyListInner&gt;**](PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerCancellationPolicyListInner.md) | List of cancellation policies. | 
**AdvanceBookingMin** | **decimal** | The minimum number of days in advance a booking must be made | 
**AdvanceBookingMax** | **decimal** | The maximum number of days in advance a booking can be made | 
**PetsPolicy** | [**PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerPetsPolicy**](PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerPetsPolicy.md) |  | [optional] 
**PrepaymentPolicy** | **string** | The type of the prepayment policy. | [optional] 
**GuaranteePolicy** | [**PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerGuaranteePolicy**](PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerGuaranteePolicy.md) |  | [optional] 
**TaxPolicyList** | [**List&lt;PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner&gt;**](PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerTaxPolicyListInner.md) | A list of taxes and their policies. | 
**FeePolicyList** | [**List&lt;PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerFeePolicyListInner&gt;**](PropertiesPropertyIdGet200ResponsePropertyPolicyListInnerFeePolicyListInner.md) | A list of fees and their policies. | 
**Name** | **string** | The name of this policy. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

