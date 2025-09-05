import Foundation

struct SpoolManService {
    static let spoolmanURL = URL(string: "http://192.168.10.100:8080/api/spools")!

    static func sendSpool(uid: String) {
        var request = URLRequest(url: spoolmanURL)
        request.httpMethod = "POST"
        request.addValue("application/json", forHTTPHeaderField: "Content-Type")
        request.httpBody = try? JSONEncoder().encode(["uid": uid])

        URLSession.shared.dataTask(with: request) { data, _, error in
            if let error = error {
                print("Errore invio: \(error)")
                return
            }
            print("Spool inviato con successo")
        }.resume()
    }
}
