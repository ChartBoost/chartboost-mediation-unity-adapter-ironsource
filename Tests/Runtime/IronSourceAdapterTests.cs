using Chartboost.Mediation.IronSource;
using Chartboost.Testing;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class IronSourceAdapterTests
    {
        [Test]
        public void Identity() => AdapterContract.AssertIdentity("ironsource", "IronSource", IronSourceAdapter.AdapterUnityVersion,
            IronSourceAdapter.PartnerIdentifier, IronSourceAdapter.PartnerDisplayName, IronSourceAdapter.AdapterNativeVersion, IronSourceAdapter.PartnerSDKVersion);
    }
}
