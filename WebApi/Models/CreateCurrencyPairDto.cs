using WebApi.Entities;

namespace WebApi.Models;

public class CreateCurrencyPairDto : ICreateDto<CurrencyPair>
{
    public string Name { get; set; } = String.Empty;
    public string Base { get; set; } = String.Empty;
    public string Quote { get; set; } = String.Empty;
}