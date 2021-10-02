using System;
using System.Globalization;
using ClientDependency.Core.Config;
using Semver;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Configuration;

namespace Skybrud.Umbraco.TextBox {
    
    /// <summary>
    /// Static class with various information and constants about the package.
    /// </summary>
    public static class TextBoxPackage {

        /// <summary>
        /// Gets the alias of the package.
        /// </summary>
        public const string Alias = "Skybrud.Umbraco.TextBox";

        /// <summary>
        /// Gets the friendly name of the package.
        /// </summary>
        public const string Name = "Skybrud.Umbraco.TextBox";

        /// <summary>
        /// Gets the version of the package.
        /// </summary>
        public static readonly Version Version = typeof(TextBoxPackage).Assembly.GetName().Version;

        /// <summary>
        /// Gets the semantic version of the package.
        /// </summary>
        public static readonly SemVersion SemVersion = new SemVersion(Version.Major, Version.Minor, Version.Build);
        
        /// <summary>
        /// Returns the cache busting hash for this package.
        /// </summary>
        /// <returns></returns>
        public static string GetCacheBuster() {
            if (GlobalSettings.DebugMode) return DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture).GenerateHash();
            string version = Current.RuntimeState.SemanticVersion.ToSemanticString();
            return $"{version}.{Version}.{ClientDependencySettings.Instance.Version}".GenerateHash();
        }

    }

}