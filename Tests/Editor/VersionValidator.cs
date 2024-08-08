using Chartboost.Editor;
using Chartboost.Logging;
using Chartboost.Mediation.IronSource;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.ironsource";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.IronSource";
        
        [SetUp]
        public void SetUp() 
            => LogController.LoggingLevel = LogLevel.Debug;
            
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, IronSourceAdapter.AdapterUnityVersion);
    }
}
