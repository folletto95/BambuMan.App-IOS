using Newtonsoft.Json;
using SpoolMan.Api.Model;

namespace BambuMan.Shared.Models;

public class Weight
{
    [JsonProperty("weight")]
    public int WeightValue { get; set; }

    [JsonProperty("spool_weight")]
    public int SpoolWeight { get; set; }

    [JsonProperty("spool_type")]
    public SpoolType? SpoolType { get; set; }
}