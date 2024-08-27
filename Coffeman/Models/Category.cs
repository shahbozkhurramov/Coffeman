namespace Coffeman.Models;

public class Category
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public List<MenuItem> MenuItems { get; set; }
}
