using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents a textbox property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Textbox", EditorView, Group = "Skybrud")]
    public class TextBoxDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.TextBox";

        internal const string EditorView = "/App_Plugins/Skybrud.TextBox/Views/TextBox.html";
        
        private readonly IIOHelper _ioHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxDataEditor"/> class.
        /// </summary>
        public TextBoxDataEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        /// <inheritdoc/>
        protected override IDataValueEditor CreateValueEditor() => DataValueEditorFactory.Create<TextOnlyValueEditor>(Attribute);

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TextBoxConfigurationEditor(_ioHelper);

    }

}