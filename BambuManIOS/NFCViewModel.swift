import CoreNFC
import Combine
import Foundation

class NFCViewModel: NSObject, ObservableObject, NFCTagReaderSessionDelegate {
    @Published var currentTag: String?
    private var session: NFCTagReaderSession?

    func beginScanning() {
        session = NFCTagReaderSession(
            pollingOption: [.iso14443, .iso15693, .iso18092],
            delegate: self,
            queue: nil
        )
        session?.alertMessage = "Avvicina un tag Bambu"
        session?.begin()
    }

    func tagReaderSessionDidBecomeActive(_ session: NFCTagReaderSession) {}

    func tagReaderSession(_ session: NFCTagReaderSession, didInvalidateWithError error: Error) {
        DispatchQueue.main.async { self.currentTag = "Errore: \(error.localizedDescription)" }
    }

    func tagReaderSession(_ session: NFCTagReaderSession, didDetect tags: [NFCTag]) {
        guard let first = tags.first else { return }
        session.connect(to: first) { err in
            if let err = err {
                DispatchQueue.main.async { self.currentTag = "Errore connessione: \(err.localizedDescription)" }
                session.invalidate()
                return
            }
            switch first {
            case .miFare(let tag):
                DispatchQueue.main.async { self.currentTag = tag.identifier.map { String(format:"%02x",$0) }.joined() }
            default:
                DispatchQueue.main.async { self.currentTag = "Tipo tag non gestito" }
            }
            session.invalidate()
        }
    }
}
