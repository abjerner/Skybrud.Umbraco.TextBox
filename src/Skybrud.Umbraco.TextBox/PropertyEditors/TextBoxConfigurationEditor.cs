using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {
 
    /// <summary>
    /// Represents the configuration editor for the textbox value editor.
    /// </summary>
    public class TextBoxConfigurationEditor : ConfigurationEditor<TextBoxConfiguration> {
        
        /// <inheritdoc />
        public TextBoxConfigurationEditor(IIOHelper ioHelper) : base(ioHelper) { }

    }

}