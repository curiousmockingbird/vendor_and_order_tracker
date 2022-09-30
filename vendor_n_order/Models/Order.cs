namespace Business.Models
{
  public class Order
  {
    //Properties
    public string Title { get; set; }
    public string Description { get; set; }
    
    //Constructor
    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
    }
    //Methods
  }
}