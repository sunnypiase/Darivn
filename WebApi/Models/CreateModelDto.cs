using WebApi.Entities;

namespace WebApi.Models;

public class CreateModelDto : ICreateDto<Model>
{
    public string BlobUrl { get; set; } = String.Empty;
    public string FileName { get; set; } = String.Empty;
    public int HistoryDataId { get; set; }
}