using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents a textarea property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Textarea", EditorView, Group = "Skybrud")]
    public class TextAreaDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.TextArea";

        internal const string EditorView = "/App_Plugins/Skybrud.TextBox/Views/TextArea.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="TextAreaDataEditor"/> class.
        /// </summary>
        public TextAreaDataEditor(ILogger logger) : base(logger) { }

        /// <inheritdoc/>
        protected override IDataValueEditor CreateValueEditor() {

            var valueEditor = new TextOnlyValueEditor(Attribute);

            if (valueEditor.View.IndexOf('?') < 0) valueEditor.View += $"?umb__rnd={TextBoxPackage.GetCacheBuster()}";

            return valueEditor;

        }

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TextAreaConfigurationEditor();

    }

}