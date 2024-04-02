namespace WebApi.Entities;

public class CurrencyPair
{
    public int CurrencyPairId { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Base { get; set; } = String.Empty;
    public string Quote { get; set; } = String.Empty;
    public IEnumerable<HistoryData> HistoryDatas { get; set; }
}