#import <Foundation/Foundation.h>
#import "SWGObject.h"

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


#import "SWGTradeRecordsInfo.h"
@protocol SWGTradeRecordsInfo;
@class SWGTradeRecordsInfo;



@protocol SWGTradeRecords
@end

@interface SWGTradeRecords : SWGObject


@property(nonatomic) NSString* orderId;

@property(nonatomic) NSArray<SWGTradeRecordsInfo>* tradeList;

@end
