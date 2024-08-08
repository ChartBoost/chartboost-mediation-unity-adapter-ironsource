# Chartboost Mediation Unity SDK - IronSource Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.ironsource/Editor/IronSourceAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.ironsource)

In order to add the Chartboost Mediation Unity SDK - IronSource Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.ironsource": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.IronSource)

To add the Chartboost Mediation Unity SDK - IronSource Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.IronSource` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.IronSource` package. Choose the appropriate version and install.

# AndroidManifest.xml Permissions & Activities

Add the following mandatory permissions to your `AndroidManifest.xml` file inside the manifest tag but outside the <application> tag:

```xml
<uses-permission android:name="android.permission.INTERNET" />
<uses-permission android:name="android.permission.ACCESS_NETWORK_STATE" />
```

Add this section inside the <application> tag in your AndroidManifest:

```xml
        <activity
            android:name="com.ironsource.sdk.controller.ControllerActivity"
            android:configChanges="orientation|screenSize"
            android:hardwareAccelerated="true" />
        <activity
            android:name="com.ironsource.sdk.controller.InterstitialActivity"
            android:configChanges="orientation|screenSize"
            android:hardwareAccelerated="true"
            android:theme="@android:style/Theme.Translucent" />
        <activity
            android:name="com.ironsource.sdk.controller.OpenUrlActivity"
            android:configChanges="orientation|screenSize"
            android:hardwareAccelerated="true"
            android:theme="@android:style/Theme.Translucent" />
        <activity
            android:name="com.ironsource.mediationsdk.testSuite.TestSuiteActivity"
            android:configChanges="orientation|screenSize"
            android:hardwareAccelerated="true"
            android:theme="@android:style/Theme.NoTitleBar" />
        <provider
            android:name="com.ironsource.lifecycle.IronsourceLifecycleProvider"
            android:authorities="${applicationId}.IronsourceLifecycleProvider" />
```

# Usage
The following code block exemplifies usage of the `IronSourceAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {IronSourceAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.8.0.0.0
Debug.Log($"Adapter Native Version: {IronSourceAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 8.0.0
Debug.Log($"Partner SDK Version: {IronSourceAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: ironsource
Debug.Log($"Partner Identifier: {IronSourceAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: IronSource
Debug.Log($"Partner Display Name: {IronSourceAdapter.PartnerDisplayName}");
```