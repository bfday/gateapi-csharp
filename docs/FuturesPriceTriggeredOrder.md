
# Io.Gate.GateApi.Model.FuturesPriceTriggeredOrder

Futures order details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Initial** | [**FuturesInitialOrder**](FuturesInitialOrder.md) |  | 
**Trigger** | [**FuturesPriceTrigger**](FuturesPriceTrigger.md) |  | 
**Id** | **long** | Auto order ID | [optional] [readonly] 
**User** | **int** | User ID | [optional] [readonly] 
**CreateTime** | **double** | Creation time | [optional] [readonly] 
**FinishTime** | **double** | Finished time | [optional] [readonly] 
**TradeId** | **long** | ID of the newly created order on condition triggered | [optional] [readonly] 
**Status** | **string** | Order status. | [optional] [readonly] 
**FinishAs** | **string** | How order is finished | [optional] [readonly] 
**Reason** | **string** | Additional remarks on how the order was finished | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
