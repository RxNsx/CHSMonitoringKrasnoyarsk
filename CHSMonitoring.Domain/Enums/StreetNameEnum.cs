using System.ComponentModel;
using CHSMonitoring.Infrastructure.Attributes;

namespace CHSMonitoring.Infrastructure.Models.Enums;

public enum StreetNameEnum
{
    #region Улицы на букву A
    
    [Description("Абазинский")]
    [EnumGuid("4B92ACAA-4050-42C3-88F6-CE52FA3B604D")]
    Abazinskiy,

    [Description("Абаканский")]
    [EnumGuid("71EC9F1F-2A7D-4890-ADAE-C977C4CC4F6D")]
    Abakanskiy,

    [Description("Абытаевская")]
    [EnumGuid("D34EFBD7-CA4E-47F1-BF9D-611638482E2A")]
    Abytaevskaya,

    [Description("Авамский")]
    [EnumGuid("88E098D6-D106-4BF8-A6FA-4E9417EBB8BB")]
    Avamskiy,

    [Description("Авангардная")]
    [EnumGuid("51020B54-70BD-41D5-9BE8-3B72C860A1E2")]
    Avangardnaya,

    [Description("Авиагородок")]
    [EnumGuid("2C22A5F3-4949-49C6-97AE-D1CFD6015394")]
    Aviogorodok,

    [Description("Авиаторов")]
    [EnumGuid("9ABD609B-496E-4354-B848-93F83F27237D")]
    Aviatory,

    [Description("Авиационная")]
    [EnumGuid("6004E84B-885F-4207-BC87-BA50AA9815CA")]
    Aviatsionnaya,

    [Description("Автобусный")]
    [EnumGuid("F7059F62-7B78-4466-86DC-F098A196C30E")]
    Avtobusnyy,

    [Description("Автомобилистов")]
    [EnumGuid("F405128B-C367-4E88-9F3B-100341EC60A6")]
    Avtomobilistov,

    [Description("Адмирала Макарова")]
    [EnumGuid("DA7E4C27-DD79-4BB5-8410-17B3A93BD42F")]
    AdmiralaMakarova,

    [Description("Ады Лебедевой")]
    [EnumGuid("42CB342A-F5C5-4268-A483-BCD5FAF8BCFB")]
    AdyLebedevoi,

    [Description("Азовская")]
    [EnumGuid("65554006-D39A-42E0-BB5E-1E5D7CB38AD9")]
    Azovskaya,

    [Description("Айвазовского")]
    [EnumGuid("0E935E8D-6948-4BC0-B004-AECB18339CF8")]
    Ayvazovskogo,

    [Description("Академгородок")]
    [EnumGuid("877FE754-DBE1-4BFB-A139-4CA78C88EE2B")]
    Akademgorodok,

    [Description("Академика Вавилова")]
    [EnumGuid("C3C9289F-F743-45D2-98DA-2168F7FD4177")]
    AkademikaVavilova,

    [Description("Академика Киренского")]
    [EnumGuid("D1634B26-4043-452F-924A-61E8BB1EDDAD")]
    AkademikaKirenskogo,

    [Description("Киренского")]
    [EnumGuid("ED8B6C97-9793-40E0-9C32-2029D89F46DA")]
    Kirenskogo,

    [Description("Академика Павлова")]
    [EnumGuid("C385DAD2-CB71-4045-B62D-AEF9F2652E7B")]
    AkademikaPavlova,

    [Description("Павлова")]
    [EnumGuid("2D429E79-1A28-4626-B987-F42EF2133D00")]
    Pavlova,

    [Description("Аксеновского")]
    [EnumGuid("5FCB03C3-BFAC-4FE1-B1C2-080B718264B3")]
    Aksenovskogo,

    [Description("Акционерная")]
    [EnumGuid("9666F17C-CEBC-4369-AFF6-26C99A115D38")]
    Aktsionernaya,

    [Description("Александра Матросова")]
    [EnumGuid("677A92AD-E011-47A7-A7F0-E20E4E9C2690")]
    AleksandraMatrosova,

    [Description("Матросова")]
    [EnumGuid("367A6589-A7F5-4D23-9212-03094C70CE5F")]
    Matrosova,

    [Description("Александровский")]
    [EnumGuid("F28521A0-4EBA-4D08-A873-4081BB6333A0")]
    Aleksandrovskiy,

    [Description("Алексеева")]
    [EnumGuid("11EA64E8-1598-49E2-9800-BBFC20BDD274")]
    Alekseeva,

    [Description("Алексея Асеева")]
    [EnumGuid("FCB4186B-BDCA-4BAB-9B44-09355693589E")]
    AlekseyaAseeva,

    [Description("Алеши Тимошенкова")]
    [EnumGuid("9192D885-D480-457E-A665-9E55F65B2EE3")]
    AleshTimoshenkova,

    [Description("Алтайская")]
    [EnumGuid("801E4F90-8CB9-41B2-9B06-595CD9D0F42D")]
    Altayskaya,

    [Description("6-я Алыкельская")]
    [EnumGuid("BB02DA51-9C41-4D96-9EA1-E032F02F6813")]
    _6yaAlykelSkaya,

    [Description("Алыкельская 6-я")]
    [EnumGuid("19CE8FCA-3A88-4551-97E0-708339195F73")]
    AlykelSkaya6ya,

    [Description("Алюминиевая")]
    [EnumGuid("21348C0C-DA30-4883-87DF-F424CA4A8DF6")]
    Alyumineevaya,

    [Description("Аманатский")]
    [EnumGuid("18496668-B982-4EE6-B6C2-33EFA43F1F49")]
    Amanatskiy,

    [Description("Амурская")]
    [EnumGuid("45BBFEB3-134F-4C9F-8AE4-4F2385DFAC20")]
    Amurskaya,

    [Description("Анабарская")]
    [EnumGuid("297766AA-5551-4418-B824-930CCD040EA5")]
    Anabarskaya,

    [Description("Анатолия Гладкова")]
    [EnumGuid("0786249C-7911-423E-9DEC-647953EB64F3")]
    AnatoliyaGladkova,

    [Description("Ангарская")]
    [EnumGuid("E8AFCD2C-74EF-4365-B834-213BBCC3E3E8")]
    Angarskaya,

    [Description("Анзельская")]
    [EnumGuid("90730E9C-724D-46BE-9DB1-75BDC7DF3B52")]
    AnzelSkaya,

    [Description("Апрельская")]
    [EnumGuid("005FE355-AC4F-40BB-B1EA-5069FE2B1189")]
    AprelSkaya,

    [Description("Аральская")]
    [EnumGuid("216E16A4-DD56-4A51-901E-5261B545682F")]
    AralSkaya,

    [Description("Арейская")]
    [EnumGuid("77C5F372-8948-4302-8DF0-7A94ECF2EF66")]
    Areyskaya,

    [Description("Аринская")]
    [EnumGuid("611FB690-E11B-4F5F-923A-34CD7A2280F2")]
    Arinskaya,

    [Description("Армейская")]
    [EnumGuid("8094D270-4744-4182-95A6-97CF9EAE36A1")]
    Armeyskaya,

    [Description("Арский")]
    [EnumGuid("44E8F6FB-A38D-44F2-93C5-E1F24F97C81A")]
    Arskiy,

    [Description("Артемовская")]
    [EnumGuid("69B571B6-F9E9-49DE-A57C-0766FAD92856")]
    Artemovskaya,

    [Description("Архангельская")]
    [EnumGuid("7BDEA3FA-B183-45E0-B63F-6ABE35119C9E")]
    ArkhangelSkaya,

    [Description("Астраханская")]
    [EnumGuid("827E90A1-C262-4078-857C-2D223F2A59B5")]
    Astrakhanskaya,

    [Description("Атаманская")]
    [EnumGuid("C696B1B8-7FFD-4F88-89BA-CD2711EB25B6")]
    Atamanskaya,

    [Description("Афонтовский")]
    [EnumGuid("E667F1BA-C9DC-458C-86A4-AA3F2AB25332")]
    Afontovskiy,

    [Description("Ачинский")]
    [EnumGuid("509F10A6-2CE4-4926-B870-4DC9B07201B6")]
    Achinskiy,

    [Description("Аэровокзальная")]
    [EnumGuid("5FDEC09D-55E8-4934-AAD1-3BC769CC3D4C")]
    Aerovokzalnaya,
    
    #endregion
    
    #region Улицы на букву Б
    
    [Description("Бабушкина")]
    [EnumGuid("340FDBB0-8771-4032-AF9C-742D76F093D5")]
    Babushkina,
    [Description("Бадалык")]
    [EnumGuid("1DA25A69-14BB-46ED-A455-4B207BA423C6")]
    Badalyk,
    [Description("Бадалыкская")]
    [EnumGuid("7E3C29F4-AE05-4973-B2C0-3D251C09B415")]
    Badalykskaya,
    [Description("Базайская")]
    [EnumGuid("7783C928-3FC1-4657-9EE1-C209E03A3EBB")]
    Bazayskaya,
    [EnumGuid("D40EB451-C5A3-43EB-8227-4BB01FA346BD")]
    [Description("Базарная")]
    BazarNaya,
    [EnumGuid("1913B8B2-4349-489B-9FD6-7726F16BA155")]
    [Description("Байкальская")]
    Baykalskaya,
    [EnumGuid("790FB554-9455-4B7D-8180-5042FD745B69")]
    [Description("Байкитская 1-я")]
    Baykitskaya1,
    [EnumGuid("4921FAC3-1AD0-4C75-B58D-4C4DFDB61105")]
    [Description("1-я Байкитская")]
    Baykitska_ya1,
    [EnumGuid("58E4F4F3-E34D-4AF9-BFDA-F79AEC29437C")]
    [Description("Байкитская 2-я")]
    Baykitskaya2,
    [EnumGuid("3A68611F-3CCA-4179-A108-C74720A8DAD9")]
    [Description("2-я Байкитская")]
    Baykitska_ya2,
    [EnumGuid("3A3B3FDB-D5FA-4870-A04D-F388B8D70D17")]
    [Description("Балахтинская")]
    BalakhTinskaya,
    [EnumGuid("73B989B5-2598-4EAC-B4D2-DC084FBF6D10")]
    [Description("Бартатский")]
    Bartatskiy,
    [EnumGuid("F9DD1DD1-7155-47A2-B39A-6838F5439139")]
    [Description("Батурина")]
    BatUrIna,
    [EnumGuid("A75A5913-91FD-42F1-8BBC-0E3CCE879135")]
    [Description("Баумана")]
    BaUmana,
    [EnumGuid("6BD83066-6D1C-422D-BC47-2EEED0307A83")]
    [Description("Башиловская")]
    BashIlovskaya,
    [EnumGuid("58357327-651B-48B0-B98D-A148B13CFAD0")]
    [Description("Бебеля")]
    Bebelya,
    [EnumGuid("F564D2A9-4034-41BD-9D84-1C47370DFC26")]
    [Description("Бегичева")]
    Begicheva,
    [EnumGuid("5BBDC256-9183-4096-A517-8A02B79DCAB7")]
    [Description("Белинского")]
    Belinskogo,
    [EnumGuid("E0038B19-06B0-46F6-8F0F-A604888A593F")]
    [Description("Беловежская")]
    BelovezhSkaya,
    [EnumGuid("AE589CB2-8A96-4073-8EF4-F1D8AA091B09")]
    [Description("Белопольского")]
    BelopolSkogo,
    [EnumGuid("F28DB2CC-6807-4F93-B9AB-919CB348997A")]
    [Description("Белорусская")]
    Belorusskaya,
    [EnumGuid("CE09C6F4-5DD8-4B8D-B3E2-A2668C72E4AB")]
    [Description("Беляева")]
    Belyaeva,
    [EnumGuid("4A6501E6-2025-4FE8-9904-8515A4BFD495")]
    [Description("Березина")]
    Berezina,
    [EnumGuid("44C6E9D7-880E-48AD-A06D-4CE6B4383E79")]
    [Description("Березовая")]
    Berezovaya,
    [EnumGuid("4C5BB0B5-9BE7-415B-9104-796688E74FA3")]
    [Description("Биатлонная")]
    Biathlonnaya,
    [EnumGuid("1DDA1D20-6987-4DC6-B8CE-5C59D83EEE2D")]
    [Description("Бийская")]
    Biyskaya,
    [EnumGuid("606695E0-F18A-4FD2-A0C1-8835473BF889")]
    [Description("Бийхемская")]
    BiyKhemsKaya,
    [EnumGuid("E4FC60FD-D34C-4C28-88E4-8E2250398369")]
    [Description("Биологов")]
    Biologov,
    [EnumGuid("1D944DB8-EBD4-4384-93AB-0F0CFB8F7053")]
    [Description("Бирикчульский")]
    BirikchulSkiy,
    [EnumGuid("505CA6DD-C84E-4B12-878E-B46799B20341")]
    [Description("Бирилюсская")]
    Birilyusskaya,
    [EnumGuid("F9C8D455-F765-495F-89BF-9C1314E89962")]
    [Description("Бирюсинская")]
    Biryusinskaya,
    [EnumGuid("E098423A-23A0-4CFE-A1AA-F81DB0162A60")]
    [Description("Благодатная")]
    Blagodatnaya,
    [EnumGuid("76A54C8E-6C8F-40A6-885F-C709D19BB3B4")]
    [Description("Бобровый")]
    Bobrovyy,
    [EnumGuid("DADE1DBD-E283-49C1-AEA4-FCCB0CCB8F30")]
    [Description("Богдана Хмельницкого")]
    BogdanaKhmelNitskogo,
    [EnumGuid("9E11873E-3F64-407E-9E1F-AA5E544F5006")]
    [Description("Боголеповская")]
    Bogolepovskaya,
    [EnumGuid("66730A61-F9C0-40A0-8BD9-872FF6193536")]
    [Description("Боготольский")]
    BogotolSkiy,
    [EnumGuid("5AD1B114-F218-419A-98F5-A839E6721B0C")]
    [Description("Бограда")]
    Bograda,
    [EnumGuid("F0559193-CDA8-4A22-9228-57051322703B")]
    [Description("Богучанская")]
    Boguchanskaya,
    [EnumGuid("99C9F1C8-8E68-4ECD-83E9-1C92A89074B5")]
    [Description("Бодрая")]
    Bodraya,
    [EnumGuid("C5B9C252-671E-4C84-AF1B-06AE80D596A4")]
    [Description("Бойкая")]
    Boykaya,
    [EnumGuid("E03B169C-F2D7-4EB6-906E-8E9EC963BD9E")]
    [Description("Болдинская")]
    Boldinskaya,
    [EnumGuid("2578A7C3-4844-49D4-A239-0BA8735D5B91")]
    [Description("Большегвардейская")]
    BolSheGvardeyskaya,
    [EnumGuid("51E0248F-6495-41D7-9ED0-4A14BB2EA9E4")]
    [Description("Большой")]
    BolShoy,
    [EnumGuid("1586CF47-E0E4-4991-A16A-C0DF09C80AEE")]
    [Description("Борисевича")]
    Borisevicha,
    [EnumGuid("04EE1734-2DB8-44B8-A0F7-209D9E162D02")]
    [Description("Борисова")]
    Borisova,
    [EnumGuid("F6D63F44-807A-41AF-A73C-E772BA365E43")]
    [Description("Боровая 1-я")]
    Borovaya1,
    [EnumGuid("D0B017FD-B1E5-468A-8C81-B668AAA41A10")]
    [Description("1-я Боровая")]
    Borova_ya1,
    [EnumGuid("227DC29C-6B99-4030-B56A-A4B5BE66FB2E")]
    [Description("Боровая 2-я")]
    Borovaya2,
    [EnumGuid("66C32B42-D699-42AB-B9BC-845E2DC9F8B7")]
    [Description("2-я Боровая")]
    Borova_ya2,
    [EnumGuid("93D87292-132F-4E75-913B-FCEA8AE1BD4A")]
    [Description("Бородинская")]
    Borodinskaya,
    [EnumGuid("B3AED898-3FAB-46B5-B154-841DD8690660")]
    [Description("Борьбы")]
    BorBy,
    [EnumGuid("F5DD4A68-5514-4CED-A399-4F031012FE92")]
    [Description("Ботаническая")]
    Botanicheskaya,
    [EnumGuid("29FA9049-7868-477E-AD3A-DB2B3C652BD9")]
    [Description("Ботаническая 2-я")]
    Botanicheskaya2,
    [EnumGuid("419D93C1-DDC6-4ADB-BDDE-CD3F724748AE")]
    [Description("2-я Ботаническая")]
    Botanicheska_ya2,
    [EnumGuid("FEAEC3BC-29EC-475C-8D9A-C6DFAED079EB")]
    [Description("Ботаническая 3-я")]
    Botanicheskaya3,
    [EnumGuid("B44637A6-8943-4EC0-9C8A-80EB746B9040")]
    [Description("3-я Ботаническая")]
    Botanicheska_ya3,
    [EnumGuid("5286F0D9-D604-4F27-BEDD-8A5D36DBBD3F")]
    [Description("Ботаническая 4-я")]
    Botanicheskaya4,
    [EnumGuid("A65F90A6-83D6-42EC-A657-5AA1D7F65F84")]
    [Description("4-я Ботаническая")]
    Botanicheska_ya4,
    [EnumGuid("7AAD11B6-5625-4A10-A38C-B6B5E8D87DC2")]
    [Description("Ботанический")]
    Botanicheskiy,
    [EnumGuid("D71E1701-3F85-4701-AF24-3301977BDC28")]
    [Description("Боткина")]
    Botkina,
    [EnumGuid("B201C7EB-6EC0-4285-A16E-325EB29268AF")]
    [Description("Бохтинский")]
    Bokhtinskiy,
    [EnumGuid("EC674EC0-22C8-4329-8180-FEA7F2307A82")]
    [Description("Братская 1-я")]
    Bratskaya1,
    [EnumGuid("4B013D92-67BF-4D1C-81AE-CA73C0FA5D0C")]
    [Description("1-я Братская")]
    Bratska_ya1,
    [EnumGuid("E22CFBCB-EA1B-4467-A5C5-DF4FA68361B9")]
    [Description("Братская 2-я")]
    Bratskaya2,
    [EnumGuid("C3444383-2E12-4939-BAF0-274F7292044E")]
    [Description("2-я Братская")]
    Bratska_ya2,
    [EnumGuid("BE5A29FA-D677-4470-A39E-DD231C296C22")]
    [Description("Братьев Абалаковых")]
    BratEyAbalakovykh,
    [EnumGuid("A3E7FD67-33F9-4BDF-A7D7-7CAF54D752C4")]
    [Description("Брестская")]
    Brestskaya,
    [EnumGuid("93BA21AA-7E26-467B-AB17-8F7FDF57E07B")]
    [Description("Брянская")]
    Bryanskaya,
    [EnumGuid("B302E806-5C81-4A87-99CC-6D9300DDD528")]
    [Description("Брянская 2-я")]
    Bryanskaya2,
    [EnumGuid("F03D7457-D7E8-4A49-AC01-B4851D2228B3")]
    [Description("2-я Брянская")]
    Bryanska_ya2,
    [EnumGuid("FB6B66C2-6AF2-4E1E-B3D8-AC9F93F405BB")]
    [Description("Бугачевская")]
    Bugachevskaya,
    [EnumGuid("384AD73D-89B3-42CD-9D8E-69837456D86E")]
    [Description("Быковского")]
    Bykovskogo,
    
