using RestaurantAPI.Entities;

namespace RestaurantAPI
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description =
                    "KFC (short for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered",
                    ContactEmail = "contact@kfc.com",
                    ContactNumber = "1234567",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Price = 10.30M,
                        },

                        new Dish()
                        {
                            Name = "Chicken Nuggets",
                            Price = 5.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Nowy Targ",
                        Street = "Wiejska 5",
                        PostalCode = "30-001"
                    }

                },
                new Restaurant()
                {
                    Name = "McDonalds",
                    Category = "Fast Food",
                    Description =
                    "The McDonald's Corporation is an American operator and franchisor of worldwide fast food restaurants and the world's top-selling fast food group.",
                    ContactEmail = "contact@McDonalds.com",
                    ContactNumber = "7654321",
                    HasDelivery= false,
                       Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "MC burger",
                            Price = 7.30M,
                        },

                        new Dish()
                        {
                            Name = "Ice cream",
                            Price = 1.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City = "Warszawa",
                        Street = "Rurka 5",
                        PostalCode = "29-001"
                    }
                }
            };
            return restaurants;

        }
    }
}
