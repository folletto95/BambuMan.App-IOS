namespace BambuMan.Shared.Test.Filaments
{
    [Trait("Category", "TPU for AMS")]
    public class TpuForAmsTest : BaseTest
    {
        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"45A7C402\",\"TagManufacturerData\":\"JAgEAARXN/Qm7SWQ\",\"MaterialVariantIdentifier\":\"U02-K0\",\"UniqueMaterialIdentifier\":\"FU02\",\"FilamentType\":\"TPU-AMS\",\"DetailedFilamentType\":\"TPU for AMS\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":70,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":220,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"CC25BBD1DB1144ACA446A1C8D00F78D1\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-04-18T04:28:00\",\"ProductionDateTimeShort\":\"A2504170466\",\"FilamentLength\":320,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"U02-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("For AMS Black", external?.Name);
            Assert.Equal("TPU", external?.Material);
        }

        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"7AC779E9\",\"TagManufacturerData\":\"LQgEAARDZbfS0t2Q\",\"MaterialVariantIdentifier\":\"U02-B0\",\"UniqueMaterialIdentifier\":\"FU02\",\"FilamentType\":\"TPU-AMS\",\"DetailedFilamentType\":\"TPU for AMS\",\"Color\":\"5898DDFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":70,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":220,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"645BDC06ADD84C97BCCF44A02DF8D96C\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-11-09T09:20:00\",\"ProductionDateTimeShort\":\"A2411080371\",\"FilamentLength\":320,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"U02-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("For AMS Blue", external?.Name);
            Assert.Equal("TPU", external?.Material);
        }

        [Fact(DisplayName = "Gray")]
        public async Task Gray()
        {
            var json = "{\"SerialNumber\":\"943A53D4\",\"TagManufacturerData\":\"KQgEAASXd7Tg6cmQ\",\"MaterialVariantIdentifier\":\"U02-D0\",\"UniqueMaterialIdentifier\":\"FU02\",\"FilamentType\":\"TPU-AMS\",\"DetailedFilamentType\":\"TPU for AMS\",\"Color\":\"939393FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":70,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":240,\"MinTemperatureForHotend\":220,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"23A77D0AE5F549FF9DCED74098591A50\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-11-29T19:50:00\",\"ProductionDateTimeShort\":\"A2411290161\",\"FilamentLength\":320,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"U02-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("For AMS Gray", external?.Name);
            Assert.Equal("TPU", external?.Material);
        }
    }
}
