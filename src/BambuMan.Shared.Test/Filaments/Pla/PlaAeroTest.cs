namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Aero")]
    public class PlaAeroTest : BaseTest
    {
        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"F0242A2E\",\"TagManufacturerData\":\"0AgEAANY2cOxsh+Q\",\"MaterialVariantIdentifier\":\"A11-K0\",\"UniqueMaterialIdentifier\":\"FA11\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Aero\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"0AfQB4QDhAMzM3M/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"182BEEFF9B1B481B9EE6C9D0C33EA6B8\",\"SpoolWidth\":8523,\"ProductionDateTime\":\"2023-06-17T04:57:00\",\"ProductionDateTimeShort\":\"A\",\"FilamentLength\":340,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A11-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("White Aero", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
