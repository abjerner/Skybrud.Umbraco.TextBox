using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace Skybrud.Umbraco.TextBox {
    
    internal class TextBoxComposer : IComposer {
        
        public void Compose(IUmbracoBuilder builder) {
            builder.Services.AddUnique<TextBoxHelper>();
        }

    }

}