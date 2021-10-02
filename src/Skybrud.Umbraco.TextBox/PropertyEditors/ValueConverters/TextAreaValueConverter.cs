using System;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Core.Services;

namespace Skybrud.Umbraco.TextBox.PropertyEditors.ValueConverters {

    internal class TextAreaValueConverter : PropertyValueConverterBase {

        private readonly ILocalizedTextService _localizedTextService;

        public TextAreaValueConverter(ILocalizedTextService localizedTextService) {
            _localizedTextService = localizedTextService;
        }

        public override bool IsConverter(IPublishedPropertyType propertyType) {
            return propertyType.EditorAlias == TextAreaDataEditor.EditorAlias;
        }

        public override object ConvertSourceToIntermediate(IPublishedElement owner, IPublishedPropertyType propertyType, object source, bool preview) {
            return source;
        }

        public override object ConvertIntermediateToObject(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {

            string value = inter as string;

            if (propertyType.DataType.Configuration is TextAreaConfiguration config && string.IsNullOrWhiteSpace(value)) {
                return string.IsNullOrWhiteSpace(config.Fallback) ? string.Empty : _localizedTextService.UmbracoDictionaryTranslate(config.Fallback);
            }

            return inter ?? string.Empty;

        }

        public override object ConvertIntermediateToXPath(IPublishedElement owner, IPublishedPropertyType propertyType, PropertyCacheLevel referenceCacheLevel, object inter, bool preview) {
            return null;
        }

        public override Type GetPropertyValueType(IPublishedPropertyType propertyType) {
            return typeof(string);
        }

    }

}