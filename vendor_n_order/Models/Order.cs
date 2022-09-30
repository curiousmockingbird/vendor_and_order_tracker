using System.Collections.Generic;
namespace Business.Models
{
  public class Order
  {
    //Properties
    public string Title { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }

    private static List<Order> _order = new List<Order> {};
    
    //Constructor
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      _order.Add(this);
    }
    //Methods
    public static List<Order> GetOrders()
    {
      return _order;
    }

    public static void ClearAll()
    {
      _order.Clear();
    }

  }
}