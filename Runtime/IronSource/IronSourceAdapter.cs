using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.IronSource.Common;
using Chartboost.Mediation.IronSource.Default;

namespace Chartboost.Mediation.IronSource
{
    /// <inheritdoc cref="IIronSourceAdapter"/>
    public static class IronSourceAdapter 
    {
        internal static IIronSourceAdapter Instance = new IronSourceDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.7";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;
    }
}