    #endregion
    
    #region Улицы на букву В
    
    [EnumGuid("E2C49141-255A-42E1-B18A-7D4F0EABF393")]
    [Description("Васильковый")]
    Vasilikovoy,
    [EnumGuid("22AE9636-F5EF-498E-B7C5-470CF4CD7D60")]
    [Description("Васнецова")]
    Vasnetsova,
    [EnumGuid("C3C483F0-D285-4230-9CF4-03F19F1FAC62")]
    [Description("Ватутина")]
    Vatutina,
    [EnumGuid("D2043CD2-186D-48DE-B4AE-81BA8A9E1206")]
    [Description("Вейнбаума")]
    VeinBauma,
    [EnumGuid("F4EC565E-8462-41D4-8870-249A6DC3CD05")]
    [Description("Вербная")]
    Verbnaya,
    [EnumGuid("AEC15368-AF3F-44AA-8081-487DB6FF9369")]
    [Description("Верещагина")]
    Vereshchagina,
    [EnumGuid("F1E27637-29D6-479C-B66D-63529197EA2A")]
    [Description("Верхняя")]
    VerkhNeya,
    [EnumGuid("A6117427-D665-4E2A-9A68-BE4CD6A3CAE5")]
    [Description("Верховая")]
    Verkhovaya,
    [EnumGuid("804A3DE9-F94A-4133-A457-06ED49AAA8FA")]
    [Description("Верхотельский")]
    VerkhotelSkiy,
    [EnumGuid("F751A786-4F95-4B0D-9A42-9E5FE960E1A5")]
    [Description("Весёлая")]
    Veselyaya,
    [EnumGuid("F976C36B-015F-49B2-89B4-1F943FC3C286")]
    [Description("Веселовская")]
    Veselovskaya,
    [EnumGuid("581C04DD-2F77-49EE-9B27-F05E16196560")]
    [Description("Весенняя")]
    VesenNaya,
    [EnumGuid("251AC25F-A1D4-4D2F-AEE7-9495BC00C3D7")]
    [Description("Весны")]
    Vesny,
    [EnumGuid("37ED781C-690F-4AC7-B0FE-18F4161A55D8")]
    [Description("Вечерняя")]
    VecherNeya,
    [EnumGuid("9B7F5109-7193-4B60-8AAC-FDC9AB7F96F7")]
    [Description("Вешняя")]
    VeshNeya,
    [EnumGuid("826CEEAA-42AC-4564-A424-EF82CF0AA6B0")]
    [Description("Взлётная")]
    Vzletnaya,
    [EnumGuid("DC5498CD-1148-4A53-8BBA-55680B6BDD11")]
    [Description("Вильского")]
    VilSkogo,
    [EnumGuid("0754DF01-E4FA-4F47-8BFA-4F3F6AC7A2F8")]
    [Description("Виражная")]
    Viazhnaya,
    [EnumGuid("F037DE96-0D1C-4E64-84C0-C3CB8C518304")]
    [Description("Вишневый")]
    Vishnevyy,
    [EnumGuid("D0381A9E-2F5D-4D5F-A38D-3A49FCF6FCED")]
    [Description("Внутриквартальная 1-я")]
    Vnutrikvartalnaya1,
    [EnumGuid("C7DB5832-B257-4D15-B307-7F2D477EAEF2")]
    [Description("1-я Внутриквартальная")]
    Vnutrikvartalna_ya1,
    [EnumGuid("FF83B91D-6964-4B11-B0EB-F8F06A5F26F1")]
    [Description("Внутриквартальная 3-я")]
    Vnutrikvartalnaya3,
    [EnumGuid("90090D6C-645D-4312-A5E1-32E4593DF52D")]
    [Description("3-я Внутриквартальная")]
    Vnutrikvartalna_ya3,
    [EnumGuid("B443EE6B-703F-4736-93B3-C933034BB626")]
    [Description("Водометный")]
    Vodometnyy,
    [EnumGuid("E02DADA7-2FB1-4F30-A6C7-4B59909355B7")]
    [Description("Водопьянова")]
    Vodopyanova,
    [EnumGuid("FAB8D86B-96B3-4A7B-9916-1F2B95B6AD51")]
    [Description("Водянникова")]
    VodyanNikova,
    [EnumGuid("A9A0283E-98E3-4F97-8367-AC4F01AA3DD0")]
    [Description("Возвышенная")]
    VozvyshchenNaya,
    [EnumGuid("782E3426-6A22-4D3C-B7F9-C2D6F9F566D4")]
    [Description("Вознесенская")]
    Voznesenskaya,
    [EnumGuid("04111CCC-C822-4456-B55B-F33E9B72930D")]
    [Description("Возрождения")]
    Rozhdeniya,
    [EnumGuid("97B77775-7221-4D87-92D0-3422E86E89B6")]
    [Description("Вокзальная")]
    Vokzalnaya,
    [EnumGuid("A8909F83-DFDD-46F0-A3E7-DFC14B921E24")]
    [Description("Волгоградская")]
    Volgogradskaya,
    [EnumGuid("3BCB9FCA-E200-461E-BE2A-0938367D94C9")]
    [Description("Волжская")]
    Volzhskaya,
    [EnumGuid("F74A57DF-0908-4BE0-B17F-65F486A93E85")]
    [Description("Володнева")]
    Volodinova,
    [EnumGuid("DFE593B6-4AF5-4120-AFE8-1F74C473B753")]
    [Description("Волочаевская")]
    Volochayevskaya,
    [EnumGuid("E0B03896-498A-44BD-96C0-B4194F14E57D")]
    [Description("Волочанская")]
    Volochanskaya,
    [EnumGuid("524A9233-0ACE-4783-80EF-8F8C5431502E")]
    [Description("Вольный")]
    Volnyy,
    [EnumGuid("08901AD1-684B-4135-AA63-E737F4A6A63A")]
    [Description("Воровского")]
    Vorovskogo,
    [EnumGuid("B8AA44B1-9334-4D1F-8318-552B0EFB27FF")]
    [Description("Воронова")]
    Voronova,
    [EnumGuid("2C63DF86-59FA-4F2B-B670-A165AE545A34")]
    [Description("Воскресенская")]
    Voskresenskaya,
    [EnumGuid("9EB4DDBB-11E0-434E-A6B4-035FA401009A")]
    [Description("Воскресная")]
    Voskresnaya,
    [EnumGuid("FE277F1F-234C-4295-9C27-D8C5D97A8859")]
    [Description("Восточная")]
    Vostochnaya,
    [EnumGuid("E55F1E67-C086-46D7-95AC-F1FDE58ED8B2")]
    [Description("Восточный")]
    Vostochnyy,
    [EnumGuid("F9D3DF78-55A7-420F-A57E-C22773E6FA8F")]
    [Description("Восходная")]
    Voskhodnaya,
    [EnumGuid("E92E506D-4B6F-4123-AC21-5F55805D0381")]
    [Description("Встречная")]
    Vstrechnaya,
    [EnumGuid("A6CCDE22-2528-449E-808B-BEE9018277E9")]
    [Description("Вузовский")]
    Vuzovskiy,
    [EnumGuid("2D21530B-3E67-46C3-8705-4357CF8E8872")]
    [Description("Выборгский")]
    Vyborgskiy,
    [EnumGuid("014BE2A9-8971-47E0-A243-61B6AB83EBE6")]
    [Description("Высокая")]
    Vysokaya,
    [EnumGuid("63BF5104-E343-48F0-AAF0-1A87747FB3E5")]
    [Description("Высотная")]
    Vysostnaya,
    [EnumGuid("DF400B70-6F4D-4E8E-A8AB-C466FEFE1226")]
    [Description("Высоцкого")]
    Vysotskogo,
    
    #endregion

    #region Улицы на букву Г

