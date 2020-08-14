using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SweetAndSavory.Models;

namespace SweetAndSavory.Models
{
  public class SweetAndSavoryContext : IdentityDbContext<Flavor>
  {
    // public virtural DbSet<Tag> Tags { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<Treat> Treats { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    public SweetAndSavoryContext(DbContextOptions options) : base(options) { }
  }
}