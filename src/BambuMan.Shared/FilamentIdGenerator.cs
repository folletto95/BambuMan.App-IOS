using System.Text;
using SpoolMan.Api.Model;

namespace BambuMan.Shared
{
    public static class FilamentIdGenerator
    {
        private static readonly Dictionary<SpoolType, string> SpoolTypeMap = new()
        {
            { SpoolType.Cardboard, "c" },
            { SpoolType.Plastic, "p" },
            { SpoolType.Metal, "m" }
        };
        
        /// <summary>
        /// Generates a unique ID for the given filament data.
        /// </summary>
        public static string GenerateId(string manufacturer, string name, string material, decimal weight, decimal diameter, SpoolType? spoolType = null)
        {
            // Remove any non-ASCII characters from name
            var asciiName = RemoveNonAscii(name);

            var weightString = $"{weight:F0}";
            var diameterString = $"{diameter:F2}".Replace(".", "");
            var spoolTypeString = spoolType != null ? SpoolTypeMap[spoolType.Value] : "n";

            return $"{manufacturer.ToLower()}_{material.ToLower()}_{asciiName.ToLower()}_{weightString}_{diameterString}_{spoolTypeString}".Replace(" ", "");
        }

        private static string RemoveNonAscii(string input)
        {
            var asciiBytes = Encoding.ASCII.GetBytes(input);
            return Encoding.ASCII.GetString(asciiBytes);
        }
    }
}