    [EnumGuid("7419095A-5F27-4A56-9F0B-FD62C1CCD497")]
    [Description("Гадалова")]
    Gadalova,
    [EnumGuid("61427BA8-56E1-4CB2-A544-701F778F3A19")]
    [Description("Гайдара")]
    Gaydara,
    [EnumGuid("8E1BE986-F389-45A5-A188-FE29A1CBE7F2")]
    [Description("Гайдашовка")]
    Gaydashovka,
    [EnumGuid("DA708040-940A-4CF3-B82F-8A8FD37685A5")]
    [Description("Гаражный")]
    Garazhnyy,
    [EnumGuid("FD0615E0-2164-4228-B5B0-C9708FBD5CED")]
    [Description("Гастелло")]
    Gastello,
    [EnumGuid("2036B070-16A2-4E11-85CE-90F22848295C")]
    [Description("Геодезическая")]
    Geodezicheskaya,
    [EnumGuid("8088B005-3CCC-4DB3-ADE6-38DBAF22A953")]
    [Description("Геологическая")]
    Geologicheskaya,
    [EnumGuid("11BFDF0E-9C0D-46F0-9C68-07C4D61285AA")]
    [Description("Геологическая 2-я")]
    Geologicheskaya2,
    [EnumGuid("90279CE9-AF8F-40A7-A78E-2A8A9016C95A")]
    [Description("2-я Геологическая")]
    Geologicheska_ya2,
    [EnumGuid("9CD0781D-8078-45EA-BF40-2108647D1074")]
    [Description("Георгиевская")]
    Georgievskaya,
    [EnumGuid("73707B16-9962-4F15-B0E5-05E732A267BF")]
    [Description("Героев Страны")]
    GeroevStrany,
    [EnumGuid("5C40382D-3015-4F01-8C74-5D488DF33517")]
    [Description("Героев Чернобыля")]
    GeroevChernobylya,
    [EnumGuid("C57CB024-56FB-4925-A288-635F9C7BB1D9")]
    [Description("Герцена")]
    Gertsena,
    [EnumGuid("01227C2D-CD15-45C0-88F6-7EE23CACFB5E")]
    [Description("Гипсовая")]
    Gipssovaya,
    [EnumGuid("6DA13887-DACC-4D78-83D5-58503C986163")]
    [Description("Гипсовая 1-я")]
    Gipssovaya1,
    [EnumGuid("3824F9E0-40FB-42FF-81C9-0C89B12D24D3")]
    [Description("1-я Гипсовая")]
    Gipssova_ya1,
    [EnumGuid("56401696-C27C-4B34-8CC9-1947D0E1958D")]
    [Description("Гипсовая 2-я")]
    Gipssovaya2,
    [EnumGuid("6E6ED651-2505-4CB0-91C1-1D79E25F5F64")]
    [Description("2-я Гипсовая")]
    Gipssova_ya2,
    [EnumGuid("BD8C825E-779E-45B9-8A7D-145CF1FF87CB")]
    [Description("Гипсовая 3-я")]
    Gipssovaya3,
    [EnumGuid("6A8E3753-DC79-41C3-8812-16DCD33EC8CB")]
    [Description("3-я Гипсовая")]
    Gipssova_ya3,
    [EnumGuid("548AD3CB-99E6-4794-8532-27EB0C50E2B5")]
    [Description("Глинки")]
    Glinskiy,
    [EnumGuid("90EA7ACB-B9D6-42DE-B63E-65189209F049")]
    [Description("Глиняная")]
    Glinyanaya,
    [EnumGuid("F19025DC-DE4A-4679-9FDF-8F62C7338D3D")]
    [Description("Говорова")]
    Govorova,
    [EnumGuid("22898CEE-07F2-4FD5-B22A-E90F9ED6C880")]
    [Description("Гоголя")]
    Gogolya,
    [EnumGuid("14337323-F01A-4D41-8217-66E4B1B1E0C0")]
    [Description("Горийский")]
    Goriyskiy,
    [EnumGuid("3EDB4AB6-9A21-417C-9D4A-26746E251DC2")]
    [Description("Гористая")]
    Goristaya,
    [EnumGuid("0E1427BB-C662-4DC3-8F20-82DAFD179F1D")]
    [Description("Горная")]
    Gornaya,
    [EnumGuid("EE772FC7-603A-4694-AB9E-30474453D04A")]
    [Description("Горького")]
    Gorkogo,
    [EnumGuid("B8A52572-76A3-4E0C-AB14-FD4E4944737D")]
    [Description("Гражданский")]
    Grazhdanskiy,
    [EnumGuid("CA3D1978-6AAC-4FDA-9653-CCDBBED7EF67")]
    [Description("Гранитная")]
    Granitnaya,
    [EnumGuid("F439F1DD-DF2B-4F6A-B68C-A26994504EE6")]
    [Description("Графитная")]
    Grafichnaya,
    [EnumGuid("D8018E5E-F122-46F6-8F8E-BEEF3B350C73")]
    [Description("Гремячий 1-й")]
    Gremyachiy1,
    [EnumGuid("6C0E6192-E1AA-4037-9738-18ABF28939EF")]
    [Description("Гремячий 2-й")]
    Gremyachiy2,
    [EnumGuid("04AFB032-B407-48AF-AE29-5D9E57D05F88")]
    [Description("Гремячий 3-й")]
    Gremyachiy3,
    [EnumGuid("7A57137E-CCDF-4049-A491-B3C7C6F3C97F")]
    [Description("Гремячий 4-й")]
    Gremyachiy4,
    [EnumGuid("A47A16A2-4E2F-4816-A4D8-F41D7F5D4E66")]
    [Description("Грибная")]
    Gribyanaya,
    [EnumGuid("CBDD14EC-52CB-4775-AB7B-7ED24214B8E3")]
    [Description("Гросовцев")]
    Grossovtsa,
    [EnumGuid("75188344-823C-4F8D-8B5E-A2B9200272FE")]
    [Description("Грунтовая")]
    Gruntovaya,
    [EnumGuid("05EE08CD-9994-4A98-A374-24C8A4593E1F")]
    [Description("Грушевая")]
    Grushevaya,
    [EnumGuid("8A6BC17A-E58D-4874-9BE3-DDE22FEF29CD")]
    [Description("Гуляева")]
    Gulyaeva,
    [EnumGuid("6AD9D174-75C7-4F49-AF31-54648E2D9E17")]
    [Description("Гусарова")]
    Gusarova,

    #endregion

    #region Улицы на букву Д

    [EnumGuid("727CE5CB-09E4-4544-92F2-24A7930AAE53")]
    [Description("Дальневосточная")]
    Dalnevostochnaya,
    [EnumGuid("A28DBD16-44E8-4870-8430-3906FDF80D6C")]
    [Description("Дальневосточная 3-я")]
    Dalnevostochnaya3,
    [EnumGuid("790EDB22-EBFB-4BE6-B126-511076F1661C")]
    [Description("3-я Дальневосточная")]
    Dalnevostochna_ya3,
    [EnumGuid("22F6F37B-4DF2-41B7-B877-347AF4BA2460")]
    [Description("Дальневосточная 4-я")]
    Dalnevostochnaya4,
    [EnumGuid("600BBD9A-CBF8-45E0-B7D6-A066B9D4972C")]
    [Description("4-я Дальневосточная")]
    Dalnevostochna_ya4,
    [EnumGuid("AB716A17-0AC9-4CF1-9F3E-476B8A59F58C")]
    [Description("Дальняя")]
    DalNaya,
    [EnumGuid("3DE48F2D-4442-454C-85E7-0CED2AFB3A62")]
    [Description("Даурская")]
    DaurSKaya,
    [EnumGuid("F5AAC9CB-7296-4B40-9FFB-C685A79EC0A0")]
    [Description("Дачная")]
    Dachnaya,
    [EnumGuid("CA23AF25-5795-4745-B753-11530C5CF57F")]
    [Description("Декабристов")]
    Dekabristov,
    [EnumGuid("117EEC35-E9B4-46F4-BF76-AE2FAC4BFDDA")]
    [Description("Делегатская")]
    Delegatskaya,
    [EnumGuid("F64991CE-DABF-4B90-9CEC-9AA217950B66")]
    [Description("Деловая")]
    Delovaya,
    [EnumGuid("F7FE0E36-4FC0-4F71-9B10-86944010C521")]
    [Description("Видьяна Бедного")]
    VidanyaBednogo,
    [EnumGuid("CE021594-03B5-4C2B-A133-5DDF72D84A55")]
    [Description("Деповская")]
    Depovskaya,
    [EnumGuid("492FABD2-8C6D-4356-AC33-EE987B764355")]
    [Description("Деповский")]
    Depovskiy,
    [EnumGuid("F6359F94-D76F-4F17-BE55-9053191C43DE")]
    [Description("Депутатская 2-я")]
    Deputatskaya2,
    [EnumGuid("FB6250CC-71BC-4BF4-BA8A-9AD9E6E54BCC")]
    [Description("2-я Депутатская")]
    Deputatska_ya2,
    [EnumGuid("F2D17AE0-A6A2-4A67-A27B-4CC7C5CB412C")]
    [Description("Детская")]
    Detskaya,
    [EnumGuid("A71B41E6-CE2E-43B4-85EA-32E010D01755")]
    [Description("Джамбульская")]
    Dzhambulskaya,
    [EnumGuid("4C41A94F-FC52-4A2D-9FB3-F9E000DF09B4")]
    [Description("Дзержинского")]
    Dzerzhinskogo,
    [EnumGuid("34566E06-482E-4651-AE2D-7A8727C05D0E")]
    [Description("Дивная")]
    Divnaya,
    [EnumGuid("701374D0-C37F-475C-B567-7B47F326AD7B")]
    [Description("Дивногорская")]
    Divnogorskaya,
    [EnumGuid("083EA217-6621-405D-9955-421DF85C05B1")]
    [Description("Диксона")]
    Dixona,
    [EnumGuid("37EBF339-EF7A-4C75-82FD-1AD1F93FA8AB")]
    [Description("Диктатуры Пролетариата")]
    DiktaturyProletariata,
    [EnumGuid("9830FC00-445B-408D-97DF-1D1FA7979CB8")]
    [Description("Димитрова")]
    Dimitrova,
    [EnumGuid("2B0B43D2-8E10-4AA1-9B69-26EA57261508")]
    [Description("Дмитрия Мартынова")]
    DmytriyaMartynova,
    [EnumGuid("CFC46B3F-65AB-4BE6-AFC1-A6BEE6F575C3")]
    [Description("Днепропетровская 1-я")]
    Dnepropetrovskaya1,
    [EnumGuid("B6D8125B-72A7-4887-A656-476E46AF5C0D")]
    [Description("1-я Днепропетровская")]
    Dnepropetrovska_ya1,
    [EnumGuid("443678F2-CDFE-487D-89CB-1CA0300AA2E0")]
    [Description("Днепропетровская 2-я")]
    Dnepropetrovskaya2,
    [EnumGuid("286C8B7A-33A2-4BD1-B146-C9CA070BCC79")]
    [Description("2-я Днепропетровская")]
    Dnepropetrovska_ya2,
    [EnumGuid("BAC1D176-93CE-4F9A-ADA6-3D580EE79E94")]
    [Description("Добролюбова")]
    Dobrolubova,
    [EnumGuid("7663B13F-672F-4E3E-83A7-05A7A87A428A")]
    [Description("Дозорная")]
    Dozornaya,
    [EnumGuid("43B59854-BCE6-4C63-850D-DC89813B0FF0")]
    [Description("Докучаева")]
    Dokuchaeva,
    [EnumGuid("6416DE38-07E0-40DD-AD3C-14D9E20F6B5C")]
    [Description("Донецкая")]
    Donetskaya,
    [EnumGuid("C5B42127-41F5-465D-A728-B63890835CAC")]
    [Description("Дорожная")]
    Dorognaya,
    [EnumGuid("B4871F29-3698-4D2A-891F-C1487C84566A")]
    [Description("Достоевского")]
    Dostoevskogo,
    [EnumGuid("692AE3CB-FE4E-4C2C-978F-8BD9AD8D568F")]
    [Description("Дрокинская")]
    Drokinskaya,
    [EnumGuid("4E9D1B76-2014-4896-967E-FDA98F7C6BAE")]
    [Description("Дружбы")]
    Druzhby,
    [EnumGuid("0CA119E7-E5FB-4C4E-8BE2-8C06233C269E")]
    [Description("Дружный")]
    Druzhnyy,
    [EnumGuid("5B92CBEB-1A3E-4032-A777-F61E36081208")]
    [Description("Дубенского")]
    Dubenskogo,
    [EnumGuid("D4EA9F1E-0BC6-4A35-BDE5-87ACD90FD493")]
    [Description("Дубровинского")]
    Dubrovinskogo,
    [EnumGuid("9A3D9937-9B4B-46A4-BE59-367D88609001")]
    [Description("Дудинская")]
    Dudinskaya,
    [EnumGuid("0A2409AD-9141-4E9D-87B3-6F88070C7766")]
    [Description("Дюнная")]
    Dunnyaya,

    #endregion

    #region Улицы на букву Е

    [EnumGuid("463927C0-D96C-40F3-B782-646A1E58EE55")]
    [Description("Елены Стасовой")]
    ElenyStasovoy,
    [EnumGuid("DD219A0A-B755-4188-9A20-DB66D7AE5F54")]
    [Description("Еловая")]
    Yelovaya,
    [EnumGuid("82D87217-FE17-46EF-8187-A81A44586C9B")]
    [Description("Емельяновская")]
    Yemelyanovskaya,
    [EnumGuid("542750FE-A977-46C3-8FCD-AB329EDE3A09")]
    [Description("Енисейская")]
    Yeniseyskaya,
    [EnumGuid("D6916773-59E0-4DA3-886B-070FEED55E00")]
    [Description("Енисейский тракт")]
    YeniseyskiyTrakt,
    [EnumGuid("35AB97B9-E392-48B4-A625-F6E9DC22DDF0")]
    [Description("Ермаковская")]
    Yermakovskaya,
    [EnumGuid("8E702617-348D-485E-8203-0A66EB845F4A")]
    [Description("Ерофеевская")]
    Yerofeyevskaya,
    [EnumGuid("7A02219B-0B20-4653-9AF3-FFC3C8EB3335")]
    [Description("Есаульская")]
    Yesaulskaya,

    #endregion
    
    #region Улицы на букву Ж
    
    [EnumGuid("A18CAAE0-79A5-4DF6-87C5-8C0757BB6243")]
    [Description("Жарковая")]
    Zarkovaya,
    [EnumGuid("233F2119-4A39-49CC-9B3F-7B84E0364C6D")]
    [Description("Жданова")]
    Zhdanova,
    [EnumGuid("4F34D258-2E06-4AE2-B4D4-2E211C0AE096")]
    [Description("Железнодорожников")]
    ZheleznoyDorožkov,
    [EnumGuid("CBC20EB0-7F0F-4C4F-9E8D-537B7E4DC3B2")]
    [Description("Желябова")]
    Zhelebova,
    [EnumGuid("502A2BD5-E59D-4D13-9362-CED3BF3146FF")]
    [Description("Жемчужная")]
    Zhemchuzhnaja,
    [EnumGuid("FE4AAE70-84B8-4953-9F1A-B99A43B9FA14")]
    [Description("Живица")]
    Zhivitsa,
    [EnumGuid("64B3703F-DB62-4C67-A2D9-09C3ED986B5C")]
    [Description("Живописная")]
    Zhivopisnaya,
    [EnumGuid("313212E3-BC52-49CF-94E6-DD64B213C6AC")]
    [Description("Жуковского")]
    Zhukovskogo,
    
    #endregion
    
    #region Улицы на букву З
    
