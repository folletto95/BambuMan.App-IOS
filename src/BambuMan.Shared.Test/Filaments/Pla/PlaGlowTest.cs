namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Glow")]
    public class PlaGlowTest : BaseTest
    {
        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"2A5276F0\",\"TagManufacturerData\":\"/ggEAASoSiaPC5iQ\",\"MaterialVariantIdentifier\":\"A12-B0\",\"UniqueMaterialIdentifier\":\"FA12\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Glow\",\"Color\":\"7AC0E9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"rA2IE4QD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2FBD61A5AA204F7F8E07BDC0905D36A8\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-04T06:47:00\",\"ProductionDateTimeShort\":\"A2408030121\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A12-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Glow Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Green")]
        public async Task Green()
        {
            var json = "{\"SerialNumber\":\"2AEF3374\",\"TagManufacturerData\":\"gggEAATDgwyknveQ\",\"MaterialVariantIdentifier\":\"A12-G0\",\"UniqueMaterialIdentifier\":\"FA12\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Glow\",\"Color\":\"A1FFACFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOIE4QD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"ECBCD93336714E16A1DA9236E1E0316B\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-09T12:54:00\",\"ProductionDateTimeShort\":\"A2408080271\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A12-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Glow Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
