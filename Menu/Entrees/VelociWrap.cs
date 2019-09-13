using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        public double Price { get; set; }
        public uint Calories { get; set; }

     
        private bool lettuce = true;
        private bool dressing = true;
        private bool cheese = true;

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast", "Romaine Lettuce", "Ceasar Dressing",
                "Parmesan Cheese"};
                if (dressing) ingredients.Add("Dressing");
                if (lettuce) ingredients.Add("Lettuce");
                if (cheese) ingredients.Add("Cheese");
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.dressing = false;
        }

        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        public void holdCheese()
        {
            this.cheese = false;
        }

    }
}
