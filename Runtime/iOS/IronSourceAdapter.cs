using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.IronSource.Common;
using UnityEngine;

namespace Chartboost.Mediation.IronSource.IOS
{
    internal sealed class IronSourceAdapter : IIronSourceAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            IronSource.IronSourceAdapter.Instance = new IronSourceAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMIronSourceAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMIronSourceAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMIronSourceAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMIronSourceAdapterPartnerDisplayName();
        
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMIronSourceAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMIronSourceAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMIronSourceAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMIronSourceAdapterPartnerDisplayName();
    }
}
