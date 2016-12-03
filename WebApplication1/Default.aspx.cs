using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                {
                PopulatePizza();
                PopulateSize();
                PopulateToppings();
            }
        }
        protected void PopulatePizza()
        {
            string[] pizza = { "Deluxe", "BBQ Chicken", "Hawaiian", "Cheese Steak" };
            PPizza.DataSource = pizza;
            PPizza.DataBind();
        }
        protected void PopulateSize()
        {
            string[] size = { "Large", "Medium", "Small" };
            PSize.DataSource = size;
            PSize.DataBind();
        }
        protected void PopulateToppings()
        {
            string[] toppings = { "Pepperoni", "Mushrooms", "Onions", "Sausage", "Bacon" };
            PTopping.DataSource = toppings;
            PTopping.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MealOrder meal = new MealOrder();
            foreach (ListItem item in PPizza.Items)
            {
                if (item.Selected)
                {
                    meal.AddPizza(item.Text);
                }
            }
            foreach (ListItem item in PSize.Items)
            {
                if (item.Selected)
                {
                    meal.AddSize(item.Text);
                }
            }
            foreach (ListItem item in PTopping.Items)
            {
                if (item.Selected)
                {
                    meal.AddTopping(item.Text);
                }
            }
             Session["Meal"] = meal;
            Response.Redirect("Receipt.aspx");
        }
    }
}