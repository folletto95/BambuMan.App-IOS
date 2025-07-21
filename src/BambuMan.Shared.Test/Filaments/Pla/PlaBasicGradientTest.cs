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

        [Fact(DisplayName = "Blueberry Bubblegum")]
        public async Task BlueberryBubblegum()
        {
            var json = "{\"SerialNumber\":\"1472A401\",\"TagManufacturerData\":\"wwgEAARkWT1bNhKQ\",\"MaterialVariantIdentifier\":\"A00-M5\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"6FCAEFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"132D1A4BE74F47E2A3D7756E7ECE0476\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-12-10T13:41:00\",\"ProductionDateTimeShort\":\"24_12_10_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"5837DDFF\",\"SkuStart\":\"A00-M5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Blueberry Bubblegum", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Cotton Candy Cloud")]
        public async Task CottonCandyCloud()
        {
            var json = "{\"SerialNumber\":\"0B9A68FD\",\"TagManufacturerData\":\"BAgEAARe5p0oyZeQ\",\"MaterialVariantIdentifier\":\"A00-M7\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"E7C1D5FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"863C344BE7C745148E3BBCC19E73391C\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-27T09:21:00\",\"ProductionDateTimeShort\":\"25_03_27_09\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"E89C9EFF\",\"SkuStart\":\"A00-M7-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Cotton Candy Cloud", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Dusk Glare")]
        public async Task DuskGlare()
        {
            var json = "{\"SerialNumber\":\"733C62A2\",\"TagManufacturerData\":\"jwgEAARjc6n7JoaQ\",\"MaterialVariantIdentifier\":\"A00-M6\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"CE4406FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A604AB510F3A4661847D256F163366FA\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-01-11T16:22:00\",\"ProductionDateTimeShort\":\"25_01_11_16\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"DE5985FF\",\"SkuStart\":\"A00-M6-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Dusk Glare", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Mint Lime")]
        public async Task MintLime()
        {
            var json = "{\"SerialNumber\":\"43A36339\",\"TagManufacturerData\":\"uggEAATNbZfm0wmQ\",\"MaterialVariantIdentifier\":\"A00-M4\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"B6FF43FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"5FDFB88AD1924FA68642CAFE8D5A3BB5\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-01-07T17:56:00\",\"ProductionDateTimeShort\":\"25_01_07_17\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"E49C93FF\",\"SkuStart\":\"A00-M4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Mint Lime", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Ocean to Meadow")]
        public async Task OceanToMeadow()
        {
            var json = "{\"SerialNumber\":\"A57F2C04\",\"TagManufacturerData\":\"8ggEAATVoP/94MuQ\",\"MaterialVariantIdentifier\":\"A00-M2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"307FE2FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"rA2IE+gD6AMAAEA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"04CB55C86F0B41A98B0D2F91BB69D42F\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-04-13T10:38:00\",\"ProductionDateTimeShort\":\"25_04_13_10\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"45FFB9FF\",\"SkuStart\":\"A00-M2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Ocean to Meadow", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Solar Breeze")]
        public async Task SolarBreeze()
        {
            var json = "{\"SerialNumber\":\"314BE30E\",\"TagManufacturerData\":\"lwgEAAS0ic8qwEeY\",\"MaterialVariantIdentifier\":\"A00-M1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"E94B3CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"rA3QB+gD6AMAAEA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F114AF0510B84F86AEE356E243134864\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-08-26T07:51:00\",\"ProductionDateTimeShort\":\"24_08_26_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"FFFFFFFF\",\"SkuStart\":\"A00-M1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Solar Breeze", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
