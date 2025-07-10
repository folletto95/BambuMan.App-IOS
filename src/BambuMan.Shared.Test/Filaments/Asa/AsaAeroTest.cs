namespace BambuMan.Shared.Test.Filaments.Asa
{
    [Trait("Category", "ASA Aero")]
    public class AsaAeroTest : BaseTest
    {
        
        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"736E63A1\",\"TagManufacturerData\":\"3wgEAATV1GncjY2Q\",\"MaterialVariantIdentifier\":\"B02-W0\",\"UniqueMaterialIdentifier\":\"FB02\",\"FilamentType\":\"ASA Aero\",\"DetailedFilamentType\":\"ASA Aero\",\"Color\":\"E9E4D9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":280,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"ECcQJ+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"21C22A1A7CFD412E8F7CF65955801DD3\",\"SpoolWidth\":3717,\"ProductionDateTime\":\"2025-01-03T13:56:00\",\"ProductionDateTimeShort\":\"25_01_03_13\",\"FilamentLength\":420,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B02-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White Aero", external?.Name);
            Assert.Equal("ASA", external?.Material);
        }
    }
}
