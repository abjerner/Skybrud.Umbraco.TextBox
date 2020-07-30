using Umbraco.Core.Logging;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents a textbox property editor.
    /// </summary>
    [DataEditor(EditorAlias, EditorType.PropertyValue, "Skybrud Textbox", EditorView, Group = "Skybrud")]
    public class TextBoxDataEditor : DataEditor {

        internal const string EditorAlias = "Skybrud.TextBox";

        internal const string EditorView = "/App_Plugins/Skybrud.TextBox/Views/TextBox.html";

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBoxDataEditor"/> class.
        /// </summary>
        public TextBoxDataEditor(ILogger logger) : base(logger) { }

        /// <inheritdoc/>
        protected override IDataValueEditor CreateValueEditor() => new TextOnlyValueEditor(Attribute);

        /// <inheritdoc/>
        protected override IConfigurationEditor CreateConfigurationEditor() => new TextBoxConfigurationEditor();

    }

}