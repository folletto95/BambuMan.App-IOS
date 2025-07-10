namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Sparkle")]
    public class PlaSparkleTest : BaseTest
    {
        [Fact(DisplayName = "Royal Purple Sparkle")]
        public async Task RoyalPurple()
        {
            var json = "{\"SerialNumber\":\"2A83AF70\",\"TagManufacturerData\":\"dggEAARxHRA62vmQ\",\"MaterialVariantIdentifier\":\"A08-B7\",\"UniqueMaterialIdentifier\":\"FA08\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Sparkle\",\"Color\":\"483D8BFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOsDegD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"B29A4BA3CCCE45E2AC7A23B330E37569\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-04-16T07:31:00\",\"ProductionDateTimeShort\":\"24_04_16_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A08-B7-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Royal Purple Sparkle", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
