using Tutorial4.Models;

namespace Tutorial4.Database
{
    public class StaticData
    {
        public static List<Animal> animals = new List<Animal>()
        {
            new Animal(1, "Burek", "Pies", 15.5, "Brązowy"),
            new Animal(2, "Reksio", "Pies", 20.0, "Czarny"),
            new Animal(3, "Filemon", "Kot", 5.0, "Szary"),
            new Animal(4, "Donald", "Kaczka", 2.5, "Biały")
        };
    }
}