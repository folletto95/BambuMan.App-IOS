# <img alt="logo" src="branding/appiconv2.png" height="36" /> BambuMan 

BambuMan is a companion app for [Spoolman](https://github.com/Donkie/Spoolman). It allows you to easily import spools by reading the Bambu Lab NFC tag.

The app tries to match the tag info with the existing [SpoolmanDB](https://github.com/Donkie/SpoolmanDB) entry. When a match is found, the app creates the filament and spool.

Imported spools will have the same `tray_uuid` as the `AMS` reports over `MQTT`. 

If you use [OpenSpoolMan](https://github.com/drndos/openspoolman) to track your filament usage, it will be able to automatically match the spool inserted into the `AMS`, no additional action is necessary.

The app is available in two versions:
 - Android applications, you will need a phone with a `NFC` reader
 - Windows desktop application, you will need a `PCSC` compatible `NFC` reader like [ACR122U](https://www.acs.com.hk/en/products/3/acr122u-usb-nfc-reader/) or [ACR1252U](https://www.acs.com.hk/en/products/342/acr1252u-usb-nfc-reader-iii-nfc-forum-certified-reader/)


## What you need

Required:
 - [Spoolman](https://github.com/Donkie/Spoolman) instance
 - Android phone with NFC

Optional:
 - [OpenSpoolMan](https://github.com/drndos/openspoolman)

## Roadmap

 - Google Play Store availability
 - 

## Big thanks to
- [Bambu-Research-Group](https://github.com/Bambu-Research-Group) for reverse engineering the NFC tag specification
- [Plugin.NFC](https://github.com/franckbour/Plugin.NFC) for providing a "easy" to use NFC implementation for MAUI
