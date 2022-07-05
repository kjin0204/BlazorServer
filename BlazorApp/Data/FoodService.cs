using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
    public interface IFoodService
    {
        public IEnumerable<Food> GetFoods();
    }

    public class FastFoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food(){Name = "Hambuerger",Price = 7000},
                new Food(){Name = "Fries",Price = 7700},
                new Food(){Name = "Bibi2",Price = 7900}
            };

            return foods;
        }
    }


    public class FoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food(){Name = "Bibi1",Price = 7000},
                new Food(){Name = "Bibi2",Price = 7700},
                new Food(){Name = "Bibi3",Price = 7900}
            };

            return foods;
        }
    }

    public class PaymentService
    {
        IFoodService _service;

        public PaymentService(IFoodService service)
        {
            _service = service;
        }
    }

    public class SingletonService : IDisposable
    {
        public Guid ID { get; set; }
        public SingletonService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("singletonService Disposed");
        }
    }

    public class TransientService : IDisposable
    {
        public Guid ID { get; set; }
        public TransientService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("singletonService Disposed");
        }
    }

    public class ScopedService : IDisposable
    {
        public Guid ID { get; set; }
        public ScopedService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("singletonService Disposed");
        }
    }

}
