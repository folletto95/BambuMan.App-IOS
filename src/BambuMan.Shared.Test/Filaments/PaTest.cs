namespace BambuMan.Shared.Test.Filaments
{
    [Trait("Category", "PA")]
    public class PaTest : BaseTest
    {
        [Trait("Category", "PAHT-CF")]
        [Fact(DisplayName = "Back")]
        public async Task PahtCfBlack()
        {
            var json = "{\"SerialNumber\": \"B71F10BA\",\"TagManufacturerData\": \"AggEAAPyh3mG90eQ\",\"MaterialVariantIdentifier\": \"N04-K0\",\"UniqueMaterialIdentifier\": \"FN04\",\"FilamentType\": \"PA-CF\",\"DetailedFilamentType\": \"PAHT-CF\",\"Color\": \"000000FF\",\"SpoolWeight\": 500,\"FilamentDiameter\": 1.75,\"DryingTemperature\": 80,\"DryingTime\": 12,\"BedTemperatureType\": 2,\"BedTemperature\": 100,\"MaxTemperatureForHotend\": 280,\"MinTemperatureForHotend\": 270,\"XCamInfo\": \"NCHsLOgD6AMzMzM/\",\"NozzleDiameter\": 0.2,\"TrayUid\": \"15D84264B4EA49B2BEE0C4405C732B8B\",\"SpoolWidth\": 666,\"ProductionDateTime\": \"2022-12-01T02:34:00\",\"ProductionDateTimeShort\": \"A221201\",\"FilamentLength\": 196,\"FormatIdentifier\": 0,\"ColorCount\": 0,\"SecondColor\": \"00000000\",\"SkuStart\": \"N04-K0-1.75-500\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("PAHT-CF", external?.Material);
        }

        [Trait("Category", "PA6-GF")]
        [Fact(DisplayName = "Back")]
        public async Task Pa6GfBlack()
        {
            var json = "{\"SerialNumber\":\"4AEAF6B4\",\"TagManufacturerData\":\"4ggEAARFjjhGRuqQ\",\"MaterialVariantIdentifier\":\"N08-K0\",\"UniqueMaterialIdentifier\":\"FN08\",\"FilamentType\":\"PA-GF\",\"DetailedFilamentType\":\"PA6-GF\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":12,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":290,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"pDgQJ7wCIAPD9Yg/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"96202CA2137D47A88C6CD5267969F627\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-06-30T00:06:00\",\"ProductionDateTimeShort\":\"20240629\",\"FilamentLength\":365,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"N08-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("PA6-GF", external?.Material);
        }
    }
}
