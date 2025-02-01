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
            new() { Id = Guid.Parse("5FDEC09D-55E8-4934-AAD1-3BC769CC3D4C"), Name = "Аэровокзальная", Description = string.Empty }
            

            #endregion
            

            
                       
        };
        
        //TODO: Указать пресет сюда
        builder.HasData(streetEnums);
    }
}