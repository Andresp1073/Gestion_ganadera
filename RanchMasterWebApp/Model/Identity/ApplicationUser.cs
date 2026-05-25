using Microsoft.AspNetCore.Identity;

namespace Model.Identity;

public class ApplicationUser : IdentityUser
{
    // Custom properties for the user profile
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? ProfileImageUrl { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}