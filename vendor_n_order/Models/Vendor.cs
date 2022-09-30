using System.Collections.Generic;
namespace Business.Models
{
  public class Vendor
  {
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendor = new List<Vendor> {};

    // Constructor
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendor.Add(this);
    }

    // Methods
    public static List<Vendor> GetVendors()
    {
      return _vendor;
    }
    public static void ClearAll()
    {
      _vendor.Clear();
    }

  }
}