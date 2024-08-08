using Chartboost.Mediation.IronSource.Common;

namespace Chartboost.Mediation.IronSource.Default
{
    internal class IronSourceDefault : IIronSourceAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => IronSourceAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => IronSourceAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "ironsource";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "IronSource";
    }
}
