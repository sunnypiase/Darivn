namespace WebApi.Entities;

public class Model
{
    public int ModelId { get; set; }
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    
    public int HistoryDataId { get; set; }
    public HistoryData HistoryData { get; set; }
}