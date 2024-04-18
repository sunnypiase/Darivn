using WebApi.Entities;

namespace WebApi.Models;

public class UserDto: IDto<User>
{
    public int UserId { get; set; }
    public string Email { get; set; } = String.Empty;
    public string Telegram { get; set; } = String.Empty;
    public bool IsAdmin { get; set; }
    public int GetId() => UserId;
}