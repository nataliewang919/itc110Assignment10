using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace WebApplication1
{
    public partial class Receipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Meal"]==null)
            {
                Response.Redirect("Default.aspx");
            }
            DisplayReceipt();
        }
        protected void DisplayReceipt()
        {
            StringBuilder sb = new StringBuilder();
            MealOrder meal = (MealOrder)Session["Meal"];
            List<string> pizzas = meal.Pizzas;
            List<string> sizes = meal.Size;
            List<string> toppings = meal.Toppings;
            
            foreach(string pizza in pizzas)
            {
                sb.Append(pizza);
                sb.Append("<br/ >");
            }
            foreach (string size in sizes)
            {
                sb.Append(size);
                sb.Append("<br/ >");
            }
            foreach (string topping in toppings)
            {
                sb.Append(topping);
                sb.Append("<br/ >");
            }
            sb.Append(meal.CalculateTotal().ToString());
            Label1.Text = "Thank you for your order <br/ > "+ sb.ToString();            
        }
    }
}