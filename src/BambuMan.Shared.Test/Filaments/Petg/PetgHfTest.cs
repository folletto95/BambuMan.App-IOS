namespace BambuMan.Shared.Test.Filaments.Petg
{
    [Trait("Category", "PETG-HF")]
    public class PetgHfTest : BaseTest
    {
        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"EB0CC9FD\",\"TagManufacturerData\":\"0wgEAAQGqAgWmyWQ\",\"MaterialVariantIdentifier\":\"G02-K0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"iBOkOPQBWAIAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1BA018934FF3436E92FFA7C047C655E4\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-10T03:54:00\",\"ProductionDateTimeShort\":\"20250309\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Black", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Blue")]
        public async Task Blue()
        {
            var json = "{\"SerialNumber\":\"53C9E3A1\",\"TagManufacturerData\":\"2AgEAARMSge/5jOQ\",\"MaterialVariantIdentifier\":\"G02-B0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"002E96FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ECcQJyADhAMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D30FDDA39C5745788300C9C4F53441AF\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-01-17T22:50:00\",\"ProductionDateTimeShort\":\"20250117\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Blue", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Cream")]
        public async Task Cream()
        {
            var json = "{\"SerialNumber\":\"D5C9DF04\",\"TagManufacturerData\":\"xwgEAATYcgsCsWeQ\",\"MaterialVariantIdentifier\":\"G02-Y1\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"F9DFB9FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"52FE93E5171943A18BE3CFC0A8AB69B0\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-04-16T15:21:00\",\"ProductionDateTimeShort\":\"20250416\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-Y1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Cream", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "DarkGray")]
        public async Task DarkGray()
        {
            var json = "{\"SerialNumber\":\"0BCBB6F6\",\"TagManufacturerData\":\"gAgEAAQrCWPJF+KQ\",\"MaterialVariantIdentifier\":\"G02-D1\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"515151FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"47E18A73F6064DF08FB64CCB963CC352\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-24T06:50:00\",\"ProductionDateTimeShort\":\"20250323\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-D1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Dark Gray", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "ForestGreen")]
        public async Task ForestGreen()
        {
            var json = "{\"SerialNumber\":\"15824C0D\",\"TagManufacturerData\":\"1ggEAAQuvWJGCmyQ\",\"MaterialVariantIdentifier\":\"G02-G2\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"39541AFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"FEA6FB030D944DFE892FB349041AA6BF\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-04-23T15:24:00\",\"ProductionDateTimeShort\":\"20250423\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-G2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Forest Green", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Gray")]
        public async Task Gray()
        {
            var json = "{\"SerialNumber\":\"2ACBA3F4\",\"TagManufacturerData\":\"tggEAASXMrXMHFKQ\",\"MaterialVariantIdentifier\":\"G02-D0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"ADB1B2FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"gD6APoQD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"46A63683CF48456AB34DD0CA3B9292F8\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-09-26T18:28:00\",\"ProductionDateTimeShort\":\"20240926\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Gray", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Green")]
        public async Task Green()
        {
            var json = "{\"SerialNumber\":\"CA9719F3\",\"TagManufacturerData\":\"twgEAAQzxL1Vi7WQ\",\"MaterialVariantIdentifier\":\"G02-G0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"00AE42FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ECcQJyADhAMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"42265C737F26404882568D84E8941C05\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-11-06T12:49:00\",\"ProductionDateTimeShort\":\"20241106\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Green", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "LakeBlue")]
        public async Task LakeBlue()
        {
            var json = "{\"SerialNumber\":\"5556EF02\",\"TagManufacturerData\":\"7ggEAAQDSkfov7mQ\",\"MaterialVariantIdentifier\":\"G02-B1\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"1F79E5FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E222372D80D145FCB5C8BDD0ECBAA56D\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-04-19T23:36:00\",\"ProductionDateTimeShort\":\"20250419\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-B1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Lake Blue", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "LimeGreen")]
        public async Task LimeGreen()
        {
            var json = "{\"SerialNumber\":\"3BEF32FC\",\"TagManufacturerData\":\"GggEAAQmgRreZLKQ\",\"MaterialVariantIdentifier\":\"G02-G1\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"6EE53CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"60C9C92E886749F2BD3AA6308FA43AF0\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-15T14:51:00\",\"ProductionDateTimeShort\":\"20250315\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-G1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Lime Green", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Orange")]
        public async Task Orange()
        {
            var json = "{\"SerialNumber\":\"7A4A78FD\",\"TagManufacturerData\":\"tQgEAARg9QhbKzKQ\",\"MaterialVariantIdentifier\":\"G02-A0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"F75403FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"iBOIEyADhAMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"6E9DD5885DF94EEF885326524666DE38\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2024-08-16T16:36:00\",\"ProductionDateTimeShort\":\"20240816\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-A0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Orange", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "PeanutBrown")]
        public async Task PeanutBrown()
        {
            var json = "{\"SerialNumber\":\"1AE0FEFD\",\"TagManufacturerData\":\"+QgEAASn8IlKW7yQ\",\"MaterialVariantIdentifier\":\"G02-N1\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"875718FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"AA48B55F593F494EBE6BD17C3C7123D4\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-08-29T03:19:00\",\"ProductionDateTimeShort\":\"20240828\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-N1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Peanut Brown", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Red")]
        public async Task Red()
        {
            var json = "{\"SerialNumber\":\"13BCB439\",\"TagManufacturerData\":\"IggEAARuuZHZfd6Q\",\"MaterialVariantIdentifier\":\"G02-R0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"BC0900FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"gD6APrwCIAMzM3M/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"438F893561854834B80DBA952A65FFC9\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-12-27T21:07:00\",\"ProductionDateTimeShort\":\"20241227\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-R0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Red", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "White")]
        public async Task White()
        {
            var json = "{\"SerialNumber\":\"AB8820FE\",\"TagManufacturerData\":\"/QgEAASlK66A5p2Q\",\"MaterialVariantIdentifier\":\"G02-W0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"gD6APoQD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"10C8EA05C741481E97F26099CECE068C\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-13T12:38:00\",\"ProductionDateTimeShort\":\"20250313\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-W0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF White", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }

        [Fact(DisplayName = "Yellow")]
        public async Task Yellow()
        {
            var json = "{\"SerialNumber\":\"44B5B3CF\",\"TagManufacturerData\":\"jQgEAARUBAPgd/SQ\",\"MaterialVariantIdentifier\":\"G02-Y0\",\"UniqueMaterialIdentifier\":\"FG02\",\"FilamentType\":\"PETG\",\"DetailedFilamentType\":\"PETG HF\",\"Color\":\"FFD00BFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":65,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":260,\"MinTemperatureForHotend\":230,\"XCamInfo\":\"ECcQJ+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"AF0D48CDB0794FFA97AA982B59F99D2F\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-12-09T10:38:00\",\"ProductionDateTimeShort\":\"20241209\",\"FilamentLength\":325,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"G02-Y0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("HF Yellow", external?.Name);
            Assert.Equal("PETG", external?.Material);
        }
    }
}
