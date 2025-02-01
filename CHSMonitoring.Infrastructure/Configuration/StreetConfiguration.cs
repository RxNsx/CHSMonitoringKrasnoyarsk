﻿using CHSMonitoring.Domain.Entities;
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
            new() { Id = Guid.Parse("DF400B70-6F4D-4E8E-A8AB-C466FEFE1226"), Name = "Высоцкого", Description = string.Empty },

            #endregion

            #region Улицы на букву Г

            new() { Id = Guid.Parse("7419095A-5F27-4A56-9F0B-FD62C1CCD497"), Name = "Гадалова", Description = string.Empty },
            new() { Id = Guid.Parse("61427BA8-56E1-4CB2-A544-701F778F3A19"), Name = "Гайдара", Description = string.Empty },
            new() { Id = Guid.Parse("8E1BE986-F389-45A5-A188-FE29A1CBE7F2"), Name = "Гайдашовка", Description = string.Empty },
            new() { Id = Guid.Parse("DA708040-940A-4CF3-B82F-8A8FD37685A5"), Name = "Гаражный", Description = string.Empty },
            new() { Id = Guid.Parse("FD0615E0-2164-4228-B5B0-C9708FBD5CED"), Name = "Гастелло", Description = string.Empty },
            new() { Id = Guid.Parse("2036B070-16A2-4E11-85CE-90F22848295C"), Name = "Геодезическая", Description = string.Empty },
            new() { Id = Guid.Parse("8088B005-3CCC-4DB3-ADE6-38DBAF22A953"), Name = "Геологическая", Description = string.Empty },
            new() { Id = Guid.Parse("11BFDF0E-9C0D-46F0-9C68-07C4D61285AA"), Name = "Геологическая 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("90279CE9-AF8F-40A7-A78E-2A8A9016C95A"), Name = "2-я Геологическая", Description = string.Empty },
            new() { Id = Guid.Parse("9CD0781D-8078-45EA-BF40-2108647D1074"), Name = "Георгиевская", Description = string.Empty },
            new() { Id = Guid.Parse("73707B16-9962-4F15-B0E5-05E732A267BF"), Name = "Героев Страны", Description = string.Empty },
            new() { Id = Guid.Parse("5C40382D-3015-4F01-8C74-5D488DF33517"), Name = "Героев Чернобыля", Description = string.Empty },
            new() { Id = Guid.Parse("C57CB024-56FB-4925-A288-635F9C7BB1D9"), Name = "Герцена", Description = string.Empty },
            new() { Id = Guid.Parse("01227C2D-CD15-45C0-88F6-7EE23CACFB5E"), Name = "Гипсовая", Description = string.Empty },
            new() { Id = Guid.Parse("6DA13887-DACC-4D78-83D5-58503C986163"), Name = "Гипсовая 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("3824F9E0-40FB-42FF-81C9-0C89B12D24D3"), Name = "1-я Гипсовая", Description = string.Empty },
            new() { Id = Guid.Parse("56401696-C27C-4B34-8CC9-1947D0E1958D"), Name = "Гипсовая 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("6E6ED651-2505-4CB0-91C1-1D79E25F5F64"), Name = "2-я Гипсовая", Description = string.Empty },
            new() { Id = Guid.Parse("BD8C825E-779E-45B9-8A7D-145CF1FF87CB"), Name = "Гипсовая 3-я", Description = string.Empty },
            new() { Id = Guid.Parse("6A8E3753-DC79-41C3-8812-16DCD33EC8CB"), Name = "3-я Гипсовая", Description = string.Empty },
            new() { Id = Guid.Parse("548AD3CB-99E6-4794-8532-27EB0C50E2B5"), Name = "Глинки", Description = string.Empty },
            new() { Id = Guid.Parse("90EA7ACB-B9D6-42DE-B63E-65189209F049"), Name = "Глиняная", Description = string.Empty },
            new() { Id = Guid.Parse("F19025DC-DE4A-4679-9FDF-8F62C7338D3D"), Name = "Говорова", Description = string.Empty },
            new() { Id = Guid.Parse("22898CEE-07F2-4FD5-B22A-E90F9ED6C880"), Name = "Гоголя", Description = string.Empty },
            new() { Id = Guid.Parse("14337323-F01A-4D41-8217-66E4B1B1E0C0"), Name = "Горийский", Description = string.Empty },
            new() { Id = Guid.Parse("3EDB4AB6-9A21-417C-9D4A-26746E251DC2"), Name = "Гористая", Description = string.Empty },
            new() { Id = Guid.Parse("0E1427BB-C662-4DC3-8F20-82DAFD179F1D"), Name = "Горная", Description = string.Empty },
            new() { Id = Guid.Parse("EE772FC7-603A-4694-AB9E-30474453D04A"), Name = "Горького", Description = string.Empty },
            new() { Id = Guid.Parse("B8A52572-76A3-4E0C-AB14-FD4E4944737D"), Name = "Гражданский", Description = string.Empty },
            new() { Id = Guid.Parse("CA3D1978-6AAC-4FDA-9653-CCDBBED7EF67"), Name = "Гранитная", Description = string.Empty },
            new() { Id = Guid.Parse("F439F1DD-DF2B-4F6A-B68C-A26994504EE6"), Name = "Графитная", Description = string.Empty },
            new() { Id = Guid.Parse("D8018E5E-F122-46F6-8F8E-BEEF3B350C73"), Name = "Гремячий 1-й", Description = string.Empty },
            new() { Id = Guid.Parse("6C0E6192-E1AA-4037-9738-18ABF28939EF"), Name = "Гремячий 2-й", Description = string.Empty },
            new() { Id = Guid.Parse("04AFB032-B407-48AF-AE29-5D9E57D05F88"), Name = "Гремячий 3-й", Description = string.Empty },
            new() { Id = Guid.Parse("7A57137E-CCDF-4049-A491-B3C7C6F3C97F"), Name = "Гремячий 4-й", Description = string.Empty },
            new() { Id = Guid.Parse("A47A16A2-4E2F-4816-A4D8-F41D7F5D4E66"), Name = "Грибная", Description = string.Empty },
            new() { Id = Guid.Parse("CBDD14EC-52CB-4775-AB7B-7ED24214B8E3"), Name = "Гросовцев", Description = string.Empty },
            new() { Id = Guid.Parse("75188344-823C-4F8D-8B5E-A2B9200272FE"), Name = "Грунтовая", Description = string.Empty },
            new() { Id = Guid.Parse("05EE08CD-9994-4A98-A374-24C8A4593E1F"), Name = "Грушевая", Description = string.Empty },
            new() { Id = Guid.Parse("8A6BC17A-E58D-4874-9BE3-DDE22FEF29CD"), Name = "Гуляева", Description = string.Empty },
            new() { Id = Guid.Parse("6AD9D174-75C7-4F49-AF31-54648E2D9E17"), Name = "Гусарова", Description = string.Empty },

            #endregion

            #region Улицы на букву Д

            new() { Id = Guid.Parse("727CE5CB-09E4-4544-92F2-24A7930AAE53"), Name = "Дальневосточная", Description = string.Empty },
            new() { Id = Guid.Parse("A28DBD16-44E8-4870-8430-3906FDF80D6C"), Name = "Дальневосточная 3-я", Description = string.Empty },
            new() { Id = Guid.Parse("790EDB22-EBFB-4BE6-B126-511076F1661C"), Name = "3-я Дальневосточная", Description = string.Empty },
            new() { Id = Guid.Parse("22F6F37B-4DF2-41B7-B877-347AF4BA2460"), Name = "Дальневосточная 4-я", Description = string.Empty },
            new() { Id = Guid.Parse("600BBD9A-CBF8-45E0-B7D6-A066B9D4972C"), Name = "4-я Дальневосточная", Description = string.Empty },
            new() { Id = Guid.Parse("AB716A17-0AC9-4CF1-9F3E-476B8A59F58C"), Name = "Дальняя", Description = string.Empty },
            new() { Id = Guid.Parse("3DE48F2D-4442-454C-85E7-0CED2AFB3A62"), Name = "Даурская", Description = string.Empty },
            new() { Id = Guid.Parse("F5AAC9CB-7296-4B40-9FFB-C685A79EC0A0"), Name = "Дачная", Description = string.Empty },
            new() { Id = Guid.Parse("CA23AF25-5795-4745-B753-11530C5CF57F"), Name = "Декабристов", Description = string.Empty },
            new() { Id = Guid.Parse("117EEC35-E9B4-46F4-BF76-AE2FAC4BFDDA"), Name = "Делегатская", Description = string.Empty },
            new() { Id = Guid.Parse("F64991CE-DABF-4B90-9CEC-9AA217950B66"), Name = "Деловая", Description = string.Empty },
            new() { Id = Guid.Parse("F7FE0E36-4FC0-4F71-9B10-86944010C521"), Name = "Видьяна Бедного", Description = string.Empty },
            new() { Id = Guid.Parse("CE021594-03B5-4C2B-A133-5DDF72D84A55"), Name = "Деповская", Description = string.Empty },
            new() { Id = Guid.Parse("492FABD2-8C6D-4356-AC33-EE987B764355"), Name = "Деповский", Description = string.Empty },
            new() { Id = Guid.Parse("F6359F94-D76F-4F17-BE55-9053191C43DE"), Name = "Депутатская 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("FB6250CC-71BC-4BF4-BA8A-9AD9E6E54BCC"), Name = "2-я Депутатская", Description = string.Empty },
            new() { Id = Guid.Parse("F2D17AE0-A6A2-4A67-A27B-4CC7C5CB412C"), Name = "Детская", Description = string.Empty },
            new() { Id = Guid.Parse("A71B41E6-CE2E-43B4-85EA-32E010D01755"), Name = "Джамбульская", Description = string.Empty },
            new() { Id = Guid.Parse("4C41A94F-FC52-4A2D-9FB3-F9E000DF09B4"), Name = "Дзержинского", Description = string.Empty },
            new() { Id = Guid.Parse("34566E06-482E-4651-AE2D-7A8727C05D0E"), Name = "Дивная", Description = string.Empty },
            new() { Id = Guid.Parse("701374D0-C37F-475C-B567-7B47F326AD7B"), Name = "Дивногорская", Description = string.Empty },
            new() { Id = Guid.Parse("083EA217-6621-405D-9955-421DF85C05B1"), Name = "Диксона", Description = string.Empty },
            new() { Id = Guid.Parse("37EBF339-EF7A-4C75-82FD-1AD1F93FA8AB"), Name = "Диктатуры Пролетариата", Description = string.Empty },
            new() { Id = Guid.Parse("9830FC00-445B-408D-97DF-1D1FA7979CB8"), Name = "Димитрова", Description = string.Empty },
            new() { Id = Guid.Parse("2B0B43D2-8E10-4AA1-9B69-26EA57261508"), Name = "Дмитрия Мартынова", Description = string.Empty },
            new() { Id = Guid.Parse("CFC46B3F-65AB-4BE6-AFC1-A6BEE6F575C3"), Name = "Днепропетровская 1-я", Description = string.Empty },
            new() { Id = Guid.Parse("B6D8125B-72A7-4887-A656-476E46AF5C0D"), Name = "1-я Днепропетровская", Description = string.Empty },
            new() { Id = Guid.Parse("443678F2-CDFE-487D-89CB-1CA0300AA2E0"), Name = "Днепропетровская 2-я", Description = string.Empty },
            new() { Id = Guid.Parse("286C8B7A-33A2-4BD1-B146-C9CA070BCC79"), Name = "2-я Днепропетровская", Description = string.Empty },
            new() { Id = Guid.Parse("BAC1D176-93CE-4F9A-ADA6-3D580EE79E94"), Name = "Добролюбова", Description = string.Empty },
            new() { Id = Guid.Parse("7663B13F-672F-4E3E-83A7-05A7A87A428A"), Name = "Дозорная", Description = string.Empty },
            new() { Id = Guid.Parse("43B59854-BCE6-4C63-850D-DC89813B0FF0"), Name = "Докучаева", Description = string.Empty },
            new() { Id = Guid.Parse("6416DE38-07E0-40DD-AD3C-14D9E20F6B5C"), Name = "Донецкая", Description = string.Empty },
            new() { Id = Guid.Parse("C5B42127-41F5-465D-A728-B63890835CAC"), Name = "Дорожная", Description = string.Empty },
            new() { Id = Guid.Parse("B4871F29-3698-4D2A-891F-C1487C84566A"), Name = "Достоевского", Description = string.Empty },
            new() { Id = Guid.Parse("692AE3CB-FE4E-4C2C-978F-8BD9AD8D568F"), Name = "Дрокинская", Description = string.Empty },
            new() { Id = Guid.Parse("4E9D1B76-2014-4896-967E-FDA98F7C6BAE"), Name = "Дружбы", Description = string.Empty },
            new() { Id = Guid.Parse("0CA119E7-E5FB-4C4E-8BE2-8C06233C269E"), Name = "Дружный", Description = string.Empty },
            new() { Id = Guid.Parse("5B92CBEB-1A3E-4032-A777-F61E36081208"), Name = "Дубенского", Description = string.Empty },
            new() { Id = Guid.Parse("D4EA9F1E-0BC6-4A35-BDE5-87ACD90FD493"), Name = "Дубровинского", Description = string.Empty },
            new() { Id = Guid.Parse("9A3D9937-9B4B-46A4-BE59-367D88609001"), Name = "Дудинская", Description = string.Empty },
            new() { Id = Guid.Parse("0A2409AD-9141-4E9D-87B3-6F88070C7766"), Name = "Дюнная", Description = string.Empty },

            #endregion

            #region Улицы на букву Е

            new() { Id = Guid.Parse("463927C0-D96C-40F3-B782-646A1E58EE55"), Name = "Елены Стасовой", Description = string.Empty },
            new() { Id = Guid.Parse("DD219A0A-B755-4188-9A20-DB66D7AE5F54"), Name = "Еловая", Description = string.Empty },
            new() { Id = Guid.Parse("82D87217-FE17-46EF-8187-A81A44586C9B"), Name = "Емельяновская", Description = string.Empty },
            new() { Id = Guid.Parse("542750FE-A977-46C3-8FCD-AB329EDE3A09"), Name = "Енисейская", Description = string.Empty },
            new() { Id = Guid.Parse("D6916773-59E0-4DA3-886B-070FEED55E00"), Name = "Енисейский тракт", Description = string.Empty },
            new() { Id = Guid.Parse("35AB97B9-E392-48B4-A625-F6E9DC22DDF0"), Name = "Ермаковская", Description = string.Empty },
            new() { Id = Guid.Parse("8E702617-348D-485E-8203-0A66EB845F4A"), Name = "Ерофеевская", Description = string.Empty },
            new() { Id = Guid.Parse("7A02219B-0B20-4653-9AF3-FFC3C8EB3335"), Name = "Есаульская", Description = string.Empty },

            #endregion

            #region Улицы на букву Ж

            new() { Id = Guid.Parse("A18CAAE0-79A5-4DF6-87C5-8C0757BB6243"), Name = "Жарковая", Description = string.Empty },
            new() { Id = Guid.Parse("233F2119-4A39-49CC-9B3F-7B84E0364C6D"), Name = "Жданова", Description = string.Empty },
            new() { Id = Guid.Parse("4F34D258-2E06-4AE2-B4D4-2E211C0AE096"), Name = "Железнодорожников", Description = string.Empty },
            new() { Id = Guid.Parse("CBC20EB0-7F0F-4C4F-9E8D-537B7E4DC3B2"), Name = "Желябова", Description = string.Empty },
            new() { Id = Guid.Parse("502A2BD5-E59D-4D13-9362-CED3BF3146FF"), Name = "Жемчужная", Description = string.Empty },
            new() { Id = Guid.Parse("FE4AAE70-84B8-4953-9F1A-B99A43B9FA14"), Name = "Живица", Description = string.Empty },
            new() { Id = Guid.Parse("64B3703F-DB62-4C67-A2D9-09C3ED986B5C"), Name = "Живописная", Description = string.Empty },
            new() { Id = Guid.Parse("313212E3-BC52-49CF-94E6-DD64B213C6AC"), Name = "Жуковского", Description = string.Empty },


            #endregion
                       
            #region Улицы на букву З
            
            new() { Id = Guid.Parse("9B29312F-0BC4-4ADB-8C5E-3B1BBD4A470A"), Name = "Забобонова", Description = string.Empty },
            new() { Id = Guid.Parse("43215DB8-295D-498B-B83D-0B6BB1D20BB7"), Name = "Заводская", Description = string.Empty },
            new() { Id = Guid.Parse("DF954BC7-5B50-484B-B499-2F3D64176B91"), Name = "Заводской", Description = string.Empty },
            new() { Id = Guid.Parse("4DE053D0-09A2-4DC0-B3A4-481D34EB32D8"), Name = "Заводской", Description = string.Empty },
            new() { Id = Guid.Parse("CEF5B07A-E12C-47FC-842B-B0FA00F7C69B"), Name = "Загородная", Description = string.Empty },
            new() { Id = Guid.Parse("25A84F65-DF49-4E6E-B39A-146C7728029A"), Name = "Загорская", Description = string.Empty },
            new() { Id = Guid.Parse("57989A50-98B4-4414-8937-F46FE9AD7851"), Name = "Заливной", Description = string.Empty },
            new() { Id = Guid.Parse("A4D35619-446B-465F-AA40-EFDC1BD59E9A"), Name = "Западная", Description = string.Empty },
            new() { Id = Guid.Parse("ECD89E49-6877-4D0C-BADA-B58BCCF4DC36"), Name = "Заповедный", Description = string.Empty },
            new() { Id = Guid.Parse("FB67C6CB-624A-42F2-B0CF-174EB33D358D"), Name = "Запорожская", Description = string.Empty },
            new() { Id = Guid.Parse("EA33F4DC-97D7-4D65-98BD-A1415F4C87CD"), Name = "Заречная", Description = string.Empty },
            new() { Id = Guid.Parse("6E501FEE-4FB1-432E-9825-64960541E34D"), Name = "Зарничная", Description = string.Empty },
            new() { Id = Guid.Parse("C3C0AF7E-A1AC-4B68-93E0-653B0F15D810"), Name = "Затонская", Description = string.Empty },
            new() { Id = Guid.Parse("43482993-BF8E-4796-81F3-DB881866F3D2"), Name = "Затонский 1-й", Description = string.Empty },
            new() { Id = Guid.Parse("C4084716-30BD-4B2A-913A-8716342A0A16"), Name = "Затонский 2-й", Description = string.Empty },
            new() { Id = Guid.Parse("725BA835-46A6-4F29-9BDF-D317E347DF13"), Name = "Затонский 3-й", Description = string.Empty },
            new() { Id = Guid.Parse("706B8DE0-A5A4-4045-ABBB-60BECAA4B285"), Name = "Защитников Ленинграда", Description = string.Empty },
            new() { Id = Guid.Parse("A9FC31EE-D7E1-4233-979F-87D4B6426147"), Name = "Зелёный", Description = string.Empty },
            new() { Id = Guid.Parse("83DB9744-AFD9-4BB8-81FA-1D95FF3F8291"), Name = "Знаменская", Description = string.Empty },
            new() { Id = Guid.Parse("2961E17C-2326-481D-9A2F-35F9C15CCDC0"), Name = "Зои Космодемьянской", Description = string.Empty },

            
            #endregion

            #region Улицы на букву И

            new() { Id = Guid.Parse("1C7C40F9-2A28-4380-8EAA-95B59CE2BD08"), Name = "Ивченко", Description = string.Empty },
            new() { Id = Guid.Parse("DC2176F3-A724-479D-BB53-04304173F643"), Name = "Игарская", Description = string.Empty },
            new() { Id = Guid.Parse("E66C9927-EFF9-4B63-8E2A-EFD11C31C671"), Name = "Извилистая", Description = string.Empty },
            new() { Id = Guid.Parse("C0C35655-3166-4928-905F-4CC93F3C59FE"), Name = "Измайлова", Description = string.Empty },
            new() { Id = Guid.Parse("C3F4E1FB-1941-43D8-85A4-081E0C48692F"), Name = "Изумрудная", Description = string.Empty },
            new() { Id = Guid.Parse("AF7471C4-A5DD-4A19-B72C-D4777D7FC874"), Name = "Изыскательский", Description = string.Empty },
            new() { Id = Guid.Parse("048CE447-6EC7-4F05-8025-78131E053854"), Name = "Иланская", Description = string.Empty },
            new() { Id = Guid.Parse("E9D28F8E-B55C-4105-ACFE-C05E75259E0A"), Name = "Имбежский", Description = string.Empty },
            new() { Id = Guid.Parse("AF1BC1EE-15EE-4D7D-A71C-3FB1873B1D8C"), Name = "Красноярский Рабочий", Description = string.Empty },
            new() { Id = Guid.Parse("3657CA63-916E-4A65-A237-6A7D2653D5ED"), Name = "Пионерская Правда", Description = string.Empty },
            new() { Id = Guid.Parse("9FC51095-5ECD-41EB-8186-B4AA3310B0A5"), Name = "Я.М. Свердлова", Description = string.Empty },
            new() { Id = Guid.Parse("EEA0C393-F14B-4B98-9593-55DFAADA78A5"), Name = "Индустриальный 1-й", Description = string.Empty },
            new() { Id = Guid.Parse("4DF4C315-DED2-40E6-A851-E43DAB3B8ED9"), Name = "Индустриальный 2-й", Description = string.Empty },
            new() { Id = Guid.Parse("E32A7E68-D550-44D0-B773-19BC2E4B04D8"), Name = "Инженерный", Description = string.Empty },
            new() { Id = Guid.Parse("2178D974-2EB3-4357-8D81-598A6299E322"), Name = "Инициаторов", Description = string.Empty },
            new() { Id = Guid.Parse("734E1C0D-B6D4-450D-A0A1-9805E3C0ABFE"), Name = "Инструментальная", Description = string.Empty },
            new() { Id = Guid.Parse("C0890C99-6B85-4C2A-8B58-967B37BC0FD0"), Name = "Интернациональная", Description = string.Empty },
            new() { Id = Guid.Parse("41019E5D-96D0-441C-8FEB-0AE7F205C88F"), Name = "Ипподром", Description = string.Empty },
            new() { Id = Guid.Parse("D9D657E5-6124-45AC-83B7-1D7DE2BC0AE2"), Name = "Ирбейская", Description = string.Empty },
            new() { Id = Guid.Parse("42D6BE8F-3D1D-44C1-9669-F1AF6981045E"), Name = "Иркутская", Description = string.Empty },
            new() { Id = Guid.Parse("28DF51DE-A55A-4B6F-A074-42C144E507B3"), Name = "Иртышская", Description = string.Empty },
            new() { Id = Guid.Parse("E18ACC51-4936-44B5-9CB7-8EB85AC314F3"), Name = "Историческая", Description = string.Empty },
            new() { Id = Guid.Parse("C2D8BB06-9B55-4365-A530-8E8D54A47AE7"), Name = "Ишимская", Description = string.Empty },


            #endregion
        };
        
        //TODO: Указать пресет сюда
        builder.HasData(streetEnums);
    }
}