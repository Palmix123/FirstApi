using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    [Route("/api/animals")]
    public IActionResult GetAnimals()
    {
        var b = StaticData.animals;
        return Ok(b);
    }
    
    [HttpGet]
    [Route("/api/animals/{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var b = StaticData.animals;
        for (int i = 0; i < b.Count; i++)
        {
            if(b[i].Id == id)
                return Ok(b[i]);
        }
        return NotFound("Nie ma zwirzaka");
    }
    
    [HttpPost]
    [Route("/api/animals/{id:int}/{firstName}/{category}/{mass:double}/{furColor}")]
    public IActionResult AddAnimal(int id, string firstName, string category, double mass, string furColor)
    {
        var b = StaticData.animals;
        for (int i = 0; i < b.Count; i++)
        {
            if(b[i].Id == id)
                return NotFound("Podany zwirzak o id = " + id + " juz istnieje");
        }
        StaticData.animals.Add(new Animal(id, firstName, category, mass, furColor));
        return Ok("Dodano " + firstName);
    }
    
    [HttpPut]
    [Route("/api/animals/{idChange:int}/{firstName}/{category}/{mass:double}/{furColor}")]
    public IActionResult ChangeAnimal(int idChange, string firstName, string category, double mass, string furColor)
    {
        var b = StaticData.animals;
        for (int i = 0; i < b.Count; i++)
        {
            if (b[i].Id == idChange)
            {
                b[i] = new Animal(idChange, firstName, category, mass, furColor);
                return Ok("Zmieniono zwirzaka");
            }
        }
        return NotFound("Nie ma zwirzaka");
    }
    
    [HttpDelete]
    [Route("/api/animals/{id:int}")]
    public IActionResult ChangeAnimal(int id)
    {
        var b = StaticData.animals;
        for (int i = 0; i < b.Count; i++)
        {
            if (b[i].Id == id)
            {
                StaticData.animals.Remove(b[id]);
                return Ok("Usunieto zwirzaka");
            }
        }
        return NotFound("Nie ma zwirzaka");
    }
}