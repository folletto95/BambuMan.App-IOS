namespace BambuMan.Shared.Test.Filaments.Abs
{
    [Trait("Category", "ABS")]
    public class AbsTest : BaseTest
    {
        [Fact(DisplayName = "Azure")]
        public async Task Azure()
        {
            var json = "{\"SerialNumber\":\"34FCB2D5\",\"TagManufacturerData\":\"rwgEAATwxPGTXdCQ\",\"MaterialVariantIdentifier\":\"B00-B4\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"489FDFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"iBOIE+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"66BAB6B45D794FDABC8B7242C8959399\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-11-13T07:50:00\",\"ProductionDateTimeShort\":\"24_11_13_07\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-B4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Azure", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "BambuGreen")]
        public async Task BambuGreen()
        {
            var json = "{\"SerialNumber\":\"3A1C6DAE\",\"TagManufacturerData\":\"5QgEAAS/eZhTl9mQ\",\"MaterialVariantIdentifier\":\"B00-G6\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"00AE42FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"iBM0IegD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"072C63087004476CB236B95E384A8F62\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-11-29T14:24:00\",\"ProductionDateTimeShort\":\"24_11_29_14\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-G6-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Bambu Green", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"94B0C6D5\",\"TagManufacturerData\":\"NwgEAATFX3/GYsCQ\",\"MaterialVariantIdentifier\":\"B00-K0\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"gD4QJ+gD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"5E755D3AE0FD409F913D5A89F817A248\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-11-27T09:19:00\",\"ProductionDateTimeShort\":\"24_11_27_09\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"CA474BFE\",\"TagManufacturerData\":\"OAgEAASwz1hBABiQ\",\"MaterialVariantIdentifier\":\"B00-B0\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"0A2CA5FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"rA2sDegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"6729CED45DDC48F28234386D627036A6\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-12-06T09:16:00\",\"ProductionDateTimeShort\":\"24_12_06_09\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Blue", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "NavyBlue")]
        public async Task NavyBlue()
        {
            var json = "{\"SerialNumber\":\"5A01F2B4\",\"TagManufacturerData\":\"HQgEAAR1LD8FQ9qQ\",\"MaterialVariantIdentifier\":\"B00-B6\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"0C2340FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"NCE0IegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A376D792C5624F5AB205AB2AF4728054\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-05-18T12:13:00\",\"ProductionDateTimeShort\":\"24_05_18_12\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-B6-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Navy Blue", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Olive")]
        public async Task Olive()
        {
            var json = "{\"SerialNumber\":\"9B7CBBF9\",\"TagManufacturerData\":\"pQgEAASuzc5UFR6Q\",\"MaterialVariantIdentifier\":\"B00-G7\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"789D4AFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"iBOsDegD6AMAAEA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A523ECF9A85347018FD1F0A82FD2129D\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-02-23T13:30:00\",\"ProductionDateTimeShort\":\"25_02_23_13\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-G7-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Olive", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Orange")]
        public async Task Orange()
        {
            var json = "{\"SerialNumber\":\"7B2ADEF9\",\"TagManufacturerData\":\"dggEAAT7diDD9W+Q\",\"MaterialVariantIdentifier\":\"B00-A0\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"FF6A13FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"iBM0IegD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1408E0F09CD949CA94BE8833759F7052\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-02-19T14:50:00\",\"ProductionDateTimeShort\":\"25_02_19_14\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-A0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Orange", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Red")]
        public async Task Red()
        {
            var json = "{\"SerialNumber\":\"1A0724F4\",\"TagManufacturerData\":\"zQgEAASWXAg8gQeQ\",\"MaterialVariantIdentifier\":\"B00-R0\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"D32941FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"iBOsDegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D7F0C41F7D464BACB17F2854F536C5E6\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-13T09:18:00\",\"ProductionDateTimeShort\":\"24_10_13_09\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-R0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Red", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "Silver")]
        public async Task Silver()
        {
            var json = "{\"SerialNumber\":\"0A9F61F2\",\"TagManufacturerData\":\"BggEAASohW0JpS+Q\",\"MaterialVariantIdentifier\":\"B00-D1\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"87909AFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"0AfQB+gD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F8C88539FD7C4EAA81AECF7DE011B16B\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-21T14:23:00\",\"ProductionDateTimeShort\":\"24_10_21_14\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-D1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Silver", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "TangerineYellow")]
        public async Task TangerineYellow()
        {
            var json = "{\"SerialNumber\":\"BB0061FC\",\"TagManufacturerData\":\"JggEAAQ+gRhWqQWQ\",\"MaterialVariantIdentifier\":\"B00-Y1\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"FFC72CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"rA00IegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"63BE8302ECC14F97B5CD27B11FCA74B6\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-04-06T12:35:00\",\"ProductionDateTimeShort\":\"25_04_06_12\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-Y1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Tangerine Yellow", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }

        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"3A0258BD\",\"TagManufacturerData\":\"3QgEAARiU+WY16OQ\",\"MaterialVariantIdentifier\":\"B00-W0\",\"UniqueMaterialIdentifier\":\"FB00\",\"FilamentType\":\"ABS\",\"DetailedFilamentType\":\"ABS\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":80,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":270,\"MinTemperatureForHotend\":240,\"XCamInfo\":\"0AfQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"658AF4C881A64A0781B32CFB5A7CB675\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-06-03T13:24:00\",\"ProductionDateTimeShort\":\"24_06_03_13\",\"FilamentLength\":398,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"B00-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White", external?.Name);
            Assert.Equal("ABS", external?.Material);
        }
    }
}
