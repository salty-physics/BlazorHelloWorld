namespace DataInteract.Model
{
    public class PizzaSpecial
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal BasePrice { get; set; }
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
