using System.Collections.Generic;

namespace SweetAndSavory.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId {get; set;}
    public int FlavorId {get; set;}
    public string TreatName {get; set;}
    public ICollection<TreatFlavor> Flavors {get;}
  }
}