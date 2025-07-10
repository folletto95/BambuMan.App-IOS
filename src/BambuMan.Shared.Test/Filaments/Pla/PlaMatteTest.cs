namespace BambuMan.Shared.Test.Filaments.Pla
{
    [Trait("Category", "PLA Matte")]
    public class PlaMatteTest : BaseTest
    {
        [Fact(DisplayName = "Apple Green")]
        public async Task AppleGreen()
        {
            var json = "{\"SerialNumber\":\"357E1706\",\"TagManufacturerData\":\"WggEAARc7tN1XoSQ\",\"MaterialVariantIdentifier\":\"A01-G0\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"C2E189FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"17FDC6E68CFC45058A2AF5AE6F27653B\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-04-16T15:44:00\",\"ProductionDateTimeShort\":\"20250416\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-G0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Apple Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Ash Gray")]
        public async Task AshGrey()
        {
            var json = "{\"SerialNumber\":\"748595D1\",\"TagManufacturerData\":\"tQgEAASAPzcx9nuQ\",\"MaterialVariantIdentifier\":\"A01-D3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"9B9EA0FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"1EAEE8657F004A69A690F1A6F59B689A\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-12-06T23:33:00\",\"ProductionDateTimeShort\":\"A2412060258\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-D3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Ash Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Bone White")]
        public async Task BoneWhite()
        {
            var json = "{\"SerialNumber\":\"05DFFA24\",\"TagManufacturerData\":\"BAgEAAR2cEquIx6Q\",\"MaterialVariantIdentifier\":\"A01-W3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"CBC6B8FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"D169672E9E364723A6795AB072C486C8\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-04-13T10:18:00\",\"ProductionDateTimeShort\":\"25_04_13_10\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-W3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Bone White", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Caramel")]
        public async Task Caramel()
        {
            var json = "{\"SerialNumber\":\"0B4AE5F9\",\"TagManufacturerData\":\"XQgEAARkxeHDbpyQ\",\"MaterialVariantIdentifier\":\"A01-N3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"AE835BFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F3E0C0D020D84D8DA607E612D698DE99\",\"SpoolWidth\":6625,\"ProductionDateTime\":\"2025-04-13T20:49:00\",\"ProductionDateTimeShort\":\"25_04_13_20\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-N3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Caramel", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Charcoal")]
        public async Task Charcoal()
        {
            var json = "{\"SerialNumber\":\"2B581FF9\",\"TagManufacturerData\":\"lQgEAATSTvUucDiQ\",\"MaterialVariantIdentifier\":\"A01-K1\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"000000FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"pDiIE+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A73D7DE4374B4786BDD2D4805E46BB2D\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2025-03-17T19:03:00\",\"ProductionDateTimeShort\":\"25_03_17_19\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-K1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Charcoal", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "DarkBlue")]
        public async Task DarkBlue()
        {
            var json = "{\"SerialNumber\":\"AA2336E1\",\"TagManufacturerData\":\"XggEAARIEKfohfeQ\",\"MaterialVariantIdentifier\":\"A01-B6\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"042F56FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"rA2sDegD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"CC14702CD5FE4A769AC0AC6DE9939C92\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-07-05T09:37:00\",\"ProductionDateTimeShort\":\"A2407040453\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-B6-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Dark Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Dark Brown")]
        public async Task DarkBrown()
        {
            var json = "{\"SerialNumber\":\"AB642BFF\",\"TagManufacturerData\":\"GwgEAAQepzMgCRyQ\",\"MaterialVariantIdentifier\":\"A01-N2\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"7D6556FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AeIE+gD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"A3122E998A7949779785E9447CA2D6E8\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-02-18T13:00:00\",\"ProductionDateTimeShort\":\"A2502180015\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-N2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Dark Brown", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Dark Chocolate")]
        public async Task DarkChocolate()
        {
            var json = "{\"SerialNumber\":\"A468BDD5\",\"TagManufacturerData\":\"pAgEAAQX52ceOt6Q\",\"MaterialVariantIdentifier\":\"A01-N0\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"4D3324FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"42E034DD102C4F21A82C617AC952A7A8\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-20T06:24:00\",\"ProductionDateTimeShort\":\"20241019\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-N0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Dark Chocolate", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Dark Green")]
        public async Task DarkGreen()
        {
            var json = "{\"SerialNumber\":\"2A325CFD\",\"TagManufacturerData\":\"uQgEAARhE3k6SgaQ\",\"MaterialVariantIdentifier\":\"A01-G7\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"68724DFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBM0IegD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"191209A8F32F4232876027C6A50B355B\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-08-24T20:37:00\",\"ProductionDateTimeShort\":\"A2408240223\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-G7-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Dark Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Dark Red")]
        public async Task DarkRed()
        {
            var json = "{\"SerialNumber\":\"8AAED83D\",\"TagManufacturerData\":\"wQgEAAR/EjWtKhqQ\",\"MaterialVariantIdentifier\":\"A01-R4\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"BB3D43FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AeIE+gD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"FC659983661648FABF6F7CAA53B31308\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-04-19T10:54:00\",\"ProductionDateTimeShort\":\"A2404190053\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-R4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Dark Red", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Desert Tan")]
        public async Task DesertTan()
        {
            var json = "{\"SerialNumber\":\"65751626\",\"TagManufacturerData\":\"IAgEAARUdIGn7XmQ\",\"MaterialVariantIdentifier\":\"A01-Y3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"E8DBB7FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"ECcQJ4QD6ANmZmY/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"79141305C58B4F1FA85C5FF1C9DE1F35\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2025-04-03T17:07:00\",\"ProductionDateTimeShort\":\"25_04_03_17\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-Y3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Desert Tan", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Grass Green")]
        public async Task GrassGreen()
        {
            var json = "{\"SerialNumber\":\"1A73D7FE\",\"TagManufacturerData\":\"QAgEAAQxJrXWwF+Q\",\"MaterialVariantIdentifier\":\"A01-G1\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"61C680FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6APNzEw/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"ED9D6F98175A4513BCC12A6C4C00D4C1\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2024-10-24T15:16:00\",\"ProductionDateTimeShort\":\"24_10_24_15\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-G1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Grass Green", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Ice Blue")]
        public async Task IceBlue()
        {
            var json = "{\"SerialNumber\":\"1A22DBEF\",\"TagManufacturerData\":\"DAgEAATI5dNfHGaQ\",\"MaterialVariantIdentifier\":\"A01-B4\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"A3D8E1FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBMQDugD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"089B6CB441AC48B7A0CC96A218FD512A\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-07-30T11:15:00\",\"ProductionDateTimeShort\":\"A2407290558\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-B4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Ice Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Ivory White")]
        public async Task IvoryWhite()
        {
            var json = "{\"SerialNumber\":\"4A38F2B4\",\"TagManufacturerData\":\"NAgEAASwMD7hry+Q\",\"MaterialVariantIdentifier\":\"A01-W2\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"FFFFFFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":1,\"BedTemperature\":35,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMAAIA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"849A7752F623496C823393049EF29F94\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-06-23T20:33:00\",\"ProductionDateTimeShort\":\"A2406230215\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-W2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Ivory White", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Latte Brown")]
        public async Task LatteBrown()
        {
            var json = "{\"SerialNumber\":\"75633E03\",\"TagManufacturerData\":\"KwgEAASqx14UwTOQ\",\"MaterialVariantIdentifier\":\"A01-N1\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"D3B7A7FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"ECcQDugD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"0BED5CBA88C94CDA8635A1C6BCA35667\",\"SpoolWidth\":1536,\"ProductionDateTime\":\"2025-04-23T19:20:00\",\"ProductionDateTimeShort\":\"25_04_23_19\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-N1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Latte Brown", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Lemon Yellow")]
        public async Task LemonYellow()
        {
            var json = "{\"SerialNumber\":\"6510FF0D\",\"TagManufacturerData\":\"hwgEAASH7K+UBvCQ\",\"MaterialVariantIdentifier\":\"A01-Y2\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"F7D959FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"699201DB49BD42BCBDE435AFB7173B49\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-03-23T01:13:00\",\"ProductionDateTimeShort\":\"A2503220424\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-Y2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Lemon Yellow", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Lilac Purple")]
        public async Task LilacPurple()
        {
            var json = "{\"SerialNumber\":\"142E1901\",\"TagManufacturerData\":\"IggEAATLEWYlHrqQ\",\"MaterialVariantIdentifier\":\"A01-P4\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"AE96D4FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBMQDugD6AMAAAA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E15E2B670F0F4012A64FD1BC66FB2CEB\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-11-13T13:40:00\",\"ProductionDateTimeShort\":\"A2411110084\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-P4-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Lilac Purple", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Mandarin Orange")]
        public async Task MandarinOrange()
        {
            var json = "{\"SerialNumber\":\"05091505\",\"TagManufacturerData\":\"HAgEAAQMxmoHFPKQ\",\"MaterialVariantIdentifier\":\"A01-A2\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"F99963FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMAAAA/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"3A5B1C9B2390453E9C9DE2204C583A2A\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-04-03T23:26:00\",\"ProductionDateTimeShort\":\"A2504030409\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-A2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Mandarin Orange", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Marine Blue")]
        public async Task MarineBlue()
        {
            var json = "{\"SerialNumber\":\"14519900\",\"TagManufacturerData\":\"3AgEAAT8Sit4dbaQ\",\"MaterialVariantIdentifier\":\"A01-B3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"0078BFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"0AfQB+gD6AMzMzM/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"E8BDEEFBD90E42F3A39749758170A503\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2024-11-11T11:49:00\",\"ProductionDateTimeShort\":\"A2411110054\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-B3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Marine Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Nardo Gray")]
        public async Task NardoGray()
        {
            var json = "{\"SerialNumber\":\"AB95EBF6\",\"TagManufacturerData\":\"IwgEAASXoYN52iWQ\",\"MaterialVariantIdentifier\":\"A01-D0\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"757575FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"DAE9B9DEA4F8429DBA29CB93FC58EE73\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2025-03-24T01:56:00\",\"ProductionDateTimeShort\":\"20250323\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-D0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Nardo Gray", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Plum")]
        public async Task Plum()
        {
            var json = "{\"SerialNumber\":\"249EC9D4\",\"TagManufacturerData\":\"pwgEAATCg2NJ3sWQ\",\"MaterialVariantIdentifier\":\"A01-R3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"950051FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"6E158D7A56794C6DA7F7C16B1AD7E1C8\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-27T03:06:00\",\"ProductionDateTimeShort\":\"20241026\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-R3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Plum", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Sakura Pink")]
        public async Task SakuraPink()
        {
            var json = "{\"SerialNumber\":\"2561CB0E\",\"TagManufacturerData\":\"gQgEAAQ89oGEJDiQ\",\"MaterialVariantIdentifier\":\"A01-P3\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"E8AFCFFF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"EE911ADEF0BA4BF8B39889A80BC941DE\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-03-20T11:33:00\",\"ProductionDateTimeShort\":\"A2503200087\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-P3-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Sakura Pink", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Scarlet Red")]
        public async Task ScarletRed()
        {
            var json = "{\"SerialNumber\":\"5B1198FF\",\"TagManufacturerData\":\"LQgEAATQqugcfWCQ\",\"MaterialVariantIdentifier\":\"A01-R1\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"DE4343FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"iBPQB+gD6AOamRk/\",\"NozzleDiameter\":0.2,\"TrayUid\":\"F855D70A115044979F25401ADD7675C0\",\"SpoolWidth\":1149,\"ProductionDateTime\":\"2025-02-10T00:53:00\",\"ProductionDateTimeShort\":\"A2502090390\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-R1-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Scarlet Red", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Sky Blue")]
        public async Task SkyBlue()
        {
            var json = "{\"SerialNumber\":\"E4B54FD5\",\"TagManufacturerData\":\"ywgEAARm5VfOHoaQ\",\"MaterialVariantIdentifier\":\"A01-B0\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"56B7E6FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"02F47CCD2CED41D08F455B85E98ECEBD\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-26T13:30:00\",\"ProductionDateTimeShort\":\"20241026\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-B0-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Sky Blue", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }

        [Fact(DisplayName = "Terracotta")]
        public async Task Terracotta()
        {
            var json = "{\"SerialNumber\":\"5A5DB9F4\",\"TagManufacturerData\":\"SggEAAS0P6C7ZVSQ\",\"MaterialVariantIdentifier\":\"A01-R2\",\"UniqueMaterialIdentifier\":\"FA01\",\"FilamentType\":\"PLA\",\"DetailedFilamentType\":\"PLA Matte\",\"Color\":\"B15533FF\",\"SpoolWeight\":1000,\"FilamentDiameter\":1.75,\"DryingTemperature\":55,\"DryingTime\":8,\"BedTemperatureType\":0,\"BedTemperature\":0,\"MaxTemperatureForHotend\":230,\"MinTemperatureForHotend\":190,\"XCamInfo\":\"AAAAAAAAAAAAAAAA\",\"NozzleDiameter\":0.2,\"TrayUid\":\"41EAFD1C41E3409ABBDECC92B637127C\",\"SpoolWidth\":666,\"ProductionDateTime\":\"2024-10-13T18:38:00\",\"ProductionDateTimeShort\":\"20241013\",\"FilamentLength\":315,\"FormatIdentifier\":2,\"ColorCount\":1,\"SecondColor\":\"00000000\",\"SkuStart\":\"A01-R2-1.75-1000\"}";

            var (_, external) = await GetExternalFilament(json);
            
            Assert.Equal("Matte Terracotta", external?.Name);
            Assert.Equal("PLA", external?.Material);
        }
    }
}
