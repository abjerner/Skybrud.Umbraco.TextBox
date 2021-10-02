using System;
using Umbraco.Cms.Core.Semver;

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
        public static readonly SemVersion SemVersion = new(Version.Major, Version.Minor, Version.Build);

    }

}