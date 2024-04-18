using WebApi.Entities;

namespace WebApi.Models;

public class CreateVerificationDto : ICreateDto<Verification>
{
    public bool IsVerified { get; set; }
    public string ApiKeyHash { get; set; } = String.Empty;
    
    public int UserId { get; set; }
}