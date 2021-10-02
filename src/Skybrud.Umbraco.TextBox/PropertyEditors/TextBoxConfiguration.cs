using Umbraco.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents the configuration for the textbox value editor.
    /// </summary>
    public class TextBoxConfiguration {
        
        /// <summary>
        /// Gets or sets the maximum character count allowed in the textbox.
        /// </summary>
        [ConfigurationField("maxChars", "Maximum allowed characters", "textstringlimited", Description = "If empty, 500 character limit.")]
        public int? MaxChars { get; set; }
        
        /// <summary>
        /// Gets or sets whether <see cref="MaxChars"/> will be encorced.
        /// </summary>
        [ConfigurationField("enforce", "Enforce limit", "boolean", Description = "Enforce the limit.")]
        public bool EnforceLimit { get; set; }
        
        /// <summary>
        /// Gets or sets the placeholder text of the textarea.
        /// </summary>
        [ConfigurationField("placeholder", "Placeholder", "textstring", Description = "A placeholder text to show when the field is empty.")]
        public string Placeholder { get; set; }
        
        /// <summary>
        /// Gets or sets the fallback text of the textarea.
        /// </summary>
        [ConfigurationField("fallback", "Fallback", "textstring", Description = "A fallback text used instead if the property is left blank.")]
        public string Fallback { get; set; }

    }

}