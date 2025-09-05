# BambuMan iOS

App nativa SwiftUI per leggere tag NFC Bambu e inviare l'UID a SpoolMan tramite REST API.

## Funzionalità
- Lettura tag NFC via CoreNFC
- Invio UID a SpoolMan (`http://192.168.10.100:8080/api/spools`)
- Build automatica con GitHub Actions
- IPA scaricabile dagli artifacts per sideloading

## Build
Il workflow GitHub Actions **ios-build** compila l'app in modalità release su runner macOS e produce un file `.ipa` non firmato negli artifacts.

## Installazione
Scarica l'IPA dagli artifacts del workflow e installalo su iPhone tramite AltStore o Sideloadly.
