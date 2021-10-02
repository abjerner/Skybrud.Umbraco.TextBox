using System;
using System.Globalization;
using Umbraco.Cms.Core.Configuration;
using Umbraco.Cms.Core.Hosting;
using Umbraco.Cms.Core.WebAssets;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.TextBox {
    
    public class TextBoxHelper {
        
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IUmbracoVersion _umbracoVersion;
        private readonly IRuntimeMinifier _runtimeMinifier;

        public TextBoxHelper(IHostingEnvironment hostingEnvironment, IUmbracoVersion umbracoVersion, IRuntimeMinifier runtimeMinifier) {
            _hostingEnvironment = hostingEnvironment;
            _umbracoVersion = umbracoVersion;
            _runtimeMinifier = runtimeMinifier;
        }

        public string GetCacheBuster() {
            if (_hostingEnvironment.IsDebugMode) return DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture).GenerateHash();
            string version = _umbracoVersion.SemanticVersion.ToSemanticString();
            return $"{version}.{TextBoxPackage.Version}.{_runtimeMinifier.CacheBuster}".GenerateHash();
        }

    }

}