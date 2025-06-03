using System.ComponentModel;
using CHSMonitoring.Infrastructure.Attributes;

namespace CHSMonitoring.Domain.Enums;

/// <summary>
/// Тип снабжения
/// </summary>
public enum ServiceTypeEnum
{
    [EnumGuid("DA945797-A35E-4F41-A63D-520FA11C213A")]
    [Description("Пустой тип снабжения")]
    None,
    [EnumGuid("93139275-C7D9-43F1-ABE3-E71259DF2E50")]
    [Description("Теплоснабжение")]
    HotWater,
    [EnumGuid("F7E60189-640E-4B66-8DAA-87CACDEC043C")]
    [Description("Горячее водоснабжение")]
    HotWater2,
    [EnumGuid("A1E57DAE-24A7-44D6-B08B-DAF4CE707D3C")]
    [Description("Горячее водоснабжение с подающего трубопровода")]
    HotWaterOutterPipe,
    [EnumGuid("A5EA3E2F-C627-4E4C-BC83-DC78BE4369D1")]
    [Description("Горячее водоснабжение с обратного трубопровода")]
    HoutWaterReversePipe,
    [EnumGuid("4E96DE1C-1443-4148-8DA6-92BA3A95A828")]
    [Description("Холодное водоснабжение")]
    ColdWater,
    [EnumGuid("25969C01-7291-458B-8A20-88A2338F62C9")]
    [Description("Электроснабжение")]
    Electricity,
    [EnumGuid("B2948B05-B798-432D-BA4A-E4EF6930092F")]
    [Description("Газоснабжение")]
    Gas
}