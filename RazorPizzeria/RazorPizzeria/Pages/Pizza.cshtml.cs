using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ ImageTitle="Margarita", PizzaName="Margarita", BasePrice=2.0f, TomatoSause=true, Cheese=true, FinalPrice=4.0f},
            new PizzasModel(){ ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=2.0f, TomatoSause=true, Cheese=true, Ham=true, Pineapple=true, FinalPrice=12.0f},
            new PizzasModel(){ ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2.0f, TomatoSause=true, Cheese=true, Ham=true, Mushroom=true, FinalPrice=12.0f},
            new PizzasModel(){ ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=2.0f, TomatoSause=true, Cheese=true, Ham=true, Beef=true, FinalPrice=14.0f},
            new PizzasModel(){ ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2.0f, TomatoSause=true, Cheese=true, Mushroom=true, FinalPrice=9.0f},
            new PizzasModel(){ ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2.0f, TomatoSause=true, Cheese=true, Pepperoni=true, FinalPrice=11.0f},
            new PizzasModel(){ ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2.0f, TomatoSause=true, Cheese=true, Tuna=true, FinalPrice=9.0f},
            new PizzasModel(){ ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=2.0f, TomatoSause=true, Cheese=true, Mushroom=true, Pineapple=true, FinalPrice=12.0f},
        }; 

        public void OnGet()
        {
        }
    }
}
