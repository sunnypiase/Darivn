namespace WebApi.Entities;

public class User : IDbEntity
{
    public int UserId { get; set; }
    public string Email { get; set; } = String.Empty;
    public string Telegram { get; set; } = String.Empty;
    public bool IsAdmin { get; set; }
    
    public Verification Verification { get; set; }
    public Authentication Authentication { get; set; }
    public IEnumerable<Subscription> Subscriptions { get; set; }
    public int GetId() => UserId;
}