    [EnumGuid("9B29312F-0BC4-4ADB-8C5E-3B1BBD4A470A")]
    [Description("Забобонова")]
    Zabobonova,
    [EnumGuid("43215DB8-295D-498B-B83D-0B6BB1D20BB7")]
    [Description("Заводская")]
    Zavodskaya,
    [EnumGuid("DF954BC7-5B50-484B-B499-2F3D64176B91")]
    [Description("Заводской")]
    ZavodskoyProyezd,
    [EnumGuid("4DE053D0-09A2-4DC0-B3A4-481D34EB32D8")]
    [Description("Заводской")]
    Zavodskoy,
    [EnumGuid("CEF5B07A-E12C-47FC-842B-B0FA00F7C69B")]
    [Description("Загородная")]
    Zagorodnaya,
    [EnumGuid("25A84F65-DF49-4E6E-B39A-146C7728029A")]
    [Description("Загорская")]
    Zagorskaya,
    [EnumGuid("57989A50-98B4-4414-8937-F46FE9AD7851")]
    [Description("Заливной")]
    Zalivnoy,
    [EnumGuid("A4D35619-446B-465F-AA40-EFDC1BD59E9A")]
    [Description("Западная")]
    Zapadnaya,
    [EnumGuid("ECD89E49-6877-4D0C-BADA-B58BCCF4DC36")]
    [Description("Заповедный")]
    Zapovednyy,
    [EnumGuid("FB67C6CB-624A-42F2-B0CF-174EB33D358D")]
    [Description("Запорожская")]
    Zaporozhskaya,
    [EnumGuid("EA33F4DC-97D7-4D65-98BD-A1415F4C87CD")]
    [Description("Заречная")]
    Zarechnaya,
    [EnumGuid("6E501FEE-4FB1-432E-9825-64960541E34D")]
    [Description("Зарничная")]
    Zarnichnaya,
    [EnumGuid("C3C0AF7E-A1AC-4B68-93E0-653B0F15D810")]
    [Description("Затонская")]
    Zatonskaya,
    [EnumGuid("43482993-BF8E-4796-81F3-DB881866F3D2")]
    [Description("Затонский 1-й")]
    Zatonskiy1,
    [EnumGuid("C4084716-30BD-4B2A-913A-8716342A0A16")]
    [Description("Затонский 2-й")]
    Zatonskiy2,
    [EnumGuid("725BA835-46A6-4F29-9BDF-D317E347DF13")]
    [Description("Затонский 3-й")]
    Zatonskiy3,
    [EnumGuid("706B8DE0-A5A4-4045-ABBB-60BECAA4B285")]
    [Description("Защитников Ленинграда")]
    ZashchitnikovLeningrada,
    [EnumGuid("A9FC31EE-D7E1-4233-979F-87D4B6426147")]
    [Description("Зелёный")]
    Zelyoniy,
    [EnumGuid("83DB9744-AFD9-4BB8-81FA-1D95FF3F8291")]
    [Description("Знаменская")]
    Znamenskaya,
    [EnumGuid("2961E17C-2326-481D-9A2F-35F9C15CCDC0")]
    [Description("Зои Космодемьянской")]
    ZoiKosmodemyanskoy,
    
    #endregion
    
    #region Улицы на букву И
    
    [EnumGuid("1C7C40F9-2A28-4380-8EAA-95B59CE2BD08")]
    [Description("Ивченко")]
    Ivchenko,
    [EnumGuid("DC2176F3-A724-479D-BB53-04304173F643")]
    [Description("Игарская")]
    Igarskaya,
    [EnumGuid("E66C9927-EFF9-4B63-8E2A-EFD11C31C671")]
    [Description("Извилистая")]
    Izvilistaya,
    [EnumGuid("C0C35655-3166-4928-905F-4CC93F3C59FE")]
    [Description("Измайлова")]
    Izmaylova,
    [EnumGuid("C3F4E1FB-1941-43D8-85A4-081E0C48692F")]
    [Description("Изумрудная")]
    Izumrudnaya,
    [EnumGuid("AF7471C4-A5DD-4A19-B72C-D4777D7FC874")]
    [Description("Изыскательский")]
    IzyvatelSkiy,
    [EnumGuid("048CE447-6EC7-4F05-8025-78131E053854")]
    [Description("Иланская")]
    Ilanskaya,
    [EnumGuid("E9D28F8E-B55C-4105-ACFE-C05E75259E0A")]
    [Description("Имбежский")]
    Imbezhskiy,
    [EnumGuid("AF1BC1EE-15EE-4D7D-A71C-3FB1873B1D8C")]
    [Description("Красноярский Рабочий")]
    KrasnoyarskiyRabochiy,
    [EnumGuid("3657CA63-916E-4A65-A237-6A7D2653D5ED")]
    [Description("Пионерская Правда")]
    PionerskayaPravda,
    [EnumGuid("9FC51095-5ECD-41EB-8186-B4AA3310B0A5")]
    [Description("Я.М. Свердлова")]
    YaMSverdlova,
    [EnumGuid("EEA0C393-F14B-4B98-9593-55DFAADA78A5")]
    [Description("Индустриальный 1-й")]
    Industrialniy1,
    [EnumGuid("4DF4C315-DED2-40E6-A851-E43DAB3B8ED9")]
    [Description("Индустриальный 2-й")]
    Industrialniy2,
    [EnumGuid("E32A7E68-D550-44D0-B773-19BC2E4B04D8")]
    [Description("Инженерный")]
    Inzhenerniy,
    [EnumGuid("2178D974-2EB3-4357-8D81-598A6299E322")]
    [Description("Инициаторов")]
    Initsiativov,
    [EnumGuid("734E1C0D-B6D4-450D-A0A1-9805E3C0ABFE")]
    [Description("Инструментальная")]
    Instrumentalnaya,
    [EnumGuid("C0890C99-6B85-4C2A-8B58-967B37BC0FD0")]
    [Description("Интернациональная")]
    Internatsionalnaya,
    [EnumGuid("41019E5D-96D0-441C-8FEB-0AE7F205C88F")]
    [Description("Ипподром")]
    Ippodrom,
    [EnumGuid("D9D657E5-6124-45AC-83B7-1D7DE2BC0AE2")]
    [Description("Ирбейская")]
    Irbeyskaya,
    [EnumGuid("42D6BE8F-3D1D-44C1-9669-F1AF6981045E")]
    [Description("Иркутская")]
    Irkutskaya,
    [EnumGuid("28DF51DE-A55A-4B6F-A074-42C144E507B3")]
    [Description("Иртышская")]
    Irtishskaya,
    [EnumGuid("E18ACC51-4936-44B5-9CB7-8EB85AC314F3")]
    [Description("Историческая")]
    Istoricheskaya,
    [EnumGuid("C2D8BB06-9B55-4365-A530-8E8D54A47AE7")]
    [Description("Ишимская")]
    Ishimskaya,
    
    #endregion

    #region Улицы на букву К

