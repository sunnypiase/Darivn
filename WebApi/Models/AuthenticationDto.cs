using WebApi.Entities;

namespace WebApi.Models;

public class AuthenticationDto : IDto<Authentication>
{
    public int AuthenticationId { get; set; }
    public string Login { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public int UserId { get; set; }

    public int GetId() => AuthenticationId;
}