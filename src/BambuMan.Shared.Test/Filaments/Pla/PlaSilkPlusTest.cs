namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Silk+")]
    public class PlaSilkPlusTest : BaseTest
    {
        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"0A4756F2\",\"TagManufacturerData\":\"6QgEAATHUTy5iauQ\",\"MaterialVariantIdentifier\":\"A06-B1\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"008BDAFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"36AF32E4344A40F8B928C91CBB1F8A93\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-12T07:11:00\",\"ProductionDateTimeShort\":\"24_10_12_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-B1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Blue", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Candy Green")]
        public async Task CandyGreen()
        {
            var json = "{\"SerialNumber\":\"2A118AF4\",\"TagManufacturerData\":\"RQgEAATr0ReC+B+Q\",\"MaterialVariantIdentifier\":\"A06-G0\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"018814FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"16ED9CAE074D4430B1EE3CEA232A7062\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-08T07:20:00\",\"ProductionDateTimeShort\":\"24_10_08_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Candy Green", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Candy Red")]
        public async Task CandyRed()
        {
            var json = "{\"SerialNumber\":\"23C54F0A\",\"TagManufacturerData\":\"owgEAATtvS8JJ4KQ\",\"MaterialVariantIdentifier\":\"A06-R0\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"D02727FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D0806FC47014440EA8833C51C1DA1007\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-29T13:23:00\",\"ProductionDateTimeShort\":\"24_10_29_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-R0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Candy Red", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Champagne")]
        public async Task Champagne()
        {
            var json = "{\"SerialNumber\":\"A3AC6F0A\",\"TagManufacturerData\":\"aggEAAQ1e3wjb/yQ\",\"MaterialVariantIdentifier\":\"A06-Y0\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"F3CFB2FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"43C8AA49CD5A4323A45992A75795C127\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-21T07:43:00\",\"ProductionDateTimeShort\":\"24_10_21_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-Y0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Champagne", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Gold")]
        public async Task Gold()
        {
            var json = "{\"SerialNumber\":\"6B2A9EF6\",\"TagManufacturerData\":\"KQgEAAS1Xs/ZIeyQ\",\"MaterialVariantIdentifier\":\"A06-Y1\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"F4A925FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"9884616174C447AFAA49AAEC19ACBCFC\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-23T07:48:00\",\"ProductionDateTimeShort\":\"25_03_23_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-Y1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Gold", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Mint")]
        public async Task Mint()
        {
            var json = "{\"SerialNumber\":\"3AC34EF2\",\"TagManufacturerData\":\"RQgEAATaLwY6HfKQ\",\"MaterialVariantIdentifier\":\"A06-G1\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"96DCB9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"311E33A406284001A8D3F2690F0C1CF2\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-13T11:14:00\",\"ProductionDateTimeShort\":\"24_10_13_11\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-G1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Mint", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Pink")]
        public async Task Pink()
        {
            var json = "{\"SerialNumber\":\"14B6BCD4\",\"TagManufacturerData\":\"yggEAAQVHh+rX6qQ\",\"MaterialVariantIdentifier\":\"A06-R2\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"F7ADA6FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"CE4EE8AF90EE433BA43F7B08B50C0E28\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-11-05T07:13:00\",\"ProductionDateTimeShort\":\"24_11_05_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-R2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Pink", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Rose Gold")]
        public async Task RoseGold()
        {
            var json = "{\"SerialNumber\":\"F32E4C0A\",\"TagManufacturerData\":\"mwgEAAQ1l//3A8yQ\",\"MaterialVariantIdentifier\":\"A06-R1\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"BA9594FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"C2D3F6DF13654481A4A5C27656C3DAAC\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-11T12:17:00\",\"ProductionDateTimeShort\":\"24_10_11_12\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-R1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Rose Gold", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Silver")]
        public async Task Silver()
        {
            var json = "{\"SerialNumber\":\"9507DB24\",\"TagManufacturerData\":\"bQgEAARHoK8VHcSQ\",\"MaterialVariantIdentifier\":\"A06-D1\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"C8C8C8FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"9A0CFEAA6C4D409F91F016C50F5CDD7A\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-04-03T16:02:00\",\"ProductionDateTimeShort\":\"25_04_03_16\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-D1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Silver", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "Titan Gray")]
        public async Task TitanGray()
        {
            var json = "{\"SerialNumber\":\"23433F0A\",\"TagManufacturerData\":\"VQgEAASO3QKoUf6Q\",\"MaterialVariantIdentifier\":\"A06-D0\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"5F6367FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A7E35E95D3EA48019ECCCBD920764D87\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-31T10:29:00\",\"ProductionDateTimeShort\":\"24_10_31_10\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ Titan Gray", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }

        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"3A844FF4\",\"TagManufacturerData\":\"BQgEAATwTse9vFWQ\",\"MaterialVariantIdentifier\":\"A06-W0\",\"UniqueMaterialIdentifier\":\"FA06\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk+\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"3F6E8DA5A8454DAF9FDDC9148E33646A\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-09-24T13:36:00\",\"ProductionDateTimeShort\":\"24_09_24_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A06-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);

            Assert.Equal("Silk+ White", external?.Name);
            Assert.Equal("PLA",external?.Material);
        }
    }
}
