namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Basic")]
    public class PlaBasicTest : BaseTest
    {

        [Fact(DisplayName = "BambuGreen")]
        public async Task BambuGreen()
        {
            var json = "{\"SerialNumber\":\"1AA00D3D\",\"TagManufacturerData\":\"iggEAAR7HEYyfriQ\",\"MaterialVariantIdentifier\":\"A00-G1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"00AE42FF\",\"SpoolWeight\":250,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOIE+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"49DD22DD3B514AA1822966818C0DD0E8\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-04-30T13:44:00\",\"ProductionDateTimeShort\":\"24_04_30_13\",\"FilamentLength\":82,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-G1-1.75-250\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Bambu Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Beige")]
        public async Task Beige()
        {
            var json = "{\"SerialNumber\":\"63B3EB09\",\"TagManufacturerData\":\"MggEAAQUDX4n9RuQ\",\"MaterialVariantIdentifier\":\"A00-P0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"F7E6DEFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"NCEQDugD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"BCD4E95BEDDE403D90786DD74788E117\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-25T07:46:00\",\"ProductionDateTimeShort\":\"24_10_25_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-P0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Beige", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Black")]
        public async Task Black()
        {
            var json = "{\"SerialNumber\":\"227FDD5F\",\"TagManufacturerData\":\"3wgEAATAv+wvQO6Q\",\"MaterialVariantIdentifier\":\"A00-K0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"gD6APugD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"8C7B1BCDC4D0452FBA7659F9BCF768BE\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2023-11-08T07:10:00\",\"ProductionDateTimeShort\":\"23_11_08_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-K0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Black", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }


        [Fact(DisplayName = "Blue Gray")]
        public async Task BlueGrey()
        {
            var json = "{\"SerialNumber\":\"8B6061F9\",\"TagManufacturerData\":\"cwgEAASQLmbT5fOQ\",\"MaterialVariantIdentifier\":\"A00-B1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"5B6579FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBMQDugD6AMAAAA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2AC2E5152E26401494DCA88AD85B95F3\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-15T15:34:00\",\"ProductionDateTimeShort\":\"25_03_15_15\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-B1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Blue Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Bright Green")]
        public async Task BrightGreen()
        {
            var json = "{\"SerialNumber\":\"2B7EF9FD\",\"TagManufacturerData\":\"UQgEAASyvxz3rGmQ\",\"MaterialVariantIdentifier\":\"A00-G3\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"BECF00FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2933EDA39E364658A3971C9F0C5EBFD5\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2025-03-17T11:24:00\",\"ProductionDateTimeShort\":\"20250316\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-G3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Bright Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
        
        [Fact(DisplayName = "Brown")]
        public async Task Brown()
        {
            var json = "{\"SerialNumber\":\"C3E4900A\",\"TagManufacturerData\":\"vQgEAAR3zwvUZxqQ\",\"MaterialVariantIdentifier\":\"A00-N0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"9D432CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"NCEQDugD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"DDCAED64F02F428C81EFB9EA4619F12B\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-28T13:36:00\",\"ProductionDateTimeShort\":\"24_10_28_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-N0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Brown", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "CobaltBlue")]
        public async Task CobaltBlue()
        {
            var json = "{\"SerialNumber\":\"3B1B1AF9\",\"TagManufacturerData\":\"wwgEAARMtla8NoSQ\",\"MaterialVariantIdentifier\":\"A00-B3\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"0056B8FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"5D9FF08DDAFA4EBDB3B55E88635458BB\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-24T12:54:00\",\"ProductionDateTimeShort\":\"25_03_24_12\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-B3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Cobalt Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "CocoaBrown")]
        public async Task CocoaBrown()
        {
            var json = "{\"SerialNumber\":\"14F13AD6\",\"TagManufacturerData\":\"CQgEAAR+MiUh/deQ\",\"MaterialVariantIdentifier\":\"A00-N1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"6F5034FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2E45F10889BE467E80E0659D0862E27A\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-11-22T09:27:00\",\"ProductionDateTimeShort\":\"20241122\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-N1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Cocoa Brown", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Cyan")]
        public async Task Cyan()
        {
            var json = "{\"SerialNumber\":\"04ED6BD0\",\"TagManufacturerData\":\"UggEAATS6+2N1/2Q\",\"MaterialVariantIdentifier\":\"A00-B8\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"0086D6FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOsDegD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"97178E8F886341BC91287EF70CB07C12\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2024-12-03T18:45:00\",\"ProductionDateTimeShort\":\"20241203\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-B8-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Cyan", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "DarkGray")]
        public async Task DarkGray()
        {
            var json = "{\"SerialNumber\":\"A31B0D0A\",\"TagManufacturerData\":\"vwgEAASuCN+DVWqQ\",\"MaterialVariantIdentifier\":\"A00-D3\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"545454FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"ECcQJ4QD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2BCCEC0BEAE246DB8D8ACB0AF1D65362\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-10-19T07:03:00\",\"ProductionDateTimeShort\":\"24_10_19_07\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-D3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Dark Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Gold")]
        public async Task Gold()
        {
            var json = "{\"SerialNumber\":\"FA0B63FE\",\"TagManufacturerData\":\"bAgEAATkuSzVNvyQ\",\"MaterialVariantIdentifier\":\"A00-Y4\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"E4BD68FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0Ac0IegD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"98B03C9420854452867BD955EE8652AB\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-09-06T14:29:00\",\"ProductionDateTimeShort\":\"24_09_06_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-Y4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Gold", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Gray")]
        public async Task Gray()
        {
            var json = "{\"SerialNumber\":\"2CA1BE95\",\"TagManufacturerData\":\"pggEAASefynQJqaQ\",\"MaterialVariantIdentifier\":\"A00-D0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"8E9089FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F679AB50D8B04539981B47A0029A4030\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-01-02T09:33:00\",\"ProductionDateTimeShort\":\"24_01_02_09\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "HotPink")]
        public async Task HotPink()
        {
            var json = "{\"SerialNumber\":\"040311D0\",\"TagManufacturerData\":\"xggEAASEw+YhPCyQ\",\"MaterialVariantIdentifier\":\"A00-R3\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"F5547CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D3335829B5774E998877C42671C4559F\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-11-26T06:51:00\",\"ProductionDateTimeShort\":\"20241125\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-R3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Hot Pink", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "IndigoPurple")]
        public async Task IndigoPurple()
        {
            var json = "{\"SerialNumber\":\"03560B0A\",\"TagManufacturerData\":\"VAgEAARRJ7Nux2+Q\",\"MaterialVariantIdentifier\":\"A00-P2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"482960FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"91809ACF2B04484B9EC9254B5EFD21BA\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-17T03:30:00\",\"ProductionDateTimeShort\":\"20241016\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-P2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Indigo Purple", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "JadeWhite")]
        public async Task JadeWhite()
        {
            var json = "{\"SerialNumber\":\"1AD2A375\",\"TagManufacturerData\":\"HggEAAQiXLK9uCOQ\",\"MaterialVariantIdentifier\":\"A00-W1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"NCGIE/QB6AMAAAA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A4DB2128230A4CBD95231A9F4A3A8B2E\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-07-15T12:00:00\",\"ProductionDateTimeShort\":\"24_07_15_12\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-W1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Jade White", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "LightGray")]
        public async Task LightGray()
        {
            var json = "{\"SerialNumber\":\"35BC3226\",\"TagManufacturerData\":\"nQgEAARpekXxf4iQ\",\"MaterialVariantIdentifier\":\"A00-D2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"D1D3D5FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"gD6APoQD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"5E4B4A28A77F4623BDF1C6932136DD4D\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-29T14:30:00\",\"ProductionDateTimeShort\":\"25_03_29_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-D2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Light Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Magenta")]
        public async Task Magenta()
        {
            var json = "{\"SerialNumber\":\"43F0E009\",\"TagManufacturerData\":\"WggEAARnqQVLjEmQ\",\"MaterialVariantIdentifier\":\"A00-P6\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"EC008CFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"ECeIE+gD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"37BECD559DC24E518DEA0FAB0FFDF0E9\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-11-09T09:45:00\",\"ProductionDateTimeShort\":\"24_11_09_09\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-P6-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Magenta", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "MaroonRed")]
        public async Task MaroonRed()
        {
            var json = "{\"SerialNumber\":\"6591260F\",\"TagManufacturerData\":\"3QgEAARnb/kjE0aQ\",\"MaterialVariantIdentifier\":\"A00-R2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"9D2235FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"37685D2D3A514410AAC2A24425641CAB\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-31T15:06:00\",\"ProductionDateTimeShort\":\"25_03_31_15\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-R2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Maroon Red", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "MistletoeGreen")]
        public async Task MistletoeGreen()
        {
            var json = "{\"SerialNumber\":\"035EDC36\",\"TagManufacturerData\":\"twgEAATPajiC8aeQ\",\"MaterialVariantIdentifier\":\"A00-G2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"3F8E43FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"rA2IEyADhAPNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"2ED5E3161B2B42528EDD9175C772E3AA\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-01-17T14:24:00\",\"ProductionDateTimeShort\":\"25_01_17_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-G2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Mistletoe Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Orange")]
        public async Task Orange()
        {
            var json = "{\"SerialNumber\":\"0308501C\",\"TagManufacturerData\":\"RwgEAARNdLW5veWQ\",\"MaterialVariantIdentifier\":\"A00-A0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"FF6A13FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBMQDugD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"8F4854BCF90D455080DCDE5FD20AD745\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-12-14T16:02:00\",\"ProductionDateTimeShort\":\"24_12_14_16\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-A0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Orange", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Pink")]
        public async Task Pink()
        {
            var json = "{\"SerialNumber\":\"33A24839\",\"TagManufacturerData\":\"4AgEAATw7VQPofOQ\",\"MaterialVariantIdentifier\":\"A00-P1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"F55A74FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"167F2C8C25EF45C4AC398CE78CC0D7FB\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-03-01T13:12:00\",\"ProductionDateTimeShort\":\"25_03_01_13\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-P1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Pink", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "PumpkinOrange")]
        public async Task PumpkinOrange()
        {
            var json = "{\"SerialNumber\":\"1BCF70FE\",\"TagManufacturerData\":\"WggEAASYdLMJJkyQ\",\"MaterialVariantIdentifier\":\"A00-A1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"FF9016FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"09AF2F7892544BE8B3D9A69277A78A92\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-15T12:08:00\",\"ProductionDateTimeShort\":\"20250315\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-A1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Pumpkin Orange", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Purple")]
        public async Task Purple()
        {
            var json = "{\"SerialNumber\":\"15FD0A10\",\"TagManufacturerData\":\"8ggEAASUoVXyDUKQ\",\"MaterialVariantIdentifier\":\"A00-P5\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"5E43B7FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBOsDegD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"B63D7661EA65468185595ED15BD074A9\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2025-02-25T10:22:00\",\"ProductionDateTimeShort\":\"20250224\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-P5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Purple", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Red")]
        public async Task Red()
        {
            var json = "{\"SerialNumber\":\"A486A6D5\",\"TagManufacturerData\":\"UQgEAASkS/XGvPWQ\",\"MaterialVariantIdentifier\":\"A00-R0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"C12E1FFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"9A7AF27577EF40DE8C52EFBE0DBF3F50\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-10-27T10:52:00\",\"ProductionDateTimeShort\":\"24_10_27_10\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-R0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Red", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Silver")]
        public async Task Silver()
        {
            var json = "{\"SerialNumber\":\"5A9D04A9\",\"TagManufacturerData\":\"aggEAASGylBQRvqQ\",\"MaterialVariantIdentifier\":\"A00-D1\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"A6A9AAFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"C9B44D8F2BA34E1F8C2A97791E1D061B\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2024-08-20T14:37:00\",\"ProductionDateTimeShort\":\"24_08_20_14\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-D1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Silver", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "SunflowerYellow")]
        public async Task SunflowerYellow()
        {
            var json = "{\"SerialNumber\":\"55DFC40D\",\"TagManufacturerData\":\"QwgEAAShZBFGX5iQ\",\"MaterialVariantIdentifier\":\"A00-Y2\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"FEC600FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"6575906E814C460A94DB7B28B23BAE58\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2025-03-20T15:54:00\",\"ProductionDateTimeShort\":\"20250319\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-Y2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Sunflower Yellow", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Turquoise")]
        public async Task Turquoise()
        {
            var json = "{\"SerialNumber\":\"6B4C67FD\",\"TagManufacturerData\":\"vQgEAARmiqbV+geQ\",\"MaterialVariantIdentifier\":\"A00-B5\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"00B1B7FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E6182497A856493DAB9711E90B9B01C5\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-02-28T17:56:00\",\"ProductionDateTimeShort\":\"20250228\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-B5-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Turquoise", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Yellow")]
        public async Task Yellow()
        {
            var json = "{\"SerialNumber\":\"15A4BF04\",\"TagManufacturerData\":\"CggEAARxhK+YbWyQ\",\"MaterialVariantIdentifier\":\"A00-Y0\",\"UniqueMaterialIdentifier\":\"FA00\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Basic\",\"Color\":\"F4EE2AFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBMQDugD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"19BCA7CBD5344D1FA0740F7ABAB8CF08\",\"SpoolWidth\":2906,\"ProductionDateTime\":\"2025-04-11T14:10:00\",\"ProductionDateTimeShort\":\"20250410\",\"FilamentLength\":330,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A00-Y0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Yellow", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
