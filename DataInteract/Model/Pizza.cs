namespace DataInteract.Model
{
    public class Pizza
    {
        public int PizzaId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
    }
}
