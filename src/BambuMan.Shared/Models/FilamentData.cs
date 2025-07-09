using Newtonsoft.Json;

namespace BambuMan.Shared.Models
{
    public class FilamentData
    {
        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("material")]
        public required string Material { get; set; }

        [JsonProperty("density")]
        public decimal Density { get; set; }

        [JsonProperty("weights")]
        public required List<Weight> Weights { get; set; }

        [JsonProperty("diameters")]
        public required List<decimal> Diameters { get; set; }

        [JsonProperty("extruder_temp")]
        public int? ExtruderTemp { get; set; }

        [JsonProperty("bed_temp")]
        public int? BedTemp { get; set; }

        [JsonProperty("translucent")]
        public bool? Translucent { get; set; }

        [JsonProperty("colors")]
        public required List<FilamentColor> Colors { get; set; }
    }
}