    [EnumGuid("3BF2D2A1-110E-4D8B-B12F-75C70A93CDF7")]
    [Description("Крайняя")]
    Kraynyaya,
	[EnumGuid("F5B6D9F9-1B9D-4B5F-9B5B-EBB4C2BBAE5E")]
    [Description("Кабульская")]
    Kabulskaya,
    [EnumGuid("5C95A37A-E0FD-42DD-A88E-4B077F914818")]
    [Description("Казанская")]
    Kazanskaya,
    [EnumGuid("2B2E8AE3-D54A-4722-8019-07D9B3B4BF44")]
    [Description("Казарменный")]
    Kazarmenniy,
    [EnumGuid("F1B3A49C-DED5-4372-87E8-AE960B8DA855")]
    [Description("Калинина")]
    Kalinina,
    [EnumGuid("1D17903E-22A6-4D16-A894-1F0821D795FF")]
    [Description("Калиновая")]
    Kalinovaya,
    [EnumGuid("66246DF2-EB10-4C92-B46F-5DE110849729")]
    [Description("Камасинская")]
    Kamasinskaya,
    [EnumGuid("C888E558-943B-4AA0-BDEB-F12C49B2F1E0")]
    [Description("Каменная")]
    Kamennaya,
    [EnumGuid("2C1AD134-12E8-48CB-95E6-C963805945BB")]
    [Description("Камская")]
    Kamskaya,
    [EnumGuid("813A8F9C-CD94-436B-B911-5B4A260CE2D1")]
    [Description("Камчатская")]
    Kamchatskaya,
    [EnumGuid("5A54DEE7-E89D-4BE5-9D04-C530C815AABD")]
    [Description("Камчатская 2-я")]
    Kamchatskaya2,
    [EnumGuid("F5F15458-5243-4D49-B3E1-F21474ED8064")]
    [Description("2-я Камчатская")]
    Kamchatska_ya2,
    [EnumGuid("D33B14B3-60A0-4EB1-960B-0E853B4FFEE5")]
    [Description("Камчатская 3-я")]
    Kamchatskaya3,
    [EnumGuid("E372AB17-AF6A-44CF-87F8-54616A783731")]
    [Description("3-я Камчатская")]
    Kamchatska_ya3,
    [EnumGuid("915853CA-5CFE-4B5E-8DF8-D2DCCA89ED97")]
    [Description("Камчатская 4-я")]
    Kamchatskaya4,
    [EnumGuid("2AF8239C-BD90-497B-9ADF-325F8307A76B")]
    [Description("4-я Камчатская")]
    Kamchatska_ya4,
    [EnumGuid("397ADF26-48C8-429B-980F-70CEC30C0947")]
    [Description("Камчатская 5-я")]
    Kamchatskaya5,
    [EnumGuid("365772AC-60DE-428A-874D-A6AA31727C86")]
    [Description("5-я Камчатская")]
    Kamchatska_ya5,
    [EnumGuid("2B5F4314-CBAB-4780-B40E-047A70A4A410")]
    [Description("Кандагарская")]
    Kandagarskaya,
    [EnumGuid("5E0C03F0-E92B-4411-B8CA-AF744C3ACE0C")]
    [Description("Канская")]
    Kanskaya,
    [EnumGuid("3CB3E52F-39EF-40E4-A0DA-A4CEE7CE3AE7")]
    [Description("Капитанская")]
    Kapitanskaya,
    [EnumGuid("17D6DC36-3CC2-4448-A057-4F5BC1863436")]
    [Description("Карамзина")]
    Karamzina,
    [EnumGuid("D52263DE-934D-495C-A421-3AF51C8BB230")]
    [Description("Каратанова")]
    Karatanova,
    [EnumGuid("75FBEDE8-0816-4D53-BEB1-2C86A004869D")]
    [Description("Каратузский")]
    Karatuzskiy,
    [EnumGuid("F6427FE1-2AF3-4CD1-8F39-52B5CF3B2BA8")]
    [Description("Караульная")]
    Karaulnaya,
    [EnumGuid("1D97330F-0939-4402-B82D-E8CB81124F39")]
    [Description("Карбышева")]
    Karbyshova,
    [EnumGuid("CE15BB21-623D-4873-87F2-94BE1754D3F2")]
    [Description("Кардагчинская")]
    Kardagchinskaya,
    [EnumGuid("D1D8E18B-41FC-47ED-AD3A-5C30E5B8C77A")]
    [Description("Карла Либкнехта")]
    KarlaLibknekhta,
    [EnumGuid("FDC9C0C3-96E7-4768-8201-5901541FF390")]
    [Description("Карла Маркса")]
    KarlaMarksa,
    [EnumGuid("F9C4DE11-2F8F-488F-BE6A-183F6412C041")]
    [Description("Карнавальная")]
    Karnavalnaya,
    [EnumGuid("9E813CB5-9EC2-4449-AA38-61D03266A519")]
    [Description("Карьерная")]
    Karernaya,
    [EnumGuid("5B37AAFC-3675-4F39-AC57-2E52E07F440F")]
    [Description("Карьерный")]
    Karerniy,
    [EnumGuid("ECBC6D0C-6DD1-4740-9560-2A24280A6205")]
    [Description("Каурова")]
    Kaurova,
    [EnumGuid("F5209866-F8DB-4EF6-955B-E4BB2CBA9BBA")]
    [Description("Каучуковый")]
    Kauchukoviy,
    [EnumGuid("9E01C914-2636-45EC-B242-CFECF183A1D3")]
    [Description("Каховская")]
    Kakhovskaya,
    [EnumGuid("73C00F32-D4C9-4E14-BE58-B5B5D7B43176")]
    [Description("Качи")]
    Kachi,
    [EnumGuid("ED4E7028-FBE6-44BF-8052-A02C65B6BFD2")]
    [Description("Качинская")]
    Kachinskaya,
    [EnumGuid("34BDB7F4-F031-4D07-AFEB-01A3EAEAA137")]
    [Description("Каштачная")]
    Kashtachnaya,
    [EnumGuid("7322765A-4D56-4D15-A2DD-0BC064B9FB2A")]
    [Description("Квадратный")]
    Kvadratniy,
    [EnumGuid("A1075693-C31F-4024-B7E4-9754313EDD8A")]
    [Description("Квартал 52-й")]
    Kvartal52,
    [EnumGuid("06FCDC0F-7BE8-43A5-9E0D-54AE3E5313D3")]
    [Description("Квартальная")]
    Kvartalnaya,
    [EnumGuid("55E74BA3-4DCF-4C1D-9543-5802906C6A66")]
    [Description("Кедровая")]
    Kedrovaya,
    [EnumGuid("ADF58374-4C9C-4C3B-A234-B6D297AFF467")]
    [Description("Кедровый")]
    Kedrovoy,
    [EnumGuid("095BF636-E149-4FD1-8E0B-5D4E1C0AF9D0")]
    [Description("Кипрейная")]
    Kipreynaya,
    [EnumGuid("4F27F88E-EE9A-41B3-AC43-EC963BB0D25A")]
    [Description("Кирова")]
    Kirova,
    [EnumGuid("8259A15E-C639-4841-9C21-C08AA3037447")]
    [Description("Кирпичников")]
    Kirpichnikova,
    [EnumGuid("19F54BA9-5169-437C-BA0A-52A52AEC1333")]
    [Description("Кишинёвская")]
    Kishinevskaya,
    [EnumGuid("3BB2E835-7A40-451A-BF21-E9FC06AC1D45")]
    [Description("Клеверный")]
    Klevernaya,
    [EnumGuid("B486A65D-1BDC-4A6B-94FD-DDC61D650275")]
    [Description("Клинкерная 1-я")]
    Klinkernaya1,
    [EnumGuid("87878ED3-9055-4336-A410-CD92C095CEE9")]
    [Description("1-я Клинкерная")]
    Klinkerna_ya1,
    [EnumGuid("B9B8FA25-B780-409E-BA53-91454D288207")]
    [Description("Клинкерная 2-я")]
    Klinkernaya2,
    [EnumGuid("0B60CD5A-A356-4B04-928D-BDFFF8104ED5")]
    [Description("2-я Клинкерная")]
    Klinkerna_ya2,
    [EnumGuid("A26612D1-8079-46F2-A4FF-F41F519A94DE")]
    [Description("Ключевская")]
    Klyuchevskaya,
    [EnumGuid("8BC33174-0EEB-4D7B-8EE4-B4096C44C5F4")]
    [Description("Ковыльная")]
    Kovylnaya,
    [EnumGuid("1069B000-485F-46DA-8337-04094D9D5CB3")]
    [Description("Кодинская")]
    Kodinskaya,
    [EnumGuid("D6756660-68DF-4991-9358-E24CCDD22F60")]
    [Description("Коломенская")]
    Kolomenskaya,
    [EnumGuid("291CE929-0D55-4E55-9871-8BB32A4E59B7")]
    [Description("Колхозная")]
    Kolkhoznaya,
    [EnumGuid("2CD618FA-8E6C-46EF-95FE-16E01E8ADCDA")]
    [Description("Кольцевая")]
    Koltevaya,
    [EnumGuid("8C331DB7-9DA3-4331-B41A-ADCB3C2E4F89")]
    [Description("Кольцевой")]
    Koltevoy,
    [EnumGuid("D3608789-28F6-46E7-8AF0-4FD4A0F7D22E")]
    [Description("Колягинская")]
    Kolyaginskaya,
    [EnumGuid("2BFF9B30-5EB1-4CCA-BC85-A348AC3736EE")]
    [Description("Комарова")]
    Komarova,
    [EnumGuid("8D461F85-397A-4193-ACAF-B882B27991FF")]
    [Description("Комбайнеров")]
    Kombaynerova,
    [EnumGuid("28DD3AC0-5206-4887-BD1C-20D755D62177")]
    [Description("Комбайностроителей")]
    KombaynoStroiteley,
    [EnumGuid("712E7A3C-1034-4866-9176-F76243922E58")]
    [Description("Коммунальная")]
    Kommunalnaya,
    [EnumGuid("D1A2A14A-6198-451B-BD70-623F05615346")]
    [Description("Коммунистическая")]
    Kommunisticheskaya,
    [EnumGuid("08BF1752-0C35-41A2-AD19-A85229B359A3")]
    [Description("Комсомольский")]
    Komsomolskiy,
    [EnumGuid("385CA1D1-A5FE-4115-840F-3CE970821558")]
    [Description("Конечная")]
    Konechnaya,
    [EnumGuid("D31332CB-1159-42B3-9367-BDB5073D5F2D")]
    [Description("Конституции СССР")]
    KonstitutsiiSssr,
    [EnumGuid("440872EB-73D3-4CD2-A3F4-DD593D7060DA")]
    [Description("Конструкторов")]
    Konstruktorov,
    [EnumGuid("E530A5FA-BEB7-4B20-9B48-CC723961A5B3")]
    [Description("Контейнерная")]
    Konteinernaya,
    [EnumGuid("65A16729-CD55-4B62-A501-441203536621")]
    [Description("Кооперативная")]
    Kooperativnaya,
    [EnumGuid("D050748B-9495-4534-9065-A9BD705BE843")]
    [Description("Копылова")]
    Kopylova,
    [EnumGuid("C94CAF15-52D3-48B9-909E-BF9446573028")]
    [Description("Копьевская")]
    Kopyevskaya,
    [EnumGuid("34062E2A-A445-4DC8-A876-473689370C09")]
    [Description("Корабельная")]
    Korabelnaya,
    [EnumGuid("577B1B0D-E7A4-4CBD-91D1-07643E9F1BCF")]
    [Description("Корнеева")]
    Korneeva,
    [EnumGuid("047AB155-CF89-4809-A333-4919F58E3A67")]
    [Description("Корнетова")]
    Kornetova,
    [EnumGuid("1D064C51-ACDA-43AC-BE45-A531828447C7")]
    [Description("Королева")]
    Koroleva,
    [EnumGuid("D92D7C5B-31CC-4A59-B64D-C1D2FA36889C")]
    [Description("Короленко")]
    Korolenko,
    [EnumGuid("FB2E68D2-F0CB-45D9-AFB4-22D7F464CC9C")]
    [Description("Короткий")]
    Korotkiy,
    [EnumGuid("DDB608CE-D120-4FBF-A1F1-D204CF233EF2")]
    [Description("Космическая")]
    Kosmicheskaya,
    [EnumGuid("30447FDC-9A1F-4759-89D9-7848D791F7DE")]
    [Description("Космонавтов микрорайон Северный")]
    KosmonavtovSeverniy,
    [EnumGuid("6804E765-67B2-44D5-8141-77F1463D064A")]
    [Description("Космонавтов")]
    Kosmonavtov,
    [EnumGuid("DD03C61A-3C85-4BB6-AAAF-8F25EB5DB98B")]
    [Description("Косой")]
    Kosoy,
    [EnumGuid("DB7DDF65-9E5F-4AD3-94BE-1475A7D84B18")]
    [Description("Котельникова")]
    Kotelnikova,
    [EnumGuid("449C15E9-4DED-4F47-9C76-FFA6CCCF7E44")]
    [Description("Котовского")]
    Kotoskogo,
    [EnumGuid("7AA23300-3AF4-4477-8B9F-1A48FCD7AA43")]
    [Description("Кочубея")]
    Kochubeya,
    [EnumGuid("D9D76B89-8290-4765-A6E4-415254DA7A7C")]
    [Description("Кравченко")]
    Kravchenko,
    [EnumGuid("E19D04DF-D80D-445A-A32F-D6AC31791D29")]
    [Description("Кразовская")]
    Krazovskaya,
    [EnumGuid("31EC551E-4C29-406C-9733-B784FFC5362B")]
    [Description("Красикова")]
    Krasikova,
    [EnumGuid("5B634DD6-0866-4367-BF34-BA3B13C95643")]
    [Description("Красная")]
    Krasnaya,
    [EnumGuid("F062D8C2-0D66-4077-A1D1-B75DD6E07A33")]
    [Description("Красногорская")]
    Krasnogorskaya,
    [EnumGuid("3AF9CC0C-487C-4F2E-88A0-F34070FFEEDF")]
    [Description("Красногорская 2-я")]
    Krasnogorskaya2,
    [EnumGuid("85A5D7EA-3829-4658-BC2D-8A53ECF7E270")]
    [Description("2-я Красногорская")]
    Krasnogorska_ya2,
    [EnumGuid("6AB6CFDD-B9EB-456F-A462-AEC13B4531DA")]
    [Description("Красноградская")]
    Krasnogradskaya,
    [EnumGuid("899923DE-D73A-4357-BB5B-4751EC4216B2")]
    [Description("Краснодарская")]
    Krasnodarskaya,
    [EnumGuid("DD879CD4-4D68-4E46-B783-D94A26FC100D")]
    [Description("Краснодарская 1-я")]
    Krasnodarskaya1,
    [EnumGuid("A2F7887B-08EE-4951-8B88-46051A729CD2")]
    [Description("1-я Краснодарская")]
    Krasnodarska_ya1,
    [EnumGuid("25B7ADA3-9E37-4E80-80DF-1A5A292F50E0")]
    [Description("Краснодарская 2-я")]
    Krasnodarskaya2,
    [EnumGuid("9C29B42B-AF5E-4604-8E7F-0CE9A10614A7")]
    [Description("2-я Краснодарская")]
    Krasnodarska_ya2,
    [EnumGuid("373F38F6-8541-4324-8674-D43D15EDF77B")]
    [Description("Краснодарская 3-я")]
    Krasnodarskaya3,
    [EnumGuid("9A05736A-1614-4682-A01B-842460C6416E")]
    [Description("3-я Краснодарская")]
    Krasnodarska_ya3,
    [EnumGuid("863BEA5A-FFE8-4638-ABB6-80BA82347D4A")]
    [Description("Краснодонцев")]
    Krasnodontsev,
    [EnumGuid("08D3C3D4-9275-4B82-AC4E-21A672D45859")]
    [Description("Красной Армии")]
    KrasnoyArmii,
    [EnumGuid("78E849AB-8EBC-4436-B0F9-92E483AAAAD0")]
    [Description("Красной Гвардии")]
    KrasnoyGvardii,
    [EnumGuid("12DC60CE-6B70-48F8-9399-0093A4F2D6E9")]
    [Description("Красной Звезды")]
    KrasnoyZvezdy,
    [EnumGuid("1D68FB6A-1061-4F2B-AD19-FBEAFC0664A1")]
    [Description("Красномосковская")]
    Krasnomoskovskaya,
    [EnumGuid("BD87782A-B6AF-4A04-9928-ABB6EABBF6CC")]
    [Description("Краснопресненская")]
    Krasnopresnenskaya,
    [EnumGuid("165E5CAC-8655-4C6D-B7F9-62F79B096227")]
    [Description("Краснофлотская 2-я")]
    Krasnoflotskaya2,
    [EnumGuid("685526B2-B983-4845-AF81-EEC19905417B")]
    [Description("2-я Краснофлотская")]
    Krasnoflotska_ya2,
    [EnumGuid("1044BB6E-AB8B-4F09-A48C-6B978726399F")]
    [Description("Красных Зорь")]
    KrasnyhZor,
    [EnumGuid("BA5AFEE6-D0D1-497F-8FE9-AFC2775E5C58")]
    [Description("Кривоколенный")]
    Krivokolenniy,
    [EnumGuid("9F5E1FA5-4D9F-499B-A7A2-506BE391BAFE")]
    [Description("Круговая")]
    Krugovaya,
    [EnumGuid("9F1C98C0-C1A7-477E-B0E2-B279283FA0A3")]
    [Description("Крупской")]
    Krupskoy,
    [EnumGuid("31A41238-F7D0-4081-9621-736C5FE23C22")]
    [Description("Крутая 1-я")]
    Krutaya1,
    [EnumGuid("C3AD66B7-F879-4F4E-816D-A43B8AD14CFE")]
    [Description("1-я Крутая")]
    Kruta_ya1,
    [EnumGuid("6F1EF89F-26DA-4494-AAC9-7A938884614A")]
    [Description("Крутая 2-я")]
    Krutaya2,
    [EnumGuid("3711EE05-B67D-49FF-BBF6-3E36C9E8B889")]
    [Description("2-я Крутая")]
    Kruta_ya2,
    [EnumGuid("9AB3804A-E6F8-440D-B7A1-B286E7B1EA40")]
    [Description("Крутовского")]
    Krutovskogo,
    [EnumGuid("961795BB-E108-4D33-81DF-7C82F4CF436B")]
    [Description("Крутогорская 1-я")]
    Krutogorskaya1,
    [EnumGuid("7D9CAB30-4479-4DD9-BEE1-843E8BBB76AC")]
    [Description("1-я Крутогорская")]
    Krutogorska_ya1,
    [EnumGuid("94E4F1CF-9C36-4FC9-8300-D6AB015B098B")]
    [Description("Крутогорская 2-я")]
    Krutogorskaya2,
    [EnumGuid("EEF84D69-36B7-44DB-B7F8-015053F41C21")]
    [Description("2-я Крутогорская")]
    Krutogorska_ya2,
    [EnumGuid("337CD6FE-EFE0-4140-9217-609F38E86688")]
    [Description("Крылова")]
    Krylova,
    [EnumGuid("79C3ADE4-41E1-4065-838D-1E7346904806")]
    [Description("Кубанская")]
    Kubanskaya,
    [EnumGuid("CF1F4921-0520-4715-ABFC-F1D865927A5B")]
    [Description("Кузнецкий")]
    Kuznetskiy,
    [EnumGuid("7AA9426C-D32A-49EE-94C8-42C8347BEA4E")]
    [Description("Куйбышева")]
    Kuybysheva,
    [EnumGuid("A66AA241-33E0-408B-9C47-92859782923F")]
    [Description("Куйсумская")]
    Kuysumskaya,
    [EnumGuid("F88683DB-0D70-4209-83D1-D95223E17FE9")]
    [Description("Куксинский")]
    Kuksinskiy,
    [EnumGuid("04DFF58D-FC52-4608-BB20-0DF0EDA95B6F")]
    [Description("Курагинская")]
    Kuraginskaya,
    [EnumGuid("84143D7A-798D-46DF-B53D-62FBA312F6E0")]
    [Description("Курганская")]
    Kurganskaya,
    [EnumGuid("03FD75BE-7765-46DF-96FD-95CF6E0D8994")]
    [Description("Курейская")]
    Kureyskaya,
    [EnumGuid("1B1FB442-2BFA-41FB-8C7C-9BF5ABC45B27")]
    [Description("Куренная")]
    Kurenaya,
    [EnumGuid("339D60A8-7CD7-424F-97F8-E3AAAF4A16AF")]
    [Description("Курчатова")]
    Kurchatova,
    [EnumGuid("6BCF2BAE-A83A-44B7-BA77-F905B358A680")]
    [Description("Кутузова")]
    Kutuzova,
    [EnumGuid("45CFCDBF-6D25-48C0-B4B2-E87F43CE628C")]
    [Description("Кутузова 2-я")]
    Kutuzova2,
    [EnumGuid("83889260-A685-4E24-A9EC-1FD24CA5BB5A")]
    [Description("2-я Кутузова")]
    Kutuzova_2,

    #endregion
    
    #region Улицы на букву Л
    
