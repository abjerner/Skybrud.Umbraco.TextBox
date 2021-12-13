using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents a textarea property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Textarea", EditorView, Group = "Skybrud", Icon = EditorIcon)]
    public class TextAreaDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.TextArea";

        internal const string EditorIcon = "icon-autofill color-skybrud";

        internal const string EditorView = "/App_Plugins/Skybrud.TextBox/Views/TextArea.html";
        
        private readonly IIOHelper _ioHelper;
        private readonly TextBoxHelper _helper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAreaDataEditor"/> class.
        /// </summary>
        public TextAreaDataEditor(IDataValueEditorFactory dataValueEditorFactory, IIOHelper ioHelper, TextBoxHelper helper) : base(dataValueEditorFactory) {
            _ioHelper = ioHelper;
            _helper = helper;
        }

        /// <inheritdoc/>
        protected override IDataValueEditor CreateValueEditor() {
            TextOnlyValueEditor valueEditor = DataValueEditorFactory.Create<TextOnlyValueEditor>(Attribute);
            if (valueEditor.View.IndexOf('?') < 0) valueEditor.View += $"?umb__rnd={_helper.GetCacheBuster()}";
            return valueEditor;
        }
        
        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TextAreaConfigurationEditor(_ioHelper);

    }

}