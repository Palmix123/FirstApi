namespace Tutorial4.Models;

public class Visit
{
    public string date { get; set; }
    public int animalId { get; set; }
    public string note { get; set; }
    public double price { get; set; }

    public Visit(string date, int animalId, string note, double price)
    {
        this.date = date;
        this.animalId = animalId;
        this.note = note;
        this.price = price;
    }
}