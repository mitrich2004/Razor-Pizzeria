using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSause) PizzaPrice += 1;
			if (Pizza.Cheese) PizzaPrice += 3;
			if (Pizza.Pepperoni) PizzaPrice += 5;
			if (Pizza.Mushroom) PizzaPrice += 3;
			if (Pizza.Tuna) PizzaPrice += 3;
			if (Pizza.Ham) PizzaPrice += 3;
			if (Pizza.Pineapple) PizzaPrice += 3;
			if (Pizza.Beef) PizzaPrice += 5;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
		}
    }
}
