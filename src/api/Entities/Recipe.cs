namespace api.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PreparationTime { get; set; }
        public int CookingTime { get; set; }
        public string Category { get; set; }
        public int Rating { get; set; }
        public int Portions { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
        public IEnumerable<Instruction> Instructions { get; set; }
    }
}