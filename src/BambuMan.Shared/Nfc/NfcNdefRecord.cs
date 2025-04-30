namespace BambuMan.Shared.Nfc;

/// <summary>
/// Class describing the information containing within a NFC tag
/// </summary>
public class NfcNdefRecord
{
    /// <summary>
    /// NDEF Type
    /// </summary>
    public NfcNdefTypeFormat TypeFormat { get; set; }

    /// <summary>
    /// MimeType used for <see cref="NfcNdefTypeFormat.Mime"/> type
    /// </summary>
    public string MimeType { get; set; } = "text/plain";

    /// <summary>
    /// External domain used for <see cref="NfcNdefTypeFormat.External"/> type
    /// </summary>
    public string? ExternalDomain { get; set; }

    /// <summary>
    /// External type used for <see cref="NfcNdefTypeFormat.External"/> type
    /// </summary>
    public string? ExternalType { get; set; }

    /// <summary>
    /// Payload
    /// </summary>
    public byte[]? Payload { get; set; }

    /// <summary>
    /// Uri
    /// </summary>
    public string? Uri { get; set; }

    /// <summary>
    /// String formatted payload
    /// </summary>
    public string Message => NfcUtils.GetMessage(TypeFormat, Payload, Uri);

    /// <summary>
    /// Two letters ISO 639-1 Language Code (ex: en, fr, de...)
    /// </summary>
    public string? LanguageCode { get; set; }
}