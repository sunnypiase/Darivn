namespace WebApi.Entities;

public class HistoryData
{
    public int HistoryDataId { get; set; }
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    public string TimeFrame { get; set; } = String.Empty;
    
    public int CurrencyPairId { get; set; }
    public CurrencyPair CurrencyPair { get; set; }
    public Model Model { get; set; }

}