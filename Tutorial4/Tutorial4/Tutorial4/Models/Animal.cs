namespace Tutorial4.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Category { get; set; }
    public double Mass { get; set; }
    public string FurColor { get; set; }

    public Animal(int id, string firstName, string category, double mass, string furColor)
    {
        Id = id;
        FirstName = firstName;
        Category = category;
        Mass = mass;
        FurColor = furColor;
    }
}