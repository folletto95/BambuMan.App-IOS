namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA-CF")]
    public class PlaCfTest : BaseTest
    {
        [Fact(DisplayName = "Jeans Blue")]
        public async Task JeansBlue()
        {
            var json = "{\"SerialNumber\":\"40AD215F\",\"TagManufacturerData\":\"kwgEAAPrlfTEai6Q\",\"MaterialVariantIdentifier\":\"A50-B9\",\"UniqueMaterialIdentifier\":\"FA50\",\"FilamentType\":\"PLA-CF\",\"DetailedFilamentType\":\"PLA-CF\",\"Color\":\"6E88BCFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":45,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":200,\"XCamInfo\":\"0AfQB4QD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2651585B582F4AF09061714A5AC2E342\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2023-06-12T16:23:00\",\"ProductionDateTimeShort\":\"202306012\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A50-B9-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Jeans Blue", external?.Name);
            Assert.Equal("PLA-CF", external?.Material);
        }
    }
}
