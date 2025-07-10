using Newtonsoft.Json;

namespace BambuMan.Shared.Models
{
    public class FilamentData
    {
        [JsonProperty("id")]
        public required string Id { get; set; }

        [JsonProperty("manufacturer")]
        public required string Manufacturer { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("material")]
        public required string Material { get; set; }

        [JsonProperty("density")]
        public decimal Density { get; set; }
        
        [JsonProperty("weight")]
        public int WeightValue { get; set; }

        [JsonProperty("spool_weight")]
        public int SpoolWeight { get; set; }

        [JsonProperty("spool_type")]
        public string? SpoolType { get; set; }
        
        [JsonProperty("diameter")]
        public required decimal Diameter { get; set; }

        [JsonProperty("color_hex")]
        public required string ColorHex { get; set; }

        [JsonProperty("color_hexes")]
        public string[]? ColorHexes { get; set; }

        [JsonProperty("extruder_temp")]
        public int? ExtruderTemp { get; set; }

        [JsonProperty("extruder_temp_range")]
        public int[]? ExtruderTempRange { get; set; }

        [JsonProperty("bed_temp")]
        public int? BedTemp { get; set; }

        [JsonProperty("bed_temp_range")]
        public int[]? BedTempRange { get; set; }

        [JsonProperty("finish")]
        public string? Finish { get; set; }
        
        [JsonProperty("multi_color_direction")]
        public string? MultiColorDirection { get; set; }
        
        [JsonProperty("pattern")]
        public string? Pattern { get; set; }

        [JsonProperty("translucent")]
        public required bool Translucent { get; set; }

        [JsonProperty("glow")]
        public required bool Glow { get; set; }
    }
}
