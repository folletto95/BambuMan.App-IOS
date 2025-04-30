namespace BambuMan.Shared.Nfc
{
    /// <summary>
    /// Default implementation of <see cref="ITagInfo"/>
    /// </summary>
    public class TagInfo : ITagInfo
    {
        public byte[] Identifier { get; } = [];

        /// <summary>
        /// Tag Serial Number
        /// </summary>
        public string? SerialNumber { get; }

        /// <summary>
        /// Writable tag
        /// </summary>
        public bool IsWritable { get; set; } = false;

        /// <summary>
        /// Capacity of tag in bytes
        /// </summary>
        public int Capacity { get; set; }

        /// <summary>
        /// Array of <see cref="NfcNdefRecord"/> of tag
        /// </summary>
        public NfcNdefRecord?[]? Records { get; set; }

        /// <summary>
        /// Empty tag
        /// </summary>
        public bool IsEmpty => Records == null || Records.Length == 0 || Records[0] == null || (Records != null && Records[0]?.TypeFormat == NfcNdefTypeFormat.Empty);

        /// <summary>
        /// 
        /// </summary>
        public bool IsSupported { get; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public TagInfo()
        {
            IsSupported = true;
        }

        /// <summary>
        /// Custom contractor
        /// </summary>
        /// <param name="identifier">Tag Identifier</param>
        /// <param name="isNdef">Is Ndef tag</param>
        public TagInfo(byte[] identifier, bool isNdef = true)
        {
            Identifier = identifier;
            SerialNumber = NfcUtils.ByteArrayToHexString(identifier);
            IsSupported = isNdef;
        }

        public override string ToString() => $"TagInfo: identifier: {Identifier}, SerialNumber:{SerialNumber}, Capacity:{Capacity} bytes, IsSupported:{IsSupported}, IsEmpty:{IsEmpty}, IsWritable:{IsWritable}";
    }
}
