using WebApi.Entities;

namespace WebApi.Models;

public class VerificationDto : IDto<Verification>
{
    public int VerificationId { get; set; }
    public bool IsVerified { get; set; }
    public string ApiKeyHash { get; set; } = String.Empty;
    
    public int UserId { get; set; }
    public int GetId() => VerificationId;
}