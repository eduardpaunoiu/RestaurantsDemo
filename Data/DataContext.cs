using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantsDemo.Models; 

namespace RestaurantsDemo.Data
{
    public class DataContext
    {
        public List<Food> FoodList;
        public List<Restaurant> RestaurantList;
        public List<Relation> RelationsList;

        public DataContext()
        {
            FoodList = new List<Models.Food>();
            RestaurantList = new List<Models.Restaurant>();
            RelationsList = new List<Models.Relation>();
        }

        public void AddRestaurant(Restaurant x)
        {
            RestaurantList.Add(x);
        }

        public void AddFood(Food f)
        {
            FoodList.Add(f);
        }

        public void AddRelation(Relation r)
        {
            RelationsList.Add(r);
        }

        public List<Restaurant> GetAllRestaurants()
        {
            return RestaurantList;
        }

        public List<Food> GetAllFoodForRestaurants(int RestaurantId)
        {
            List<int> food = new List<int>();
            foreach (var item in RelationsList)
            {
                if(item.IdRest == RestaurantId)
                {
                    food.Add(item.IdFood);
                }
            }

            List<Food> mancaruri = new List<Food>();
            foreach (var i in food)
            {
                foreach (var j in FoodList)
                {
                    if(i == j.Id)
                    {
                        mancaruri.Add(j);
                    }
                }
            }

            return mancaruri;
        }

        public List<Relation> GetAllRelations()
        {
            return RelationsList;
        }


    }
}
