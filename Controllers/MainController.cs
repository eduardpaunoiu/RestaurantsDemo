using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantsDemo.Data;
using RestaurantsDemo.Models;

namespace RestaurantsDemo.Controllers
{
    [Route("api/controller")]
    public class MainController : Controller
    {
        static DataContext database = new DataContext();


        [HttpPost]
        [Route("")]
        public void AddRestaurants([FromBody] List<Restaurant> restaurants)
        {
            foreach (var rest in restaurants)
            {
                database.AddRestaurant(rest);
            }
        }

        [HttpGet]
        [Route("")]
        public List<Restaurant> GetRetaurants()
        {
            return database.RestaurantList;
        }

        [HttpPost]
        [Route("food")]
        public void AddFood([FromBody] List<Food> food)
        {
            foreach (var f in food)
            {
                database.AddFood(f);
            }
        }

        [HttpGet]
        [Route("food")]
        public List<Food> GetFoods([FromBody] int idRestaurant)
        {
            return database.GetAllFoodForRestaurants(idRestaurant);
        }

        [HttpPost]
        [Route("foodrestaurant")]
        public void addRelations([FromBody] List<Relation> relations)
        {
            foreach (var v in relations)
            {
                database.AddRelation(v);
            }
        }
    }
}