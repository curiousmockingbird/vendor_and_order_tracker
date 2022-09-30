using System.Collections.Generic;
namespace Business.Models
{
  public class Vendor
  {
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    private static List<Vendor> _vendor = new List<Vendor> {};
    public List<Order> Orders { get; set; }
    public int Id { get; }

    // Constructor
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _vendor.Add(this);
      Orders = new List<Order> {};
      Id = _vendor.Count;
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
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

  }
}