using CHSMonitoring.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CHSMonitoring.Infrastructure.Configuration;

public class StreetConfiguration : IEntityTypeConfiguration<Street>
{
    public void Configure(EntityTypeBuilder<Street> builder)
    {
        builder.ToTable("streets", "dictionaries");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Name)
            .HasMaxLength(150);

        builder.Property(x => x.Description)
            .HasMaxLength(150);
        
        PrepareData(builder);
    }

    public void PrepareData(EntityTypeBuilder<Street> builder)
    {
        var streetEnums = new List<Street>()
        {
            #region Улицы на букву А
            
            new() { Id = Guid.Parse("4B92ACAA-4050-42C3-88F6-CE52FA3B604D"), Name = "Абхазинский", Description = string.Empty },
            new() { Id = Guid.Parse("71EC9F1F-2A7D-4890-ADAE-C977C4CC4F6D"), Name = "Абаканский", Description = string.Empty },
            new() { Id = Guid.Parse("D34EFBD7-CA4E-47F1-BF9D-611638482E2A"), Name = "Абытаевская", Description = string.Empty },
            new() { Id = Guid.Parse("88E098D6-D106-4BF8-A6FA-4E9417EBB8BB"), Name = "Авамский", Description = string.Empty },
            new() { Id = Guid.Parse("51020B54-70BD-41D5-9BE8-3B72C860A1E2"), Name = "Авангардная", Description = string.Empty },
            new() { Id = Guid.Parse("2C22A5F3-4949-49C6-97AE-D1CFD6015394"), Name = "Авиагородок", Description = string.Empty },
            new() { Id = Guid.Parse("9ABD609B-496E-4354-B848-93F83F27237D"), Name = "Авиаторов", Description = string.Empty },
            new() { Id = Guid.Parse("6004E84B-885F-4207-BC87-BA50AA9815CA"), Name = "Авиационная", Description = string.Empty },
            new() { Id = Guid.Parse("F7059F62-7B78-4466-86DC-F098A196C30E"), Name = "Автобусный", Description = string.Empty },
            new() { Id = Guid.Parse("F405128B-C367-4E88-9F3B-100341EC60A6"), Name = "Автомобилистов", Description = string.Empty },
            new() { Id = Guid.Parse("DA7E4C27-DD79-4BB5-8410-17B3A93BD42F"), Name = "Адмирала Макарова", Description = string.Empty },
            new() { Id = Guid.Parse("42CB342A-F5C5-4268-A483-BCD5FAF8BCFB"), Name = "Ады Лебедевой", Description = string.Empty },
            new() { Id = Guid.Parse("65554006-D39A-42E0-BB5E-1E5D7CB38AD9"), Name = "Азовская", Description = string.Empty },
            new() { Id = Guid.Parse("0E935E8D-6948-4BC0-B004-AECB18339CF8"), Name = "Айвазовского", Description = string.Empty },
            new() { Id = Guid.Parse("877FE754-DBE1-4BFB-A139-4CA78C88EE2B"), Name = "Академгородок", Description = string.Empty },
            new() { Id = Guid.Parse("C3C9289F-F743-45D2-98DA-2168F7FD4177"), Name = "Академика Вавилова", Description = string.Empty },
            new() { Id = Guid.Parse("D1634B26-4043-452F-924A-61E8BB1EDDAD"), Name = "Академика Киренского", Description = string.Empty },
            new() { Id = Guid.Parse("ED8B6C97-9793-40E0-9C32-2029D89F46DA"), Name = "Киренского", Description = string.Empty },
            new() { Id = Guid.Parse("C385DAD2-CB71-4045-B62D-AEF9F2652E7B"), Name = "Академика Павлова", Description = string.Empty },
            new() { Id = Guid.Parse("2D429E79-1A28-4626-B987-F42EF2133D00"), Name = "Павлова", Description = string.Empty },
            new() { Id = Guid.Parse("5FCB03C3-BFAC-4FE1-B1C2-080B718264B3"), Name = "Аксеновского", Description = string.Empty },
            new() { Id = Guid.Parse("9666F17C-CEBC-4369-AFF6-26C99A115D38"), Name = "Акционерная", Description = string.Empty },
            new() { Id = Guid.Parse("677A92AD-E011-47A7-A7F0-E20E4E9C2690"), Name = "Александра Матросова", Description = string.Empty },
            new() { Id = Guid.Parse("367A6589-A7F5-4D23-9212-03094C70CE5F"), Name = "Матросова", Description = string.Empty },
            new() { Id = Guid.Parse("F28521A0-4EBA-4D08-A873-4081BB6333A0"), Name = "Александровский", Description = string.Empty },
            new() { Id = Guid.Parse("11EA64E8-1598-49E2-9800-BBFC20BDD274"), Name = "Алексеева", Description = string.Empty },
            new() { Id = Guid.Parse("FCB4186B-BDCA-4BAB-9B44-09355693589E"), Name = "Алексея Асеева", Description = string.Empty },
            new() { Id = Guid.Parse("9192D885-D480-457E-A665-9E55F65B2EE3"), Name = "Алеши Тимошенкова", Description = string.Empty },
            new() { Id = Guid.Parse("801E4F90-8CB9-41B2-9B06-595CD9D0F42D"), Name = "Алтайская", Description = string.Empty },
            new() { Id = Guid.Parse("BB02DA51-9C41-4D96-9EA1-E032F02F6813"), Name = "6-я Алыкельская", Description = string.Empty },
            new() { Id = Guid.Parse("19CE8FCA-3A88-4551-97E0-708339195F73"), Name = "Алыкельская 6-я", Description = string.Empty },
            new() { Id = Guid.Parse("21348C0C-DA30-4883-87DF-F424CA4A8DF6"), Name = "Алюминиевая", Description = string.Empty },
            new() { Id = Guid.Parse("18496668-B982-4EE6-B6C2-33EFA43F1F49"), Name = "Аманатский", Description = string.Empty },
            new() { Id = Guid.Parse("45BBFEB3-134F-4C9F-8AE4-4F2385DFAC20"), Name = "Амурская", Description = string.Empty },
            new() { Id = Guid.Parse("297766AA-5551-4418-B824-930CCD040EA5"), Name = "Анабарская", Description = string.Empty },
            new() { Id = Guid.Parse("0786249C-7911-423E-9DEC-647953EB64F3"), Name = "Анатолия Гладкова", Description = string.Empty },
            new() { Id = Guid.Parse("E8AFCD2C-74EF-4365-B834-213BBCC3E3E8"), Name = "Ангарская", Description = string.Empty },
            new() { Id = Guid.Parse("90730E9C-724D-46BE-9DB1-75BDC7DF3B52"), Name = "Анзельская", Description = string.Empty },
            new() { Id = Guid.Parse("005FE355-AC4F-40BB-B1EA-5069FE2B1189"), Name = "Апрельская", Description = string.Empty },
            new() { Id = Guid.Parse("216E16A4-DD56-4A51-901E-5261B545682F"), Name = "Аральская", Description = string.Empty },
            new() { Id = Guid.Parse("77C5F372-8948-4302-8DF0-7A94ECF2EF66"), Name = "Арейская", Description = string.Empty },
            new() { Id = Guid.Parse("611FB690-E11B-4F5F-923A-34CD7A2280F2"), Name = "Аринская", Description = string.Empty },
            new() { Id = Guid.Parse("8094D270-4744-4182-95A6-97CF9EAE36A1"), Name = "Армейская", Description = string.Empty },
            new() { Id = Guid.Parse("44E8F6FB-A38D-44F2-93C5-E1F24F97C81A"), Name = "Арский", Description = string.Empty },
            new() { Id = Guid.Parse("69B571B6-F9E9-49DE-A57C-0766FAD92856"), Name = "Артемовская", Description = string.Empty },
            new() { Id = Guid.Parse("7BDEA3FA-B183-45E0-B63F-6ABE35119C9E"), Name = "Архангельская", Description = string.Empty },
            new() { Id = Guid.Parse("827E90A1-C262-4078-857C-2D223F2A59B5"), Name = "Астраханская", Description = string.Empty },
            new() { Id = Guid.Parse("C696B1B8-7FFD-4F88-89BA-CD2711EB25B6"), Name = "Атаманская", Description = string.Empty },
            new() { Id = Guid.Parse("E667F1BA-C9DC-458C-86A4-AA3F2AB25332"), Name = "Афонтовский", Description = string.Empty },
            new() { Id = Guid.Parse("509F10A6-2CE4-4926-B870-4DC9B07201B6"), Name = "Ачинский", Description = string.Empty },
            new() { Id = Guid.Parse("5FDEC09D-55E8-4934-AAD1-3BC769CC3D4C"), Name = "Аэровокзальная", Description = string.Empty },
            

            #endregion

            #region Улицы на букву Б

            new() { Id = Guid.Parse("340FDBB0-8771-4032-AF9C-742D76F093D5"), Name = "Бабушкина", Description = string.Empty },
            new() { Id = Guid.Parse("1DA25A69-14BB-46ED-A455-4B207BA423C6"), Name = "Бадалык", Description = string.Empty },
            new() { Id = Guid.Parse("7E3C29F4-AE05-4973-B2C0-3D251C09B415"), Name = "Бадалыкская", Description = string.Empty },
            new() { Id = Guid.Parse("7783C928-3FC1-4657-9EE1-C209E03A3EBB"), Name = "Базайская", Description = string.Empty },
            new() { Id = Guid.Parse("D40EB451-C5A3-43EB-8227-4BB01FA346BD"), Name = "Базарная", Description = string.Empty },
            new() { Id = Guid.Parse("1913B8B2-4349-489B-9FD6-7726F16BA155"), Name = "Байкальская", Description = string.Empty },
            new() { Id = Guid.Parse("790FB554-9455-4B7D-8180-5042FD745B69"), Name = "Байкитская 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("4921FAC3-1AD0-4C75-B58D-4C4DFDB61105"), Name = "1-я Байкитская", Description = string.Empty },
            new() { Id = Guid.Parse("58E4F4F3-E34D-4AF9-BFDA-F79AEC29437C"), Name = "Байкитская 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("3A68611F-3CCA-4179-A108-C74720A8DAD9"), Name = "2-я Байкитская", Description = string.Empty },
            new() { Id = Guid.Parse("3A3B3FDB-D5FA-4870-A04D-F388B8D70D17"), Name = "Балахтинская", Description = string.Empty },
            new() { Id = Guid.Parse("73B989B5-2598-4EAC-B4D2-DC084FBF6D10"), Name = "Бартатский", Description = string.Empty },
            new() { Id = Guid.Parse("F9DD1DD1-7155-47A2-B39A-6838F5439139"), Name = "Батурина", Description = string.Empty },
            new() { Id = Guid.Parse("A75A5913-91FD-42F1-8BBC-0E3CCE879135"), Name = "Баумана", Description = string.Empty },
            new() { Id = Guid.Parse("6BD83066-6D1C-422D-BC47-2EEED0307A83"), Name = "Башиловская", Description = string.Empty },
            new() { Id = Guid.Parse("58357327-651B-48B0-B98D-A148B13CFAD0"), Name = "Бебеля", Description = string.Empty },
            new() { Id = Guid.Parse("F564D2A9-4034-41BD-9D84-1C47370DFC26"), Name = "Бегичева", Description = string.Empty },
            new() { Id = Guid.Parse("5BBDC256-9183-4096-A517-8A02B79DCAB7"), Name = "Белинского", Description = string.Empty },
            new() { Id = Guid.Parse("E0038B19-06B0-46F6-8F0F-A604888A593F"), Name = "Беловежская", Description = string.Empty },
            new() { Id = Guid.Parse("AE589CB2-8A96-4073-8EF4-F1D8AA091B09"), Name = "Белопольского", Description = string.Empty },
            new() { Id = Guid.Parse("F28DB2CC-6807-4F93-B9AB-919CB348997A"), Name = "Белорусская", Description = string.Empty },
            new() { Id = Guid.Parse("CE09C6F4-5DD8-4B8D-B3E2-A2668C72E4AB"), Name = "Беляева", Description = string.Empty },
            new() { Id = Guid.Parse("4A6501E6-2025-4FE8-9904-8515A4BFD495"), Name = "Березина", Description = string.Empty },
            new() { Id = Guid.Parse("44C6E9D7-880E-48AD-A06D-4CE6B4383E79"), Name = "Березовая", Description = string.Empty },
            new() { Id = Guid.Parse("4C5BB0B5-9BE7-415B-9104-796688E74FA3"), Name = "Биатлонная", Description = string.Empty },
            new() { Id = Guid.Parse("1DDA1D20-6987-4DC6-B8CE-5C59D83EEE2D"), Name = "Бийская", Description = string.Empty },
            new() { Id = Guid.Parse("606695E0-F18A-4FD2-A0C1-8835473BF889"), Name = "Бийхемская", Description = string.Empty },
            new() { Id = Guid.Parse("E4FC60FD-D34C-4C28-88E4-8E2250398369"), Name = "Биологов", Description = string.Empty },
            new() { Id = Guid.Parse("1D944DB8-EBD4-4384-93AB-0F0CFB8F7053"), Name = "Бирикчульский", Description = string.Empty },
            new() { Id = Guid.Parse("505CA6DD-C84E-4B12-878E-B46799B20341"), Name = "Бирилюсская", Description = string.Empty },
            new() { Id = Guid.Parse("F9C8D455-F765-495F-89BF-9C1314E89962"), Name = "Бирюсинская", Description = string.Empty },
            new() { Id = Guid.Parse("E098423A-23A0-4CFE-A1AA-F81DB0162A60"), Name = "Благодатная", Description = string.Empty },
            new() { Id = Guid.Parse("76A54C8E-6C8F-40A6-885F-C709D19BB3B4"), Name = "Бобровый", Description = string.Empty },
            new() { Id = Guid.Parse("DADE1DBD-E283-49C1-AEA4-FCCB0CCB8F30"), Name = "Богдана Хмельницкого", Description = string.Empty },
            new() { Id = Guid.Parse("9E11873E-3F64-407E-9E1F-AA5E544F5006"), Name = "Боголеповская", Description = string.Empty },
            new() { Id = Guid.Parse("66730A61-F9C0-40A0-8BD9-872FF6193536"), Name = "Боготольский", Description = string.Empty },
            new() { Id = Guid.Parse("5AD1B114-F218-419A-98F5-A839E6721B0C"), Name = "Бограда", Description = string.Empty },
            new() { Id = Guid.Parse("F0559193-CDA8-4A22-9228-57051322703B"), Name = "Богучанская", Description = string.Empty },
            new() { Id = Guid.Parse("99C9F1C8-8E68-4ECD-83E9-1C92A89074B5"), Name = "Бодрая", Description = string.Empty },
            new() { Id = Guid.Parse("C5B9C252-671E-4C84-AF1B-06AE80D596A4"), Name = "Бойкая", Description = string.Empty },
            new() { Id = Guid.Parse("E03B169C-F2D7-4EB6-906E-8E9EC963BD9E"), Name = "Болдинская", Description = string.Empty },
            new() { Id = Guid.Parse("2578A7C3-4844-49D4-A239-0BA8735D5B91"), Name = "Большегвардейская", Description = string.Empty },
            new() { Id = Guid.Parse("51E0248F-6495-41D7-9ED0-4A14BB2EA9E4"), Name = "Большой", Description = string.Empty },
            new() { Id = Guid.Parse("1586CF47-E0E4-4991-A16A-C0DF09C80AEE"), Name = "Борисевича", Description = string.Empty },
            new() { Id = Guid.Parse("04EE1734-2DB8-44B8-A0F7-209D9E162D02"), Name = "Борисова", Description = string.Empty },
            new() { Id = Guid.Parse("F6D63F44-807A-41AF-A73C-E772BA365E43"), Name = "Боровая 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("D0B017FD-B1E5-468A-8C81-B668AAA41A10"), Name = "1-я Боровая", Description = string.Empty },
            new() { Id = Guid.Parse("227DC29C-6B99-4030-B56A-A4B5BE66FB2E"), Name = "Боровая 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("66C32B42-D699-42AB-B9BC-845E2DC9F8B7"), Name = "2-я Боровая", Description = string.Empty },
            new() { Id = Guid.Parse("93D87292-132F-4E75-913B-FCEA8AE1BD4A"), Name = "Бородинская", Description = string.Empty },
            new() { Id = Guid.Parse("B3AED898-3FAB-46B5-B154-841DD8690660"), Name = "Борьбы", Description = string.Empty },
            new() { Id = Guid.Parse("F5DD4A68-5514-4CED-A399-4F031012FE92"), Name = "Ботаническая", Description = string.Empty },
            new() { Id = Guid.Parse("29FA9049-7868-477E-AD3A-DB2B3C652BD9"), Name = "Ботаническая 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("419D93C1-DDC6-4ADB-BDDE-CD3F724748AE"), Name = "2-я Ботаническая", Description = string.Empty },
            new() { Id = Guid.Parse("FEAEC3BC-29EC-475C-8D9A-C6DFAED079EB"), Name = "Ботаническая 3-я", Description = string.Empty },
            new() { Id = Guid.Parse("B44637A6-8943-4EC0-9C8A-80EB746B9040"), Name = "3-я Ботаническая", Description = string.Empty },
            new() { Id = Guid.Parse("5286F0D9-D604-4F27-BEDD-8A5D36DBBD3F"), Name = "Ботаническая 4-я", Description = string.Empty },
            new() { Id = Guid.Parse("A65F90A6-83D6-42EC-A657-5AA1D7F65F84"), Name = "4-я Ботаническая", Description = string.Empty },
            new() { Id = Guid.Parse("7AAD11B6-5625-4A10-A38C-B6B5E8D87DC2"), Name = "Ботанический", Description = string.Empty },
            new() { Id = Guid.Parse("D71E1701-3F85-4701-AF24-3301977BDC28"), Name = "Боткина", Description = string.Empty },
            new() { Id = Guid.Parse("B201C7EB-6EC0-4285-A16E-325EB29268AF"), Name = "Бохтинский", Description = string.Empty },
            new() { Id = Guid.Parse("EC674EC0-22C8-4329-8180-FEA7F2307A82"), Name = "Братская 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("4B013D92-67BF-4D1C-81AE-CA73C0FA5D0C"), Name = "1-я Братская", Description = string.Empty },
            new() { Id = Guid.Parse("E22CFBCB-EA1B-4467-A5C5-DF4FA68361B9"), Name = "Братская 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("C3444383-2E12-4939-BAF0-274F7292044E"), Name = "2-я Братская", Description = string.Empty },
            new() { Id = Guid.Parse("BE5A29FA-D677-4470-A39E-DD231C296C22"), Name = "Братьев Абалаковых", Description = string.Empty },
            new() { Id = Guid.Parse("A3E7FD67-33F9-4BDF-A7D7-7CAF54D752C4"), Name = "Брестская", Description = string.Empty },
            new() { Id = Guid.Parse("93BA21AA-7E26-467B-AB17-8F7FDF57E07B"), Name = "Брянская", Description = string.Empty },
            new() { Id = Guid.Parse("B302E806-5C81-4A87-99CC-6D9300DDD528"), Name = "Брянская 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("F03D7457-D7E8-4A49-AC01-B4851D2228B3"), Name = "2-я Брянская", Description = string.Empty },
            new() { Id = Guid.Parse("FB6B66C2-6AF2-4E1E-B3D8-AC9F93F405BB"), Name = "Бугачевская", Description = string.Empty },
            new() { Id = Guid.Parse("384AD73D-89B3-42CD-9D8E-69837456D86E"), Name = "Быковского", Description = string.Empty },

            #endregion

            #region Улицы на букву В

            new() { Id = Guid.Parse("E2C49141-255A-42E1-B18A-7D4F0EABF393"), Name = "Васильковый", Description = string.Empty },
            new() { Id = Guid.Parse("22AE9636-F5EF-498E-B7C5-470CF4CD7D60"), Name = "Васнецова", Description = string.Empty },
            new() { Id = Guid.Parse("C3C483F0-D285-4230-9CF4-03F19F1FAC62"), Name = "Ватутина", Description = string.Empty },
            new() { Id = Guid.Parse("D2043CD2-186D-48DE-B4AE-81BA8A9E1206"), Name = "Вейнбаума", Description = string.Empty },
            new() { Id = Guid.Parse("F4EC565E-8462-41D4-8870-249A6DC3CD05"), Name = "Вербная", Description = string.Empty },
            new() { Id = Guid.Parse("AEC15368-AF3F-44AA-8081-487DB6FF9369"), Name = "Верещагина", Description = string.Empty },
            new() { Id = Guid.Parse("F1E27637-29D6-479C-B66D-63529197EA2A"), Name = "Верхняя", Description = string.Empty },
            new() { Id = Guid.Parse("A6117427-D665-4E2A-9A68-BE4CD6A3CAE5"), Name = "Верховая", Description = string.Empty },
            new() { Id = Guid.Parse("804A3DE9-F94A-4133-A457-06ED49AAA8FA"), Name = "Верхотельский", Description = string.Empty },
            new() { Id = Guid.Parse("F751A786-4F95-4B0D-9A42-9E5FE960E1A5"), Name = "Весёлая", Description = string.Empty },
            new() { Id = Guid.Parse("F976C36B-015F-49B2-89B4-1F943FC3C286"), Name = "Веселовская", Description = string.Empty },
            new() { Id = Guid.Parse("581C04DD-2F77-49EE-9B27-F05E16196560"), Name = "Весенняя", Description = string.Empty },
            new() { Id = Guid.Parse("251AC25F-A1D4-4D2F-AEE7-9495BC00C3D7"), Name = "Весны", Description = string.Empty },
            new() { Id = Guid.Parse("37ED781C-690F-4AC7-B0FE-18F4161A55D8"), Name = "Вечерняя", Description = string.Empty },
            new() { Id = Guid.Parse("9B7F5109-7193-4B60-8AAC-FDC9AB7F96F7"), Name = "Вешняя", Description = string.Empty },
            new() { Id = Guid.Parse("826CEEAA-42AC-4564-A424-EF82CF0AA6B0"), Name = "Взлётная", Description = string.Empty },
            new() { Id = Guid.Parse("DC5498CD-1148-4A53-8BBA-55680B6BDD11"), Name = "Вильского", Description = string.Empty },
            new() { Id = Guid.Parse("0754DF01-E4FA-4F47-8BFA-4F3F6AC7A2F8"), Name = "Виражная", Description = string.Empty },
            new() { Id = Guid.Parse("F037DE96-0D1C-4E64-84C0-C3CB8C518304"), Name = "Вишневый", Description = string.Empty },
            new() { Id = Guid.Parse("D0381A9E-2F5D-4D5F-A38D-3A49FCF6FCED"), Name = "Внутриквартальная 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("C7DB5832-B257-4D15-B307-7F2D477EAEF2"), Name = "1-я Внутриквартальная", Description = string.Empty },
            new() { Id = Guid.Parse("FF83B91D-6964-4B11-B0EB-F8F06A5F26F1"), Name = "Внутриквартальная 3-я", Description = string.Empty },
            new() { Id = Guid.Parse("90090D6C-645D-4312-A5E1-32E4593DF52D"), Name = "3-я Внутриквартальная", Description = string.Empty },
            new() { Id = Guid.Parse("B443EE6B-703F-4736-93B3-C933034BB626"), Name = "Водометный", Description = string.Empty },
            new() { Id = Guid.Parse("E02DADA7-2FB1-4F30-A6C7-4B59909355B7"), Name = "Водопьянова", Description = string.Empty },
            new() { Id = Guid.Parse("FAB8D86B-96B3-4A7B-9916-1F2B95B6AD51"), Name = "Водянникова", Description = string.Empty },
            new() { Id = Guid.Parse("A9A0283E-98E3-4F97-8367-AC4F01AA3DD0"), Name = "Возвышенная", Description = string.Empty },
            new() { Id = Guid.Parse("782E3426-6A22-4D3C-B7F9-C2D6F9F566D4"), Name = "Вознесенская", Description = string.Empty },
            new() { Id = Guid.Parse("04111CCC-C822-4456-B55B-F33E9B72930D"), Name = "Возрождения", Description = string.Empty },
            new() { Id = Guid.Parse("97B77775-7221-4D87-92D0-3422E86E89B6"), Name = "Вокзальная", Description = string.Empty },
            new() { Id = Guid.Parse("A8909F83-DFDD-46F0-A3E7-DFC14B921E24"), Name = "Волгоградская", Description = string.Empty },
            new() { Id = Guid.Parse("3BCB9FCA-E200-461E-BE2A-0938367D94C9"), Name = "Волжская", Description = string.Empty },
            new() { Id = Guid.Parse("F74A57DF-0908-4BE0-B17F-65F486A93E85"), Name = "Володнева", Description = string.Empty },
            new() { Id = Guid.Parse("DFE593B6-4AF5-4120-AFE8-1F74C473B753"), Name = "Волочаевская", Description = string.Empty },
            new() { Id = Guid.Parse("E0B03896-498A-44BD-96C0-B4194F14E57D"), Name = "Волочанская", Description = string.Empty },
            new() { Id = Guid.Parse("524A9233-0ACE-4783-80EF-8F8C5431502E"), Name = "Вольный", Description = string.Empty },
            new() { Id = Guid.Parse("08901AD1-684B-4135-AA63-E737F4A6A63A"), Name = "Воровского", Description = string.Empty },
            new() { Id = Guid.Parse("B8AA44B1-9334-4D1F-8318-552B0EFB27FF"), Name = "Воронова", Description = string.Empty },
            new() { Id = Guid.Parse("2C63DF86-59FA-4F2B-B670-A165AE545A34"), Name = "Воскресенская", Description = string.Empty },
            new() { Id = Guid.Parse("9EB4DDBB-11E0-434E-A6B4-035FA401009A"), Name = "Воскресная", Description = string.Empty },
            new() { Id = Guid.Parse("FE277F1F-234C-4295-9C27-D8C5D97A8859"), Name = "Восточная", Description = string.Empty },
            new() { Id = Guid.Parse("E55F1E67-C086-46D7-95AC-F1FDE58ED8B2"), Name = "Восточный", Description = string.Empty },
            new() { Id = Guid.Parse("F9D3DF78-55A7-420F-A57E-C22773E6FA8F"), Name = "Восходная", Description = string.Empty },
            new() { Id = Guid.Parse("E92E506D-4B6F-4123-AC21-5F55805D0381"), Name = "Встречная", Description = string.Empty },
            new() { Id = Guid.Parse("A6CCDE22-2528-449E-808B-BEE9018277E9"), Name = "Вузовский", Description = string.Empty },
            new() { Id = Guid.Parse("2D21530B-3E67-46C3-8705-4357CF8E8872"), Name = "Выборгский", Description = string.Empty },
            new() { Id = Guid.Parse("014BE2A9-8971-47E0-A243-61B6AB83EBE6"), Name = "Высокая", Description = string.Empty },
            new() { Id = Guid.Parse("63BF5104-E343-48F0-AAF0-1A87747FB3E5"), Name = "Высотная", Description = string.Empty },
            new() { Id = Guid.Parse("DF400B70-6F4D-4E8E-A8AB-C466FEFE1226"), Name = "Высоцкого", Description = string.Empty }

            #endregion

            
                       
        };
        
        //TODO: Указать пресет сюда
        builder.HasData(streetEnums);
    }
}