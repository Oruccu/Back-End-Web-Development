using Microsoft.AspNetCore.DataProtection;

public class UserService
{
    private readonly AppDbContext _context;
    private readonly IDataProtector _protector;

    public UserService(AppDbContext context, IDataProtectionProvider provider)
    {
        _context = context;
        _protector = provider.CreateProtector("UserPasswordProtector");
    }

    public void AddUser(string email, string password)
    {
        var encryptedPassword = _protector.Protect(password);
        var user = new User { Email = email, Password = encryptedPassword };

        _context.Users.Add(user);
        _context.SaveChanges();
    }
}
