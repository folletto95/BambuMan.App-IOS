namespace BambuMan.Shared.Test.Filaments
{
    [Trait("Category", "Support")]
    public class SupportTest : BaseTest
    {
        [Fact(DisplayName = "Support for PLA White")]
        public async Task SupportForPlaWhite()
        {
            var json = "{\"SerialNumber\":\"3526771C\",\"TagManufacturerData\":\"eAgEAAPFE3AN9t2Q\",\"MaterialVariantIdentifier\":\"S00-W0\",\"UniqueMaterialIdentifier\":\"FS00\",\"FilamentType\":\"Support\",\"DetailedFilamentType\":\"Support W\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":250,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":40,\"MaxTemperatureForHotend\":220,\"MinTemperatureForHotend\":220,\"XCamInfo\":\"NCHQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1EACC234E93F49268139474ACBA4E144\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2022-07-11T22:50:00\",\"ProductionDateTimeShort\":\"2207090310\",\"FilamentLength\":80,\"FormatIdentifier\":0,\"ColorCount\":0,\"SecondColor\":\"00000000\",\"SkuStart\":\"S00-W0-1.75-250\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Support for PLA White", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Support for PLA Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"E44D9301\",\"TagManufacturerData\":\"OwgEAAS4hBrMBIqQ\",\"MaterialVariantIdentifier\":\"S05-C0\",\"UniqueMaterialIdentifier\":\"FS05\",\"FilamentType\":\"PLA-S\",\"DetailedFilamentType\":\"Support for PLA\",\"Color\":\"00000000\",\"SpoolWeight\":250,\"FilamentDiameter\":1.75,\"DryingTemperature\":70,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":220,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"pDikOIQD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"EE6962D8F91243479DD0F07595B6C171\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-09T02:57:00\",\"ProductionDateTimeShort\":\"20241008\",\"FilamentLength\":87,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"S05-C0-1.75-250\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Support for PLA/PETG Nature", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Support W White")]
        public async Task White2()
        {
            var json = "{\"SerialNumber\":\"071737C1\",\"TagManufacturerData\":\"5ggEAAO1NwU3mf2Q\",\"MaterialVariantIdentifier\":\"S00-W0\",\"UniqueMaterialIdentifier\":\"FS00\",\"FilamentType\":\"PLA-S\",\"DetailedFilamentType\":\"Support W\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":250,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":40,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"NCHQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"FA42614FC40C49E399184254BA8B3A14\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2022-12-29T11:39:00\",\"ProductionDateTimeShort\":\"2212260052\",\"FilamentLength\":80,\"FormatIdentifier\":0,\"ColorCount\":0,\"SecondColor\":\"00000000\",\"SkuStart\":\"S00-W0-1.75-250\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Support for PLA White", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Support for ABS White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"1AB940AA\",\"TagManufacturerData\":\"SQgEAAR8wI54jrOQ\",\"MaterialVariantIdentifier\":\"S06-W0\",\"UniqueMaterialIdentifier\":\"FS06\",\"FilamentType\":\"ABS-S\",\"DetailedFilamentType\":\"Support for ABS\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":500,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"pDiAPugD6APsUXg/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"84BCF4AA7F4A4892860206DAB32F5CE4\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-08-29T06:09:00\",\"ProductionDateTimeShort\":\"20240828\",\"FilamentLength\":200,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"S06-W0-1.75-500\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Support for ABS", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }
    }
}
