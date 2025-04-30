using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace BambuMan.Converters
{
    [AcceptEmptyServiceProvider]
    public class NoNullToBoolConverter : BaseConverter<string?, bool>
    {
        /// <inheritdoc/>
        public override bool DefaultConvertReturnValue { get; set; } = false;

        /// <inheritdoc />
        public override string? DefaultConvertBackReturnValue { get; set; } = null;

        /// <summary>
        /// Converts a <see cref="bool"/> to its inverse value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="culture">The culture to use in the converter. This is not implemented.</param>
        /// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
        public override bool ConvertFrom(string? value, CultureInfo? culture = null) => !string.IsNullOrEmpty(value);


        /// <summary>
        /// Converts a <see cref="bool"/> to its inverse value.
        /// </summary>
        /// <param name="value">The value to convert.</param>
        /// <param name="culture">The culture to use in the converter. This is not implemented.</param>
        /// <returns>An inverted <see cref="bool"/> from the one coming in.</returns>
        public override string? ConvertBackTo(bool value, CultureInfo? culture = null) => value ? "not empty" : null;
    }
}
