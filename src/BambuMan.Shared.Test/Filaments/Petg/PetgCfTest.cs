namespace BambuMan.Shared.Test.Filaments.Petg
{
    [Trait("Category", "PETG-CF")]
    public class PetgCfTest : BaseTest
    {
        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"3AEF4CFD\",\"TagManufacturerData\":\"ZAgEAAT/yYzOOs6Q\",\"MaterialVariantIdentifier\":\"G50-K0\",\"UniqueMaterialIdentifier\":\"FG50\",\"FilamentType\":\"PETG-CF\",\"DetailedFilamentType\":\"PETG-CF\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"gD6APugD6AMzM3M/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E0AE65F811DA4F9CA2580DDC83479A8C\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-08-07T09:45:00\",\"ProductionDateTimeShort\":\"20240807\",\"FilamentLength\":334,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G50-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("PETG-CF", external?.Material);
        }
    }
}
