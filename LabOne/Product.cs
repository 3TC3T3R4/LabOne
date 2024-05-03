using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    public class Product
    {

        protected string Name { get; set; }
        protected String CategoryProduct { get; set; }


        public Product(string name,String category)
        {

            Name = name;
            CategoryProduct = category;

        }

        public virtual void GetInfo() { 
        
            Console.WriteLine("The name of product is: " + Name,"The Category of the product is: " + CategoryProduct);
        
        
        }


    }
}
