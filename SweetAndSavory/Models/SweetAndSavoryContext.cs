using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SweetAndSavory.Models;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : IdentityDbContext<Tasty>
  {
    // public virtural DbSet<Tag> Tags { get; set; }
    public DbSet<Tasty> Tastys { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<TastyTreat> TastyTreat { get; set; }
    public SweetAndSavoryContext(DbContextOptions options) : base(options) { }
  }
}