    [EnumGuid("D24F5C54-F444-4006-A8E2-829525266089")]
    [Description("Лабазный")]
    Labazniy,
    [EnumGuid("446ADC7D-8671-4D77-A1CC-67A5E8431DEF")]
    [Description("Ладо Кецховели")]
    LadoKechkhoveli,
    [EnumGuid("08CE180E-DE3F-4292-880F-4714D33F71CA")]
    [Description("Лазурная")]
    Lazurnaya,
    [EnumGuid("51AD2CF8-8371-44EB-B8C1-45440DFB50B0")]
    [Description("Лалетино")]
    Laletino,
    [EnumGuid("64368AAC-655D-4C4A-9409-820AADEE39F0")]
    [Description("Ламская")]
    Lamskaya,
    [EnumGuid("C553456E-7C31-46E8-BCF1-CC74D7776EEA")]
    [Description("Ленина")]
    Lenina,
    [EnumGuid("6FBB86ED-87C0-40DA-B938-A38DF57F9CEB")]
    [Description("Ленинградская")]
    Leningradskaya,
    [EnumGuid("4E9C46EE-AB66-407E-A35D-A516F4FCE98F")]
    [Description("Ленинградская 1-я")]
    Leningradskaya1,
    [EnumGuid("7B6A0ACE-3F42-4309-87D9-B4A6B04760A9")]
    [Description("1-я Ленинградская")]
    Leningradska_ya1,
    [EnumGuid("7D3861B2-CAA2-441F-AC0E-13978A8C6A5B")]
    [Description("Лермонтова")]
    Lermontova,
    [EnumGuid("8763941A-907E-47D0-B371-C8895E5F64BE")]
    [Description("Лесная")]
    Lesnaya,
    [EnumGuid("FBE34967-FB20-4AEA-83A7-76151D602C53")]
    [Description("Лесников")]
    Lesnikov,
    [EnumGuid("BFCDA052-330C-4B38-ABED-DEE8545606C1")]
    [Description("Лесной")]
    Lesnoy,
    [EnumGuid("49ABB922-8C73-4390-926A-F52A76F65600")]
    [Description("Лесопарковая")]
    Lesoparkovaya,
    [EnumGuid("1EFE8EE3-4B32-413C-BF62-50704801AECC")]
    [Description("Лесоперевалочная")]
    Lesoperevalochnaya,
    [EnumGuid("E31C5661-A483-466B-9B90-15E1C5EC0895")]
    [Description("Лесопильщиков")]
    Lesopilschikov,
    [EnumGuid("5D802D83-2774-45F0-9C13-A22B841034D8")]
    [Description("Лесопитомник")]
    Lesopitomnik,
    [EnumGuid("ACB26937-E0B2-487F-ABE8-D628540CA5C4")]
    [Description("Лесосибирский")]
    Lesosibirskiy,
    [EnumGuid("4EDFC4D2-C07E-4B41-9E25-A232910E6718")]
    [Description("Лесосплавная")]
    Lesosplavnaya,
    [EnumGuid("7DF94615-F8A6-47D4-903F-04BD0BB91807")]
    [Description("Летчиков")]
    Letchikov,[EnumGuid("C23ADDD9-97F8-4D55-9A91-F4F77CF24763")]
    [Description("Лиды Прушинской")]
    LidyPrushinskoy,
    [EnumGuid("B5A0AF60-CD40-4676-9C3F-A98E2932CEFD")]
    [Description("Лизы Чайкиной")]
    LiziChaykinoy,
    [EnumGuid("CAAFBD77-AF55-43ED-A218-17E80470C6D3")]
    [Description("Линейная")]
    Lineynaya,
    [EnumGuid("FD009479-55EF-4DDB-AB64-BDD06E3EE98C")]
    [Description("Линейная 2-я")]
    Lineynaya2,
    [EnumGuid("8E66BC17-0CDC-4BFE-AF64-B38B01AA5ADE")]
    [Description("2-я Линейная")]
    Lineyna_ya2,
    [EnumGuid("D84B451E-923D-481F-BCAE-F241156F7C02")]
    [Description("Линейная 3-я")]
    Lineynaya3,
    [EnumGuid("6E25CDF1-5E90-43EE-A607-A438A816C8A3")]
    [Description("3-я Линейная")]
    Lineyna_ya3,
    [EnumGuid("12F7C60D-22DD-4437-9028-519D2317EB1D")]
    [Description("Линейная 4-я")]
    Lineynaya4,
    [EnumGuid("6943E05F-1605-4B1F-824E-11A68A608A6D")]
    [Description("4-я Линейная")]
    Lineyna_ya4,
    [EnumGuid("B513DB6C-59CC-44A5-846C-1352C495EC13")]
    [Description("Линейная 5-я")]
    Lineynaya5,
    [EnumGuid("185238EF-14D1-408B-B9FC-A6CFB8E2748B")]
    [Description("5-я Линейная")]
    Lineyna_ya5,
    [EnumGuid("D1FAFC07-152C-4947-8332-BAA76C71C3A6")]
    [Description("Линейная 6-я")]
    Lineynaya6,
    [EnumGuid("6452493E-128C-4610-882B-744769889DC9")]
    [Description("6-я Линейная")]
    Lineyna_ya6,
    [EnumGuid("DC6D01D8-EF09-4773-A14B-0BAEC19570AF")]
    [Description("Линейная 7-я")]
    Lineynaya7,
    [EnumGuid("8B5F2D6F-3F68-4121-87AA-4A83C37182B5")]
    [Description("7-я Линейная")]
    Lineyna_ya7,
    [EnumGuid("B51FC4C6-4505-4B40-955A-4614C386ABEE")]
    [Description("Лириков")]
    Lirikov,
    [EnumGuid("00E058C5-DCE0-4CE4-AEB2-B73EB6C7F4CD")]
    [Description("Лиственная")]
    Listvennaya,
    [EnumGuid("67FCDA21-FA59-49A5-9F16-13FCB7AD13BF")]
    [Description("Листвяжный Лог")]
    ListvyazhniyLog,
    [EnumGuid("13D16C14-6C54-44C8-B2F9-E768CA27E328")]
    [Description("Литейная")]
    Liteynaya,
    [EnumGuid("731A920F-B6B4-41AD-B08E-68401F002419")]
    [Description("Лихачева")]
    Likhacheva,
    [EnumGuid("CACDA311-D416-40E2-8E65-6DE49EF37FF3")]
    [Description("Лодочная")]
    Lodochaya,
    [EnumGuid("175B6A95-4A0F-433B-B628-841DA8C55B2E")]
    [Description("Локомотивная")]
    Lokomotivnaya,
    [EnumGuid("74E57B61-4010-4798-9666-8DE8DDE4A066")]
    [Description("Ломоносова")]
    Lomonosova,
    [EnumGuid("315AD927-DC15-4429-B5F9-094A10E22CD0")]
    [Description("Луговая")]
    Lugovaya,
    [EnumGuid("4F31FC14-198B-4461-AAD1-682E8DEA891B")]
    [Description("Луначарского")]
    Lunacharskogo,
    [EnumGuid("9E5FA752-1F76-44BF-AA9B-DB0F4FAFD207")]
    [Description("Лучистая")]
    Luchistaya,
    [EnumGuid("C1FF17AB-0AA3-4A07-A929-EA5E3FF9A6EC")]
    [Description("Львовская")]
    Lvovskaya,
    [EnumGuid("5BF43868-0CFE-478F-BDA9-7BACAD1BEBD5")]
    [Description("Любимый")]
    Lyubimiy,
    [EnumGuid("E3E98362-CBA8-4E9A-87DE-F8EA36AC8A1C")]
    [Description("Любы Шевцовой")]
    LyubyShevtsovoy,
    
    #endregion
    
    #region Улицы на букву М
    
    [EnumGuid("CD6AC6BC-319B-43DE-A63B-27B275A3456B")]
    [Description("Магистральная")]
    Magistralnaya,
    [EnumGuid("74339A80-4F3E-47C2-87C5-77CADD2138AD")]
    [Description("Магнитогорская")]
    Magnitogorskaya,
    [EnumGuid("B440E53F-EF62-4454-94E3-38863B0357A4")]
    [Description("Маерчака")]
    Mayerchaka,
    [EnumGuid("588725C6-DAEF-42A2-BE8D-F8E447AB66EA")]
    [Description("Майская")]
    Mayskaya,
    [EnumGuid("FDA2B1DB-B973-4951-85E3-EFE787A917F0")]
    [Description("Макаренко")]
    Makarenko,
    [EnumGuid("DC7BDE3A-BA2A-48A4-8A4D-503085235076")]
    [Description("Малаховская")]
    Malahovskaya,
    [EnumGuid("D348DB1C-55C2-478A-AA41-22069890B68E")]
    [Description("Малая")]
    Malaya,
    [EnumGuid("BF4A4DDA-EB45-44D5-A24B-4A64DE5D986E")]
    [Description("Малиновая")]
    Malinovaya,
    [EnumGuid("6294EE0E-6373-4F6E-A731-7921F3C4E630")]
    [Description("Малиновского")]
    Malinovskogo,
    [EnumGuid("E233CEBB-B0EC-455E-A574-BED9070B9656")]
    [Description("Малтатский")]
    Maltatskiy,
    [EnumGuid("50560BCA-8145-46BE-BE10-5B1B171EBECC")]
    [Description("Мангазейская")]
    Mangazeyskaya,
    [EnumGuid("5BE0ED6B-1FB6-4A3F-84C0-CD98C17A5C1D")]
    [Description("Марата")]
    Marata,
    [EnumGuid("137A050B-7C4D-43FF-A72E-C33604E34663")]
    [Description("Марии Ульяновой")]
    MariiUlyanovoy,
    [EnumGuid("94F7B59E-BC5C-4DE7-A6D7-CDC5166C6023")]
    [Description("Марии Цукановой")]
    MariiTsukanovoy,
    [EnumGuid("27EBB392-5EF2-49F5-B98F-F1F9C864C5FA")]
    [Description("Марковского")]
    Markovskogo,
    [EnumGuid("4BD21C60-7A3B-425F-8B9B-1BD91664361F")]
    [Description("Матвеева")]
    Matveeva,
    [EnumGuid("AF0BC9AA-26C7-4762-AB5D-0356E3F30F14")]
    [Description("Мате Залки")]
    MateZalki,
    [EnumGuid("54D419DB-EA34-4662-8AEB-951C7E21FCA2")]
    [Description("Машиностроителей")]
    Mashinostroiteley,
    [EnumGuid("FDACEA43-7982-4631-87B0-C9CFF158D8E5")]
    [Description("Маяковского")]
    Mayakovskogo,
    [EnumGuid("9D9D5C2D-78F6-4B1B-A0DB-C30EECCCF7E9")]
    [Description("Мебельная")]
    Mebelnaya,
    [EnumGuid("69482E02-C4F1-452D-B543-E06A5DA2110C")]
    [Description("Медицинский")]
    Meditsinskiy,
    [EnumGuid("0DB6B8CF-3B91-48F0-AAE9-71835ACD353A")]
    [Description("Медовая")]
    Medovaya,
    [EnumGuid("6020C496-4D7E-4514-831C-C5C849D0638E")]
    [Description("Мелькомбинатская")]
    Melkombinatskaya,
    [EnumGuid("1F88CED2-F4FB-43C6-9F62-24D09944068C")]
    [Description("Мелькомбинатская 2-я")]
    Melkombinatskaya2,
    [EnumGuid("A64379E3-AF11-43BA-BBA6-AA58D43549E3")]
    [Description("2-я Мелькомбинатская")]
    Melkombinatska_ya2,
    [EnumGuid("830771D8-B277-41D0-B30B-F917A3141E8F")]
    [Description("Менделеева")]
    Mendeleeva,
    [EnumGuid("529B39CC-9BEA-4E20-8160-0AEDF15C72C4")]
    [Description("Менжинского")]
    Menzhinskogo,
    [EnumGuid("5304C549-1E46-4B40-8C1B-4D0026EA5C30")]
    [Description("Металлургов")]
    Metallurgov,
    [EnumGuid("66FC275E-A2DA-4B5B-82ED-8C7016248FBE")]
    [Description("Мечникова")]
    Mechnikova,
    [EnumGuid("A75D63FD-F3C5-4A0D-8D1C-B8B2E8BDE707")]
    [Description("Микуцкого")]
    Mikutskogo,
    [EnumGuid("C84CA287-927A-4FA1-A07C-8298E3C25137")]
    [Description("Минина")]
    Minina,
    [EnumGuid("8D83303B-A78E-410A-9C97-B0D1DDD208E0")]
    [Description("Минская")]
    Minskaya,
    [EnumGuid("A5109F8F-EF43-4611-96DC-889623BCBAB7")]
    [Description("Минусинская")]
    Minusinskaya,
    [EnumGuid("21F0CAD5-33B1-4EC7-942F-B5C56171E4FE")]
    [Description("Мира")]
    Mira,
    [EnumGuid("5AAEC5BC-825F-48A7-8A65-4F8C649A3F19")]
    [Description("Мирошниченко")]
    Miroshnichenko,
    [EnumGuid("B9D09132-DD4B-4704-90BB-A6FDD4F2EBB2")]
    [Description("Михаила Годенко")]
    MikhailaGodenko,
    [EnumGuid("BCEF5E9C-4B2D-40B9-99E5-D8DB5EEC6745")]
	[Description("Годенко")]
    Godenko,
    [EnumGuid("0EACFAF9-9FB2-4D62-BB17-1CDE5E19C064")]
    [Description("Мичурина")]
    Michurina,
    [EnumGuid("9D501510-5A2D-474F-B18D-165C000B514E")]
    [Description("Можайского")]
    Mozhayskogo,
    [EnumGuid("B7574F97-F154-4DAD-AB65-EB332D869073")]
    [Description("Молодежный")]
    Molodezhniy,
    [EnumGuid("63DB6BA6-8734-47DB-8933-2EAAE55A4B46")]
    [Description("Молодогвардейцев")]
    Molodogvardeytsev,
    [EnumGuid("EEE93BFE-2A43-4194-B7D3-56FB40632A63")]
    [Description("Молодости")]
    Molodosti,
    [EnumGuid("3D8FF1A1-B7BD-474F-82BE-0B19FAE8E6F6")]
    [Description("Молокова")]
    Molokova,
    [EnumGuid("901B2CDD-CC84-42ED-84B4-471B475CC47F")]
    [Description("Монастырская")]
    Monastyrskaya,
    [EnumGuid("6D139A02-1E6F-4B63-8BFB-EF0521B17E76")]
    [Description("Монтажников")]
    Montazhnikov,
    [EnumGuid("07E3F35C-EA9C-4DED-B78F-5C05825D9CBD")]
    [Description("Московская")]
    Moskovskaya,
    [EnumGuid("820C67DB-255D-47CA-AAFB-91108B46221F")]
    [Description("Мостовиков")]
    Mostovikov,
    [EnumGuid("CF8E7708-102A-4808-8B6F-042EC83B0606")]
    [Description("Моторная")]
    Motornaya,
    [EnumGuid("B2A58868-98BB-48B7-89AC-F629AFB9A509")]
    [Description("Моховая")]
    Mokhovaya,
    [EnumGuid("1254ADC6-7DB7-43E6-B77C-8B7CD6B461E5")]
    [Description("МПС")]
    Mps,
    [EnumGuid("3DF05FD1-7F33-4DFA-B07C-B2F711E946BD")]
    [Description("Мужества")]
    Muzhestva,
    [EnumGuid("84572DA3-2353-4DC2-8420-76A68BC4DED5")]
    [Description("Мурманская")]
    Murmanskaya,
    [EnumGuid("95796331-9E68-40A3-B427-EADE68988B37")]
    [Description("Мусоргского")]
    Musorgskogo,
    [EnumGuid("6F043DED-3126-4DA2-AC30-D3CA82FBF472")]
    [Description("Мясокомбинат")]
    Myasokombinat,
    
