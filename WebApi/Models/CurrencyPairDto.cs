using WebApi.Entities;

namespace WebApi.Models;

public class CurrencyPairDto : IDto<CurrencyPair>
{
    public int CurrencyPairId { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Base { get; set; } = String.Empty;
    public string Quote { get; set; } = String.Empty;
    public int GetId() => CurrencyPairId;
}