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



@interface SWGKlineApi: NSObject <SWGApi>

extern NSString* kSWGKlineApiErrorDomain;
extern NSInteger kSWGKlineApiMissingParamErrorCode;

-(instancetype) initWithApiClient:(SWGApiClient *)apiClient NS_DESIGNATED_INITIALIZER;

/// Query historical kline.
/// 
///
/// @param symbol Contract type.
/// @param interval Kline interval.
/// @param from from timestamp.
/// @param limit Contract type. (optional)
/// 
///  code:200 message:"Request was successful"
///
/// @return NSObject*
-(NSURLSessionTask*) klineGetWithSymbol: (NSString*) symbol
    interval: (NSString*) interval
    from: (NSNumber*) from
    limit: (NSString*) limit
    completionHandler: (void (^)(NSObject* output, NSError* error)) handler;



@end
