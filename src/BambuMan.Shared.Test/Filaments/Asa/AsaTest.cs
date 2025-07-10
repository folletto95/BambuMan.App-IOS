namespace BambuMan.Shared.Test.Filaments.Asa
{
    [Trait("Category", "ASA")]
    public class AsaTest : BaseTest
    {
        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"1A502DB5\",\"TagManufacturerData\":\"0ggEAARlTIE254uQ\",\"MaterialVariantIdentifier\":\"B01-K0\",\"UniqueMaterialIdentifier\":\"FB01\",\"FilamentType\":\"ASA\",\"DetailedFilamentType\":\"ASA\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"gD4QJ+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"9DFBD5BBA24A420486A50835B0AF5EA1\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-05-06T10:39:00\",\"ProductionDateTimeShort\":\"24_05_06_10\",\"FilamentLength\":395,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B01-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("ASA", external?.Material);
        }

        [Fact(DisplayName = "Gray")]
        public async Task Gray()
        {
            var json = "{\"SerialNumber\":\"BA968EE9\",\"TagManufacturerData\":\"SwgEAAQz9OmnQnSQ\",\"MaterialVariantIdentifier\":\"B01-D0\",\"UniqueMaterialIdentifier\":\"FB01\",\"FilamentType\":\"ASA\",\"DetailedFilamentType\":\"ASA\",\"Color\":\"8A949EFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"NCGIE+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D6090ED6821A4319B54E9BA7BFDC2043\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-08-11T03:34:00\",\"ProductionDateTimeShort\":\"24_08_11_03\",\"FilamentLength\":395,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B01-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Gray", external?.Name);
            Assert.Equal("ASA", external?.Material);
        }

        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"3A578DE9\",\"TagManufacturerData\":\"CQgEAAQ8fNxvhc+Q\",\"MaterialVariantIdentifier\":\"B01-W0\",\"UniqueMaterialIdentifier\":\"FB01\",\"FilamentType\":\"ASA\",\"DetailedFilamentType\":\"ASA\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"NCGIE+gD6APNzAw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F349B0AEA1BB4B17A97AB80517B76C1C\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-09-19T04:25:00\",\"ProductionDateTimeShort\":\"24_09_19_04\",\"FilamentLength\":395,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B01-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White", external?.Name);
            Assert.Equal("ASA", external?.Material);
        }
    }
}
