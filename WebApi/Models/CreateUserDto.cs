using WebApi.Entities;

namespace WebApi.Models;

public class CreateUserDto : ICreateDto<User>
{
    public string Email { get; set; } = String.Empty;
    public string Telegram { get; set; } = String.Empty;
    public bool IsAdmin { get; set; }
}