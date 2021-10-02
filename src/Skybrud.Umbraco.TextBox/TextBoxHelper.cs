using System;
using System.Globalization;
using Umbraco.Cms.Core.Configuration;
using Umbraco.Cms.Core.Hosting;
using Umbraco.Cms.Core.WebAssets;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.TextBox {

    /// <summary>
    /// Helper class used throughout this package.
    /// </summary>
    public class TextBoxHelper {
        
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUmbracoVersion _umbracoVersion;
        private readonly IRuntimeMinifier _runtimeMinifier;

        /// <summary>
        /// Initializes a new helper instance.
        /// </summary>
        public TextBoxHelper(IHostingEnvironment hostingEnvironment, IUmbracoVersion umbracoVersion, IRuntimeMinifier runtimeMinifier) {
            _hostingEnvironment = hostingEnvironment;
            _umbracoVersion = umbracoVersion;
            _runtimeMinifier = runtimeMinifier;
        }

        /// <summary>
        /// Returns a cache busting hash for this package.
        ///
        /// When running in debug mode, the returned hash is based on the current time, causing the hash to change for
        /// each request.
        ///
        /// In any other case, the hash is based on the version of Umbraco, the version of this package and Umbraco's
        /// internal cache busting value. This ensures that changing any of these individually will result in a new
        /// caching busting hash.
        /// </summary>
        /// <returns>The generated cache busting hash.</returns>
        public string GetCacheBuster() {
            if (_hostingEnvironment.IsDebugMode) return DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture).GenerateHash();
            string version = _umbracoVersion.SemanticVersion.ToSemanticString();
            return $"{version}.{TextBoxPackage.Version}.{_runtimeMinifier.CacheBuster}".GenerateHash();
        }

    }

}