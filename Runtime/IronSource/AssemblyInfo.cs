using System.Runtime.CompilerServices;
using Chartboost.Mediation.IronSource;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.IronSourceAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.IronSourceAssemblyInfoIOS)]

namespace Chartboost.Mediation.IronSource
{
    internal class AssemblyInfo
    {
        public const string IronSourceAssemblyInfoAndroid = "Chartboost.Mediation.IronSource.Android";
        public const string IronSourceAssemblyInfoIOS = "Chartboost.Mediation.IronSource.IOS";
    }
}
