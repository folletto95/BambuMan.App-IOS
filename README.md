# <img alt="logo" src="branding/appiconv2.png" height="36" /> BambuMan 

BambuMan is a companion app for [Spoolman](https://github.com/Donkie/Spoolman). It allows you to easily import spools by reading the `Bambu Lab` filaments `NFC` tag info.

The app tries to match the tag info with the existing [SpoolmanDB](https://github.com/Donkie/SpoolmanDB) entry. When a match is found, the app creates the filament and spool. Imported spools will have the same `tray_uuid` as the `AMS` reports over `MQTT`. 

If you use [OpenSpoolMan](https://github.com/drndos/openspoolman) to track your filament usage, it will be able to automatically match the spool inserted into the `AMS`, no additional action is necessary.

## The app is available in two versions
 - iOS application (your device has to support `NFC`)
 - Windows desktop application (a `PCSC` compatible `NFC` reader like [ACR122U](https://www.acs.com.hk/en/products/3/acr122u-usb-nfc-reader/) or [ACR1252U](https://www.acs.com.hk/en/products/342/acr1252u-usb-nfc-reader-iii-nfc-forum-certified-reader/) is needed)
   <img src="https://bambuman.github.io/desktop_app.jpg" alt="desktop app screenshot" width="700" height="411" />
## Known limitations

 - You can't read filaments in foil bags! The foil blocks the NFC signal. You can still inventory them when you open the bag before use.
 - There is no 1 to 1 mapping from `NFC` to `Spoolman DB` entry. Currently, there are some hard-coded rules. Known working filaments:
	 - PLA: Basic, Matte, Wood, Silk+ and Glow
	 - PETG: HF and Transparent
	 - ABS, ABS-GF
	 - ASA, ASA-CF
	 - TPU

## How to setup

### iOS
 1. Install the app from TestFlight or compile from source.
 2. Go to settings and scan the Spoolman URL with QR code or enter it manually.
         - BambuMan supports basic authentication, URL format http[s]://username:password@host[:port]/
         - If the password contains special characters (like @ :) it must be URL encoded
 3. Go back to the main window. BambuMan will connect to Spoolman and create the necessary extra fields and default vendor.
 4. Once all three status `Settings`, `Spoolman` and `NFC` are green, you can start reading `NFC` tags.

### Windows

 1. You will need .NET Desktop Runtime 9 installed
 2. Download the released `BambuMan.exe` or compile from source
 3. Paste the Spoolman URL and click `Change Url` button
	 - BambuMan supports basic authentication, url format http[s]://username:password@host[:port]/
	 - If password contains special characters (like @ :) it must be url encoded
 4. The app connects to Spoolman and creates the necessary extra fields and default vendor.
 5. You can start reading `NFC` tags.

## Tested with

  - Spoolman v0.22.1
  - OpenSpoolMan v0.1.8

## Roadmap

 - Dynamic `NFC` tag mapping to `Spoolman DB` external filament (GitHub repo with config file)
 - Make extra fields optional
 - More intuitive UI

## Big thanks to
- [Bambu-Research-Group](https://github.com/Bambu-Research-Group) for reverse engineering the NFC tag specification
- [Plugin.NFC](https://github.com/franckbour/Plugin.NFC) for providing a plugin to use NFC in MAUI
