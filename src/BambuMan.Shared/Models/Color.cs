using Newtonsoft.Json;

namespace BambuMan.Shared.Models;

public class FilamentColor
{
    [JsonProperty("name")]
    public required string Name { get; set; }

    [JsonProperty("hex")]
    public required string Hex { get; set; }
}