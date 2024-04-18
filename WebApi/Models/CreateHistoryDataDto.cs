using WebApi.Entities;

namespace WebApi.Models;

public class CreateHistoryDataDto : ICreateDto<HistoryData>
{
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    public string TimeFrame { get; set; } = String.Empty;
    public int CurrencyPairId { get; set; }
}