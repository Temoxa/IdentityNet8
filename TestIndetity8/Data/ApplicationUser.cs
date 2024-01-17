using Microsoft.AspNetCore.Identity;

namespace TestIndetity8.Data;

public class ApplicationUser : IdentityUser
{
    public string? TestField { get; set; }
}
