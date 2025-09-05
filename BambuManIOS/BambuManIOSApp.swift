import SwiftUI

@main
struct BambuManIOSApp: App {
    @StateObject private var nfcVM = NFCViewModel()

    var body: some Scene {
        WindowGroup {
            ContentView()
                .environmentObject(nfcVM)
        }
    }
}
