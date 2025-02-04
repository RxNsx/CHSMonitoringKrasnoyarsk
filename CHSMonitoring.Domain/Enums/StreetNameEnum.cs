using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
    
    [EnumGuid("8096791D-36BC-47D9-AD00-1A178EFF255E")]
    [Description("Навигационная")]
    Navigatsionnaya,
    [EnumGuid("F3087FDC-9852-498E-B8E8-1FC3B1599723")]
    [Description("Нагорная")]
    Nagornaya,
    [EnumGuid("07828B06-39E7-4FA1-9167-5B1786A501BE")]
    [Description("Назаровская")]
    Nazarovskaya,
    [EnumGuid("F546DBF7-E25F-4DBD-9377-A436A3F6A136")]
    [Description("Наклонная")]
    Naklonnaya,
    [EnumGuid("E5D91DFB-F488-4F79-B15E-FD4F894AF9ED")]
    [Description("Нанжульская")]
    Nanzhulskaya,
    [EnumGuid("C63F6F59-6803-4956-871A-2A33A36651AD")]
    [Description("Национальная")]
    Natsionalnaya,
    [EnumGuid("3F13483F-BB1D-45AD-BB54-89C2E7DDA977")]
    [Description("Невская")]
    Nevskaya,
    [EnumGuid("8F5A5617-48A3-491F-BA8A-69B3FD5B02E7")]
    [Description("Независимости")]
    Nezavisimosti,
    [EnumGuid("AB1E3256-C022-4418-9294-53F768AA55FA")]
    [Description("Некрасова")]
    Nekrasova,
    [EnumGuid("C93E3A2E-9146-435C-9B2D-6C3EA11AAD38")]
    [Description("Нерчинская")]
    Nerchinskaya,
    [EnumGuid("BCCE07B7-4E52-4CD3-8E16-1ABAFD3BBDEE")]
    [Description("Нестерова")]
    Nesterova,
    [EnumGuid("8150236D-6179-4677-AD81-4BADF5AFB56B")]
    [Description("Нефтяной")]
    Neftyanoy,
    [EnumGuid("424BDEA0-395A-4C9E-B7EA-075BC5DE0610")]
    [Description("Никитина")]
    Nikitina,
    [EnumGuid("A2D9C47A-E89A-4351-8439-8CD587A6B6BE")]
    [Description("Николаева")]
    Nikolaeva,
    [EnumGuid("8F434227-00CE-4D8D-803E-F3F94BCC3643")]
    [Description("Николаевский")]
    Nikolaevskiy,
    [EnumGuid("ABFF20AE-D4BB-4428-B12F-E12F5DC9BE4E")]
    [Description("Николая Донского")]
    NikolayaDonskogo,
    [EnumGuid("815A1467-9357-40AA-B8C5-8CE4E65C2B4A")]
    [Description("Новаторская")]
    Novatorskaya,
    [EnumGuid("346F2F4A-4588-4ED4-8713-32B8A86EC740")]
    [Description("Новая")]
    Novaya,
    [EnumGuid("7027475E-7FB3-4932-84CF-AB8747E637A4")]
    [Description("Новая Заря")]
    NovayaZarya,
    [EnumGuid("8344B66F-0A32-49EE-9C98-C6CC4AAADE7A")]
    [Description("Новгородская")]
    Novgorodskaya,
    [EnumGuid("FA7F3D0F-C797-4C36-ACA7-38C109451FD2")]
    [Description("Новогорская")]
    Novogorskaya,
    [EnumGuid("29839413-845A-4663-A8F0-F9C9BFFDB97A")]
    [Description("Новой Жизни")]
    NovoyZhizni,
    [EnumGuid("F7E70193-8781-4AAF-86BD-0A1D2E760DF7")]
    [Description("Новомлинская")]
    Novomlinskaya,
    [EnumGuid("3DC0CCED-C8E0-4990-8692-5801901AE337")]
    [Description("Новосибирская")]
    Novosibirskaya,
    [EnumGuid("331A10D9-A8F8-457D-A6A1-C6F0B38C25B7")]
    [Description("Новостроек")]
    Novostroyek,
    [EnumGuid("78D600A2-AE32-44E0-8237-A72B12617136")]
    [Description("Норильская")]
    Norilskaya,
    
    #endregion
    
    #region Улицы на букву О
    
    [EnumGuid("E7224507-0037-4105-A50A-D4B684794BEB")]
    [Description("Обзорная")]
    Obzornaya,
    [EnumGuid("43FC901B-3470-4163-B4CA-B7064439A4DE")]
    [Description("Облачная")]
    Oblachnaya,
    [EnumGuid("01C087A9-B6A1-4BA2-9D72-DFC7DDD0A22E")]
    [Description("Облепиховая")]
    Oblepikhovaya,
    [EnumGuid("37E1B7E2-0455-488E-B36E-E1B68F63FEE9")]
    [Description("Обороны")]
    Oborony,
    [EnumGuid("77CEC8ED-27CC-4300-B241-86CEFD199F38")]
    [Description("Овражная")]
    Ovrashnaya,
    [EnumGuid("C643CE83-FF4C-4956-AD4B-E748168AD57A")]
    [Description("2-я Огородная")]
    Ogorodnaya2,
    [EnumGuid("8D27DD01-3002-4845-8C23-BBEFB721AEBB")]
    [Description("Одесская")]
    Odesskaya,
    [EnumGuid("2FA676A8-7711-41AD-93DD-73CD5A22E4AE")]
    [Description("Одесский")]
    Odesskiy,
    [EnumGuid("19FF63FC-4F49-42AF-AC17-888CC86105A0")]
    [Description("Односторонний")]
    Odnostoronniy,
    [EnumGuid("54FBB146-B236-4C69-9869-62D660B82618")]
    [Description("Озерная")]
    Ozerennaya,
    [EnumGuid("DC8F6FCB-F875-40EE-9158-6876DE8D1D85")]
    [Description("2-я Озёрная")]
    Ozernaya2,
    [EnumGuid("3A1509F8-0726-4D64-BC9E-11E718F58D06")]
    [Description("4-я Озёрная")]
    Ozernaya4,
    [EnumGuid("C6CF64CA-E3DC-4333-BF35-15BD9BFD22D8")]
    [Description("Окаемная")]
    Okaymnaya,
    [EnumGuid("677C8408-1CB5-45E0-AD60-138D2A2AE716")]
    [Description("Окружная")]
    Okruzhnaya,
    [EnumGuid("403D71D2-AFFC-4498-AAA9-D70F473C09E3")]
    [Description("Октябрьская")]
    Oktyabrskaya,
    [EnumGuid("F7C29146-E1F9-4942-B328-6FB34F08DEE7")]
    [Description("Олега Кошевого")]
    OlegaKoshevoy,
    [EnumGuid("985AE251-EB7E-4F04-8D4E-9BA82C1C6562")]
    [Description("Олейникова")]
    Oleynikova,
    [EnumGuid("76F85A6E-4E77-48CE-BDEE-73427B50B0E3")]
    [Description("Олониченко")]
    Olonichenko,
    [EnumGuid("D4C2EF57-E0FA-4CF3-AEAF-E7E2A9377617")]
    [Description("Ольховая")]
    Olkhovaya,
    [EnumGuid("0B367053-C66F-4550-9344-488633A62D47")]
    [Description("Омская")]
    Omskaya,
    [EnumGuid("C4CFF567-554E-42EA-A32C-AE67EFFEA6AD")]
    [Description("Ореховская")]
    Orekhovskaya,
    [EnumGuid("05DB46AE-26F4-4ABF-9E8A-44ABCD9B5769")]
    [Description("Орловская")]
    Orlovskaya,
    [EnumGuid("56A96858-9D86-4024-B42C-2AD73E1EF2B9")]
    [Description("Осенняя")]
    Osennaya,
    [EnumGuid("7A3DFC55-2BFF-4FA9-8844-C616F75FBCC0")]
    [Description("Осипенко")]
    Osipenko,
    [EnumGuid("07357FE0-0AB5-4620-8977-B58359E3A81E")]
    [Description("Остров Отдыха")]
    OstrovOtdyha,
    [EnumGuid("C293EABC-2FDF-4BC0-ADE7-8F389CDD90BB")]
    [Description("Островная")]
    Ostrovskaya,
    [EnumGuid("4376888F-A2B6-47BC-9EF2-E7C6A0E79513")]
    [Description("Островского")]
    Ostrovskogo,
    [EnumGuid("993C8489-D295-4344-AD7D-BD26085ADD19")]
    [Description("Острожная")]
    Ostrozhnaya,
    [EnumGuid("ED74B65D-617B-4D14-B776-04600BE9CE97")]
    [Description("Отважный")]
    Otvazhniy,
    [EnumGuid("7FF72DFD-D848-47E9-AB55-940FC3F49768")]
    [Description("Отдыха")]
    Otdyha,
    [EnumGuid("18074366-B9C0-4BC6-BD6C-CD14853F931C")]
    [Description("Отрадная")]
    Otrada,
    [EnumGuid("F1A98B7D-AC0A-4759-8C67-87E330C5DAEC")]
    [Description("Офицерская")]
    Ofitserskaya,
    [EnumGuid("CD3D23ED-4CB8-4247-A148-C95030E85993")]
    [Description("Охраны Труда")]
    OkhranyTruda,
    
    #endregion
    
    #region Улицы на букву П
    
    [EnumGuid("798FD25C-F2C5-4522-8D2C-7C2A779F71D0")]
    [Description("Павлика Морозова")]
    PavlikaMorozova,
    [EnumGuid("AB54F774-EB20-4629-BC4F-28979C8FE8D4")]
    [Description("Памяти Героев")]
    PamyatiGeroev,
    [EnumGuid("B186CCF3-90E2-4837-9355-5E10B0A1F1B7")]
    [Description("Паниковская")]
    Panikovskaya,
    [EnumGuid("48AE61FA-C2A5-4588-A2C6-BC11358A92C3")]
    [Description("Панорамная")]
    Panoramnaya,
    [EnumGuid("F88F50E0-5775-4E02-A1E5-7F253728E8F1")]
    [Description("Панфиловцев")]
    Panfilovtsev,
    [EnumGuid("CEDE606B-F859-40EB-ABBD-A4BDB562727D")]
    [Description("Папанинцев")]
    Papanintsev,
    [EnumGuid("E02271C7-D93A-45AE-8E56-5FC493B72D8F")]
    [Description("Парадовского")]
    Paradovskogo,
    [EnumGuid("84C05C08-C1BF-4B29-9B0C-7F925AEFA297")]
    [Description("Парашютная")]
    Parashyutnaya,
    [EnumGuid("7B9731B1-9461-4177-86CB-E76275546548")]
    [Description("Парижской Коммуны")]
    ParizhskoyKommuny,
    [EnumGuid("F2755B75-5B38-46D1-BF77-A24ACF06F67C")]
    [Description("Парковая")]
    Parkovaya,
    [EnumGuid("AEBFB968-13B5-4532-B917-D1A3FD340610")]
    [Description("Паровозная")]
    Parovoznaya,
    [EnumGuid("969C18C3-87E5-49D8-B63A-7195DCEF0307")]
    [Description("Партизана Железняка")]
    PartizanaZheleznaka,
    [EnumGuid("BF05AC6E-526C-4695-8940-FDE1D9F15936")]
    [Description("Партизанская")]
    Partizanskaya,
    [EnumGuid("AC5418CE-2834-47A1-A305-DC524995AEE0")]
    [Description("Парусная")]
    Parusnaya,
    [EnumGuid("14B427B2-A95D-43A2-99F0-6FD0385BB9AE")]
    [Description("Пархоменко")]
    Parkhomenko,
    [EnumGuid("D9E6778C-E2C5-43D3-BD1B-20F70A099E3D")]
    [Description("Пасечная")]
    Pasechnaya,
    [EnumGuid("16DF0D50-C655-498E-9448-912CCD560EB3")]
    [Description("Пастеровская")]
    Pasterevskaya,
    [EnumGuid("2C5248E3-3D69-4553-9BD6-81697EBAF11F")]
    [Description("Пасхальная")]
    Paskhalnaya,
    [EnumGuid("7675E111-577D-4486-AB52-AE698BB360E2")]
    [Description("Первых Пионеров")]
    PervykhPionerov,
    [EnumGuid("72B020DB-BB64-4A4A-BDAF-1DF4CEE06A67")]
    [Description("Перенсона")]
    Perensona,
    [EnumGuid("5B1E61AD-6251-4303-9691-BB9854FF78FE")]
    [Description("Перепелиная")]
    Perepelina,
    [EnumGuid("2869739E-66BA-4AF1-A59E-16B9EEABF511")]
    [Description("Перспективная")]
    Perspektivnaya,
    [EnumGuid("334D8FC3-F7A2-404F-B22F-0899BC5EF1E3")]
    [Description("Песочная")]
    Pesochaya,
    [EnumGuid("398CCA0E-24CB-4D96-9EE6-1D23EC042BD8")]
    [Description("Петлина")]
    Petlina,
    [EnumGuid("853BAB77-0517-4DE3-B434-D4776C67A485")]
    [Description("Петра Ломако")]
    PetraLomako,
    [EnumGuid("AC23BA3B-0400-4981-AFF9-29972D1073AC")]
    [Description("Петра Подзолкова")]
    PetraPodzolkova,
    [EnumGuid("55466740-AFB7-488C-AD29-5A866BE38D2A")]
    [Description("Петра Словцова")]
    PetraSlovtsa,
    [EnumGuid("1ED82390-3D8D-4139-9BE3-7E9AD538C4C7")]
    [Description("Словцова")]
    Slovtsova,
    [EnumGuid("E1A7D264-8C3F-49C8-94CF-ED6C6CB5C47E")]
    [Description("Петрушина")]
    Petrushina,
    [EnumGuid("97C09283-0B06-4D50-ADE6-A7804E5598FC")]
    [Description("Пионеров 2-я")]
    Pionerov2,
    [EnumGuid("5C28313C-FD9F-4535-BF0A-E88A46270E35")]
    [Description("2-я Пионеров")]
    Pionerov_2,
    [EnumGuid("71C2DC1F-5C3B-45B6-8525-76AC1E8E7B16")]
    [Description("Пионеров 3-я")]
    Pionerov3,
    [EnumGuid("B081E9C3-01CE-4AE4-B3EB-4C05C1690A34")]
    [Description("3-я Пионеров")]
    Pionerov_3,
    [EnumGuid("5659236B-5A82-4C80-A2B6-E6F078AC463E")]
    [Description("Пировская")]
    Pirovskaya,
    [EnumGuid("52A72087-E0C1-4C13-853A-5A8CD970F21A")]
    [Description("Пирогова")]
    Pirogova,
    [EnumGuid("6FFD8351-712B-4B17-8DE5-C96409C9B6A3")]
    [Description("Писарева")]
    Pisareva,
    [EnumGuid("9EE7CECD-8474-41CC-ACAB-0FB6888C664A")]
    [Description("Пихтовая")]
    Pikhtovaya,
    [EnumGuid("B46A7F6D-3FE7-4FA3-ABD3-C3ED09CBB340")]
    [Description("Плановая")]
    Planovaya,
    [EnumGuid("2837FA7D-7F18-4D91-91CC-58D518AA53D1")]
    [Description("Плодовая")]
    Plodovaya,
    [EnumGuid("01305FF7-6829-4B3E-853A-220C1C6A0109")]
    [Description("Победы")]
    Pobedy,
    [EnumGuid("7DEDE235-DAA3-44AB-91EE-BEFA7F6A5554")]
    [Description("Побежимова")]
    Pobezhimova,
    [EnumGuid("6A69E287-C5BA-4DDA-B58C-695941D2B5FF")]
    [Description("Пограничников")]
    Pogranichnikov,
    [EnumGuid("B781323B-65A1-4F9C-BDE1-10C8A1F4D171")]
    [Description("Подгорная")]
    Podgornaya,
    [EnumGuid("5269634C-18C4-4CF7-AF74-C8239A645CAF")]
    [Description("Подсобная")]
    Podsobnaya,
    [EnumGuid("6BD7ABA2-4138-44E2-B645-FAC4FCBA3720")]
    [Description("Подъемная")]
    Podyomnaya,
    [EnumGuid("05E26084-F179-46EA-96FA-3BF8664C0E8A")]
    [Description("Пожарского")]
    Pozharskogo,
    [EnumGuid("E50A266B-C916-43E7-AE44-B9A07FAA2C8C")]
    [Description("Позднякова")]
    Pozdnyakova,
    [EnumGuid("072C986E-A5A0-4330-825C-527A6DF497FC")]
    [Description("Пойменный")]
    Poymenny,
    [EnumGuid("624ED360-2C57-476A-B682-C15C4F218A40")]
    [Description("Покровская")]
    Pokrovskaya,
    [EnumGuid("EA3F190F-0A48-4796-95BF-63E8F0AE9C57")]
    [Description("Полевая")]
    Polevaya,
    [EnumGuid("466D3379-779F-451E-997B-5E6A40708795")]
    [Description("Полевой")]
    Polevoy,
    [EnumGuid("00A840D2-5D1D-48F1-ADB3-2A48E794318B")]
    [Description("Ползунова")]
    Polzunova,
    [EnumGuid("CC20DD4C-F618-49C6-B561-55263999C522")]
    [Description("Полигонная")]
    Poligonaya,
    [EnumGuid("9BF8C597-407F-4C5E-AD9F-7EBB3C6BB1CD")]
    [Description("Полтавская")]
    Poltavskaya,
    [EnumGuid("BCEEF0B1-C8D4-4F17-BCEF-8240CB76A99C")]
    [Description("Полярная")]
    Polyarnaya,
    [EnumGuid("F4917AA0-AB6B-436E-89CD-242B7D6144A5")]
    [Description("3-я Полярная")]
    Polyarnaya3,
    [EnumGuid("B4C4DC5B-E936-4A2F-B9AE-2AA1D892DF2C")]
    [Description("4-я Полярная")]
    Polyarnaya4,
    [EnumGuid("A90673A6-130A-4019-A19D-6B4C73E6112F")]
    [Description("5-я Полярная")]
    Polyarnaya5,
    [EnumGuid("3F876403-DE63-44C7-BC9D-5E31DB6F7C7D")]
    [Description("6-я Полярная")]
    Polyarnaya6,
    [EnumGuid("8DF51AAD-A350-44C7-ACA6-DA95FCC1F08D")]
    [Description("7-я Полярная")]
    Polyarnaya7,
    [EnumGuid("C8EAF472-2CF8-4984-9C48-9268A0D60F6F")]
    [Description("Поперечный")]
    Poperechny,
    [EnumGuid("A577F8CF-059C-448F-A8FD-CD505420DD88")]
    [Description("Попова")]
    Popova,
    [EnumGuid("F1A26EB4-D399-4A04-9EF6-1B4F874FEA27")]
    [Description("Пороховой")]
    Porokhovoy,
    [EnumGuid("4B905109-0A19-434A-BD17-2EB06739A938")]	
    [Description("Посадный")]
    Posadniy,
    [EnumGuid("801F0932-C4F2-44DE-B347-A3A7B7830487")]
    [Description("Посадская")]
    Posadskaya,
    [EnumGuid("708E0579-B9D2-4929-BF44-30DF42467ED4")]
    [Description("Послушников")]
    Poslushnikov,
    [EnumGuid("4F89A21E-3677-438B-B6A8-C1E1825B0BC1")]
    [Description("Послушников")]
    Poslushnikov2,
    [EnumGuid("E78AAD3C-C174-4D50-957A-416A1B0750F7")]
    [Description("Походная")]
    Pokhodnaya,
    [EnumGuid("9CF3A59B-EE96-48EA-A583-0E3C6DD5A8AE")]
    [Description("Преображенская")]
    Preobrazhenskaya,
    [EnumGuid("6A2F2B40-7E31-4D8E-A617-E6C3E77B70FC")]
    [Description("Пржевальского")]
    Przhevalskogo,
    [EnumGuid("383E69CA-BF49-428B-89BB-5FDE52B3921A")]
    [Description("Прибойная")]
    Priboynaya,
    [EnumGuid("47DB5ECB-6D95-455C-8E4B-476B909919B8")]
    [Description("Привокзальная")]
    Privokzalnaya,
    [EnumGuid("C78ABDFF-B0BF-4B48-A92D-BB54E9C38871")]
    [Description("Пригорная")]
    Prigornaya,
    [EnumGuid("84EEC862-234E-4F82-BE96-3E51519E0FD6")]
    [Description("Придорожная")]
    Pridorozhnaya,
    [EnumGuid("0AB2FC37-889A-43E3-9899-D563E4787265")]
    [Description("Приручейная")]
    Prirucheynaya,
    [EnumGuid("A85CB9BB-DE67-42F8-9E58-473BED058CF4")]
    [Description("1-я Приручейная")]
    Prirucheynaya1r,
    [EnumGuid("BD81563F-1CA1-46B9-824A-F81802DE5F9C")]
    [Description("2-я Приручейная")]
    Prirucheynaya2r,
    [EnumGuid("A00556B2-D07D-4F57-87C7-45E4B9FA4059")]
    [Description("Приручейная 2-я")]
    Prirucheynaya2,
    [EnumGuid("10BF3896-3245-481F-A415-B46B58B24CA3")]
    [Description("Приручейный")]
    Prirucheyny,
    [EnumGuid("CF310ED5-C9DB-4E31-8366-907EAFA3C377")]
    [Description("Приусадебный")]
    Priusadebny,
    [EnumGuid("46ABD1E3-4FFA-4AA5-AE50-E490D46EF07D")]
    [Description("Причальная 5-я")]
    Prichalnaya5,
    [EnumGuid("66C0C3EE-9EA4-45CA-8D44-C99034880F4E")]
    [Description("Прогулочная")]
    Progulochnaya,
    [EnumGuid("99F4E8AA-A0DF-41D7-ACD7-E09EAB3FF245")]
    [Description("Продольная")]
    Prodolnaya,
    [EnumGuid("19379761-11D3-463D-8955-9AF8245BFB27")]
    [Description("Продольная 10-я")]
    Prodolnaya10,
    [EnumGuid("C1BB5B07-AF97-4130-AFFC-17538CBE0F03")]
    [Description("10-я Продольная")]
    Prodolnaya10r,
    [EnumGuid("E83DCB2A-F26C-490C-8026-7B88FF576BE5")]
    [Description("Продольная 11-я")]
    Prodolnaya11,
    [EnumGuid("63B3FBA6-A2F5-4C16-9FCC-E346029AA468")]
    [Description("11-я Продольная")]
    Prodolnaya11r,
    [EnumGuid("4EC52EC6-FB43-4282-9752-405A5D92CADC")]
    [Description("Продольная 2-я")]
    Prodolnaya2,
    [EnumGuid("354CACAB-DCEB-4D72-A6D9-8D72B0738CB7")]
    [Description("2-я Продольная")]
    Prodolnaya2r,
    [EnumGuid("EA147AAA-A17C-4004-8C3F-7ECD9512A932")]
    [Description("Продольная 3-я")]
    Prodolnaya3,
    [EnumGuid("D573E761-C74D-451D-B8C3-E2ACE01FB871")]
    [Description("3-я Продольная")]
    Prodolnaya3r,
    [EnumGuid("2476D432-CA23-4658-8490-C64EE50598F3")]
    [Description("Продольная 4-я")]
    Prodolnaya4,
    [EnumGuid("5F95389E-558F-4050-8CD6-DC5C7742FBDE")]
    [Description("4-я Продольная")]
    Prodolnaya4r,
    [EnumGuid("F6FF042B-BCFA-4463-A83A-C327B09D9F01")]
    [Description("Продольная 5-я")]
    Prodolnaya5,
    [EnumGuid("F52DF1A7-BCF1-4520-BED9-5B76C4E4D097")]
    [Description("5-я Продольная")]
    Prodolnaya5r,
    [EnumGuid("5A0BB97E-F7A5-4B11-AEA8-AECB360814C1")]
    [Description("Продольная 6-я")]
    Prodolnaya6,
    [EnumGuid("60D229E0-8F09-4C29-ADEC-C891DB3B227A")]
    [Description("6-я Продольная")]
    Prodolnaya6r,
    [EnumGuid("5D7B40FB-3795-46E5-B18D-3EBECB541410")]
    [Description("Продольная 7-я")]
    Prodolnaya7,
    [EnumGuid("5F0EE8C9-4EB7-4245-9EEF-A33A4D473207")]
    [Description("7-я Продольная")]
    Prodolnaya7r,
    [EnumGuid("92E396BA-2E21-4A0F-8DB6-02667176C251")]
    [Description("Продольная 8-я")]
    Prodolnaya8,
    [EnumGuid("0D692EB1-D601-4D15-9163-0A30445E3BCE")]
    [Description("8-я Продольная")]
    Prodolnaya8r,
    [EnumGuid("B88503FF-E291-4F95-AF7F-3C69FEF59254")]
    [Description("Продольная 9-я")]
    Prodolnaya9,
    [EnumGuid("D2AD6240-6C87-4331-95B9-EFDCD21226FC")]
    [Description("9-я Продольная")]
    Prodolnaya9r,
    [EnumGuid("9E9B0CC0-9BF9-48ED-8B05-5F7283F6EEBE")]
    [Description("Проектная")]
    Proyektnaya,
    [EnumGuid("7EC57A88-EDCE-4B1D-A3F7-A5B3EF3CA218")]
    [Description("Пролетарская")]
    Proletarskaya,
    [EnumGuid("D5525A79-0506-401E-BE2C-6B7C658C276A")]
    [Description("Промбаза")]
    Prombaza,
    [EnumGuid("14C620BF-9029-4709-B52E-D119FF84402B")]
    [Description("Промысловая")]
    Promyslovaya,
    [EnumGuid("B7C97797-433D-423A-A1AC-56B07FA2A6A6")]
    [Description("Промышленный")]
    Promyshlenniy,
    [EnumGuid("F95D523A-7DEF-4368-902D-BC9445A7F0C8")]
    [Description("Просвещения")]
    ProsvesheniyaBerezovka,
    [EnumGuid("195DE901-C971-4354-838B-8ACEA1C62392")]
    [Description("Просторная")]
    Prostoraya,
    [EnumGuid("FF5649E5-1F87-4797-81A4-6DA48FB71560")]
    [Description("Профсоюзов")]
    Profsoyuzov,
    [EnumGuid("998F1D1B-3809-4FB8-A9AD-5FC99D84E3C3")]
    [Description("Прохладный")]
    Prokhladniy,
    [EnumGuid("82F17505-FB5A-40E5-952E-01C04A9E36C0")]
    [Description("Прямая")]
    Pryamaya,
    [EnumGuid("AE489205-B38B-494E-A665-6AC985D23689")]
    [Description("Пугачева")]
    Pugacheva,
    [EnumGuid("E1DF4CCF-1310-4F08-9F27-7D7AE1CA1DF8")]
    [Description("Путевая")]
    Putevaya,
    [EnumGuid("2000FE34-0AA9-4C96-818A-0D28F5F8273F")]
    [Description("Путиловская")]
    Putilovskaya,
    [EnumGuid("EFC5633C-0CB9-4C29-ACE0-F22392820D1E")]
    [Description("Путоранская")]
    Putoranskaya,
    [EnumGuid("22CAEF05-78CC-49C9-80B0-9DF31129DB4E")]
    [Description("Пушкина")]
    Pushkina,
    [EnumGuid("FAC5892C-C062-47F7-A507-3B597A1A4CB2")]
    [Description("Пясинская")]
    Pyasinskaya,
    
    #endregion
    
    #region Улицы на букву Р
    
    [EnumGuid("D4700958-EAD2-4F0E-B205-6583195A285F")]
    [Description("Рабочая")]
    Rabochaya,
    [EnumGuid("A8F58005-0C30-49DC-986F-76A3FFA354FE")]
    [Description("Радищева")]
    Raditsheva,
    [EnumGuid("51CE76CE-5D1F-4F59-9264-418B8A504A2A")]
    [Description("Радужная")]
    Radzhumnaya,
    [EnumGuid("65FF4971-FB92-4200-9ABC-98CB34309B34")]
    [Description("Раздольная")]
    Razdolnaya,
    [EnumGuid("399270A4-4F3B-417A-B366-E56474D53D64")]
    [Description("Раскатная")]
    Raskatnaya,
    [EnumGuid("9978B431-DC84-4F32-B69D-BB4DEBA8C843")]
    [Description("Рассветная")]
    Rossvetnaya,
    [EnumGuid("80431A82-D460-4E61-AF43-1000FBEBEC75")]
    [Description("Революции")]
    Revolyutsionnaya,
    [EnumGuid("D7179D78-B89B-49AE-9A75-37920E88842B")]
    [Description("Регатная")]
    Regatnaya,
    [EnumGuid("94204F24-BF6D-418F-B8C0-C3F398D764B8")]
    [Description("Рейдовая")]
    Reydovaya,
    [EnumGuid("3E555D8D-661D-46C5-B2A3-CF8E04CB0C23")]
    [Description("Ремесловская")]
    Remeslovskaya,
    [EnumGuid("7F424E30-79AA-4202-9CE8-80B64CA27BA2")]
    [Description("Ремесленная")]
    Remeslennaya,
    [EnumGuid("5636F465-6A3B-4312-9EAE-323CC7E570F4")]
    [Description("Республика")]
    Respublika,
    [EnumGuid("29A6DAD9-EDE3-472C-9CD9-FE77973EC644")]
    [Description("Речников")]
    Rechkov,
    [EnumGuid("4EF7F052-7EBB-41B8-8B98-6F1515E16C46")]
    [Description("Речной")]
    Rechnyy,
    [EnumGuid("370163EA-0C39-4455-9C77-FEA697C053DE")]
    [Description("Робеспьера")]
    Robespierre,
    [EnumGuid("E723A68D-9453-4489-8603-F6258E0AD305")]
    [Description("Ровная")]
    Rovnaya,
    [EnumGuid("B2E75DFE-6F43-4064-B484-0F7FA897A020")]
    [Description("Рогова")]
    Rogova,
    [EnumGuid("D0EBC1FA-7B65-4284-BD00-11ED704BE8AD")]
    [Description("Родниковая")]
    Rodnikovaya,
    [EnumGuid("2519EB75-C93D-4193-8F5B-7A8E86F47B44")]
    [Description("Рождественская")]
    Rozhdestvenskaya,
    [EnumGuid("DCE21F81-D88C-4CF0-959A-445624539730")]
    [Description("Рождественская")]
    Rozhdestvenskaya2,
    [EnumGuid("FE8E3C0A-3D35-42B6-8ED3-BB71C2C84C76")]
    [Description("Розы Люксембург")]
    RozyLuksemburg,
    [EnumGuid("AEEA391C-6D24-4E09-AB9C-7C1BFBE35D9C")]
    [Description("Рокоссовского")]
    Rozhdonskogo,
    [EnumGuid("5CC17E89-9D03-4E1C-A0E4-4F8461BBD4E3")]
    [Description("Российская")]
    Rossiyskaya,
    [EnumGuid("CFA08766-EABC-4334-98D3-71EFDB9FA5AA")]
    [Description("Рощевая")]
    Rozchevaya,
    [EnumGuid("062ED5D8-DB74-4147-A841-E40930B8EEE8")]
    [Description("Русаковская")]
    Rusakovskaya,
    [EnumGuid("5E8C3382-2CBE-411E-A4DF-7A970E67307D")]
    [Description("Ручейная")]
    Rechnyaya,
    [EnumGuid("319DD61D-40AB-4885-97EA-62C0F74B5B8E")]
    [Description("Рябиновая")]
    Rabanovaya,
    [EnumGuid("3A30EBAA-8E55-4FB3-8DCD-DDF2BA71B908")]
    [Description("Рязанская")]
    Ryazanskaya,
    [EnumGuid("5D1CDFFE-41A5-44C5-A7BC-5CAB6AEBC7E5")]
    [Description("Ряузовский")]
    Ryauzovskii,
    
    #endregion

    #region Улицы на букву С

    [EnumGuid("AEF0D7AD-998B-45D0-9CF6-6140D07B1808")]
    [Description("Сад Крутовского")]
    SadKrutovskogo,
    [EnumGuid("6697F601-4FC7-4173-903B-57123EDA6237")]
    [Description("Садовая")]
    Sadovaya,
    [EnumGuid("06105139-D27F-4AE8-A2F1-E72AEC704F77")]
    [Description("Садовая")]
    Sadovaya2,
    [EnumGuid("00685919-6D7C-4B1E-8E07-49E7ED358306")]
    [Description("Садовая")]
    Sadovaya3,
    [EnumGuid("1047577B-6DD0-40A3-9EEF-83EBB9111F6F")]
    [Description("Сады")]
    Sady,
    [EnumGuid("AE674334-93B7-410E-981B-BC05F21B4A15")]
    [Description("Самарский")]
    Samarskiy,
    [EnumGuid("22BFC0BB-8F7F-4A2E-885A-2BB204BE3271")]
    [Description("Самодеятельности")]
    Samodeyatelnosti,
    [EnumGuid("BCCD1A15-69C0-4C0C-A311-4DA9E6A256B9")]
    [Description("Санаторная")]
    Sanatornaya,
    [EnumGuid("64123707-BA59-4444-867C-6D9BF8246434")]
    [Description("Саянская")]
    Sayanskaya,
    [EnumGuid("AC1375EC-327E-4271-822C-B349294C68A7")]
    [Description("Свердловская")]
    Sverdlovskaya,
    [EnumGuid("5F6F9D87-4C06-489A-AFB6-87B18B5623E0")]
    [Description("Светлая Элита")]
    SvetlayaElita,
    [EnumGuid("19874D33-8C26-48C6-B41B-CA9393DF71A2")]
    [Description("Светлова")]
    Svetlova,
    [EnumGuid("3E200386-86C6-4F20-A765-A3813551D877")]
    [Description("Светлогорская")]
    Svetlogorskaya,
    [EnumGuid("83880821-3B54-4BB2-AB24-934A10929F6E")]
    [Description("Светлогорский")]
    Svetlogorskiy,
    [EnumGuid("00873C50-91BF-4F5C-A57E-BBD126A78EC2")]
    [Description("Светлогорский")]
    Svetlogorskiy2,
    [EnumGuid("9E266437-B441-415E-8F1F-528E185FE0F5")]
    [Description("Светлый")]
    Svetliy,
    [EnumGuid("F2987110-B9D9-4AFD-B3DD-7C974259047C")]
    [Description("Свободная")]
    Svobodnaya,
    [EnumGuid("1F0F25BF-030E-4FDE-A05E-4049CE348511")]
    [Description("Свободный")]
    Svobodniy,
    [EnumGuid("B6BF2D70-D959-48F5-A751-6AD28C01D15A")]
    [Description("Связи")]
    Svazi,
    [EnumGuid("B131BBBC-66A8-45F0-BAE6-349D77ECC002")]
    [Description("Связистов")]
    Svyazistov,
    [EnumGuid("517716FD-EBF3-41BD-910F-6E2656AA2166")]
    [Description("Севастопольский")]
    Sevastopolskiy,
    [EnumGuid("B2C4D1CC-C5D8-40F0-91C4-07F5A4ABFAF4")]
    [Description("Северная")]
    Severnaya,
    [EnumGuid("7CB9EFFB-1634-4331-B3F9-0BBCEA20D627")]
    [Description("Северное")]
    Severnoe,
    [EnumGuid("3CD38DB4-49DF-41DA-B54F-F25F529A8E5C")]
    [Description("Северный")]
    Severniy,
    [EnumGuid("88010BDF-95E3-41B0-88B7-77F1991A9238")]
    [Description("Северо-Енисейская")]
    SeveroYeniseyskaya,
    [EnumGuid("F635D6A2-5E30-4240-B21B-1CFA097BD530")]
    [Description("Седова")]
    Sedova,
    [EnumGuid("7157EB51-12C2-4906-A2D2-DC9E71E1011E")]
    [Description("Сезонников")]
    Sezonnikov,
    [EnumGuid("0D5E7E0F-0A64-4F85-82FC-2B26495918A1")]
    [Description("Сельская")]
    Selskaya,
    [EnumGuid("0F0B23AD-C4CD-44F0-A433-78FE357C52C2")]
    [Description("Семафорная")]
    Semafornaya,
    [EnumGuid("1BAE4D84-3FAE-4A8A-8496-1F3A660BB2B7")]
    [Description("Семена Давыдова")]
    SemenaDavydova,
    [EnumGuid("DDDC4428-0452-412A-8906-E9D9CBB71E2F")]
    [Description("Сенная")]
    Sennaya,
    [EnumGuid("29AB2402-1EBB-4014-B7FA-A0BEF62B7D92")]
    [Description("Серафимовича")]
    Serafimovicha,
    [EnumGuid("A75D8BD8-7ACC-48E9-B7F0-6088403DE8F3")]
    [Description("Сергея Куликова")]
    SergeyaKulikova,
    [EnumGuid("8A3AB83D-7E50-4316-B323-035811D74EBB")]
    [Description("Сергея Лазо")]
    SergeyaLazo,
    [EnumGuid("5F6964E0-0073-470C-AC39-D0B674F7D202")]
    [Description("Сергея Тюленина")]
    SergeyaTyulenina,
    [EnumGuid("9143155C-7290-453C-B25A-344180DAB33E")]
    [Description("Серебряный")]
    Serebryaniy,
    [EnumGuid("514E986F-A1FE-469B-AFB3-F48AF2B03FB0")]
    [Description("Серебряный Бор")]
    SerebryaniyBor,
    [EnumGuid("2FE84DC1-8D2B-46ED-814B-9235040B0E64")]
    [Description("Серова")]
    Serova,
    [EnumGuid("A0E5F795-AAB4-48EA-9EF3-06496EFA62DF")]
    [Description("Сеченова")]
    Sechenova,
    [EnumGuid("3B4335C8-BF74-4282-B243-A197FAFE6DD1")]
    [Description("Сибирская")]
    Sibirskaya,
    [EnumGuid("0813E142-8D71-49FC-A7A0-0C2BD816F4BE")]
    [Description("Сибирский")]
    Sibirskiy,
    [EnumGuid("CD1CC520-0F4D-42ED-A812-2EBF4A12611A")]
    [Description("Сиреневая")]
    Sirennevaya,
    [EnumGuid("4510662F-43F5-4035-BEF0-7E732B19295C")]
    [Description("Сисимский")]
    Sisimskiy,
    [EnumGuid("1D3B08B4-9AB5-45CA-AD10-153422A99FB5")]
    [Description("Скальная")]
    Skalnaya,
    [EnumGuid("F9B06AD2-0B54-4C07-9C7E-1DA3AF19C324")]
    [Description("Сквозной")]
    Skvoznoy,
    [EnumGuid("153F22ED-3867-4E3A-8B92-8CE4E0F4A04E")]
    [Description("Складская")]
    Skladskaya,
    [EnumGuid("23DAEAA6-8C7F-4545-9F9D-6CAA1F6900BA")]
    [Description("Славы")]
    Slavy,
    [EnumGuid("1593DEC3-F07B-442F-B855-1B44B2399258")]
    [Description("Славянская")]
    Slavyanskaya,
    [EnumGuid("0E2ABED1-ED64-43E4-8F54-91A207FA2D5A")]
    [Description("Слободская")]
    Slobodskaya,
    [EnumGuid("D3ED33EF-E0D5-40A3-93CB-4C91FB49B23D")]
    [Description("Смоленская 1-я")]
    Smolenskaya1,
    [EnumGuid("1147EAC1-6665-4680-9E12-CE92C3362B35")]
    [Description("Смоленская 2-я")]
    Smolenskaya2,
    [EnumGuid("DEAB652D-580F-44B6-BC08-27BF04B6F03D")]
    [Description("Смоленская 3-я")]
    Smolenskaya3,
    [EnumGuid("BEEA32AD-EC62-4C24-A39A-752B3F14BD4C")]
    [Description("1-я Смоленская ")]
    Smolenskaya1r,
    [EnumGuid("BA0B9C9D-A155-4BD0-B926-365A81F4EF0E")]
    [Description("2-я Смоленская ")]
    Smolenskaya2r,
    [EnumGuid("A9C384F7-12F0-4104-B093-3A002BE78108")]
    [Description("3-я Смоленская ")]
    Smolenskaya3r,
    [EnumGuid("0976C806-7D20-4BC2-8D20-171F7704BF0D")]
    [Description("Снежная")]
    Snezhnaya,
    [EnumGuid("37617871-D331-4F79-883D-6EB16382F93F")]
    [Description("Советская")]
    Sovetskaya,
    [EnumGuid("0E4BF6FE-37D5-467F-8FC8-D5534E5C6031")]
    [Description("Содружества")]
    Sodruzhestva,
    [EnumGuid("F65AAD2E-4B64-4332-BA39-BFD9FFE054FF")]
    [Description("Соколовская")]
    Sokolovskaya,
    [EnumGuid("2FA099A3-0E94-4269-9E51-7038A0BE761D")]
    [Description("Сокольский")]
    Sokolskiy,
    [EnumGuid("0ED02514-8DE5-487E-BA14-38A72A538B83")]
    [Description("Солнечная")]
    Solnechnaya,
    [EnumGuid("E6DDF91D-8C51-4E99-8AD3-AE28A15E1C75")]
    [Description("Солнечный")]
    Solnechniy,
    [EnumGuid("7E213562-C392-4C0A-BD77-8DCB3532E905")]
    [Description("Солонцовая")]
    Solontsovaya,
    [EnumGuid("DFDD997E-BA10-47C8-A787-CBD82A7386B3")]
    [Description("Сопочная")]
    Sopochaya,
    [EnumGuid("9CB60000-FE27-4FE6-909F-E21EA94592CF")]
    [Description("Соревнования")]
    Sorevnovaniya,
    [EnumGuid("D19C2E8D-964C-4E91-829F-8F125A413559")]
    [Description("Сосновая")]
    Sosnovaya,
    [EnumGuid("3461282F-AB0A-4675-A4F2-2FD6ABA4C23B")]
    [Description("Сосновая")]
    Sosnovaya2,
    [EnumGuid("48815CDE-4949-490C-9382-3B32389E8BFC")]
    [Description("Сосновского")]
    Sosnovskogo,
    [EnumGuid("219D381C-51EB-4AA9-A7E6-C25AE0DEBF0B")]
    [Description("Сосновый Бор")]
    SosnoviyBor,
    [EnumGuid("5FFA7560-E669-49DF-85D8-929BED117475")]
    [Description("Софьи Ковалевской")]
    SofyiKovalevskoy,
    [EnumGuid("C7806735-1DF2-4620-9FDA-6EBF69328D99")]
    [Description("Социалистическая")]
    Sotsialisticheskaya,
    [EnumGuid("F6440BC0-51E1-4ED7-BA9A-DB0E95FE3901")]
    [Description("Спандаряна")]
    Spandaryana,
    [EnumGuid("233B6B28-A6FC-45C6-A254-A6E9B9B498A9")]
    [Description("Спартаковцев")]
    Spartakovtsev,
    [EnumGuid("8C384A4B-D114-415D-9361-779D6E2568B2")]
    [Description("Спасского")]
    Spasskogo,
    [EnumGuid("E199CF35-CEEA-4874-8BF0-091FAFB89547")]
    [Description("Сплавучасток")]
    Splavuchastok,
    [EnumGuid("FA0EB70A-6CCA-450A-8405-690FD9221C57")]
    [Description("Спокойная")]
    Spokoinaya,
    [EnumGuid("5FEF8F89-2FC0-4CE7-AFF8-365E15791EB1")]
    [Description("Спорта")]
    Sporta,
    [EnumGuid("7856D271-1905-47CF-9689-AC2FD1F45D08")]
    [Description("Спортивная")]
    Sportivnaya,
    [EnumGuid("9ED58301-EDD4-48BF-BD3B-E4C4C8A81C4E")]
    [Description("Спортивный")]
    Sportivniy,
    [EnumGuid("18443FCE-F975-4F00-A521-BB8CFA5DB576")]
    [Description("Средний")]
    Sredniy,
    [EnumGuid("D6541C53-AFD9-4021-A456-9F955B9C4F43")]
    [Description("Сретенская")]
    Sretenkaya,
    [EnumGuid("DEF63267-CA4C-4B0D-BFB0-EA5C638E5193")]
    [Description("Стадионная")]
    Stadionnaya,
    [EnumGuid("0C0B6227-5EF2-4BC6-8E45-B0F55BB20162")]
    [Description("Станиславского")]
    Stanislavskogo,
    [EnumGuid("81C4EC76-68EF-4E18-918B-60B7640F47D3")]
    [Description("Станичная")]
    Stanichnaya,
    [EnumGuid("0B935F67-D4E3-43E0-856D-D39BEA96D4F9")]
    [Description("Становая")]
    Stanovaya,
    [EnumGuid("5F25753A-08F9-48E2-A48F-8BE1927EB5DB")]
    [Description("Станочная")]
    Stanochaya,
    [EnumGuid("63EC252A-BC5B-4823-BB2B-35DCBCDB622C")]
    [Description("Станционная")]
    Stantsionnaya,
    [EnumGuid("487ADA37-D131-4175-A5DC-BD0FFC0FD0D2")]
    [Description("Степана Разина")]
    StepanaRazina,
    [EnumGuid("C37ED1E9-7C9B-4458-815A-E0C03AB51620")]
    [Description("Столбовая")]
    Stolbovaya,
    [EnumGuid("53BED7FE-76C5-4440-80E9-2D63AEB8DF26")]
    [Description("Стрелецкая")]
    Streltskaya,
    [EnumGuid("97696037-A856-45B5-8BA4-7ABA2900411A")]
    [Description("Стрелочная")]
    Strelochnaya,
    [EnumGuid("9A143CA9-AA4C-4AFE-995D-AD1C8431667F")]
    [Description("Строительная")]
    Stroitelnaya,
    [EnumGuid("1892124A-B803-4008-A811-B7C46E128381")]
    [Description("Суворова")]
    Suvorova,
    [EnumGuid("05D727BE-45F4-452E-A015-664C682A7636")]
    [Description("Судостроительная")]
    Sudostroitelnaya,
    [EnumGuid("36C7892C-F960-4439-AC26-2DA91AECE52D")]
    [Description("Сурикова")]
    Surikova,
    [EnumGuid("7D24F754-6DDF-44FD-932C-228DAEBC52C2")]
    [Description("Счастливая")]
    Schastlivaya,

    #endregion

    #region Улицы на букву Т

    [EnumGuid("7B9E17D4-4151-4C91-A9EF-7486E00265B3")]
    [Description("Таежная")]
    Tayezhnaya,
    [EnumGuid("07F3785E-86C5-40A9-B017-970DDEFA1364")]
    [Description("Бугачево")]
    Bugachevo,
    [EnumGuid("9B6C34C8-DC7D-423B-804F-C1AE0FF3F352")]
    [Description("Таймырская")]
    Taymyrskaya,
    [EnumGuid("69985192-7E9C-4DC7-A087-E8FA68C1ADC5")]
    [Description("1-я Таймырская")]
    Taymyrskaya1,
    [EnumGuid("7617790C-B000-4EAE-B10B-5E47485E5846")]
    [Description("2-я Таймырская")]
    Taymyrskaya2,
    [EnumGuid("B5000FF2-95AB-4D4E-B94D-0191E2A3B0E8")]
    [Description("3-я Таймырская")]
    Taymyrskaya3,
    [EnumGuid("D51ED3A5-3EA4-4397-AF71-E18B745F9E88")]
    [Description("4-я Таймырская")]
    Taymyrskaya4,
    [EnumGuid("EBE1F94D-6BD9-4FC7-A76B-8EE4B36B8912")]
    [Description("5-я Таймырская")]
    Taymyrskaya5,
    [EnumGuid("89090BC7-0BBC-499B-90AB-A06AFBE0B98F")]
    [Description("Талнахская")]
    Talnakhskaya,
    [EnumGuid("23B32D31-9CBF-40FA-B3DA-366D424B9A98")]
    [Description("Тамбовская")]
    Tambovskaya,
    [EnumGuid("19954DF9-99C3-439A-9FD8-D2B3D0E68222")]
    [Description("Танкистов")]
    Tankistov,
    [EnumGuid("8B5048A5-DB53-44D7-9925-87191D917C28")]
    [Description("Таскинская")]
    Taskinskaya,
    [EnumGuid("87DF5E15-D4D6-45CE-9327-B9E9085D3A0E")]
    [Description("Татышев")]
    Tatyshev,
    [EnumGuid("4FA1C438-C914-468C-A2AE-4D9D60C3956A")]
    [Description("Таштыпский")]
    Tashtypskiy,
    [EnumGuid("1EF29DAD-26B5-464F-8B64-9CCACABAD137")]
    [Description("Театральная")]
    Teatralnaya,
    [EnumGuid("18BF61CB-6E54-400A-9CCE-881C9A903ABE")]
    [Description("Текстильщиков")]
    Tekstilshchikov,
    [EnumGuid("8F2BDAFF-C6F3-4A82-A8D1-C2D7954AB110")]
    [Description("Телевизорная")]
    Televidzornaya,
    [EnumGuid("6B1C2B21-CC59-44E3-A4C4-27265736086C")]
    [Description("Телевизорный")]
    Televidzorniy,
    [EnumGuid("31AF1D7F-949E-4A07-8C42-ABDD281BF830")]
    [Description("Тельмана")]
    Telmana,
    [EnumGuid("6D622793-730D-4F20-8C08-A1C18510A8B3")]
    [Description("Тенистая")]
    Tenistaya,
    [EnumGuid("BD148654-8332-4161-9BF0-AECA8AD9C2B0")]
    [Description("Теплый")]
    Teplyy,
    [EnumGuid("0FA2A3D2-28A4-440F-A324-EE0893FE9D36")]
    [Description("Терешковой")]
    Tereshkovoy,
    [EnumGuid("B38EF6D8-D3C3-43C2-A6AC-9D211D5E92E6")]
    [Description("Техническая")]
    Tekhnicheskaya,
    [EnumGuid("D98EF8FA-CCB3-449B-97AC-1B4FE4DDF3BA")]
    [Description("Технический Поселок")]
    TekhnicheskiyPoselok,
    [EnumGuid("31D9B643-F461-4DED-8BC5-8DE395B3BAD1")]
    [Description("Технологическая")]
    Tekhnologicheskaya,
    [EnumGuid("60D1F76D-FE82-4A58-8BEB-487623583899")]
    [Description("Тимирязева")]
    Timiryazeva,
    [EnumGuid("1C00551F-65A7-4008-AC48-C6C621A95B85")]
    [Description("Тихий")]
    Tikhiy,
    [EnumGuid("2A9457D1-93B9-46CD-AFD1-D9134071AA77")]
    [Description("Тихоновская")]
    Tikhonovskaya,
    [EnumGuid("C787D864-4020-4A48-A5D4-53AFBCDAD2BA")]
    [Description("Тобольская")]
    Tobolskaya,
    [EnumGuid("FA477421-C78E-48ED-B96A-8032E564F052")]
    [Description("Толстого")]
    Tolstogo,
    [EnumGuid("B6D39F5B-316B-474B-8A80-561356BBF801")]
    [Description("Томская")]
    Tomskaya,
    [EnumGuid("7EEB7838-CD70-4395-B9C5-CCC46AB76839")]
    [Description("Торгашинская")]
    Torgashinskaya,
    [EnumGuid("4CB68190-69A0-497F-A4D0-02790033D30F")]
    [Description("Торговая")]
    Torgovaya,
    [EnumGuid("8406AD7C-9D0A-4D4B-9958-BB681B75DB09")]
    [Description("Тотмина")]
    Totmina,
    [EnumGuid("3AF552D8-F6CF-4669-A64C-E5543D52F38C")]
    [Description("Трактовая")]
    Traktovaya,
    [EnumGuid("C5F08B6C-2ED5-4D26-93DD-8596AE0F228F")]
    [Description("Трактористов")]
    Traktoristov,
    [EnumGuid("5F8AEF78-2633-42DC-8ED8-B90024215745")]
    [Description("Транзитная")]
    Tranzitnaya,
    [EnumGuid("AC4A0C00-636B-4AEF-8356-1BF066613D75")]
    [Description("Транспортный")]
    Transportniy,
    [EnumGuid("C3DAF816-8EED-4F9A-8775-C880E9E4EE8E")]
    [Description("Транспортный")]
    Transportniy2,
    [EnumGuid("50C0AA6B-5510-4AC0-80E1-1EEB6946E65D")]
    [Description("Троицкая")]
    Troitskaya,
    [EnumGuid("114C544B-DF5C-4F58-927D-39DF5E700390")]
    [Description("Труда")]
    Truda,
    [EnumGuid("B0106C5C-2160-445F-80AE-5352219A6BB3")]
    [Description("Тубинская")]
    Tubinskaya,
    [EnumGuid("4D31C35A-F8DC-41FA-AEC2-55B6FEDA8D21")]
    [Description("Туимский")]
    Tuimskiy,
    [EnumGuid("AA403EF0-D9EA-4848-876D-A52BD8E83806")]
    [Description("Туманный")]
    Tumanniy,
    [EnumGuid("BAB097FD-8126-401B-9EBF-9C60D264FA6A")]
    [Description("Тупиковый")]
    Tupikoviy,
    [EnumGuid("0608E7BC-5B11-4795-8C53-73D2681B8B4A")]
    [Description("Турбаза")]
    Turbaza,
    [EnumGuid("894DA46F-03FE-44CC-9DE9-9593121E8E80")]
    [Description("Турбинная")]
    Turbinaya,
    [EnumGuid("31BCB708-1FE2-4E2F-8041-C6BC38C88D39")]
    [Description("Тургенева")]
    Turgeneva,
    [EnumGuid("5404E128-91CD-4D82-87B1-96921EA349E0")]
    [Description("Туристская")]
    Turistskaya,
    [EnumGuid("6565BF4A-91C1-4E20-9231-972112B160EC")]
    [Description("Туруханская")]
    Turukhanskaya,
    [EnumGuid("607BECAF-5B99-42F0-9D26-48C8219E202A")]
    [Description("Турчанинова")]
    Turchaninova,
    [EnumGuid("21FB4A3D-A1E2-41D6-ABE7-7787FEE27361")]
    [Description("Тюхтетский")]
    Tyukhtetskaya,

    #endregion

    #region Улицы на букву У

    [EnumGuid("2C3D10ED-693A-41ED-B9A7-1E4FCD29364F")]
    [Description("Угловой")]
    Uglovoy,
    [EnumGuid("CEB1F119-B672-4E93-97FE-2B8A32601EE4")]
    [Description("Угольный")]
    Ugolniy,
    [EnumGuid("6D32E121-CA49-4D2D-94A6-F8D9260BAB3C")]
    [Description("Угольщиков")]
    Ugolshchikov,
    [EnumGuid("C5E1B271-6ECF-4C45-A3FA-5C62F8642786")]
    [Description("Ударный")]
    Udarniy,
    [EnumGuid("2211AC2C-8641-4D9A-ADD0-0F6D582BA26B")]
    [Description("Удачная")]
    Udachnaya,
    [EnumGuid("2E68CC16-F135-4DE7-B5B2-23FEE1456396")]
    [Description("Удобный")]
    Udobniy,
    [EnumGuid("23710265-9814-4FDF-8D27-2E51BD77FD4B")]
    [Description("Узкий")]
    Uzkij,
    [EnumGuid("33899FD3-6FF3-4F5A-B78A-8B60089CBD07")]
    [Description("Украинская")]
    Ukrainskaya,
    [EnumGuid("0DB7EDF2-F510-42B2-BB0F-AEBD1AC6ADB6")]
    [Description("Уланова")]
    Ulanova,
    [EnumGuid("22B2B508-0C97-4775-9A49-7CCA581ACA77")]
    [Description("Ульяновский")]
    Ulyanovskiy,
    [EnumGuid("75EA8E8A-705A-4600-994A-93189BAC253A")]
    [Description("Ульяны Громовой")]
    UlyaniGromovoy,
    [EnumGuid("21A2A574-F82A-41C3-8CAB-A218BE6A5F64")]
    [Description("Уральский")]
    Uraliskiy,
    [EnumGuid("06C9359A-6C09-4FCE-B63B-F4AA4EF6F82F")]
    [Description("Урванцева")]
    Urvantseva,
    [EnumGuid("240A3A01-7125-45E4-900C-49B9F8FF221C")]
    [Description("Урицкого")]
    Uritskogo,
    [EnumGuid("7A56D006-3AE6-408B-BB0E-80F35B4A24D3")]
    [Description("Урожайная")]
    Urozhaynaya,
    [EnumGuid("FF5E3D0A-27F5-488C-943D-9E0CE0ED4BDC")]
    [Description("Усадебная")]
    Usadebnaya,
    [EnumGuid("29D4AE59-D6E6-4A7F-8C71-5C5E678831CA")]
    [Description("Успенская")]
    Uspenskaya,
    [EnumGuid("CBE72B0D-A93E-46C2-A18D-1BB5E3B944E5")]
    [Description("Уссурийская")]
    Ussuriyskaya,
    [EnumGuid("9A68A489-6813-48C7-B8BC-49ABD45A06A7")]
    [Description("Устиновича")]
    Ustinovicha,
    [EnumGuid("AC930576-F0A1-4743-9B5F-796CF529DD73")]
    [Description("Утренняя")]
    Utrennyaya,
    [EnumGuid("7ACE7286-2BD1-42BE-B0DA-FAA3939EAB6A")]
    [Description("Ухоженный")]
    Ukhozhenniy,
    [EnumGuid("F7BEE84B-BE55-483C-A3FE-5432B7F57BE5")]
    [Description("Участок 5-й")]
    Uchastok5,
    [EnumGuid("56168172-D0F3-4195-900F-080FC7325E0E")]
    [Description("Учумская")]
    Uchumskaya,
    [EnumGuid("9E355D5D-1B1B-4C4D-8A22-105418962B9A")]
    [Description("Уютная")]
    Uyutnaya,
    [EnumGuid("B4F53BC7-5353-43BA-AE3C-E94A0CF08DFF")]
    [Description("Уютный")]
    Uyutniy,
    [EnumGuid("91E22415-3A90-4B36-9614-97E55C973275")]
    [Description("Уярская")]
    Uyarskaya,

    #endregion

    #region Улицы на букву Ф

    [EnumGuid("8BADE87A-5346-4D06-B724-4CCE1B7B88F1")]
    [Description("Фабричная")]
    Fabrichnaya,
    [EnumGuid("36C2504F-A953-49C9-99EF-B53164FDE603")]
    [Description("Ферганская")]
    Ferganskaya,
    [EnumGuid("8E28FAD3-524A-4B47-982E-F55AEEE62058")]
    [Description("Фестивальная")]
    Festivalnaya,
    [EnumGuid("889F2D8E-E42C-4B46-B8F0-9FBEE8B37A1D")]
    [Description("Фигурная")]
    Figurnaya,
    [EnumGuid("191E015A-E5B6-451F-8936-91D676CC304D")]
    [Description("Фруктовая")]
    Fructovaya,
    [EnumGuid("1BA19D30-B641-47F4-A4E1-BC12CF9A416A")]
    [Description("Фрунзе")]
    Frunze,
    [EnumGuid("317B4EAF-C0A0-49D7-98B9-57F51B57C4B1")]
    [Description("Фурманова")]
    Furmanova,

    #endregion

    #region Улицы на букву Х

    [EnumGuid("AB12063F-000E-4715-859B-A3FF45C35477")]
    [Description("Хабаровская 1-я")]
    Khabarovskaya1,
    [EnumGuid("0DCFF0AF-172E-4C63-A574-F0108A6998A1")]
    [Description("Хабаровская 2-я")]
    Khabarovskaya2,
    [EnumGuid("D99A0A01-61D7-43BB-82D0-F8A394BC4C03")]
    [Description("1-я Хабаровская")]
    Khabarovskaya1r,
    [EnumGuid("07B56EB6-9300-44FC-8E60-2527CA8F8BFE")]
    [Description("2-я Хабаровская")]
    Khabarovskaya2r,
    [EnumGuid("96928748-546D-4367-9BF1-FA3106678332")]
    [Description("Хантайская")]
    Khantayskaya,
    [EnumGuid("F394B787-C42E-45B7-AFCB-B78A1807A67A")]
    [Description("Харламова")]
    Kharlamova,
    [EnumGuid("E4BDB2A3-E477-4966-BE92-6D09CC24ED58")]
    [Description("Хетская")]
    Khetskaya,
    [EnumGuid("5CAE70CB-304F-45B2-A048-3C8D91ADAD19")]
    [Description("Холмистая")]
    Kholmistaya,
    [EnumGuid("25427496-F491-45C3-9F55-25493C13BB49")]
    [Description("Храпова")]
    Khrapova,
    [EnumGuid("9BED6308-4592-4C60-9CCB-29DB5FD7B58A")]
    [Description("Хрустальная")]
    Khristalnaya,
    [EnumGuid("572EEBF1-9FD4-41D7-99C0-B621F3D92B24")]
    [Description("Хуторская")]
    Khutorskaya,

    #endregion

    #region Улицы на букву Ц

    [EnumGuid("A7D37156-C67F-4FBD-9C33-2B8449A60755")]
    [Description("Цветной")]
    Tsvetnoy,
    [EnumGuid("76CF8AB6-79BF-4241-A871-4BDCC33F34B5")]
    [Description("Цветочная")]
    Tsvetochnaya,
    [EnumGuid("3CCECF9B-26C7-46BC-AAB8-69ADC98A6681")]
    [Description("Цветущая")]
    Tsvetusshaya,
    [EnumGuid("ABE34199-D3EE-46DD-BBB4-9CCB07E9E3AA")]
    [Description("Цементников")]
    Tsementnikov,
    [EnumGuid("79FFE264-CDBF-4ED4-9A06-BED9BBDF6376")]
    [Description("Центральный")]
    Tsentralniy,
    [EnumGuid("FF6118E3-D53E-4A58-BEC7-DCF86F339B74")]
    [Description("Цимлянская")]
    Tsimalanskaya,
    [EnumGuid("D9837763-45ED-4C9F-AF21-7C750B2491D6")]
    [Description("Циолковского")]
    Tsolkovskogo,

    #endregion

    #region Улицы на букву Ч

    [EnumGuid("D1355196-E618-41D8-8204-EE0BECC5FC70")]
    [Description("Чайковского")]
    Chaykovskogo,
    [EnumGuid("3CA9FA2A-A778-4DB6-9C48-51263FA06496")]
    [Description("Частоостровская")]
    Chastoostrovskaya,
    [EnumGuid("03E043A5-5E9B-4CEE-8830-9F58F7DA8656")]
    [Description("Челюскинцев")]
    Chelyuskintsev,
    [EnumGuid("0D5DF015-32CB-449D-9C68-B40E4537F942")]
    [Description("Черёмуховая")]
    Cheryomukhovaya,
    [EnumGuid("EBC03110-9129-450D-A29C-074F140A36F8")]
    [Description("Черемховская 2-я")]
    Cheryomukhovaya2,
    [EnumGuid("0651B8CB-5530-4D08-BE38-89F321831736")]
    [Description("2-я Черемховская")]
    Cheremkhovskaya2r,
    [EnumGuid("C436B5E7-8AC0-47E7-AF81-F6A8F13AE387")]
    [Description("Черепнина")]
    Cherepnina,
    [EnumGuid("F0FE3E53-0D97-46F0-9C6A-20F38E7934A4")]
    [Description("Черничная")]
    Chernichnaya,
    [EnumGuid("AAEF5E81-A413-4D6C-BDBC-E678E68DC078")]
    [Description("Чернышева")]
    Chernysheva,
    [EnumGuid("FC7C23BF-DA64-4F10-9AAB-9FE2467DA319")]
    [Description("Чернышевского")]
    Chernyshevskogo,
    [EnumGuid("1C2A6E2C-4AA9-4D20-91F1-F8D457EC1CCA")]
    [Description("Черняховского")]
    Chernyakhovskogo,
    [EnumGuid("72A0F734-6F53-48E8-AC11-0C16FDCED31A")]
    [Description("Чехова")]
    Chekhova,
    [EnumGuid("FC253252-642B-4A54-89C9-564603B7CF53")]
    [Description("Чечеульский")]
    Checheulskiy,
    [EnumGuid("3011B8FD-F968-4C63-BC6A-C16E45E88611")]
    [Description("Чистопрудная")]
    Chistoprudnaya,
    [EnumGuid("19B185D3-221E-4F4C-BB47-F96A67CA9F83")]
    [Description("Чистый Лог")]
    ChistiyLog,
    [EnumGuid("7027BDB7-F090-401F-B227-BCE02429387B")]
    [Description("Читинская")]
    Chitinskaya,
    [EnumGuid("F898DE7C-2B38-4A71-92CB-8AEBF5A37E34")]
    [Description("Чкалова")]
    Chkalova,

    #endregion

    #region Улицы на букву Ш

    [EnumGuid("A5417791-EFEC-44D1-A83C-3183C30E62A6")]
    [Description("Шахтёров")]
    Shakhtyorov,
    [EnumGuid("63175FD4-D231-40AB-9DCB-61F1068EB624")]
    [Description("Шевченко")]
    Shevchenko,
    [EnumGuid("C8755BF1-A7B6-4278-B2C9-382EFADA4E61")]
    [Description("Шелковая")]
    Shelkovaya,
    [EnumGuid("345B98BD-9CEE-4976-96C3-9D057B567606")]
    [Description("Шиверская")]
    Shiverskaya,
    [EnumGuid("C11816D5-BAED-451D-B3B5-0C67702C0893")]
    [Description("Шиндандская улица")]
    Shindandskaya,
    [EnumGuid("CD4C43C5-1372-47CF-A4FF-245381B66CBF")]
    [Description("Шинная 1-я")]
    Shinnaya1,
    [EnumGuid("EA3BA672-594C-4ABB-97A5-20DD57A5AFF2")]
    [Description("Шинная 2-я")]
    Shinnaya2,
    [EnumGuid("AD5EC753-5960-43B4-BFAD-2036F31FBBC0")]
    [Description("Шинная 3-я")]
    Shinnaya3,
    [EnumGuid("B4C03C58-C5B2-438D-ACFB-51E8C59D51EB")]
    [Description("4-я Шинная")]
    Shinnaya4,
    [EnumGuid("BE043C3B-85C7-49B4-888D-6AA0DC98DF58")]
    [Description("1-я Шинная")]
    Shinnaya1r,
    [EnumGuid("01C4F04A-8878-4A76-AEC8-ED4443326BC7")]
    [Description("1-я Шинная")]
    Shinnaya2r,
    [EnumGuid("35C4C5BA-F113-4206-AE52-3D76A84FDFC8")]
    [Description("3-я Шинная")]
    Shinnaya3r,
    [EnumGuid("A0C7320A-F40F-4EF4-94A5-FF7145A0DF8F")]
    [Description("4-я Шинная")]
    Shinnaya4r,
    [EnumGuid("289DCD89-1DF6-404B-9216-03826265C3EA")]
    [Description("Ширинская")]
    Shirinskaya,
    [EnumGuid("E9F36CEA-2F9E-4331-8543-E440992FC3F7")]
    [Description("Широкая")]
    Shirokaya,
    [EnumGuid("40B2F43D-A39B-44F6-883B-14B08801FBF6")]
    [Description("Шиферников")]
    Shiferinikov,
    [EnumGuid("A96359BC-EAE7-4A5B-BF19-69AB5CEFBB14")]
    [Description("Школьный")]
    Shkolniy,
    [EnumGuid("6374C82A-1488-43A5-BAC4-E67174825784")]
    [Description("Шмидта")]
    Shmidta,
    [EnumGuid("3BFACA88-F3CC-4393-8E6D-E8A4AFFC1A5C")]
    [Description("Шумяцкого")]
    Shumyatskogo,
    [EnumGuid("FDD2B462-0E75-4002-B9F9-59F8E5AE1CFE")]
    [Description("Шушенская")]
    Shushenskaya,

    #endregion

    #region Улицы на букву Щ

    [EnumGuid("F30D8B0B-5A08-4C81-B6D0-6BB5F718A9AE")]
    [Description("Щербакова")]
    Shcherbakova,
    [EnumGuid("E625BAC6-1B7E-466B-9864-332A75F37931")]
    [Description("Щетинкина")]
    Shchetinkina,
    [EnumGuid("D50A21B9-A6A9-4223-9E08-399EBCFC943E")]
    [Description("Щорса")]
    Shchorssa,

    #endregion

    #region Улицы на букву Э

    [EnumGuid("3940EC43-5201-402C-B0A8-1524CF741823")]
    [Description("Эвенкийская")]
    Evenkiyskaya,
    [EnumGuid("C44C0703-F3DD-425A-9D2E-DDCA6A601C57")]
    [Description("Экологов")]
    Ekologov,
    [EnumGuid("78F168AF-5AFB-467B-BAFA-9602BEBE47B5")]
    [Description("Экскурсантов")]
    Ekskursantov,
    [EnumGuid("7335C2FD-F9EC-47DC-AC83-417A52A8AA39")]
    [Description("Электриков")]
    Elektrokov,
    [EnumGuid("AF3C2960-6F0C-42CA-A7BA-B3C31A70019D")]
    [Description("Энгельса")]
    Engelsa,
    [EnumGuid("54B02F2E-92CA-46A0-99BA-2C14DABECAF0")]
    [Description("Энергетиков")]
    Energetikov,
    [EnumGuid("ABFE8B71-384B-496F-8D51-1F5DD111C27B")]
    [Description("Энтузиастов")]
    Entuziastov,

    #endregion

    #region Улицы на букву Ю

    [EnumGuid("33BDFEFE-C2D3-4EB5-9746-6ACCD6FF809C")]
    [Description("Юбилейная")]
    Yubileynaya,
    [EnumGuid("1F2CF922-BC1A-49F4-B96E-80FD95736E51")]
    [Description("Южная")]
    Yuzhnaya,
    [EnumGuid("0FA0758C-E00E-4770-8548-2DC9CDEFB13B")]
    [Description("Юности")]
    Yunosti,
    [EnumGuid("FF51506A-B8B0-4B23-B7F9-ACB5A207686D")]
    [Description("Юрия Гагарина")]
    YuriyaGagarina,
    [EnumGuid("3F025014-89C5-4B3B-B19C-07B2385CE851")]
    [Description("Юрия Смирнова")]
    YuriyaSmirnova,
    [EnumGuid("8C8AB3BB-5092-4BD5-B213-B1E2ECEF64F5")]
    [Description("Юшкова")]
    Yushkova,

    #endregion

    #region Улицы на букву Я 

    [EnumGuid("C0D42C82-A57B-4D56-8357-1FDFD73B81D2")]
    [Description("Яблоневая")]
    Yablonovaya,
    [EnumGuid("6B8DD42A-9C22-4025-B96A-4BFAAB29151C")]
    [Description("Яблочкова")]
    Yablochkova,
    [EnumGuid("09A7554B-1C7B-48EE-AD3F-8C56647627A5")]
    [Description("Ягельный")]
    Yagelniy,
    [EnumGuid("6742EC20-B322-44E9-838D-ABA385E07868")]
    [Description("Ягодная")]
    Yagodnaya,
    [EnumGuid("7E048420-86AB-4480-8092-70B30A97DD10")]
    [Description("Ягодный")]
    Yagodniy,
    [EnumGuid("9DDDB5FE-F429-49F4-BAC3-E9940AD27813")]
    [Description("Яковлева")]
    Yakovleva,
    [EnumGuid("22BE3311-2702-441A-A55B-DB8750C594FA")]
    [Description("Якорный")]
    Yakorniy,
    [EnumGuid("C5B2535B-1310-4B88-8C36-5E1FEE6691F3")]
    [Description("Якутская")]
    Yakutskaya,
    [EnumGuid("7087001E-D069-411F-B5EF-455D9F17F442")]
    [Description("Якутская 1-я")]
    Yakutskaya1,
    [EnumGuid("D752869D-10F3-47A0-B45F-7D828BD5284E")]
    [Description("Ялтинский")]
    Yaltinskiy,
    [EnumGuid("D9B1097E-A520-402D-944B-FF98F1B54DC5")]
    [Description("Янковского")]
    Yankovskogo,
    [EnumGuid("93BDBD32-D7D3-40FD-8F51-869378EAE365")]
    [Description("Янтарная")]
    Yantarnaya,
    [EnumGuid("1D0D6BF0-DC9E-429E-8A1C-74E2F8CCB669")]
    [Description("Ярлыковская")]
    Yarlykovskaya,
    [EnumGuid("7D0657BC-1E75-4BDC-912F-BBEB0575A75D")]
    [Description("Ярославская")]
    Yaroslavskaya,
    [EnumGuid("D2F3C61B-2562-498B-9E18-BC3FA0FE09C7")]
    [Description("Ярцевский")]
    Yarcevskiy,
    [EnumGuid("20D78B76-C2E4-47E8-BDB3-673FF109A951")]
    [Description("Ярыгинская")]
    Yaryginskaya,
    [EnumGuid("7AF8AF4F-266E-4223-9F68-15EA9CBC4F63")]
    [Description("Ярыгинский")]
    Yaryginskiy,
    [EnumGuid("888A50E6-58B7-4340-8D31-76A494DAD488")]
    [Description("Ясная")]
    Yasnaya,
    [EnumGuid("FBBF82AC-53C9-4D90-B0A2-17B767068307")]
    [Description("Ястынская")]
    Yastinskaya,

    #endregion

    #region Улицы на цифру

    [EnumGuid("CA7F0141-102E-4AB3-A2A4-23C5A62E3B8B")]
    [Description("3 Августа")]
    ThirdOfAugust,
    [EnumGuid("CBAD7ABB-1BD2-4A2B-BA46-F8F97FB84DFF")]
    [Description("8 Марта")]
    EighthOfMarch,
    [EnumGuid("40F0F05C-6A5F-4E20-B6AC-3509334B4565")]
    [Description("9 Мая")]
    NinthOfMay,
    [EnumGuid("38FAC84D-DD0A-4D3B-B29C-A0FDBB0BF2BD")]
    [Description("9 Января")]
    NinthOfJanuary,
    [EnumGuid("03303C1D-9568-454E-8C33-BEE73A87E334")]
    [Description("26 Бакинских Комиссаров")]
    TwentySixBakinskihKomissarov,
    [EnumGuid("32EC904B-231F-4729-A7D1-79E3E2A272BA")]
    [Description("30 Июля")]
    ThirtiethOfJuly,
    [EnumGuid("ED07E863-802C-448C-896C-5E4208C1012B")]
    [Description("40 лет Победы")]
    FortyYearsOfVictory,
    [EnumGuid("4C814E6B-9552-427F-93A2-D2C21D061564")]
    [Description("60 лет Образования СССР")]
    SixtyYearsOfUssrFormation,
    [EnumGuid("EA94B6D6-2BE7-4B86-B5A2-99405F2BDAFE")]
    [Description("60 лет Октября")]
    SixtyYearsOfOctober,
    [EnumGuid("B5580D04-D8E4-4950-BFA6-AC5BB599724A")]
    [Description("78-й Добровольческой Бригады")]
    SeventyEighthDobrovolcheskoyBrigady,
    [EnumGuid("B7FD54B4-F4DA-4081-BF27-537A4515F582")]
    [Description("78 Добровольческой Бригады")]
    SeventyEDobrovolcheskoyBrigady,

    #endregion

    #region СНТ и СТ

    [EnumGuid("37623FF5-4312-4E91-B37F-B2ECC776D7C2")]
    [Description("ТСН Заимка")]
    SNTZaimka,
    [EnumGuid("F1CA041A-31A6-4FA8-B569-18FA66CCA31E")]
    [Description("СНТ Строитель 22")]
    SNTStroitel22,
    [EnumGuid("842C910E-A80B-44C1-99AD-BDCA648C0F80")]
    [Description("СНТ Сад 5 Локомотив")]
    SNTSad5Lokomotiv,
    [EnumGuid("8042DE68-6391-4AF5-99C0-A89A9C45E1DE")]
    [Description("СНТ Сирень")]
	SNTSiren,
	[EnumGuid("B70D823B-1D71-4DA0-9AD1-36E5500DA92C")]
	[Description("СНТ Строитель")]
	SNTStroitel,
	[EnumGuid("69F03113-E7F9-4178-8AB8-AA18B6B74142")]
	[Description("СТ Электрик")]
	STElektrik,
	[EnumGuid("A0D9E8FA-E6EE-49DD-9BC5-5E3797C30072")]
	[Description("СТ Березка")]
	STBerezka,
	[EnumGuid("54B85B01-7142-4721-9F19-1A5B26985295")]
	[Description("СТ Берёзка")]
	STBereеzka,
	[EnumGuid("13589C81-526C-4855-BEF5-B241B7E48AD4")]
	[Description("СТ Колос")]
	STKolos,
	[EnumGuid("24C39679-E557-493B-A646-CABB98FBFFAF")]
	[Description("СТ Октябрьское-2")]
	STOktyabrskoe2,
	[EnumGuid("91803FA9-D35C-49D2-A0B7-FF61346F5E63")]
	[Description("СНТ Энергия 1")]
	SNTEnergia1,
	[EnumGuid("C967BCA8-954B-4967-AF07-83F59B3C8FC9")]
	[Description("СТ Боровинка")]
	STBorovinka,
	[EnumGuid("2E21C1A9-B877-498A-8CA1-282375DD8BA8")]
	[Description("СТ Локомотив")]
	STLokomotiv,
	[EnumGuid("CB83E30D-0CEA-473A-A459-8F43C79578F0")]
	[Description("СТ Лесная полянка")]
	STLesnayaPolianka,
	[EnumGuid("5F547E62-75BA-416E-8988-A0E74359E984")]
	[Description("СТ Мир")]
	STMir,
	[EnumGuid("BA50EAC8-6370-4A91-8BE1-E9558C148308")]
	[Description("СТ Юбилейный")]
	STYubileyniy,
	[EnumGuid("E347B7E6-90EB-4805-96DA-752BD2B4FF38")]
	[Description("СНТ Дружба")]
	SNTDruzhba,
	[EnumGuid("43744EC2-A4AA-4ED0-A388-7EBCD672FAA7")]
	[Description("СНТ Восход")]
	SNTVoshod,
	[EnumGuid("B8296371-8751-4462-9B9A-F4F017D66182")]
	[Description("СНТ Сад 2 Комбайного завода")]
	SNTSad2KombaynogoZavoda,
	[EnumGuid("355A2F84-FBE7-4BAF-933B-20B2AC0265B5")]
	[Description("СНТ Шафран")]
	SNTShafran,
	[EnumGuid("0D691064-466A-4F37-8AF3-DE4AD2D183D2")]
	[Description("СНТ Сад 2 ЭВРЗ")]
	SNTSad2EVRZ,
	[EnumGuid("0034C507-3DB3-463C-A276-2916C175A6CF")]
	[Description("СНТ Родничок-2")]
	SNTRodnichok2,
	[EnumGuid("FC9CEDBC-F7A4-49C7-BC36-2AD9CE77594E")]
	[Description("СПК Родничок")]
	SPKRodnichok,
	[EnumGuid("B046DC1A-DA4B-42D8-8C75-B8EDF573A1F7")]
	[Description("СПК Коммунальник")]
	SPKKomunalnik,
	[EnumGuid("712BA46E-98B1-4916-A9CD-DB5DA5701A7B")]
	[Description("СНТ Сад 1 завода телевизоров")]
	SNTSad1ZavodaTelevisorov,
	[EnumGuid("36F73088-45BB-4A75-9EC0-55B419C096BD")]
	[Description("СТ Сад 2 Локомотивного депо")]
	STSad2LokomotivnogoDepo,
	[EnumGuid("C9A1FF7D-CBEC-47BA-A56B-A28A3D879A05")]
	[Description("СО Объединённый сад 1")]
	SOObshchennyySad1,
	[EnumGuid("DBBC383A-4386-457D-9E96-C337984F4E36")]
	[Description("СО Родничок")]
	SORodnichok,
	[EnumGuid("047D60FC-E327-40AC-98AE-6D831855DD7E")]
	[Description("СТ Сад 2 Вагонного депо")]
	STSad2VagonnogoDepo,
	[EnumGuid("A4E431ED-7088-469F-BACE-001140971501")]
	[Description("СНТ Сад 1 Сельхозинститута")]
	SNTSad1Selskhozinstituta,
	[EnumGuid("F26C4385-1B10-4C13-81F2-6A2CD4833F54")]
	[Description("СТ Горстройбанк")]
	STDstroybank,
	[EnumGuid("2C98BCDD-CBD0-404A-9CF8-E090D6455743")]
	[Description("СТ Енисей")]
	STEnisei,
	[EnumGuid("91625A7B-A326-4FFA-B7B7-FB375BC9ACA0")]
	[Description("СТ Зорька")]
	STZorka,
	[EnumGuid("BDC35BBB-338F-43B0-AD41-8746D56A1374")]
	[Description("СО Сад 1 Крайсельхозуправления")]
	SOSad1Krayshelhozupravleniya,
	[EnumGuid("CDEC234B-02E3-476A-9812-1DAAB75AA105")]
	[Description("СНТ Сад 3 Локомотивного депо")]
	SNTSad3LokomotivnogoDepo,
	[EnumGuid("679831C8-D530-4A7C-9952-1839FC89CD2B")]
	[Description("СТ Сад 1 НОД-3")]
	STSad1NOD3,
	[EnumGuid("BAB71193-F53B-4F28-8703-F5D5CAD25B5B")]
	[Description("СНТ Победа")]
	SNTPobeda,
	[EnumGuid("58644821-9183-4CAE-BDAE-B11BD9751DF4")]
	[Description("СНТ Склад топлива")]
	SNTSkldTopliva,
	[EnumGuid("49FEA93F-EF8E-4473-B513-0DA4367FF6E4")]
	[Description("СТ Дом матери и ребёнка")]
	STDomMateryiRebeenka,
	[EnumGuid("56830706-D388-4D87-B130-3DFBFDF968C2")]
	[Description("СНТ Маяк")]
	SNTMayak,
	[EnumGuid("DAFDFCE2-C785-4DB7-8541-C903E74C95CF")]
	[Description("СК Берёзка-2")]
	SKBerezka2,
	[EnumGuid("30185623-24F4-48E5-A82A-F487577C53E4")]
	[Description("СК Березка-2")]
	SKBereеzka2,
	[EnumGuid("2114D16A-6470-47C0-89A7-E51B01A8208E")]
	[Description("СНТ Гремячий ключ")]
	SNTGremyachiyKlyuch,
	[EnumGuid("9483D7CB-E64C-4623-AA46-FE9860DCC674")]
	[Description("СНТ Здоровье Красфарма")]
	SNTZdorovieKrasfarma,
	[EnumGuid("FC3E8455-97F7-4C71-8709-ECF5801F5CFF")]
	[Description("СНТ Лесник")]
	SNTLesnik,
	[EnumGuid("2F32A9C3-E7A1-4F44-93F2-3DD32FC98B65")]
	[Description("СНТ Мебельщик")]
	SNTMebelshchik,
	[EnumGuid("946C0B3D-E5F6-4157-8CCE-681A42A1F605")]
	[Description("СНТ Звёздочка")]
	SNTZvezdochka,
	[EnumGuid("7C53677E-BB2D-4AAF-9439-5DB8FEA600DB")]
	[Description("СПК Восход-2")]
	SPKVoshod2,
	[EnumGuid("5F22C9B0-FBBF-41ED-8A59-162B6D488500")]
	[Description("СНТ Заря")]
	SNTZarya,
	[EnumGuid("19061E5B-955C-4241-9F05-C6B61A013B71")]
	[Description("СНТ Градостроитель")]
	SNTGradostroitel,
	[EnumGuid("B0AC708D-84A3-4872-B200-E3E75000AF66")]
	[Description("СНТ Ключи")]
	SNTKlyuchi,
	[EnumGuid("FC7EE791-56C3-468D-9C42-4EB75EC16411")]
	[Description("СНТ Шинник")]
	SNTShinnik,
	[EnumGuid("31571D2F-BBEA-4C63-A612-FE4F7214712A")]
	[Description("СНТ Заря АК-1265")]
	SNTZaryaAK1265,
	[EnumGuid("1FF981AC-38D2-40BA-A19A-DC42BFCE1344")]
	[Description("СНТ Труд")]
	SNTTrud,
	[EnumGuid("E59F7697-AE28-4EB6-8AFA-84374DDABA4E")]
	[Description("СНТ Нагорное")]
	SNTNagornoe,
	[EnumGuid("0931848C-FD18-45DA-8F4C-3CF63A8C2E70")]
	[Description("СНТ Сад 8 Сопка")]
	SNTSad8Sopka,
	[EnumGuid("23BD40E8-B759-415C-8A35-6AC734FBCD9D")]
	[Description("СНТ Транспортник")]
	SNTTransportnik,
	[EnumGuid("875C22E6-7407-4CC4-BFAB-BA8F4C1C1451")]
	[Description("СНТ Мечта")]
	SNTMecha,
	[EnumGuid("F38E5663-2AF5-4791-B7DC-BF02C191CBC7")]
	[Description("СНТ Судостроитель")]
	SNTSudostroitel,
	[EnumGuid("F62C246C-CC8D-4F5C-9FCB-4F6D78044135")]
	[Description("СНТ Текстильщик")]
	SNTTekstilshchik,
	[EnumGuid("68D969C9-5CAA-427D-B007-FC75AE3F6A24")]
	[Description("СНТ 7 Дядин Лог")]
	SNT7DyadinLog,
	[EnumGuid("F2B30C18-497C-4B22-99CC-E48415C1F5C8")]
	[Description("СТ Весна")]
	STVesna,
	[EnumGuid("D6FEE572-D845-48FC-853D-434325A05375")]
	[Description("СНТ ВОС")]
	SNTVOS,
	[EnumGuid("D27840F2-F0B9-41AD-9330-7F6DBE8E1987")]
	[Description("СНТ Красноярец 4")]
	SNTKrasnoyarets4,
	[EnumGuid("E663FD8B-937C-4810-BBCC-161FF446763A")]
	[Description("СНТ Саяны")]
	SNTSayany,
	[EnumGuid("68D7862E-46FE-43CF-885D-29F463120963")]
	[Description("СНТ Звезда-1")]
	SNTZvezda1,
	[EnumGuid("BEA6F265-BA6B-46CE-B929-03B610041B1A")]
	[Description("СНТ Здоровье")]
	SNTZdorovie,
	[EnumGuid("691A2FEF-454D-4101-959D-0A37DD9C12A0")]
	[Description("СНТ Богатырь")]
	SNTBogatyr,
	[EnumGuid("5E6D2207-B750-4345-9625-F404A4965E1C")]
	[Description("СНТ Звезда-2")]
	SNTZvezda2,
	[EnumGuid("02AD16A6-F388-4436-8F07-68241D81EEE7")]
	[Description("СНТ 1 Завода Сибэлектросталь")]
	SNT1ZavodaSibelektrostal,
	[EnumGuid("68E7B539-02CC-470E-867C-16E876E5DFEE")]
	[Description("СНТ Мечта-2")]
	SNTMecha2,
	[EnumGuid("BCC9FDCF-E80C-4C51-AAE1-2079CAF4F68B")]
	[Description("СНТ 3 Красноярец")]
	SNT3Krasnoyarets,
	[EnumGuid("A300B56E-4A97-47C2-9654-FBB08DE1613D")]
	[Description("СНТ Речник")]
	SNTRechnik,
	[EnumGuid("953AFAED-52D5-41B5-8AE5-662228BD8392")]
	[Description("СНТ Сад 1")]
	SNTSad1,
	[EnumGuid("024C5950-131D-41E5-B933-ACB3CC087144")]
	[Description("СНТ завода Красцветмет сад 2")]
	SNTZavodaKrascvetmetSad2,
	[EnumGuid("2C1C8B43-43D6-4975-BA7F-800E3D4C43A5")]
	[Description("СТ Химик")]
	STHimik,
	[EnumGuid("37071EAC-4A91-41F1-A0B0-7F40CBC00AC5")]
	[Description("СТ Сад 1 Черёмушки")]
	STSad1Chereomushki,
	[EnumGuid("8146950C-42C4-451E-8A20-3E06E0D21FA7")]
	[Description("СТ Семья")]
	STSemya,
	[EnumGuid("8017058D-D5A6-4EF4-B7A8-D6947FF12956")]
	[Description("СНТ Солнечный")]
	SNTSolechnyy,
	[EnumGuid("77D34BBF-7719-4B70-9376-44F52A90B582")]
	[Description("СНТ Алюминий")]
	SNTAluminium,
	[EnumGuid("ABCB169A-4E41-472D-AF3D-92BE68E75ADC")]
	[Description("СНТ Ветерок")]
	SNTVeterek,
	[EnumGuid("9CE14F62-F475-425F-9795-8F1E28D6C953")]
	[Description("СНТ Радуга")]
	SNTRaduga,
	[EnumGuid("DCBAD7A4-37B3-4474-877C-FABB93A979E1")]
	[Description("СНТ Автодорожник")]
	SNTAvtodorozhnik,
	[EnumGuid("8E680431-4FCD-4A63-8E57-0AD7C55216DC")]
	[Description("СНТ Калина")]
	SNTKalina,
	[EnumGuid("83F99799-FCD5-4606-AD5E-C03521D98056")]
	[Description("СНТ Родничок")]
	SNTRodnichok,
	[EnumGuid("82F6F30E-72FD-425D-86F7-42826D24469A")]
	[Description("СНТ Надежда")]
	SNTNadezhda,
	[EnumGuid("E3CC923A-7EA3-4B7A-B904-079274D07CF2")]
	[Description("СТ Лира")]
	STLira,
	[EnumGuid("00965453-1EF0-4B96-9E61-5FA09F40ACC4")]
	[Description("СТ Управление")]
	STUpravlenie,
	[EnumGuid("3CD25DF2-A570-447E-9E9E-C950E2DE1A4E")]
	[Description("СТ Лаванда")]
	STLavanda,
	[EnumGuid("B6BE4ABD-773A-4AAE-9B4F-8A9CF930A56C")]
	[Description("СТ Восход")]
	STVoshod,
	[EnumGuid("434AD1B4-6160-4CB4-9476-DD3D34D0B7AC")]
	[Description("СНТ Олимп-92")]
	SNTOlimp92,
	[EnumGuid("C24BACC3-D9EF-4DF3-8336-1D385E256593")]
	[Description("СТ Ветеран-10")]
	STVeteran10,
	[EnumGuid("0A142088-62EB-46B6-B1ED-2A9E817A48FD")]
	[Description("СНТ Отдых")]
	SNTOtdikh,
	[EnumGuid("F97272AF-3096-4E41-8405-A45898FCADE4")]
	[Description("СНТ Отдых-2")]
	SNTOtdikh2

    #endregion
}