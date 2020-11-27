using System.Collections.Generic;
using System.Linq;
namespace PizzaPlace.Shared
{
    public class Menu
    {
        public List<Pizza> Pizzas {get;set;} =
         new List<Pizza>();
         //Method to Get the Pizza
         public Pizza GetPizza(int id)=> 
         Pizzas.SingleOrDefault(Pizza=> Pizza.Id==id);

    }
}