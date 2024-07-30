using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

    //GET ALL action
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

    //GET by Id action 
    [HttpGet("{id}")]
    public ActionResult<Pizza> Get(int id)
    {
        var pizza = PizzaService.Get(id);
        if (pizza == null)
            return NotFound();

        return pizza;
    }


    //POST action
    //[HttpPost]
    /*public IActionResult Create(Pizza pizza)
    {
        //This code will save the pizza and return a result
    }

    //PUT action 
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        //This code will update the pizza and return a result
    }



    //DELETE action
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    { 
        //This code will delte the pizza and return a result
        PizzaService.Delete(id);
    
    }*/

}