    #endregion
    
    #region Улицы на букву Н
    
    [Description("Навигационная")]
    Navigatsionnaya,
    [Description("Нагорная")]
    Nagornaya,
    [Description("Назаровская")]
    Nazarovskaya,
    [Description("Наклонная")]
    Naklonnaya,
    [Description("Нанжульская")]
    Nanzhulskaya,
    [Description("Национальная")]
    Natsionalnaya,
    [Description("Невская")]
    Nevskaya,
    [Description("Независимости")]
    Nezavisimosti,
    [Description("Некрасова")]
    Nekrasova,
    [Description("Нерчинская")]
    Nerchinskaya,
    [Description("Нестерова")]
    Nesterova,
    [Description("Нефтяной")]
    Neftyanoy,
    [Description("Никитина")]
    Nikitina,
    [Description("Николаева")]
    Nikolaeva,
    [Description("Николаевский")]
    Nikolaevskiy,
    [Description("Николая Донского")]
    NikolayaDonskogo,
    [Description("Новаторская")]
    Novatorskaya,
    [Description("Новая")]
    Novaya,
    [Description("Новая Заря")]
    NovayaZarya,
    [Description("Новгородская")]
    Novgorodskaya,
    [Description("Новогорская")]
    Novogorskaya,
    [Description("Новой Жизни")]
    NovoyZhizni,
    [Description("Новомлинская")]
    Novomlinskaya,
    [Description("Новосибирская")]
    Novosibirskaya,
    [Description("Новостроек")]
    Novostroyek,
    [Description("Норильская")]
    Norilskaya,
    
    #endregion
    
    #region Улицы на букву О
    
    [Description("Обзорная")]
    Obzornaya,
    [Description("Облачная")]
    Oblachnaya,
    [Description("Облепиховая")]
    Oblepikhovaya,
    [Description("Обороны")]
    Oborony,
    [Description("Овражная")]
    Ovrashnaya,
    [Description("2-я Огородная")]
    Ogorodnaya2,
    [Description("Одесская")]
    Odesskaya,
    [Description("Одесский")]
    Odesskiy,
    [Description("Односторонний")]
    Odnostoronniy,
    [Description("Озерная")]
    Ozerennaya,
    [Description("2-я Озёрная")]
    Ozernaya2,
    [Description("4-я Озёрная")]
    Ozernaya4,
    [Description("Окаемная")]
    Okaymnaya,
    [Description("Окружная")]
    Okruzhnaya,
    [Description("Октябрьская")]
    Oktyabrskaya,
    [Description("Олега Кошевого")]
    OlegaKoshevoy,
    [Description("Олейникова")]
    Oleynikova,
    [Description("Олониченко")]
    Olonichenko,
    [Description("Ольховая")]
    Olkhovaya,
    [Description("Омская")]
    Omskaya,
    [Description("Ореховская")]
    Orekhovskaya,
    [Description("Орловская")]
    Orlovskaya,
    [Description("Осенняя")]
    Osennaya,
    [Description("Осипенко")]
    Osipenko,
    [Description("Остров Отдыха")]
    OstrovOtdyha,
    [Description("Островная")]
    Ostrovskaya,
    [Description("Островского")]
    Ostrovskogo,
    [Description("Острожная")]
    Ostrozhnaya,
    [Description("Отважный")]
    Otvazhniy,
    [Description("Отдыха")]
    Otdyha,
    [Description("Отрадная")]
    Otrada,
    [Description("Офицерская")]
    Ofitserskaya,
    [Description("Охраны Труда")]
    OkhranyTruda,
    
    #endregion
    
    #region Улицы на букву П
    
    [Description("Павлика Морозова")]
    PavlikaMorozova,
    [Description("Памяти Героев")]
    PamyatiGeroev,
    [Description("Паниковская")]
    Panikovskaya,
    [Description("Панорамная")]
    Panoramnaya,
    [Description("Панфиловцев")]
    Panfilovtsev,
    [Description("Папанинцев")]
    Papanintsev,
    [Description("Парадовского")]
    Paradovskogo,
    [Description("Парашютная")]
    Parashyutnaya,
    [Description("Парижской Коммуны")]
    ParizhskoyKommuny,
    [Description("Парковая")]
    Parkovaya,
    [Description("Паровозная")]
    Parovoznaya,
    [Description("Партизана Железняка")]
    PartizanaZheleznaka,
    [Description("Партизанская")]
    Partizanskaya,
    [Description("Парусная")]
    Parusnaya,
    [Description("Пархоменко")]
    Parkhomenko,
    [Description("Пасечная")]
    Pasechnaya,
    [Description("Пастеровская")]
    Pasterevskaya,
    [Description("Пасхальная")]
    Paskhalnaya,
    [Description("Первых Пионеров")]
    PervykhPionerov,
    [Description("Перенсона")]
    Perensona,
    [Description("Перепелиная")]
    Perepelina,
    [Description("Перспективная")]
    Perspektivnaya,
    [Description("Песочная")]
    Pesochaya,
    [Description("Петлина")]
    Petlina,
    [Description("Петра Ломако")]
    PetraLomako,
    [Description("Петра Подзолкова")]
    PetraPodzolkova,
    [Description("Петра Словцова")]
    PetraSlovtsa,
    [Description("Словцова")]
    Slovtsova,
    [Description("Петрушина")]
    Petrushina,
    [Description("Пионеров 2-я")]
    Pionerov2,
    [Description("2-я Пионеров")]
    Pionerov_2,
    [Description("Пионеров 3-я")]
    Pionerov3,
    [Description("3-я Пионеров")]
    Pionerov_3,
    [Description("Пировская")]
    Pirovskaya,
    [Description("Пирогова")]
    Pirogova,
    [Description("Писарева")]
    Pisareva,
    [Description("Пихтовая")]
    Pikhtovaya,
    [Description("Плановая")]
    Planovaya,
    [Description("Плодовая")]
    Plodovaya,
    [Description("Победы")]
    Pobedy,
    [Description("Побежимова")]
    Pobezhimova,
    [Description("Пограничников")]
    Pogranichnikov,
    [Description("Подгорная")]
    Podgornaya,
    [Description("Подсобная")]
    Podsobnaya,
    [Description("Подъемная")]
    Podyomnaya,
    [Description("Пожарского")]
    Pozharskogo,
    [Description("Позднякова")]
    Pozdnyakova,
    [Description("Пойменный")]
    Poymenny,
    [Description("Покровская")]
    Pokrovskaya,
    [Description("Полевая")]
    Polevaya,
    [Description("Полевой")]
    Polevoy,
    [Description("Ползунова")]
    Polzunova,
    [Description("Полигонная")]
    Poligonaya,
    [Description("Полтавская")]
    Poltavskaya,
    [Description("Полярная")]
    Polyarnaya,
    [Description("3-я Полярная")]
    Polyarnaya3,
    [Description("4-я Полярная")]
    Polyarnaya4,
    [Description("5-я Полярная")]
    Polyarnaya5,
    [Description("6-я Полярная")]
    Polyarnaya6,
    [Description("7-я Полярная")]
    Polyarnaya7,
    [Description("Поперечный")]
    Poperechny,
    [Description("Попова")]
    Popova,
    [Description("Пороховой")]
    Porokhovoy,
    [Description("Посадный")]
    Posadniy,
    [Description("Посадская")]
    Posadskaya,
    [Description("Послушников")]
    Poslushnikov,
    [Description("Послушников")]
    Poslushnikov2,
    [Description("Походная")]
    Pokhodnaya,
    [Description("Преображенская")]
    Preobrazhenskaya,
    [Description("Пржевальского")]
    Przhevalskogo,
    [Description("Прибойная")]
    Priboynaya,
    [Description("Привокзальная")]
    Privokzalnaya,
    [Description("Пригорная")]
    Prigornaya,
    [Description("Придорожная")]
    Pridorozhnaya,
    [Description("Приручейная")]
    Prirucheynaya,
    [Description("Приручейная 2-я")]
    Prirucheynaya2,
    [Description("Приручейный")]
    Prirucheyny,
    [Description("Приусадебный")]
    Priusadebny,
    [Description("Причальная 5-я")]
    Prichalnaya5,
    [Description("Прогулочная")]
    Progulochnaya,
    [Description("Продольная")]
    Prodolnaya,
    [Description("Продольная 10-я")]
    Prodolnaya10,
    [Description("Продольная 11-я")]
    Prodolnaya11,
    [Description("Продольная 2-я")]
    Prodolnaya2,
    [Description("Продольная 3-я")]
    Prodolnaya3,
    [Description("Продольная 4-я")]
    Prodolnaya4,
    [Description("Продольная 5-я")]
    Prodolnaya5,
    [Description("Продольная 6-я")]
    Prodolnaya6,
    [Description("Продольная 7-я")]
    Prodolnaya7,
    [Description("Продольная 8-я")]
    Prodolnaya8,
    [Description("Продольная 9-я")]
    Prodolnaya9,
    [Description("Проектная")]
    Proyektnaya,
    [Description("Пролетарская")]
    Proletarskaya,
    [Description("Промбаза")]
    Prombaza,
    [Description("Промысловая")]
    Promyslovaya,
    [Description("Промышленный")]
    Promyshlenniy,
    [Description("Просвещения")]
    ProsvesheniyaBerezovka,
    [Description("Просторная")]
    Prostoraya,
    [Description("Профсоюзов")]
    Profsoyuzov,
    [Description("Прохладный")]
    Prokhladniy,
    [Description("Прямая")]
    Pryamaya,
    [Description("Пугачева")]
    Pugacheva,
    [Description("Путевая")]
    Putevaya,
    [Description("Путиловская")]
    Putilovskaya,
    [Description("Путоранская")]
    Putoranskaya,
    [Description("Пушкина")]
    Pushkina,
    [Description("Пясинская")]
    Pyasinskaya,
    
    #endregion
    
    #region Улицы на букву Р
    
    [Description("Рабочая")]
    Rabochaya,
    [Description("Радищева")]
    Raditsheva,
    [Description("Радужная")]
    Radzhumnaya,
    [Description("Раздольная")]
    Razdolnaya,
    [Description("Раскатная")]
    Raskatnaya,
    [Description("Рассветная")]
    Rossvetnaya,
    [Description("Революции")]
    Revolyutsionnaya,
    [Description("Регатная")]
    Regatnaya,
    [Description("Рейдовая")]
    Reydovaya,
    [Description("Ремесловская")]
    Remeslovskaya,
    [Description("Ремесленная")]
    Remeslennaya,
    [Description("Республика")]
    Respublika,
    [Description("Речников")]
    Rechkov,
    [Description("Речной")]
    Rechnyy,
    [Description("Робеспьера")]
    Robespierre,
    [Description("Ровная")]
    Rovnaya,
    [Description("Рогова")]
    Rogova,
    [Description("Родниковая")]
    Rodnikovaya,
    [Description("Рождественская")]
    Rozhdestvenskaya,
    [Description("Рождественская")]
    Rozhdestvenskaya2,
    [Description("Розы Люксембург")]
    RozyLuksemburg,
    [Description("Рокоссовского")]
    Rozhdonskogo,
    [Description("Российская")]
    Rossiyskaya,
    [Description("Рощевая")]
    Rozchevaya,
    [Description("Русаковская")]
    Rusakovskaya,
    [Description("Ручейная")]
    Rechnyaya,
    [Description("Рябиновая")]
    Rabanovaya,
    [Description("Рязанская")]
    Ryazanskaya,
    [Description("Ряузовский")]
    Ryauzovskii,
    
    #endregion

    #region Улицы на букву С

