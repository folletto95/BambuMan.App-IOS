namespace BambuMan.Shared.Test.Filaments.Abs
{
    [Trait("Category", "ABS-GF")]
    public class AbsGfTest : BaseTest
    {
        [Fact(DisplayName = "Orange")]
        public async Task Orange()
        {
            var json = "{\"SerialNumber\":\"5182D803\",\"TagManufacturerData\":\"CAgEAATwDiyexcmY\",\"MaterialVariantIdentifier\":\"B50-A0\",\"UniqueMaterialIdentifier\":\"FB50\",\"FilamentType\":\"ABS-GF\",\"DetailedFilamentType\":\"ABS-GF\",\"Color\":\"F48438FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"gD6APoQD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1EF5B06CA60046538D3C9522944DA56B\",\"SpoolWidth\":3717,\"ProductionDateTime\":\"2024-06-11T18:31:00\",\"ProductionDateTimeShort\":\"24_06_11_18\",\"FilamentLength\":385,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B50-A0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Orange", external?.Name);
            Assert.Equal("ABS-GF", external?.Material);
        }
    }
}
