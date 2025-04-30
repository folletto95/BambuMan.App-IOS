using System.Text;
#if __IOS__
using UIKit;
#endif

namespace BambuMan.Shared.Nfc
{
    /// <summary>
    /// NFC tools
    /// </summary>
    public static class NfcUtils
    {
        /// <summary>
        /// Returns the content size of an array of <see cref="NfcNdefRecord"/>
        /// </summary>
        /// <param name="records">array of <see cref="NfcNdefRecord"/></param>
        /// <returns>Content size</returns>
        public static int GetSize(NfcNdefRecord?[]? records)
        {
            return records is not { Length: > 0 } ? 0 : records.Where(x => x != null).Sum(x => x!.Payload!.Length);
        }

        /// <summary>
        /// Returns the string formatted payload
        /// </summary>
        /// <param name="type">type of <see cref="NfcNdefTypeFormat"/></param>
        /// <param name="payload">record payload</param>
        /// <param name="uri">record uri</param>
        /// <returns>String formatted payload</returns>
        public static string GetMessage(NfcNdefTypeFormat type, byte[]? payload, string? uri)
        {
            if (payload == null) return string.Empty;

            string message;

            if (!string.IsNullOrWhiteSpace(uri)) message = uri;
            else
            {
                if (type == NfcNdefTypeFormat.WellKnown)
                {
                    // NDEF_WELLKNOWN Text record
                    var status = payload[0];
                    var enc = status & 0x80;
                    var languageCodeLength = status & 0x3F;
                    message = enc == 0 ? Encoding.UTF8.GetString(payload, languageCodeLength + 1, payload.Length - languageCodeLength - 1) : Encoding.Unicode.GetString(payload, languageCodeLength + 1, payload.Length - languageCodeLength - 1);
                }
                else
                {
                    // Other NDEF types
                    message = Encoding.UTF8.GetString(payload, 0, payload.Length);
                }
            }
            return message;
        }

        /// <summary>
        /// Transforms a string message into an array of bytes
        /// </summary>
        /// <param name="text">text message</param>
        /// <returns>Array of bytes</returns>
        // ReSharper disable once UnusedMember.Global
        public static byte[] EncodeToByteArray(string text) => Encoding.UTF8.GetBytes(text);

        /// <summary>
        /// Returns the string formatted payload
        /// </summary>
        /// <param name="record">Object <see cref="NfcNdefRecord"/></param>
        /// <returns>String formatted payload</returns>
        public static string GetMessage(NfcNdefRecord? record)
        {
            return record == null ? string.Empty : GetMessage(record.TypeFormat, record.Payload, record.Uri);
        }

        /// <summary>
        /// Convert bytes array into hexadecimal string
        /// </summary>
        /// <param name="bytes">Bytes Array</param>
        /// <param name="separator">Separator</param>
        /// <returns>Hexadecimal string</returns>
        public static string ByteArrayToHexString(byte[]? bytes, string? separator = null)
        {
            return bytes == null ? string.Empty : string.Join(separator ?? string.Empty, bytes.Select(b => b.ToString("X2")));
        }

        /// <summary>
        /// Checks if writing tags is supported
        /// </summary>
        /// <returns>boolean</returns>
        public static bool IsWritingSupported()
        {
#if __IOS__
			var splitted = UIDevice.CurrentDevice.SystemVersion?.Split('.');
			if (splitted != null && splitted.Length > 0 && int.TryParse(splitted[0], out var majorVersion))
				return majorVersion >= 13;
			return false;
#else
            return true;
#endif
        }
    }
}
