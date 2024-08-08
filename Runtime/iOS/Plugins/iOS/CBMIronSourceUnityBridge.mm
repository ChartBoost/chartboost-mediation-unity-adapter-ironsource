#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterIronSource/ChartboostMediationAdapterIronSource-Swift.h>

extern "C" {

    const char * _CBMIronSourceAdapterAdapterVersion(){
        return toCStringOrNull([IronSourceAdapterConfiguration adapterVersion]);
    }

    const char * _CBMIronSourceAdapterPartnerSDKVersion(){
        return toCStringOrNull([IronSourceAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMIronSourceAdapterPartnerId(){
        return toCStringOrNull([IronSourceAdapterConfiguration partnerID]);
    }

    const char * _CBMIronSourceAdapterPartnerDisplayName(){
        return toCStringOrNull([IronSourceAdapterConfiguration partnerDisplayName]);
    }
}
