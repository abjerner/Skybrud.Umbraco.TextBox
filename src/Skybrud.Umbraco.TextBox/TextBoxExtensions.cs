using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Dictionary;
using Umbraco.Core.Services;

namespace Skybrud.Umbraco.TextBox {

    internal static class TextBoxExtensions {

        private static ICultureDictionary _cultureDictionary;

        private static ICultureDictionary CultureDictionary => _cultureDictionary ?? (_cultureDictionary = Current.CultureDictionaryFactory.CreateDictionary());

        internal static string UmbracoDictionaryTranslate(this ILocalizedTextService manager, string text) {
            // Based on: https://github.com/umbraco/Umbraco-CMS/blob/release-8.17.0/src/Umbraco.Core/Services/LocalizedTextServiceExtensions.cs#L189
            return manager.UmbracoDictionaryTranslate(text, CultureDictionary);
        }

        private static string UmbracoDictionaryTranslate(this ILocalizedTextService manager, string text, ICultureDictionary cultureDictionary) {

            // Based on: https://github.com/umbraco/Umbraco-CMS/blob/release-8.17.0/src/Umbraco.Core/Services/LocalizedTextServiceExtensions.cs#L195

            if (text == null) return null;

            if (text.StartsWith("#") == false) return text;

            text = text.Substring(1);
            string value = cultureDictionary[text];
            if (value.IsNullOrWhiteSpace() == false) return value;

            value = manager.Localize(text.Replace('_', '/'));
            return value.StartsWith("[") ? text : value;

        }

    }

}