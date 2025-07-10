namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Silk")]
    public class PlaSilkTest : BaseTest
    {
        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"5A04A2FB\",\"TagManufacturerData\":\"BwgEAAQor+3n55eQ\",\"MaterialVariantIdentifier\":\"A05-B0\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"147BD1FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"NCGIE+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1F3E1F2027C54F3FB5FFD93336F4F13E\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-21T15:39:00\",\"ProductionDateTimeShort\":\"A2408210190\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A05-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Silk Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Purple")]
        public async Task Purple()
        {
            var json = "{\"SerialNumber\":\"9AA982AC\",\"TagManufacturerData\":\"HQgEAASEOXB1/rOQ\",\"MaterialVariantIdentifier\":\"A05-P5\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"854CE4FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"iBOIE4QD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"0FEF43278A104281BAC91EAEC8169B9F\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-19T20:09:00\",\"ProductionDateTimeShort\":\"A2408190267\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A05-P5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Silk Purple", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
