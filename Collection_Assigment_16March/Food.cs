using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Assigment_16March
{
   
   public class Food
    {
        public string food_name;
        public int food_price;

        public Food(string food_name,int food_price)
        {
            this.food_name = food_name;
            this.food_price = food_price;
        }

        public override string ToString()
        {
            return food_name+" "+food_price;
        }
    }
}
