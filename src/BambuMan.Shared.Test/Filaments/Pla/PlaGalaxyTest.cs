namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Basic Gradient")]
    public class PlaGalaxyTest : BaseTest
    {
        [Fact(DisplayName = "Brown Galaxy")]
        public async Task Brown()
        {
            var json = "{\"SerialNumber\":\"1A7FF1F3\",\"TagManufacturerData\":\"ZwgEAAS1BTj7xdWQ\",\"MaterialVariantIdentifier\":\"A15-R0\",\"UniqueMaterialIdentifier\":\"FA15\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Galaxy\",\"Color\":\"684A43FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"NCGsDSADhAMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A31FDF7B34284E3FB3BCD0C2983D6268\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-09-25T07:58:00\",\"ProductionDateTimeShort\":\"24_09_25_07\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A15-R0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Brown Galaxy", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Green Galaxy")]
        public async Task Green()
        {
            var json = "{\"SerialNumber\":\"4A99E471\",\"TagManufacturerData\":\"RggEAASUqe5lA86Q\",\"MaterialVariantIdentifier\":\"A15-G0\",\"UniqueMaterialIdentifier\":\"FA15\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Galaxy\",\"Color\":\"3B665EFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"gD6APoQD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"35FFAAB3C20A4E11AED7881EB63E56EC\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-05-04T08:38:00\",\"ProductionDateTimeShort\":\"24_05_04_08\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A15-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Green Galaxy", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Nebulae Galaxy")]
        public async Task Nebulae()
        {
            var json = "{\"SerialNumber\":\"1EFB5E72\",\"TagManufacturerData\":\"yQgEAATEwUhxTSyQ\",\"MaterialVariantIdentifier\":\"A15-G1\",\"UniqueMaterialIdentifier\":\"FA15\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Galaxy\",\"Color\":\"424379FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"pDikOIQD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"127C038F311647FEAA10CC52978808CC\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-03-16T07:11:00\",\"ProductionDateTimeShort\":\"24_03_16_07\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A15-G1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Nebulae Galaxy", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Purple Galaxy")]
        public async Task Purple()
        {
            var json = "{\"SerialNumber\":\"74B4D6D4\",\"TagManufacturerData\":\"wggEAAR53PUNm42Q\",\"MaterialVariantIdentifier\":\"A15-B0\",\"UniqueMaterialIdentifier\":\"FA15\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Galaxy\",\"Color\":\"594177FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOsDbwCIAMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F1E9785F938E41D285C0D317AD77256D\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-12-09T12:47:00\",\"ProductionDateTimeShort\":\"24_12_09_12\",\"FilamentLength\":350,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A15-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Purple Galaxy", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
