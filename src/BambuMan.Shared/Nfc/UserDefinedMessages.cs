namespace BambuMan.Shared.Nfc;

/// <summary>
/// User defined UI messages
/// </summary>
public class UserDefinedMessages
{
    private string nfcSessionInvalidated = "Session Invalidated";
    private string nfcSessionInvalidatedButton = "OK";
    private string nfcWritingNotSupported = "Writing NFC Tag is not supported on this device";
    private string nfcDialogAlertMessage = "Please hold your phone near a NFC tag";
    private string nfcErrorRead = "Read error. Please try again";
    private string nfcErrorEmptyTag = "Tag is empty";
    private string nfcErrorReadOnlyTag = "Tag is not writable";
    private string nfcErrorCapacityTag = "Tag's capacity is too low";
    private string nfcErrorMissingTag = "Tag is missing";
    private string nfcErrorMissingTagInfo = "No Tag Informations: nothing to write";
    private string nfcErrorNotSupportedTag = "Tag is not supported";
    private string nfcErrorNotCompliantTag = "Tag is not NDEF compliant";
    private string nfcErrorWrite = "Nothing to write";
    private string nfcSuccessRead = "Read Operation Successful";
    private string nfcSuccessWrite = "Write Operation Successful";
    private string nfcSuccessClear = "Clear Operation Successful";
    private string nfcSessionTimeout = "session timeout";

    /// <summary>
    /// Session timeout
    /// </summary>
    public string NFCSessionTimeout
    {
        get => nfcSessionTimeout;
        set
        {
            if (!string.IsNullOrWhiteSpace(value)) nfcSessionTimeout = value;
        }
    }

    /// <summary>
    /// Session invalidated
    /// </summary>
    public string NFCSessionInvalidatedButton
    {
        get => nfcSessionInvalidatedButton;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcSessionInvalidatedButton = value;
        }
    }

    /// <summary>
    /// Session invalidated
    /// </summary>
    public string NFCSessionInvalidated
    {
        get => nfcSessionInvalidated;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcSessionInvalidated = value;
        }
    }

    /// <summary>
    /// Writing feature not supported
    /// </summary>
    public string NFCWritingNotSupported
    {
        get => nfcWritingNotSupported;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcWritingNotSupported = value;
        }
    }

    /// <summary>
    /// [iOS] NFC Scan dialog alert message
    /// </summary>
    public string NFCDialogAlertMessage
    {
        get => nfcDialogAlertMessage;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcDialogAlertMessage = value;
        }
    }

    /// <summary>
    /// Read operation error
    /// </summary>
    public string NFCErrorRead
    {
        get => nfcErrorRead;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorRead = value;
        }
    }

    /// <summary>
    /// Write operation error
    /// </summary>
    public string NFCErrorWrite
    {
        get => nfcErrorWrite;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorWrite = value;
        }
    }

    /// <summary>
    /// Empty tag error
    /// </summary>
    public string NFCErrorEmptyTag
    {
        get => nfcErrorEmptyTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorEmptyTag = value;
        }
    }

    /// <summary>
    /// Read-only tag error
    /// </summary>
    public string NFCErrorReadOnlyTag
    {
        get => nfcErrorReadOnlyTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorReadOnlyTag = value;
        }
    }

    /// <summary>
    /// Tag capacity error
    /// </summary>
    public string NFCErrorCapacityTag
    {
        get => nfcErrorCapacityTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorCapacityTag = value;
        }
    }

    /// <summary>
    /// Missing tag error
    /// </summary>
    public string NFCErrorMissingTag
    {
        get => nfcErrorMissingTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorMissingTag = value;
        }
    }

    /// <summary>
    /// Missing tag info error
    /// </summary>
    public string NFCErrorMissingTagInfo
    {
        get => nfcErrorMissingTagInfo;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorMissingTagInfo = value;
        }
    }

    /// <summary>
    /// Not supported tag error
    /// </summary>
    public string NFCErrorNotSupportedTag
    {
        get => nfcErrorNotSupportedTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorNotSupportedTag = value;
        }
    }

    /// <summary>
    /// Not NDEF compliant tag error
    /// </summary>
    public string NFCErrorNotCompliantTag
    {
        get => nfcErrorNotCompliantTag;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcErrorNotCompliantTag = value;
        }
    }

    /// <summary>
    /// [iOS] Successful read operation message 
    /// </summary>
    public string NFCSuccessRead
    {
        get => nfcSuccessRead;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcSuccessRead = value;
        }
    }

    /// <summary>
    /// [iOS] Successful write operation message
    /// </summary>
    public string NFCSuccessWrite
    {
        get => nfcSuccessWrite;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcSuccessWrite = value;
        }
    }

    /// <summary>
    /// [iOS] Successful clear operation message
    /// </summary>
    public string NFCSuccessClear
    {
        get => nfcSuccessClear;
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                nfcSuccessClear = value;
        }
    }
}