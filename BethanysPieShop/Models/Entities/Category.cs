namespace BethanysPieShop.Models.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Pie> Pies { get; set; }
}