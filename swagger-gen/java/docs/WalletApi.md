# WalletApi

All URIs are relative to *https://api-testnet.bybit.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**walletGetRecords**](WalletApi.md#walletGetRecords) | **GET** /open-api/wallet/fund/records | Get wallet fund records
[**walletWithdraw**](WalletApi.md#walletWithdraw) | **GET** /open-api/wallet/withdraw/list | Get wallet fund records


<a name="walletGetRecords"></a>
# **walletGetRecords**
> Object walletGetRecords(startDate, endDate, currency, walletFundType, page, limit)

Get wallet fund records

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WalletApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKey
ApiKeyAuth apiKey = (ApiKeyAuth) defaultClient.getAuthentication("apiKey");
apiKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKey.setApiKeyPrefix("Token");

// Configure API key authorization: apiSignature
ApiKeyAuth apiSignature = (ApiKeyAuth) defaultClient.getAuthentication("apiSignature");
apiSignature.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiSignature.setApiKeyPrefix("Token");

// Configure API key authorization: timestamp
ApiKeyAuth timestamp = (ApiKeyAuth) defaultClient.getAuthentication("timestamp");
timestamp.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//timestamp.setApiKeyPrefix("Token");

WalletApi apiInstance = new WalletApi();
String startDate = "startDate_example"; // String | Start point for result
String endDate = "endDate_example"; // String | End point for result
String currency = "currency_example"; // String | Currency type
String walletFundType = "walletFundType_example"; // String | wallet fund type
String page = "page_example"; // String | Page. Default getting first page data
String limit = "limit_example"; // String | Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page
try {
    Object result = apiInstance.walletGetRecords(startDate, endDate, currency, walletFundType, page, limit);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WalletApi#walletGetRecords");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **String**| Start point for result | [optional]
 **endDate** | **String**| End point for result | [optional]
 **currency** | **String**| Currency type | [optional]
 **walletFundType** | **String**| wallet fund type | [optional]
 **page** | **String**| Page. Default getting first page data | [optional]
 **limit** | **String**| Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page | [optional]

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey), [apiSignature](../README.md#apiSignature), [timestamp](../README.md#timestamp)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

<a name="walletWithdraw"></a>
# **walletWithdraw**
> Object walletWithdraw(startDate, endDate, coin, status, page, limit)

Get wallet fund records

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.WalletApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKey
ApiKeyAuth apiKey = (ApiKeyAuth) defaultClient.getAuthentication("apiKey");
apiKey.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKey.setApiKeyPrefix("Token");

// Configure API key authorization: apiSignature
ApiKeyAuth apiSignature = (ApiKeyAuth) defaultClient.getAuthentication("apiSignature");
apiSignature.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiSignature.setApiKeyPrefix("Token");

// Configure API key authorization: timestamp
ApiKeyAuth timestamp = (ApiKeyAuth) defaultClient.getAuthentication("timestamp");
timestamp.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//timestamp.setApiKeyPrefix("Token");

WalletApi apiInstance = new WalletApi();
String startDate = "startDate_example"; // String | Start point for result
String endDate = "endDate_example"; // String | End point for result
String coin = "coin_example"; // String | Currency
String status = "status_example"; // String | Withdraw status
String page = "page_example"; // String | Page. Default getting first page data
String limit = "limit_example"; // String | Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page
try {
    Object result = apiInstance.walletWithdraw(startDate, endDate, coin, status, page, limit);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling WalletApi#walletWithdraw");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **startDate** | **String**| Start point for result | [optional]
 **endDate** | **String**| End point for result | [optional]
 **coin** | **String**| Currency | [optional]
 **status** | **String**| Withdraw status | [optional]
 **page** | **String**| Page. Default getting first page data | [optional]
 **limit** | **String**| Limit for data size per page, max size is 50. Default as showing 20 pieces of data per page | [optional]

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey), [apiSignature](../README.md#apiSignature), [timestamp](../README.md#timestamp)

### HTTP request headers

 - **Content-Type**: application/json, application/x-www-form-urlencoded
 - **Accept**: application/json

