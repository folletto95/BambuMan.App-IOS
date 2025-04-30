namespace BambuMan.Shared.Nfc
{
	/// <summary>
	/// Interface for ITagInfo
	/// </summary>
	public interface ITagInfo
	{
		/// <summary>
		/// Tag Raw Identifier
		/// </summary>
		byte[] Identifier { get; }

		/// <summary>
		/// Tag Serial Number
		/// </summary>
		string? SerialNumber { get; }
		
		/// <summary>
		/// Writable tag
		/// </summary>
		bool IsWritable { get; set; }

		/// <summary>
		/// Empty tag
		/// </summary>
		bool IsEmpty { get; }

		/// <summary>
		/// Supported tag
		/// </summary>
		bool IsSupported { get; }

		/// <summary>
		/// Capacity of tag in bytes
		/// </summary>
		int Capacity { get; set; }

		/// <summary>
		/// Array of <see cref="NfcNdefRecord"/> of tag
		/// </summary>
        public NfcNdefRecord?[]? Records { get; set; }
	}
}
