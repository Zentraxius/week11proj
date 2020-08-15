using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public int FlavorId { get; set; }
    public virtual ApplicationUser User { get; set; }
    public string Name { get; set; }
    public ICollection<TreatFlavor> Flavors { get; }
  }
}