    [Description("Сад Крутовского")]
    SadKrutovskogo,
    [Description("Садовая")]
    Sadovaya,
    [Description("Садовая")]
    Sadovaya2,
    [Description("Садовая")]
    Sadovaya3,
    [Description("Сады")]
    Sady,
    [Description("Самарский")]
    Samarskiy,
    [Description("Самодеятельности")]
    Samodeyatelnosti,
    [Description("Санаторная")]
    Sanatornaya,
    [Description("Саянская")]
    Sayanskaya,
    [Description("Свердловская")]
    Sverdlovskaya,
    [Description("Светлая Элита")]
    SvetlayaElita,
    [Description("Светлова")]
    Svetlova,
    [Description("Светлогорская")]
    Svetlogorskaya,
    [Description("Светлогорский")]
    Svetlogorskiy,
    [Description("Светлогорский")]
    Svetlogorskiy2,
    [Description("Светлый")]
    Svetliy,
    [Description("Свободная")]
    Svobodnaya,
    [Description("Свободный")]
    Svobodniy,
    [Description("Связи")]
    Svazi,
    [Description("Связистов")]
    Svyazistov,
    [Description("Севастопольский")]
    Sevastopolskiy,
    [Description("Северная")]
    Severnaya,
    [Description("Северное")]
    Severnoe,
    [Description("Северный")]
    Severniy,
    [Description("Северо-Енисейская")]
    SeveroYeniseyskaya,
    [Description("Седова")]
    Sedova,
    [Description("Сезонников")]
    Sezonnikov,
    [Description("Сельская")]
    Selskaya,
    [Description("Семафорная")]
    Semafornaya,
    [Description("Семена Давыдова")]
    SemenaDavydova,
    [Description("Сенная")]
    Sennaya,
    [Description("Серафимовича")]
    Serafimovicha,
    [Description("Сергея Куликова")]
    SergeyaKulikova,
    [Description("Сергея Лазо")]
    SergeyaLazo,
    [Description("Сергея Тюленина")]
    SergeyaTyulenina,
    [Description("Серебряный")]
    Serebryaniy,
    [Description("Серебряный Бор")]
    SerebryaniyBor,
    [Description("Серова")]
    Serova,
    [Description("Сеченова")]
    Sechenova,
    [Description("Сибирская")]
    Sibirskaya,
    [Description("Сибирский")]
    Sibirskiy,
    [Description("Сиреневая")]
    Sirennevaya,
    [Description("Сисимский")]
    Sisimskiy,
    [Description("Скальная")]
    Skalnaya,
    [Description("Сквозной")]
    Skvoznoy,
    [Description("Складская")]
    Skladskaya,
    [Description("Славы")]
    Slavy,
    [Description("Славянская")]
    Slavyanskaya,
    [Description("Слободская")]
    Slobodskaya,
    [Description("Смоленская 1-я")]
    Smolenskaya1,
    [Description("Смоленская 2-я")]
    Smolenskaya2,
    [Description("Смоленская 3-я")]
    Smolenskaya3,
    [Description("Снежная")]
    Snezhnaya,
    [Description("Советская")]
    Sovetskaya,
    [Description("Содружества")]
    Sodruzhestva,
    [Description("Соколовская")]
    Sokolovskaya,
    [Description("Сокольский")]
    Sokolskiy,
    [Description("Солнечная")]
    Solnechnaya,
    [Description("Солнечный")]
    Solnechniy,
    [Description("Солонцовая")]
    Solontsovaya,
    [Description("Сопочная")]
    Sopochaya,
    [Description("Соревнования")]
    Sorevnovaniya,
    [Description("Сосновая")]
    Sosnovaya,
    [Description("Сосновая")]
    Sosnovaya2,
    [Description("Сосновского")]
    Sosnovskogo,
    [Description("Сосновый Бор")]
    SosnoviyBor,
    [Description("Софьи Ковалевской")]
    SofyiKovalevskoy,
    [Description("Социалистическая")]
    Sotsialisticheskaya,
    [Description("Спандаряна")]
    Spandaryana,
    [Description("Спартаковцев")]
    Spartakovtsev,
    [Description("Спасского")]
    Spasskogo,
    [Description("Сплавучасток")]
    Splavuchastok,
    [Description("Спокойная")]
    Spokoinaya,
    [Description("Спорта")]
    Sporta,
    [Description("Спортивная")]
    Sportivnaya,
    [Description("Спортивный")]
    Sportivniy,
    [Description("Средний")]
    Sredniy,
    [Description("Сретенская")]
    Sretenkaya,
    [Description("Стадионная")]
    Stadionnaya,
    [Description("Станиславского")]
    Stanislavskogo,
    [Description("Станичная")]
    Stanichnaya,
    [Description("Становая")]
    Stanovaya,
    [Description("Станочная")]
    Stanochaya,
    [Description("Станционная")]
    Stantsionnaya,
    [Description("Степана Разина")]
    StepanaRazina,
    [Description("Столбовая")]
    Stolbovaya,
    [Description("Стрелецкая")]
    Streltskaya,
    [Description("Стрелочная")]
    Strelochnaya,
    [Description("Строительная")]
    Stroitelnaya,
    [Description("Суворова")]
    Suvorova,
    [Description("Судостроительная")]
    Sudostroitelnaya,
    [Description("Сурикова")]
    Surikova,
    [Description("Счастливая")]
    Schastlivaya,

    #endregion

    #region Улицы на букву Т

    [Description("Таежная")]
    Tayezhnaya,
    [Description("Бугачево")]
    Bugachevo,
    [Description("Таймырская")]
    Taymyrskaya,
    [Description("1-я Таймырская")]
    Taymyrskaya1,
    [Description("2-я Таймырская")]
    Taymyrskaya2,
    [Description("3-я Таймырская")]
    Taymyrskaya3,
    [Description("4-я Таймырская")]
    Taymyrskaya4,
    [Description("5-я Таймырская")]
    Taymyrskaya5,
    [Description("Талнахская")]
    Talnakhskaya,
    [Description("Тамбовская")]
    Tambovskaya,
    [Description("Танкистов")]
    Tankistov,
    [Description("Таскинская")]
    Taskinskaya,
    [Description("Татышев")]
    Tatyshev,
    [Description("Таштыпский")]
    Tashtypskiy,
    [Description("Театральная")]
    Teatralnaya,
    [Description("Текстильщиков")]
    Tekstilshchikov,
    [Description("Телевизорная")]
    Televidzornaya,
    [Description("Телевизорный")]
    Televidzorniy,
    [Description("Тельмана")]
    Telmana,
    [Description("Тенистая")]
    Tenistaya,
    [Description("Теплый")]
    Teplyy,
    [Description("Терешковой")]
    Tereshkovoy,
    [Description("Техническая")]
    Tekhnicheskaya,
    [Description("Технический Поселок")]
    TekhnicheskiyPoselok,
    [Description("Технологическая")]
    Tekhnologicheskaya,
    [Description("Тимирязева")]
    Timiryazeva,
    [Description("Тихий")]
    Tikhiy,
    [Description("Тихоновская")]
    Tikhonovskaya,
    [Description("Тобольская")]
    Tobolskaya,
    [Description("Толстого")]
    Tolstogo,
    [Description("Томская")]
    Tomskaya,
    [Description("Торгашинская")]
    Torgashinskaya,
    [Description("Торговая")]
    Torgovaya,
    [Description("Тотмина")]
    Totmina,
    [Description("Трактовая")]
    Traktovaya,
    [Description("Трактористов")]
    Traktoristov,
    [Description("Транзитная")]
    Tranzitnaya,
    [Description("Транспортный")]
    Transportniy,
    [Description("Транспортный")]
    Transportniy2,
    [Description("Троицкая")]
    Troitskaya,
    [Description("Труда")]
    Truda,
    [Description("Тубинская")]
    Tubinskaya,
    [Description("Туимский")]
    Tuimskiy,
    [Description("Туманный")]
    Tumanniy,
    [Description("Тупиковый")]
    Tupikoviy,
    [Description("Турбаза")]
    Turbaza,
    [Description("Турбинная")]
    Turbinaya,
    [Description("Тургенева")]
    Turgeneva,
    [Description("Туристская")]
    Turistskaya,
    [Description("Туруханская")]
    Turukhanskaya,
    [Description("Турчанинова")]
    Turchaninova,
    [Description("Тюхтетский")]
    Tyukhtetskaya,

    #endregion

    #region Улицы на букву У

    [Description("Угловой")]
    Uglovoy,
    [Description("Угольный")]
    Ugolniy,
    [Description("Угольщиков")]
    Ugolshchikov,
    [Description("Ударный")]
    Udarniy,
    [Description("Удачная")]
    Udachnaya,
    [Description("Удобный")]
    Udobniy,
    [Description("Узкий")]
    Uzkij,
    [Description("Украинская")]
    Ukrainskaya,
    [Description("Уланова")]
    Ulanova,
    [Description("Ульяновский")]
    Ulyanovskiy,
    [Description("Ульяны Громовой")]
    UlyaniGromovoy,
    [Description("Уральский")]
    Uraliskiy,
    [Description("Урванцева")]
    Urvantseva,
    [Description("Урицкого")]
    Uritskogo,
    [Description("Урожайная")]
    Urozhaynaya,
    [Description("Усадебная")]
    Usadebnaya,
    [Description("Успенская")]
    Uspenskaya,
    [Description("Уссурийская")]
    Ussuriyskaya,
    [Description("Устиновича")]
    Ustinovicha,
    [Description("Утренняя")]
    Utrennyaya,
    [Description("Ухоженный")]
    Ukhozhenniy,
    [Description("Участок 5-й")]
    Uchastok5,
    [Description("Учумская")]
    Uchumskaya,
    [Description("Уютная")]
    Uyutnaya,
    [Description("Уютный")]
    Uyutniy,
    [Description("Уярская")]
    Uyarskaya,

    #endregion

    #region Улицы на букву Ф

    [Description("Фабричная")]
    Fabrichnaya,
    [Description("Ферганская")]
    Ferganskaya,
    [Description("Фестивальная")]
    Festivalnaya,
    [Description("Фигурная")]
    Figurnaya,
    [Description("Фруктовая")]
    Fructovaya,
    [Description("Фрунзе")]
    Frunze,
    [Description("Фурманова")]
    Furmanova,

    #endregion

    #region Улицы на букву Х

    [Description("Хабаровская 1-я")]
    Khabarovskaya1,
    [Description("Хабаровская 2-я")]
    Khabarovskaya2,
    [Description("Хантайская")]
    Khantayskaya,
    [Description("Харламова")]
    Kharlamova,
    [Description("Хетская")]
    Khetskaya,
    [Description("Холмистая")]
    Kholmistaya,
    [Description("Храпова")]
    Khrapova,
    [Description("Хрустальная")]
    Khristalnaya,
    [Description("Хуторская")]
    Khutorskaya,

    #endregion

    #region Улицы на букву Ц

    [Description("Цветной")]
    Tsvetnoy,
    [Description("Цветочная")]
    Tsvetochnaya,
    [Description("Цветущая")]
    Tsvetusshaya,
    [Description("Цементников")]
    Tsementnikov,
    [Description("Центральный")]
    Tsentralniy,
    [Description("Цимлянская")]
    Tsimalanskaya,
    [Description("Циолковского")]
    Tsolkovskogo,

    #endregion

    #region Улицы на букву Ч

    [Description("Чайковского")]
    Chaykovskogo,
    [Description("Частоостровская")]
    Chastoostrovskaya,
    [Description("Челюскинцев")]
    Chelyuskintsev,
    [Description("Черёмуховая")]
    Cheryomukhovaya,
    [Description("Черемховская 2-я")]
    Cheremkhovskaya2,
    [Description("Черепнина")]
    Cherepnina,
    [Description("Черничная")]
    Chernichnaya,
    [Description("Чернышева")]
    Chernysheva,
    [Description("Чернышевского")]
    Chernyshevskogo,
    [Description("Черняховского")]
    Chernyakhovskogo,
    [Description("Чехова")]
    Chekhova,
    [Description("Чечеульский")]
    Checheulskiy,
    [Description("Чистопрудная")]
    Chistoprudnaya,
    [Description("Чистый Лог")]
    ChistiyLog,
    [Description("Читинская")]
    Chitinskaya,
    [Description("Чкалова")]
    Chkalova,

    #endregion

    #region Улицы на букву Ш

    [Description("Шахтёров")]
    Shakhtyorov,
    [Description("Шевченко")]
    Shevchenko,
    [Description("Шелковая")]
    Shelkovaya,
    [Description("Шиверская")]
    Shiverskaya,
    [Description("Шиндандская улица")]
    Shindandskaya,
    [Description("Шинная 1-я")]
    Shinnaya1,
    [Description("Шинная 2-я")]
    Shinnaya2,
    [Description("Шинная 3-я")]
    Shinnaya3,
    [Description("Шинная 4-я")]
    Shinnaya4,
    [Description("Ширинская")]
    Shirinskaya,
    [Description("Широкая")]
    Shirokaya,
    [Description("Шиферников")]
    Shiferinikov,
    [Description("Школьный")]
    Shkolniy,
    [Description("Шмидта")]
    Shmidta,
    [Description("Шумяцкого")]
    Shumyatskogo,
    [Description("Шушенская")]
    Shushenskaya,

    #endregion

    #region Улицы на букву Щ

    [Description("Щербакова")]
    Shcherbakova,
    [Description("Щетинкина")]
    Shchetinkina,
    [Description("Щорса")]
    Shchorssa,

    #endregion

    #region Улицы на букву Э

    [Description("Эвенкийская")]
    Evenkiyskaya,
    [Description("Экологов")]
    Ekologov,
    [Description("Экскурсантов")]
    Ekskursantov,
    [Description("Электриков")]
    Elektrokov,
    [Description("Энгельса")]
    Engelsa,
    [Description("Энергетиков")]
    Energetikov,
    [Description("Энтузиастов")]
    Entuziastov,

    #endregion

    #region Улицы на букву Ю

    [Description("Юбилейная")]
    Yubileynaya,
    [Description("Южная")]
    Yuzhnaya,
    [Description("Юности")]
    Yunosti,
    [Description("Юрия Гагарина")]
    YuriyaGagarina,
    [Description("Юрия Смирнова")]
    YuriyaSmirnova,
    [Description("Юшкова")]
    Yushkova,

    #endregion

    #region Улицы на букву Я 

    [Description("Яблоневая")]
    Yablonovaya,
    [Description("Яблочкова")]
    Yablochkova,
    [Description("Ягельный")]
    Yagelniy,
    [Description("Ягодная")]
    Yagodnaya,
    [Description("Ягодный")]
    Yagodniy,
    [Description("Яковлева")]
    Yakovleva,
    [Description("Якорный")]
    Yakorniy,
    [Description("Якутская")]
    Yakutskaya,
    [Description("Якутская 1-я")]
    Yakutskaya1,
    [Description("Ялтинский")]
    Yaltinskiy,
    [Description("Янковского")]
    Yankovskogo,
    [Description("Янтарная")]
    Yantarnaya,
    [Description("Ярлыковская")]
    Yarlykovskaya,
    [Description("Ярославская")]
    Yaroslavskaya,
    [Description("Ярцевский")]
    Yarcevskiy,
    [Description("Ярыгинская")]
    Yaryginskaya,
    [Description("Ярыгинский")]
    Yaryginskiy,
    [Description("Ясная")]
    Yasnaya,
    [Description("Ястынская")]
    Yastinskaya,

    #endregion

    #region Улицы на цифру

    [Description("3 Августа")]
    ThirdOfAugust,
    [Description("8 Марта")]
    EighthOfMarch,
    [Description("9 Мая")]
    NinthOfMay,
    [Description("9 Января")]
    NinthOfJanuary,
    [Description("26 Бакинских Комиссаров")]
    TwentySixBakinskihKomissarov,
    [Description("30 Июля")]
    ThirtiethOfJuly,
    [Description("40 лет Победы")]
    FortyYearsOfVictory,
    [Description("60 лет Образования СССР")]
    SixtyYearsOfUssrFormation,
    [Description("60 лет Октября")]
    SixtyYearsOfOctober,
    [Description("78-й Добровольческой Бригады")]
    SeventyEighthDobrovolcheskoyBrigady,
    [Description("78 Добровольческой Бригады")]
    SeventyEDobrovolcheskoyBrigady,

    #endregion
}