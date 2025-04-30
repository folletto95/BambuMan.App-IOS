using Android.Content.PM;
using AndroidApp = Android.App.Application;

namespace BambuMan.Utils;

public static class PackageUtils
{
    public static bool IsPackageInstalled(string? packageName)
    {
        return TryGetPackageInfo(packageName, out _);
    }

    public static bool TryGetPackageInfo(string? packageName, out PackageInfo? packageInfo)
    {
        try
        {
            packageInfo = GetPackageInfo(packageName);
            return true;
        }
        catch (PackageManager.NameNotFoundException)
        {
            packageInfo = null;
            return false;
        }
    }

    public static PackageInfo? GetPackageInfo(string? packageName)
    {
        if (string.IsNullOrEmpty(packageName)) return null;
        var packageManager = AndroidApp.Context.PackageManager;
        if (OperatingSystem.IsAndroidVersionAtLeast(33))
            return packageManager?.GetPackageInfo(packageName, PackageManager.PackageInfoFlags.Of((int)PackageInfoFlags.MetaData));
        else
            return packageManager?.GetPackageInfo(packageName, PackageInfoFlags.MetaData);
    }
}

