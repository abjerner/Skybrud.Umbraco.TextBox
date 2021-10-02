using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {
    
    /// <summary>
    /// Represents the configuration editor for the textarea value editor.
    /// </summary>
    public class TextAreaConfigurationEditor : ConfigurationEditor<TextAreaConfiguration> {
        
        /// <inheritdoc />
        public TextAreaConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}