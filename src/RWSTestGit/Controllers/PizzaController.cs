namespace RWSTestGit.Controllers
{
    using System.Collections.Generic;
    using System.Net;

    using Microsoft.AspNetCore.Mvc;

    using RWSTestGit.Models;

    [Route("api/[controller]")]
    public class PizzaController
    {
        [HttpPost]
        public void Post([FromBody]Pizza pizza)
        {
            // todo: add pizza
            
        }

        [HttpGet("{name}")]
        public IActionResult Name(string name)
        {
            var pizza = new Pizza
            {
                CrustStyle = new CrustStyle { Color = "white", Name = name, Thickness = "thin" },
                Name = name,
                Toppings = new List<string> { "peperoni", "onion" },
            };

            return new ObjectResult(pizza);
        }
    }
}
