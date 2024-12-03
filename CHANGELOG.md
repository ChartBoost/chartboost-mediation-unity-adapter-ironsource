# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.4 *(2024-10-17)*
This version of the IronSource Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-ironsource:chartboost-mediation-adapter-ironsource:5.8.2.+`
  * iOS: `ChartboostMediationAdapterIronSource: ~> 5.8.4.0.0`

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - IronSource Adapter.

#Added
- Support for the following `IronSource` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-ironsource:5.8.2.+`
    * iOS: `ChartboostMediationAdapterIronSource ~> 5.8.1.0.0`
    
- `IronSourceAdapter.cs` with Configuration Properties for `IronSource`.
- The following properties have been added in `IronSourceAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`