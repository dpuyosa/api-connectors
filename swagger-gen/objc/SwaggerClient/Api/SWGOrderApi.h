#import <Foundation/Foundation.h>
#import "SWGApi.h"

/**
* Bybit API
* ## REST API for the Bybit Exchange. 
*
* OpenAPI spec version: 1.0.0
* Contact: support@bybit.com
*
* NOTE: This class is auto generated by the swagger code generator program.
* https://github.com/swagger-api/swagger-codegen.git
* Do not edit the class manually.
*/



@interface SWGOrderApi: NSObject <SWGApi>

extern NSString* kSWGOrderApiErrorDomain;
extern NSInteger kSWGOrderApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// Get my active order list.
/// 
///
/// @param orderId Order ID
/// @param symbol Contract type. (optional)
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) orderCancelWithOrderId: (NSString*) orderId
    symbol: (NSString*) symbol
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// Get my active order list.
/// 
///
/// @param orderId Order ID (optional)
/// @param orderLinkId Customized order ID. (optional)
/// @param symbol Contract type. Default BTCUSD (optional)
/// @param order Sort orders by creation date (optional)
/// @param page Page. Default getting first page data (optional)
/// @param limit TLimit for data size per page, max size is 50. Default as showing 20 pieces of data per page (optional)
/// @param orderStatus Query your orders for all statuses if &#39;order_status&#39; is empty. If you want to query orders with specific statuses , you can pass the order_status split by (optional)
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) orderGetOrdersWithOrderId: (NSString*) orderId
    orderLinkId: (NSString*) orderLinkId
    symbol: (NSString*) symbol
    order: (NSString*) order
    page: (NSNumber*) page
    limit: (NSNumber*) limit
    orderStatus: (NSString*) orderStatus
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;


/// Place active order
/// 
///
/// @param side Side
/// @param symbol Contract type.
/// @param orderType Active order type
/// @param qty 
/// @param price Order price.
/// @param timeInForce Time in force
/// @param takeProfit take profit price (optional)
/// @param stopLoss stop loss price (optional)
/// @param reduceOnly reduce only (optional)
/// @param closeOnTrigger close on trigger (optional)
/// @param orderLinkId TCustomized order ID, maximum length at 36 characters, and order ID under the same agency has to be unique. (optional)
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) orderNewWithSide: (NSString*) side
    symbol: (NSString*) symbol
    orderType: (NSString*) orderType
    qty: (NSNumber*) qty
    price: (NSNumber*) price
    timeInForce: (NSString*) timeInForce
    takeProfit: (NSNumber*) takeProfit
    stopLoss: (NSNumber*) stopLoss
    reduceOnly: (NSNumber*) reduceOnly
    closeOnTrigger: (NSNumber*) closeOnTrigger
    orderLinkId: (NSString*) orderLinkId
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;



@end
