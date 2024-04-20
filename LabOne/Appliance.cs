using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    public class Appliance : Product

    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public String Category { get; set; }

       

        public Appliance(string brand,string model,string color,string name, String category) : base(name,category)
        {

            Brand = brand;
            Model = model;
            Color = color;
            Category = category;
        
        
        }

        public override void GetInfo()
        {
            Console.WriteLine("The name of product is: " + Name  + " The brand is: " + Brand + " The model is: " + Model + " The color is: " + Color + " The category is: " + Category);
            

        }



    }
}
