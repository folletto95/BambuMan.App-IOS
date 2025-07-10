namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Basic Gradient")]
    public class PlaBasicGradientTest : BaseTest
    {
        [Fact(DisplayName = "Arctic Whisper")]
        public async Task ArcticWhisper()
        {
            var json = "{\"SerialNumber\":\"4A5EAD3B\",\"TagManufacturerData\":\"gggEAAStJvpSS1SQ\",\"MaterialVariantIdentifier\":\"A00-M0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"9CDBD9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"FEE8B504E67B4147A855166BE75D9E6C\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-04-02T15:21:00\",\"ProductionDateTimeShort\":\"24_04_02_15\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"FFFFFFFF\"}";

            var (_, external) = await GetExternalFilament(json);
        
            Assert.Equal("Arctic Whisper", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Pink Citrus")]
        public async Task PinkCitrus()
        {
            var json = "{\"SerialNumber\":\"2B4FDAFE\",\"TagManufacturerData\":\"QAgEAARzYEuxuGmQ\",\"MaterialVariantIdentifier\":\"A00-M3\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"F78F77FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"7D264B87C0B0414FB3D5AC5D8DEEE203\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-01T13:14:00\",\"ProductionDateTimeShort\":\"25_03_01_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"4E05A5FF\",\"SkuStart\":\"A00-M3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Pink Citrus", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
