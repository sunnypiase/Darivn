namespace WebApi.Entities;

public class Verification
{
    public int VerificationId { get; set; }
    public bool IsVerified { get; set; }
    public string ApiKeyHash { get; set; } = String.Empty;
    
    public int UserId { get; set; }
    public User User { get; set; }
}