namespace BambuMan.Shared.Test.Filaments.Petg
{
    [Trait("Category", "PETG")]
    public class PetgTranslucentTest : BaseTest
    {
        [Fact(DisplayName = "Clear")]
        public async Task Clear()
        {
            var json = "{\"SerialNumber\":\"DAC888FB\",\"TagManufacturerData\":\"YQgEAASo9nmRwduQ\",\"MaterialVariantIdentifier\":\"G01-C0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"00000000\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"pDiAPrwCIAMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"697C12C070E044FAA79740483B46139A\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-08-17T16:11:00\",\"ProductionDateTimeShort\":\"20240817\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-C0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Clear", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }
        
        [Fact(DisplayName = "Translucent Brown")]
        public async Task TranslucentBrown()
        {
            var json = "{\"SerialNumber\":\"0AA978F2\",\"TagManufacturerData\":\"KQgEAAReQPG1rLWQ\",\"MaterialVariantIdentifier\":\"G01-N0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"C9A38180\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ECc0IYQD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F1B82FBB549E4BDA9AC28F91AB331362\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-09-21T18:38:00\",\"ProductionDateTimeShort\":\"20240921\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-N0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Brown", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Gray")]
        public async Task TranslucentGray()
        {
            var json = "{\"SerialNumber\":\"2A8292F4\",\"TagManufacturerData\":\"zggEAASTiqUBgE2Q\",\"MaterialVariantIdentifier\":\"G01-D0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"8E8E8E80\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"NCE0IYQD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"430333B496074ADA81D7CDA626721271\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-10-14T13:37:00\",\"ProductionDateTimeShort\":\"20241014\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Gray", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Olive")]
        public async Task TranslucentOlive()
        {
            var json = "{\"SerialNumber\":\"AD3CF1DD\",\"TagManufacturerData\":\"vQgEAAPXhg2NonWQ\",\"MaterialVariantIdentifier\":\"G01-G0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"748C4580\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"NCE0IYQD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"0C8A60CC3AB04241B7D757C66EF44D94\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-07-21T18:54:00\",\"ProductionDateTimeShort\":\"20240721\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Olive", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Orange")]
        public async Task TranslucentOrange()
        {
            var json = "{\"SerialNumber\":\"FAD957EF\",\"TagManufacturerData\":\"mwgEAARygWGDooeQ\",\"MaterialVariantIdentifier\":\"G01-A0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"FF911A80\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ECekOIQD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"4A0558D8D96640128657DA68B7ED8EF3\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-08-12T14:49:00\",\"ProductionDateTimeShort\":\"20240812\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-A0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Orange", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Pink")]
        public async Task TranslucentPink()
        {
            var json = "{\"SerialNumber\":\"4A84E4EE\",\"TagManufacturerData\":\"xAgEAATIhIFuSAaQ\",\"MaterialVariantIdentifier\":\"G01-P1\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"F9C1BD80\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ZBmIEyADIAPNzAw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"ED172B0319CE44AE94B56F7257EF0BBA\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-08-24T04:53:00\",\"ProductionDateTimeShort\":\"20240824\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-P1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Pink", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Purple")]
        public async Task TranslucentPurple()
        {
            var json = "{\"SerialNumber\":\"AA58FFE0\",\"TagManufacturerData\":\"7QgEAATh4pz1JZiQ\",\"MaterialVariantIdentifier\":\"G01-P0\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"D6ABFF80\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"rA2IEyADIAOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E924842EB7954C07966649A01572AE96\",\"SpoolWidth\":201,\"ProductionDateTime\":\"2024-07-10T14:19:00\",\"ProductionDateTimeShort\":\"20240710\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-P0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Purple", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Translucent Teal")]
        public async Task TranslucentTeal()
        {
            var json = "{\"SerialNumber\":\"3ACD61AE\",\"TagManufacturerData\":\"OAgEAAT1aN/Qj3OQ\",\"MaterialVariantIdentifier\":\"G01-G1\",\"UniqueMaterialIdentifier\":\"FG01\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG Translucent\",\"Color\":\"77EDD780\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"7CzsLIQD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2FD2B9425D2C4B1DBA352A4896CAF676\",\"SpoolWidth\":2875,\"ProductionDateTime\":\"2024-08-12T18:22:00\",\"ProductionDateTimeShort\":\"20240812\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G01-G1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Translucent Teal", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }
    }
}
