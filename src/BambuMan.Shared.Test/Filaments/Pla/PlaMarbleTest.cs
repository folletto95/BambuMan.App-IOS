namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Marble")]
    public class PlaMarbleTest : BaseTest
    {
        [Fact(DisplayName = "Red Granite")]
        public async Task RedGranite()
        {
            var json = "{\"SerialNumber\":\"4B5F23FA\",\"TagManufacturerData\":\"zQgEAASrHM7p88mQ\",\"MaterialVariantIdentifier\":\"A07-R5\",\"UniqueMaterialIdentifier\":\"FA07\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Marble\",\"Color\":\"AD4E38FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0Ac0IegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"636B60D3D59C42CFAFA787C743705265\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-06T16:20:00\",\"ProductionDateTimeShort\":\"25_03_06_16\",\"FilamentLength\":340,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A07-R5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Red Granite", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}