namespace BambuMan.Shared.Test.Filaments
{
    [Trait("Category", "PC")]
    public class PcTest : BaseTest
    {
        [Fact(DisplayName = "FR White")]
        public async Task FrWhite()
        {
            var json = "{\"SerialNumber\":\"7AEDA1FD\",\"TagManufacturerData\":\"ywgEAAThczaFQziQ\",\"MaterialVariantIdentifier\":\"C01-W0\",\"UniqueMaterialIdentifier\":\"FC01\",\"FilamentType\":\"PC\",\"DetailedFilamentType\":\"PC FR\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F6D149EC530E4E82B4EFFD6C45EDC4A0\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-12-12T12:26:00\",\"ProductionDateTimeShort\":\"24_12_12_12\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"C01-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("FR White", external?.Name);
            Assert.Equal("PC", external?.Material);
        }

        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"5C9D20D0\",\"TagManufacturerData\":\"MQgEAAQ79M+gFiqQ\",\"MaterialVariantIdentifier\":\"C00-K0\",\"UniqueMaterialIdentifier\":\"FC00\",\"FilamentType\":\"PC\",\"DetailedFilamentType\":\"PC\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":2,\"BedTemperature\":110,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"gD6APgAALAEAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"3AB2EB157ACF48919A2F0DBA08431B9E\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-03-30T15:31:00\",\"ProductionDateTimeShort\":\"24_03_30_15\",\"FilamentLength\":345,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"C00-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("PC", external?.Material);
        }

        [Fact(DisplayName = "Clear Black")]
        public async Task ClearBlack()
        {
            var json = "{\"SerialNumber\":\"33D0CF36\",\"TagManufacturerData\":\"GggEAAT7EERhQVyQ\",\"MaterialVariantIdentifier\":\"C00-C1\",\"UniqueMaterialIdentifier\":\"FC00\",\"FilamentType\":\"PC\",\"DetailedFilamentType\":\"PC\",\"Color\":\"00000000\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"rA2sDcADwAMAAAA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"51FC8497A41D47B99B0F01FE74EA6239\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-01-11T19:45:00\",\"ProductionDateTimeShort\":\"25_01_11_19\",\"FilamentLength\":345,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"C00-C1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Clear Black", external?.Name);
            Assert.Equal("PC", external?.Material);
        }

        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"\",\"TagManufacturerData\":\"3QgEAAQA1VkccJyQ\",\"MaterialVariantIdentifier\":\"C00-W0\",\"UniqueMaterialIdentifier\":\"FC00\",\"FilamentType\":\"PC\",\"DetailedFilamentType\":\"PC\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"0AfQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"B10AE8E44665404A87BAFEC7C5020BA9\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-09-07T17:52:00\",\"ProductionDateTimeShort\":\"24_09_07_17\",\"FilamentLength\":345,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"C00-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White", external?.Name);
            Assert.Equal("PC", external?.Material);
        }

        [Fact(DisplayName = "White2")]
        public async Task White2()
        {
            var json = "{\"SerialNumber\":\"B3DF3039\",\"TagManufacturerData\":\"ZQgEAAQM4GMQ/ImQ\",\"MaterialVariantIdentifier\":\"C00-W0\",\"UniqueMaterialIdentifier\":\"FC00\",\"FilamentType\":\"PC\",\"DetailedFilamentType\":\"PC\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":260,\"XCamInfo\":\"0AfQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"696B72F34E1A41D28655AFD6E82BEDF6\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-01-04T18:44:00\",\"ProductionDateTimeShort\":\"25_01_04_18\",\"FilamentLength\":345,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"C00-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White", external?.Name);
            Assert.Equal("PC", external?.Material);
        }
    }
}
