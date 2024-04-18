using WebApi.Entities;

namespace WebApi.Models;

public class CreateAuthenticationDto :ICreateDto<Authentication>
{
    public string Login { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public int UserId { get; set; }
}