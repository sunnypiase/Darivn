using WebApi.Entities;

namespace WebApi.Models;

public class HistoryDataDto : IDto<HistoryData>
{
    public int HistoryDataId { get; set; }
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    public string TimeFrame { get; set; } = String.Empty;
    public int CurrencyPairId { get; set; }
    public int GetId() => HistoryDataId;
}