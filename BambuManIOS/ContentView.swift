import SwiftUI

struct ContentView: View {
    @EnvironmentObject var nfcVM: NFCViewModel

    var body: some View {
        VStack(spacing: 20) {
            Text("📦 BambuMan iOS")
                .font(.title)
                .bold()

            if let tag = nfcVM.currentTag {
                Text("Tag letto: \(tag)")
                    .padding()
            } else {
                Text("Nessun tag ancora letto")
                    .foregroundColor(.gray)
            }

            Button("Scansiona Tag NFC") {
                nfcVM.beginScanning()
            }
            .buttonStyle(.borderedProminent)
        }
        .padding()
    }
}
