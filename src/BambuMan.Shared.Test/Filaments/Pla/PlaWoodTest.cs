namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Wood")]
    public class PlaWoodTest : BaseTest
    {
        [Fact(DisplayName = "Classic Birch")]
        public async Task ClassicBirch()
        {
            var json = "{\"SerialNumber\":\"5B1449F6\",\"TagManufacturerData\":\"8AgEAATrOVf5DLaQ\",\"MaterialVariantIdentifier\":\"A16-G0\",\"UniqueMaterialIdentifier\":\"FA16\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Wood\",\"Color\":\"918669FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":6,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"4663E9ADF9CC454380EB58CE627BFE72\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2025-03-11T00:38:00\",\"ProductionDateTimeShort\":\"25_03_11_00\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A16-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Classic Birch", external?.Name);
            Assert.Equal("PLA+WOOD", external?.Material);
        }

        [Fact(DisplayName = "BlackWalnut")]
        public async Task BlackWalnut()
        {
            var json = "{\"SerialNumber\":\"3A78A1FD\",\"TagManufacturerData\":\"HggEAARb0K0PxXGQ\",\"MaterialVariantIdentifier\":\"A16-K0\",\"UniqueMaterialIdentifier\":\"FA16\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Wood\",\"Color\":\"4F3F24FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":6,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"61F0FC6434024A84B4CAA3A025336377\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-09-21T06:01:00\",\"ProductionDateTimeShort\":\"24_09_21_06\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A16-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black Walnut", external?.Name);
            Assert.Equal("PLA+WOOD", external?.Material);
        }
        
        [Fact(DisplayName = "Clay Brown")]
        public async Task ClayBrown()
        {
            var json = "{\"SerialNumber\":\"5A1335FE\",\"TagManufacturerData\":\"gggEAAS7jhOAG3SQ\",\"MaterialVariantIdentifier\":\"A16-N0\",\"UniqueMaterialIdentifier\":\"FA16\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Wood\",\"Color\":\"995F11FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":6,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"82AE00E7D02F4DF286B73E490B59C394\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-09-16T13:59:00\",\"ProductionDateTimeShort\":\"24_09_16_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A16-N0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Clay Brown", external?.Name);
            Assert.Equal("PLA+WOOD", external?.Material);
        }

        [Fact(DisplayName = "Ochre Yellow")]
        public async Task OchreYellow()
        {
            var json = "{\"SerialNumber\":\"6A1247AF\",\"TagManufacturerData\":\"kAgEAAQknvJ+E4CQ\",\"MaterialVariantIdentifier\":\"A16-Y0\",\"UniqueMaterialIdentifier\":\"FA16\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Wood\",\"Color\":\"C98935FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":6,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"133F8DDD222B4D01BF085F8410FCB726\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-09-12T14:44:00\",\"ProductionDateTimeShort\":\"24_09_12_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A16-Y0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Ochre Yellow", external?.Name);
            Assert.Equal("PLA+WOOD", external?.Material);
        }

        [Fact(DisplayName = "White Oak")]
        public async Task WhiteOak()
        {
            var json = "{\"SerialNumber\":\"4A56A7FD\",\"TagManufacturerData\":\"RggEAASrVYpR63eQ\",\"MaterialVariantIdentifier\":\"A16-W0\",\"UniqueMaterialIdentifier\":\"FA16\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Wood\",\"Color\":\"D6CCA3FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":60,\"DryingTime\":6,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"6565C3D60CCA4218A7C4745E769DF226\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-09-19T14:00:00\",\"ProductionDateTimeShort\":\"24_09_19_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A16-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("White Oak", external?.Name);
            Assert.Equal("PLA+WOOD", external?.Material);
        }
    }
}
