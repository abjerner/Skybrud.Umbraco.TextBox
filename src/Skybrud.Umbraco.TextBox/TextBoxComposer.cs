using Microsoft.Extensions.DependencyInjection;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Skybrud.Umbraco.TextBox {
    
    internal class TextBoxComposer : IComposer {
        
        public void Compose(IUmbracoBuilder builder) {
            builder.Services.AddSingleton<TextBoxHelper>();
        }

    }

}