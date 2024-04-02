namespace WebApi.Entities;

public class Authentication
{
    public int AuthenticationId { get; set; }
    public string Login { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    
    public int UserId { get; set; }
    public User User { get; set; }
}