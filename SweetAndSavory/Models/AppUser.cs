using Microsoft.AspNetCore.Identity;

namespace SweetAndSavory.Models
{
  public class AppUser : IdentityUser
  {
    public string Name {get; set;}
  }
}