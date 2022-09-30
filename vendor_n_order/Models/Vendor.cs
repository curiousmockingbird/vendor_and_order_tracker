namespace Business.Models
{
  public class Vendor
  {
    // Properties
    public string Name { get; set; }
    public string Description { get; set; }
    // Constructor
    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;

    }

    // Methods

  }
}