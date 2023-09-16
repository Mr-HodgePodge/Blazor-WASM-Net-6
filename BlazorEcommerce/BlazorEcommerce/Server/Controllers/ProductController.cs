using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Masters of Doom",
                Description = "Masters of Doom: How Two Guys Created an Empire and Transformed Pop Culture is a 2003 book by David Kushner about video game company id Software and its influence on popular culture, focusing on co-founders John Carmack and John Romero.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/53/Masters_of_doom-Book_cover.jpg",
                Price = 9.99m,
            },
            new Product
            {
                Id = 2,
                Title = "Foucault's Pendulum",
                Description = "Foucault's Pendulum (original title: Il pendolo di Foucault [il ˈpɛndolo di fuˈko]) is a novel by Italian writer and philosopher Umberto Eco. It was first published in 1988, and an English translation by William Weaver appeared a year later.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/09/FoucaultsPendulum.jpg",
                Price = 7.49m,
            },
            new Product
            {
                Id = 3,
                Title = "Morals and Dogma",
                Description = "Morals and Dogma of the Ancient and Accepted Scottish Rite of Freemasonry, or simply Morals and Dogma, is a book of esoteric philosophy published by the Supreme Council, Thirty Third Degree, of the Scottish Rite, Southern Jurisdiction of the United States",
                ImageUrl = "https://moly.hu/system/covers/big/covers_460628.jpg",
                Price = 19.99m,
            }
        };

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(Products);
        }
    }
}
