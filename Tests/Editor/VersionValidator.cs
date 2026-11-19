using Chartboost.Editor;
using Chartboost.Mediation.IronSource;
using NUnit.Framework;

namespace Chartboost.Mediation.IronSource.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.ironsource";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.IronSource";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, IronSourceAdapter.AdapterUnityVersion);
    }
}
