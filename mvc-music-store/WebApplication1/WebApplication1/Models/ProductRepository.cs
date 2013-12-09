using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new List<Product>();
        private int _nextId = 1;

        public ProductRepository()
        {
            Add(new Product { Name = "Potatoes", Category = "Groceries", Description = "Best served mashed!", Price = 99.99M });
            Add(new Product { Name = "Tomato soup", Category = "Groceries", Description = "Tasty when spiced just right.", Price = 1.39M });
            Add(new Product { Name = "Yo-yo", Category = "Toys", Description = "A fun child's toy", Price = 3.75M });
            Add(new Product { Name = "Hammer", Category = "Hardware", Description = "In a pinch, use to mash the potatoes.", Price = 16.99M });
        }

        public IEnumerable<Product> GetAll()
        {
            return products;
        }

        public Product Get(int id)
        {
            return products.Find(p => p.Id == id);

        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            products.Add(item);
            return item;

        }

        public void Remove(int id)
        {
            products.RemoveAll(p => p.Id == id);
        }

        public bool Update(Product item)
        {
            if (item == null)
            {

                throw new ArgumentNullException("item");

            }
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1) 
            {
                return false;
            }

            products.RemoveAt(index);
            products.Add(item);

            return true;
        }








    }
}