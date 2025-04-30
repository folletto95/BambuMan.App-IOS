namespace BambuMan.Shared.Nfc
{
	/// <summary>
	/// NFC Configuration class
	/// </summary>
	public class NfcConfiguration
    {
        /// <summary>
        /// List of user defined messages
        /// </summary>
        public UserDefinedMessages Messages { get; set; } = new();

		/// <summary>
		/// Sets ISO 639-1 Language Code for all ndef records (default is "en")
		/// </summary>
		public string? DefaultLanguageCode { get; set; }

		/// <summary>
		/// Update Nfc Configuration with a new configuration object
		/// </summary>
		/// <param name="newCfg"><see cref="NfcConfiguration"/></param>
		public void Update(NfcConfiguration? newCfg)
		{
			if (newCfg?.Messages == null) return;

			Messages = newCfg.Messages;
			DefaultLanguageCode = newCfg.DefaultLanguageCode;
		}

		/// <summary>
		/// Get the default Nfc configuration
		/// </summary>
		/// <returns>Default <see cref="NfcConfiguration"/></returns>
		public static NfcConfiguration GetDefaultConfiguration() => new() { DefaultLanguageCode = "en" };
	}
}
