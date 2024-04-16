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
        protected string Description { get; set; }
        protected double Price { get; set; }
        protected string Category { get; set; }

        //public Product(string name, string description, double price, string category) { 
        
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //    Category = category;
        //}

        public Product() { 
        
        }


        public static void CreateProduct() {

            Console.WriteLine("Ingrese nombre de su producto");




        }



        public void ShowProduct() {

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");

        }




    }
}
