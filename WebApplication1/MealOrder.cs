using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class MealOrder
    {
        public List<string> Pizzas { set; get; }
        public List<string> Size { set; get; }
        public List<string> Toppings { set; get; }
        public MealOrder()
        {
            Pizzas = new List<string>();
            Size = new List<string>();
            Toppings = new List<string>();
        }
        public void AddPizza(string item)
        {
            Pizzas.Add(item);
        }
        public void AddSize(string item)
        {
            Size.Add(item);
        }
        public void AddTopping(string item)
        {
            Toppings.Add(item);
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach (string pizza in Pizzas)
            {
                total += 5.99;
            }
            foreach(string topping in Toppings)
            {
                total += 1;
            }
            return total;
        }
    }

}