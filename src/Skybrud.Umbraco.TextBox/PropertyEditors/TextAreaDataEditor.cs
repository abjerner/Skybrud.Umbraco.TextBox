using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents a textarea property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Textarea", EditorView, Group = "Skybrud")]
    public class TextAreaDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.TextArea";

        internal const string EditorView = "/App_Plugins/Skybrud.TextBox/Views/TextArea.html";
        
        private readonly IIOHelper _ioHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAreaDataEditor"/> class.
        /// </summary>
        public TextAreaDataEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
        }

        /// <inheritdoc/>
        protected override IDataValueEditor CreateValueEditor() => DataValueEditorFactory.Create<TextOnlyValueEditor>(Attribute);

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TextAreaConfigurationEditor(_ioHelper);

    }

}