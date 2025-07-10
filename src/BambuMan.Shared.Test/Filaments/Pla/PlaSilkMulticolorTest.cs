using System.Net.NetworkInformation;

namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Silk Multi-Color")]
    public class PlaSilkMulticolorTest : BaseTest
    {
        [Fact(DisplayName = "Blue Hawaii (blue-green)")]
        public async Task BlueHawaiiBlueGreen()
        {
            var json = "{\"SerialNumber\":\"BA8B7DE9\",\"TagManufacturerData\":\"pQgEAARo7R9ejaGQ\",\"MaterialVariantIdentifier\":\"A05-T4\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"418FDEFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"iBOIE+gD6AMAAEA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2B0F937219F4468BA9F23AD8010951E5\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-11-08T08:37:00\",\"ProductionDateTimeShort\":\"A2411070318\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"078C48FF\",\"SkuStart\":\"A05-T4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Blue Hawaii (Blue-Green)", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Gilded Rose (pink-gold)")]
        public async Task GildedRosePinkGold()
        {
            var json = "{\"SerialNumber\":\"2A16E8EE\",\"TagManufacturerData\":\"OggEAAT2b4K83wGQ\",\"MaterialVariantIdentifier\":\"A05-T1\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"FF9425FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"rA2IEyAD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1E4B0FC735054841BA3BEB09403A01C3\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-31T01:32:00\",\"ProductionDateTimeShort\":\"A2408300130\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"1C7648FF\",\"SkuStart\":\"A05-T1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Gilded Rose (Pink-Gold)", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Midnight Blaze (blue-red)")]
        public async Task MidnightBlazeBlueRed()
        {
            var json = "{\"SerialNumber\":\"1A717CF3\",\"TagManufacturerData\":\"5AgEAATaGc09/KuQ\",\"MaterialVariantIdentifier\":\"A05-T2\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"0047BBFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"NCGsDegD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"911D4B25B40944F9B35749853B16352B\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-11-06T20:43:00\",\"ProductionDateTimeShort\":\"20241106\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"D7B194FF\",\"SkuStart\":\"A05-T2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Midnight Blaze (Blue-Red)", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Neon City (blue-magenta)")]
        public async Task NeonCityBlueMagenta()
        {
            var json = "{\"SerialNumber\":\"44F349D0\",\"TagManufacturerData\":\"LggEAASPspkygh+Q\",\"MaterialVariantIdentifier\":\"A05-T3\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"0047BBFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"NCGIE4QD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"DA9DD8321FD54406BCC1DFCAF687DE5F\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-12-12T02:21:00\",\"ProductionDateTimeShort\":\"20241211\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"BB223AFF\",\"SkuStart\":\"A05-T3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Neon City (Blue-Magenta)", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Velvet Eclipse (black-red)")]
        public async Task VelvetEclipseBlackRed()
        {
            var json = "{\"SerialNumber\":\"5AF635F2\",\"TagManufacturerData\":\"awgEAARED3obBeiQ\",\"MaterialVariantIdentifier\":\"A05-T5\",\"UniqueMaterialIdentifier\":\"FA05\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Silk\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":210,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"27B8D25807004D498A58874F29F285F3\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-25T18:47:00\",\"ProductionDateTimeShort\":\"20241025\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":2,\"SecondColor\":\"3A3424FF\",\"SkuStart\":\"A05-T5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Velvet Eclipse (Black-Red)", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
