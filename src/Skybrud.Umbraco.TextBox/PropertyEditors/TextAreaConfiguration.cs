using Umbraco.Cms.Core.PropertyEditors;

namespace Skybrud.Umbraco.TextBox.PropertyEditors {

    /// <summary>
    /// Represents the configuration for the textarea value editor.
    /// </summary>
    public class TextAreaConfiguration {
        
        /// <summary>
        /// Gets or sets the maximum character count allowed in the textarea.
        /// </summary>
        [ConfigurationField("maxChars", "Maximum allowed characters", "textstringlimited", Description = "If empty - no character limit.")]
        public int? MaxChars { get; set; }
        
        /// <summary>
        /// Gets or sets the deault number of rows.
        /// </summary>
        [ConfigurationField("rows", "Number of rows", "number", Description = "If empty - 10 rows would be set as the default value.")]
        public int? Rows { get; set; }
        
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