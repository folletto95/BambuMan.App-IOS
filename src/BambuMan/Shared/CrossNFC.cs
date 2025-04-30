using BambuMan.Shared.Nfc;

namespace BambuMan;

/// <summary>
/// Cross NFC
/// </summary>
public partial class CrossNfc
{
    private static Lazy<INfc?> implementation = new(CreateNfc, LazyThreadSafetyMode.PublicationOnly);

    /// <summary>
    /// Gets if the plugin is supported on the current platform.
    /// </summary>
    public static bool IsSupported => implementation.Value != null;

    /// <summary>
    /// Legacy Mode (Supporting Mifare Classic on iOS)
    /// </summary>
    private static bool legacy;

    public static bool Legacy 
    {
        get => legacy;
        set
        {
            legacy = value;
            implementation = new Lazy<INfc?>(CreateNfc, LazyThreadSafetyMode.PublicationOnly);
        }
    }

    /// <summary>
    /// Current plugin implementation to use
    /// </summary>
    public static INfc Current
    {
        get
        {
            var ret = implementation.Value;
            return ret ?? throw NotImplementedInReferenceAssembly();
        }
    }

    private static INfc? CreateNfc()
    {
#if NETSTANDARD || !__MOBILE__
        return null;
#elif __IOS__
			ObjCRuntime.Class.ThrowOnInitFailure = false;
			if (NfcUtils.IsWritingSupported() && !Legacy)
				return new NfcImplementation();
			return new NfcImplementationBeforeIOs13();
#else
#pragma warning disable IDE0022 // Use expression body for methods
            return new NfcImplementation();
#pragma warning restore IDE0022 // Use expression body for methods
#endif
    }

    internal static Exception NotImplementedInReferenceAssembly() => new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
}