using WebApi.Entities;

namespace WebApi.Models;

public class ModelDto: IDto<Model>
{
    public int ModelId { get; set; }
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    
    public int HistoryDataId { get; set; }
    public int GetId() => ModelId;
}