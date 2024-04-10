using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
public class VisitsController : ControllerBase
{

    [HttpGet]
    [Route("/api/visits/{id:int}")]
    public IActionResult GetAnimalVisits(int id)
    {
        var b = StaticVisitsData.visits;
        var output = new List<Visit>();
        for (int i = 0; i < b.Count(); i++)
        {
            if (b[i].animalId == id)
                output.Add(b[i]);
        }
        if (output.Count == 0)
            return NotFound("Zwirzak o id = " + id + " nie mial jeszcze zadnej wizyty");
        return Ok(output);
    }
    
    [HttpPost]
    [Route("/api/visits/{date}/{animalId:int}/{note}/{price:double}")]
    public IActionResult AddAnimalVisits(string date, int animalId, string note, double price)
    {
        var b = StaticVisitsData.visits;
        b.Add(new Visit(date, animalId, note, price));
        return Ok("Dodano wizyte");
    }
}