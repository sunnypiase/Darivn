using WebApi.Entities;

namespace WebApi.Models;

public class CreateSubscriptionDto : ICreateDto<Subscription>
{
    public bool IsTrading { get; set; }
    
    public int ModelId { get; set; }
    public int UserId { get; set; }
}