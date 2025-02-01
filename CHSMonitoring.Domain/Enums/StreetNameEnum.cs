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
    [EnumGuid("0A6A374A-FD71-4DDA-8534-3B277E7617FD")]
    
    #endregion

    #region Улицы на букву Г

    [Description("Гадалова")]
    Gadalova,
    [Description("Гайдара")]
    Gaydara,
    [Description("Гайдашовка")]
    Gaydashovka,
    [Description("Гаражный")]
    Garazhnyy,
    [Description("Гастелло")]
    Gastello,
    [Description("Геодезическая")]
    Geodezicheskaya,
    [Description("Геологическая")]
    Geologicheskaya,
    [Description("Геологическая 2-я")]
    Geologicheskaya2,
    [Description("2-я Геологическая")]
    Geologicheska_ya2,
    [Description("Георгиевская")]
    Georgievskaya,
    [Description("Героев Страны")]
    GeroevStrany,
    [Description("Героев Чернобыля")]
    GeroevChernobylya,
    [Description("Герцена")]
    Gertsena,
    [Description("Гипсовая")]
    Gipssovaya,
    [Description("Гипсовая 1-я")]
    Gipssovaya1,
    [Description("1-я Гипсовая")]
    Gipssova_ya1,
    [Description("Гипсовая 2-я")]
    Gipssovaya2,
    [Description("2-я Гипсовая")]
    Gipssova_ya2,
    [Description("Гипсовая 3-я")]
    Gipssovaya3,
    [Description("3-я Гипсовая")]
    Gipssova_ya3,
    [Description("Глинки")]
    Glinskiy,
    [Description("Глиняная")]
    Glinyanaya,
    [Description("Говорова")]
    Govorova,
    [Description("Гоголя")]
    Gogolya,
    [Description("Горийский")]
    Goriyskiy,
    [Description("Гористая")]
    Goristaya,
    [Description("Горная")]
    Gornaya,
    [Description("Горького")]
    Gorkogo,
    [Description("Гражданский")]
    Grazhdanskiy,
    [Description("Гранитная")]
    Granitnaya,
    [Description("Графитная")]
    Grafichnaya,
    [Description("Гремячий 1-й")]
    Gremyachiy1,
    [Description("Гремячий 2-й")]
    Gremyachiy2,
    [Description("Гремячий 3-й")]
    Gremyachiy3,
    [Description("Гремячий 4-й")]
    Gremyachiy4,
    [Description("Грибная")]
    Gribyanaya,
    [Description("Гросовцев")]
    Grossovtsa,
    [Description("Грунтовая")]
    Gruntovaya,
    [Description("Грушевая")]
    Grushevaya,
    [Description("Гуляева")]
    Gulyaeva,
    [Description("Гусарова")]
    Gusarova,

    #endregion

    #region Улицы на букву Д

    [Description("Дальневосточная")]
    Dalnevostochnaya,
    [Description("Дальневосточная 3-я")]
    Dalnevostochnaya3,
    [Description("3-я Дальневосточная")]
    Dalnevostochna_ya3,
    [Description("Дальневосточная 4-я")]
    Dalnevostochnaya4,
    [Description("4-я Дальневосточная")]
    Dalnevostochna_ya4,
    [Description("Дальняя")]
    DalNaya,
    [Description("Даурская")]
    DaurSKaya,
    [Description("Дачная")]
    Dachnaya,
    [Description("Декабристов")]
    Dekabristov,
    [Description("Делегатская")]
    Delegatskaya,
    [Description("Деловая")]
    Delovaya,
    [Description("Видьяна Бедного")]
    VidanyaBednogo,
    [Description("Деповская")]
    Depovskaya,
    [Description("Деповский")]
    Depovskiy,
    [Description("Депутатская 2-я")]
    Deputatskaya2,
    [Description("2-я Депутатская")]
    Deputatska_ya2,
    [Description("Детская")]
    Detskaya,
    [Description("Джамбульская")]
    Dzhambulskaya,
    [Description("Дзержинского")]
    Dzerzhinskogo,
    [Description("Дивная")]
    Divnaya,
    [Description("Дивногорская")]
    Divnogorskaya,
    [Description("Диксона")]
    Dixona,
    [Description("Диктатуры Пролетариата")]
    DiktaturyProletariata,
    [Description("Димитрова")]
    Dimitrova,
    [Description("Дмитрия Мартынова")]
    DmytriyaMartynova,
    [Description("Днепропетровская 1-я")]
    Dnepropetrovskaya1,
    [Description("1-я Днепропетровская")]
    Dnepropetrovska_ya1,
    [Description("Днепропетровская 2-я")]
    Dnepropetrovskaya2,
    [Description("2-я Днепропетровская")]
    Dnepropetrovska_ya2,
    [Description("Добролюбова")]
    Dobrolubova,
    [Description("Дозорная")]
    Dozornaya,
    [Description("Докучаева")]
    Dokuchaeva,
    [Description("Донецкая")]
    Donetskaya,
    [Description("Дорожная")]
    Dorognaya,
    [Description("Достоевского")]
    Dostoevskogo,
    [Description("Дрокинская")]
    Drokinskaya,
    [Description("Дружбы")]
    Druzhby,
    [Description("Дружный")]
    Druzhnyy,
    [Description("Дубенского")]
    Dubenskogo,
    [Description("Дубровинского")]
    Dubrovinskogo,
    [Description("Дудинская")]
    Dudinskaya,
    [Description("Дюнная")]
    Dunnyaya,

    #endregion

    #region Улицы на букву Е

    [Description("Елены Стасовой")]
    ElenyStasovoy,
    [Description("Еловая")]
    Yelovaya,
    [Description("Емельяновская")]
    Yemelyanovskaya,
    [Description("Енисейская")]
    Yeniseyskaya,
    [Description("Енисейский тракт")]
    YeniseyskiyTrakt,
    [Description("Ермаковская")]
    Yermakovskaya,
    [Description("Ерофеевская")]
    Yerofeyevskaya,
    [Description("Есаульская")]
    Yesaulskaya,

    #endregion
    
    #region Улицы на букву Ж
    
    [Description("Жарковая")]
    Zarkovaya,
    [Description("Жданова")]
    Zhdanova,
    [Description("Железнодорожников")]
    ZheleznoyDorožkov,
    [Description("Желябова")]
    Zhelebova,
    [Description("Жемчужная")]
    Zhemchuzhnaja,
    [Description("Живица")]
    Zhivitsa,
    [Description("Живописная")]
    Zhivopisnaya,
    [Description("Жуковского")]
    Zhukovskogo,
    
    #endregion
    
    #region Улицы на букву З
    
    [Description("Забобонова")]
    Zabobonova,
    [Description("Заводская")]
    Zavodskaya,
    [Description("Заводской")]
    ZavodskoyProyezd,
    [Description("Заводской")]
    Zavodskoy,
    [Description("Загородная")]
    Zagorodnaya,
    [Description("Загорская")]
    Zagorskaya,
    [Description("Заливной")]
    Zalivnoy,
    [Description("Западная")]
    Zapadnaya,
    [Description("Заповедный")]
    Zapovednyy,
    [Description("Запорожская")]
    Zaporozhskaya,
    [Description("Заречная")]
    Zarechnaya,
    [Description("Зарничная")]
    Zarnichnaya,
    [Description("Затонская")]
    Zatonskaya,
    [Description("Затонский 1-й")]
    Zatonskiy1,
    [Description("Затонский 2-й")]
    Zatonskiy2,
    [Description("Затонский 3-й")]
    Zatonskiy3,
    [Description("Защитников Ленинграда")]
    ZashchitnikovLeningrada,
    [Description("Зелёный")]
    Zelyoniy,
    [Description("Знаменская")]
    Znamenskaya,
    [Description("Зои Космодемьянской")]
    ZoiKosmodemyanskoy,
    
    #endregion
    
    #region Улицы на букву И
    
    [Description("Ивченко")]
    Ivchenko,
    [Description("Игарская")]
    Igarskaya,
    [Description("Извилистая")]
    Izvilistaya,
    [Description("Измайлова")]
    Izmaylova,
    [Description("Изумрудная")]
    Izumrudnaya,
    [Description("Изыскательский")]
    IzyvatelSkiy,
    [Description("Иланская")]
    Ilanskaya,
    [Description("Имбежский")]
    Imbezhskiy,
    [Description("Красноярский Рабочий")]
    KrasnoyarskiyRabochiy,
    [Description("Пионерская Правда")]
    PionerskayaPravda,
    [Description("Я.М. Свердлова")]
    YaMSverdlova,
    [Description("Индустриальный 1-й")]
    Industrialniy1,
    [Description("Индустриальный 2-й")]
    Industrialniy2,
    [Description("Инженерный")]
    Inzhenerniy,
    [Description("Инициаторов")]
    Initsiativov,
    [Description("Инструментальная")]
    Instrumentalnaya,
    [Description("Интернациональная")]
    Internatsionalnaya,
    [Description("Ипподром")]
    Ippodrom,
    [Description("Ирбейская")]
    Irbeyskaya,
    [Description("Иркутская")]
    Irkutskaya,
    [Description("Иртышская")]
    Irtishskaya,
    [Description("Историческая")]
    Istoricheskaya,
    [Description("Ишимская")]
    Ishimskaya,
    
    #endregion

    #region Улицы на букву К

    [Description("Крайняя")]
    Kraynyaya,
    [Description("Кабульская")]
    Kabulskaya,
    [Description("Казанская")]
    Kazanskaya,
    [Description("Казарменный")]
    Kazarmenniy,
    [Description("Калинина")]
    Kalinina,
    [Description("Калиновая")]
    Kalinovaya,
    [Description("Камасинская")]
    Kamasinskaya,
    [Description("Каменная")]
    Kamennaya,
    [Description("Камская")]
    Kamskaya,
    [Description("Камчатская")]
    Kamchatskaya,
    [Description("Камчатская 2-я")]
    Kamchatskaya2,
    [Description("2-я Камчатская")]
    Kamchatska_ya2,
    [Description("Камчатская 3-я")]
    Kamchatskaya3,
    [Description("3-я Камчатская")]
    Kamchatska_ya3,
    [Description("Камчатская 4-я")]
    Kamchatskaya4,
    [Description("4-я Камчатская")]
    Kamchatska_ya4,
    [Description("Камчатская 5-я")]
    Kamchatskaya5,
    [Description("5-я Камчатская")]
    Kamchatska_ya5,
    [Description("Кандагарская")]
    Kandagarskaya,
    [Description("Канская")]
    Kanskaya,
    [Description("Капитанская")]
    Kapitanskaya,
    [Description("Карамзина")]
    Karamzina,
    [Description("Каратанова")]
    Karatanova,
    [Description("Каратузский")]
    Karatuzskiy,
    [Description("Караульная")]
    Karaulnaya,
    [Description("Карбышева")]
    Karbyshova,
    [Description("Кардагчинская")]
    Kardagchinskaya,
    [Description("Карла Либкнехта")]
    KarlaLibknekhta,
    [Description("Карла Маркса")]
    KarlaMarksa,
    [Description("Карнавальная")]
    Karnavalnaya,
    [Description("Карьерная")]
    Karernaya,
    [Description("Карьерный")]
    Karerniy,
    [Description("Каурова")]
    Kaurova,
    [Description("Каучуковый")]
    Kauchukoviy,
    [Description("Каховская")]
    Kakhovskaya,
    [Description("Качи")]
    Kachi,
    [Description("Качинская")]
    Kachinskaya,
    [Description("Каштачная")]
    Kashtachnaya,
    [Description("Квадратный")]
    Kvadratniy,
    [Description("Квартал 52-й")]
    Kvartal52,
    [Description("Квартальная")]
    Kvartalnaya,
    [Description("Кедровая")]
    Kedrovaya,
    [Description("Кедровый")]
    Kedrovoy,
    [Description("Кипрейная")]
    Kipreynaya,
    [Description("Кирова")]
    Kirova,
    [Description("Кирпичников")]
    Kirpichnikova,
    [Description("Кишинёвская")]
    Kishinevskaya,
    [Description("Клеверный")]
    Klevernaya,
    [Description("Клинкерная 1-я")]
    Klinkernaya1,
    [Description("1-я Клинкерная")]
    Klinkerna_ya1,
    [Description("Клинкерная 2-я")]
    Klinkernaya2,
    [Description("2-я Клинкерная")]
    Klinkerna_ya2,
    [Description("Ключевская")]
    Klyuchevskaya,
    [Description("Ковыльная")]
    Kovylnaya,
    [Description("Кодинская")]
    Kodinskaya,
    [Description("Коломенская")]
    Kolomenskaya,
    [Description("Колхозная")]
    Kolkhoznaya,
    [Description("Кольцевая")]
    Koltevaya,
    [Description("Кольцевой")]
    Koltevoy,
    [Description("Колягинская")]
    Kolyaginskaya,
    [Description("Комарова")]
    Komarova,
    [Description("Комбайнеров")]
    Kombaynerova,
    [Description("Комбайностроителей")]
    KombaynoStroiteley,
    [Description("Коммунальная")]
    Kommunalnaya,
    [Description("Коммунистическая")]
    Kommunisticheskaya,
    [Description("Комсомольский")]
    Komsomolskiy,
    [Description("Конечная")]
    Konechnaya,
    [Description("Конституции СССР")]
    KonstitutsiiSssr,
    [Description("Конструкторов")]
    Konstruktorov,
    [Description("Контейнерная")]
    Konteinernaya,
    [Description("Кооперативная")]
    Kooperativnaya,
    [Description("Копылова")]
    Kopylova,
    [Description("Копьевская")]
    Kopyevskaya,
    [Description("Корабельная")]
    Korabelnaya,
    [Description("Корнеева")]
    Korneeva,
    [Description("Корнетова")]
    Kornetova,
    [Description("Королева")]
    Koroleva,
    [Description("Короленко")]
    Korolenko,
    [Description("Короткий")]
    Korotkiy,
    [Description("Космическая")]
    Kosmicheskaya,
    [Description("Космонавтов микрорайон Северный")]
    KosmonavtovSeverniy,
    [Description("Космонавтов")]
    Kosmonavtov,
    [Description("Косой")]
    Kosoy,
    [Description("Котельникова")]
    Kotelnikova,
    [Description("Котовского")]
    Kotoskogo,
    [Description("Кочубея")]
    Kochubeya,
    [Description("Кравченко")]
    Kravchenko,
    [Description("Кразовская")]
    Krazovskaya,
    [Description("Красикова")]
    Krasikova,
    [Description("Красная")]
    Krasnaya,
    [Description("Красногорская")]
    Krasnogorskaya,
    [Description("Красногорская 2-я")]
    Krasnogorskaya2,
    [Description("2-я Красногорская")]
    Krasnogorska_ya2,
    [Description("Красноградская")]
    Krasnogradskaya,
    [Description("Краснодарская")]
    Krasnodarskaya,
    [Description("Краснодарская 1-я")]
    Krasnodarskaya1,
    [Description("1-я Краснодарская")]
    Krasnodarska_ya1,
    [Description("Краснодарская 2-я")]
    Krasnodarskaya2,
    [Description("2-я Краснодарская")]
    Krasnodarska_ya2,
    [Description("Краснодарская 3-я")]
    Krasnodarskaya3,
    [Description("3-я Краснодарская")]
    Krasnodarska_ya3,
    [Description("Краснодонцев")]
    Krasnodontsev,
    [Description("Красной Армии")]
    KrasnoyArmii,
    [Description("Красной Гвардии")]
    KrasnoyGvardii,
    [Description("Красной Звезды")]
    KrasnoyZvezdy,
    [Description("Красномосковская")]
    Krasnomoskovskaya,
    [Description("Краснопресненская")]
    Krasnopresnenskaya,
    [Description("Краснофлотская 2-я")]
    Krasnoflotskaya2,
    [Description("2-я Краснофлотская")]
    Krasnoflotska_ya2,
    [Description("Красных Зорь")]
    KrasnyhZor,
    [Description("Кривоколенный")]
    Krivokolenniy,
    [Description("Круговая")]
    Krugovaya,
    [Description("Крупской")]
    Krupskoy,
    [Description("Крутая 1-я")]
    Krutaya1,
    [Description("1-я Крутая")]
    Kruta_ya1,
    [Description("Крутая 2-я")]
    Krutaya2,
    [Description("2-я Крутая")]
    Kruta_ya2,
    [Description("Крутовского")]
    Krutovskogo,
    [Description("Крутогорская 1-я")]
    Krutogorskaya1,
    [Description("1-я Крутогорская")]
    Krutogorska_ya1,
    [Description("Крутогорская 2-я")]
    Krutogorskaya2,
    [Description("2-я Крутогорская")]
    Krutogorska_ya2,
    [Description("Крылова")]
    Krylova,
    [Description("Кубанская")]
    Kubanskaya,
    [Description("Кузнецкий")]
    Kuznetskiy,
    [Description("Куйбышева")]
    Kuybysheva,
    [Description("Куйсумская")]
    Kuysumskaya,
    [Description("Куксинский")]
    Kuksinskiy,
    [Description("Курагинская")]
    Kuraginskaya,
    [Description("Курганская")]
    Kurganskaya,
    [Description("Курейская")]
    Kureyskaya,
    [Description("Куренная")]
    Kurenaya,
    [Description("Курчатова")]
    Kurchatova,
    [Description("Кутузова")]
    Kutuzova,
    [Description("Кутузова 2-я")]
    Kutuzova2,
    [Description("2-я Кутузова")]
    Kutuzova_2,

    #endregion
    
    #region Улицы на букву Л
    
    [Description("Лабазный")]
    Labazniy,
    [Description("Ладо Кецховели")]
    LadoKechkhoveli,
    [Description("Лазурная")]
    Lazurnaya,
    [Description("Лалетино")]
    Laletino,
    [Description("Ламская")]
    Lamskaya,
    [Description("Ленина")]
    Lenina,
    [Description("Ленинградская")]
    Leningradskaya,
    [Description("Ленинградская 1-я")]
    Leningradskaya1,
    [Description("1-я Ленинградская")]
    Leningradska_ya1,
    [Description("Лермонтова")]
    Lermontova,
    [Description("Лесная")]
    Lesnaya,
    [Description("Лесников")]
    Lesnikov,
    [Description("Лесной")]
    Lesnoy,
    [Description("Лесопарковая")]
    Lesoparkovaya,
    [Description("Лесоперевалочная")]
    Lesoperevalochnaya,
    [Description("Лесопильщиков")]
    Lesopilschikov,
    [Description("Лесопитомник")]
    Lesopitomnik,
    [Description("Лесосибирский")]
    Lesosibirskiy,
    [Description("Лесосплавная")]
    Lesosplavnaya,
    [Description("Летчиков")]
    Letchikov,
    [Description("Лиды Прушинской")]
    LidyPrushinskoy,
    [Description("Лизы Чайкиной")]
    LiziChaykinoy,
    [Description("Линейная")]
    Lineynaya,
    [Description("Линейная 2-я")]
    Lineynaya2,
    [Description("2-я Линейная")]
    Lineyna_ya2,
    [Description("Линейная 3-я")]
    Lineynaya3,
    [Description("3-я Линейная")]
    Lineyna_ya3,
    [Description("Линейная 4-я")]
    Lineynaya4,
    [Description("4-я Линейная")]
    Lineyna_ya4,
    [Description("Линейная 5-я")]
    Lineynaya5,
    [Description("5-я Линейная")]
    Lineyna_ya5,
    [Description("Линейная 6-я")]
    Lineynaya6,
    [Description("6-я Линейная")]
    Lineyna_ya6,
    [Description("Линейная 7-я")]
    Lineynaya7,
    [Description("7-я Линейная")]
    Lineyna_ya7,
    [Description("Лириков")]
    Lirikov,
    [Description("Лиственная")]
    Listvennaya,
    [Description("Листвяжный Лог")]
    ListvyazhniyLog,
    [Description("Литейная")]
    Liteynaya,
    [Description("Лихачева")]
    Likhacheva,
    [Description("Лодочная")]
    Lodochaya,
    [Description("Локомотивная")]
    Lokomotivnaya,
    [Description("Ломоносова")]
    Lomonosova,
    [Description("Луговая")]
    Lugovaya,
    [Description("Луначарского")]
    Lunacharskogo,
    [Description("Лучистая")]
    Luchistaya,
    [Description("Львовская")]
    Lvovskaya,
    [Description("Любимый")]
    Lyubimiy,
    [Description("Любы Шевцовой")]
    LyubyShevtsovoy,
    
    #endregion
    
    #region Улицы на букву М
    
    [Description("Магистральная")]
    Magistralnaya,
    [Description("Магнитогорская")]
    Magnitogorskaya,
    [Description("Маерчака")]
    Mayerchaka,
    [Description("Майская")]
    Mayskaya,
    [Description("Макаренко")]
    Makarenko,
    [Description("Малаховская")]
    Malahovskaya,
    [Description("Малая")]
    Malaya,
    [Description("Малиновая")]
    Malinovaya,
    [Description("Малиновского")]
    Malinovskogo,
    [Description("Малтатский")]
    Maltatskiy,
    [Description("Мангазейская")]
    Mangazeyskaya,
    [Description("Марата")]
    Marata,
    [Description("Марии Ульяновой")]
    MariiUlyanovoy,
    [Description("Марии Цукановой")]
    MariiTsukanovoy,
    [Description("Марковского")]
    Markovskogo,
    [Description("Матвеева")]
    Matveeva,
    [Description("Мате Залки")]
    MateZalki,
    [Description("Машиностроителей")]
    Mashinostroiteley,
    [Description("Маяковского")]
    Mayakovskogo,
    [Description("Мебельная")]
    Mebelnaya,
    [Description("Медицинский")]
    Meditsinskiy,
    [Description("Медовая")]
    Medovaya,
    [Description("Мелькомбинатская")]
    Melkombinatskaya,
    [Description("Мелькомбинатская 2-я")]
    Melkombinatskaya2,
    [Description("2-я Мелькомбинатская")]
    Melkombinatska_ya2,
    [Description("Менделеева")]
    Mendeleeva,
    [Description("Менжинского")]
    Menzhinskogo,
    [Description("Металлургов")]
    Metallurgov,
    [Description("Мечникова")]
    Mechnikova,
    [Description("Микуцкого")]
    Mikutskogo,
    [Description("Минина")]
    Minina,
    [Description("Минская")]
    Minskaya,
    [Description("Минусинская")]
    Minusinskaya,
    [Description("Мира")]
    Mira,
    [Description("Мирошниченко")]
    Miroshnichenko,
    [Description("Михаила Годенко")]
    MikhailaGodenko,
	[Description("Годенко")]
    Godenko,
    [Description("Мичурина")]
    Michurina,
    [Description("Можайского")]
    Mozhayskogo,
    [Description("Молодежный")]
    Molodezhniy,
    [Description("Молодогвардейцев")]
    Molodogvardeytsev,
    [Description("Молодости")]
    Molodosti,
    [Description("Молокова")]
    Molokova,
    [Description("Монастырская")]
    Monastyrskaya,
    [Description("Монтажников")]
    Montazhnikov,
    [Description("Московская")]
    Moskovskaya,
    [Description("Мостовиков")]
    Mostovikov,
    [Description("Моторная")]
    Motornaya,
    [Description("Моховая")]
    Mokhovaya,
    [Description("МПС")]
    Mps,
    [Description("Мужества")]
    Muzhestva,
    [Description("Мурманская")]
    Murmanskaya,
    [Description("Мусоргского")]
    Musorgskogo,
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