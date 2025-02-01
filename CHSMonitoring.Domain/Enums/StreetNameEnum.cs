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
    Babushkina,
    [Description("Бадалык")]
    Badalyk,
    [Description("Бадалыкская")]
    Badalykskaya,
    [Description("Базайская")]
    Bazayskaya,
    [Description("Базарная")]
    BazarNaya,
    [Description("Байкальская")]
    Baykalskaya,
    [Description("Байкитская 1-я")]
    Baykitskaya1,
    [Description("1-я Байкитская")]
    Baykitska_ya1,
    [Description("Байкитская 2-я")]
    Baykitskaya2,
    [Description("2-я Байкитская")]
    Baykitska_ya2,
    [Description("Балахтинская")]
    BalakhTinskaya,
    [Description("Бартатский")]
    Bartatskiy,
    [Description("Батурина")]
    BatUrIna,
    [Description("Баумана")]
    BaUmana,
    [Description("Башиловская")]
    BashIlovskaya,
    [Description("Бебеля")]
    Bebelya,
    [Description("Бегичева")]
    Begicheva,
    [Description("Белинского")]
    Belinskogo,
    [Description("Беловежская")]
    BelovezhSkaya,
    [Description("Белопольского")]
    BelopolSkogo,
    [Description("Белорусская")]
    Belorusskaya,
    [Description("Беляева")]
    Belyaeva,
    [Description("Березина")]
    Berezina,
    [Description("Березовая")]
    Berezovaya,
    [Description("Биатлонная")]
    Biathlonnaya,
    [Description("Бийская")]
    Biyskaya,
    [Description("Бийхемская")]
    BiyKhemsKaya,
    [Description("Биологов")]
    Biologov,
    [Description("Бирикчульский")]
    BirikchulSkiy,
    [Description("Бирилюсская")]
    Birilyusskaya,
    [Description("Бирюсинская")]
    Biryusinskaya,
    [Description("Благодатная")]
    Blagodatnaya,
    [Description("Бобровый")]
    Bobrovyy,
    [Description("Богдана Хмельницкого")]
    BogdanaKhmelNitskogo,
    [Description("Боголеповская")]
    Bogolepovskaya,
    [Description("Боготольский")]
    BogotolSkiy,
    [Description("Бограда")]
    Bograda,
    [Description("Богучанская")]
    Boguchanskaya,
    [Description("Бодрая")]
    Bodraya,
    [Description("Бойкая")]
    Boykaya,
    [Description("Болдинская")]
    Boldinskaya,
    [Description("Большегвардейская")]
    BolSheGvardeyskaya,
    [Description("Большой")]
    BolShoy,
    [Description("Борисевича")]
    Borisevicha,
    [Description("Борисова")]
    Borisova,
    [Description("Боровая 1-я")]
    Borovaya1,
    [Description("1-я Боровая")]
    Borova_ya1,
    [Description("Боровая 2-я")]
    Borovaya2,
    [Description("2-я Боровая")]
    Borova_ya2,
    [Description("Бородинская")]
    Borodinskaya,
    [Description("Борьбы")]
    BorBy,
    [Description("Ботаническая")]
    Botanicheskaya,
    [Description("Ботаническая 2-я")]
    Botanicheskaya2,
    [Description("2-я Ботаническая")]
    Botanicheska_ya2,
    [Description("Ботаническая 3-я")]
    Botanicheskaya3,
    [Description("3-я Ботаническая")]
    Botanicheska_ya3,
    [Description("Ботаническая 4-я")]
    Botanicheskaya4,
    [Description("4-я Ботаническая")]
    Botanicheska_ya4,
    [Description("Ботанический")]
    Botanicheskiy,
    [Description("Боткина")]
    Botkina,
    [Description("Бохтинский")]
    Bokhtinskiy,
    [Description("Братская 1-я")]
    Bratskaya1,
    [Description("1-я Братская")]
    Bratska_ya1,
    [Description("Братская 2-я")]
    Bratskaya2,
    [Description("2-я Братская")]
    Bratska_ya2,
    [Description("Братьев Абалаковых")]
    BratEyAbalakovykh,
    [Description("Брестская")]
    Brestskaya,
    [Description("Брянская")]
    Bryanskaya,
    [Description("Брянская 2-я")]
    Bryanskaya2,
    [Description("2-я Брянская")]
    Bryanska_ya2,
    [Description("Бугачевская")]
    Bugachevskaya,
    [Description("Быковского")]
    Bykovskogo,
    
    #endregion
    
    #region Улицы на букву В
    
    [Description("Васильковый")]
    Vasilikovoy,
    [Description("Васнецова")]
    Vasnetsova,
    [Description("Ватутина")]
    Vatutina,
    [Description("Вейнбаума")]
    VeinBauma,
    [Description("Вербная")]
    Verbnaya,
    [Description("Верещагина")]
    Vereshchagina,
    [Description("Верхняя")]
    VerkhNeya,
    [Description("Верховая")]
    Verkhovaya,
    [Description("Верхотельский")]
    VerkhotelSkiy,
    [Description("Весёлая")]
    Veselyaya,
    [Description("Веселовская")]
    Veselovskaya,
    [Description("Весенняя")]
    VesenNaya,
    [Description("Весны")]
    Vesny,
    [Description("Вечерняя")]
    VecherNeya,
    [Description("Вешняя")]
    VeshNeya,
    [Description("Взлётная")]
    Vzletnaya,
    [Description("Вильского")]
    VilSkogo,
    [Description("Виражная")]
    Viazhnaya,
    [Description("Вишневый")]
    Vishnevyy,
    [Description("Внутриквартальная 1-я")]
    Vnutrikvartalnaya1,
    [Description("1-я Внутриквартальная")]
    Vnutrikvartalna_ya1,
    [Description("Внутриквартальная 3-я")]
    Vnutrikvartalnaya3,
    [Description("3-я Внутриквартальная")]
    Vnutrikvartalna_ya3,
    [Description("Водометный")]
    Vodometnyy,
    [Description("Водопьянова")]
    Vodopyanova,
    [Description("Водянникова")]
    VodyanNikova,
    [Description("Возвышенная")]
    VozvyshchenNaya,
    [Description("Вознесенская")]
    Voznesenskaya,
    [Description("Возрождения")]
    Rozhdeniya,
    [Description("Вокзальная")]
    Vokzalnaya,
    [Description("Волгоградская")]
    Volgogradskaya,
    [Description("Волжская")]
    Volzhskaya,
    [Description("Володнева")]
    Volodinova,
    [Description("Волочаевская")]
    Volochayevskaya,
    [Description("Волочанская")]
    Volochanskaya,
    [Description("Вольный")]
    Volnyy,
    [Description("Воровского")]
    Vorovskogo,
    [Description("Воронова")]
    Voronova,
    [Description("Воскресенская")]
    Voskresenskaya,
    [Description("Воскресная")]
    Voskresnaya,
    [Description("Восточная")]
    Vostochnaya,
    [Description("Восточный")]
    Vostochnyy,
    [Description("Восходная")]
    Voskhodnaya,
    [Description("Встречная")]
    Vstrechnaya,
    [Description("Вузовский")]
    Vuzovskiy,
    [Description("Выборгский")]
    Vyborgskiy,
    [Description("Высокая")]
    Vysokaya,
    [Description("Высотная")]
    Vysostnaya,
    [Description("Высоцкого")]
    Vysotskogo,
    
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