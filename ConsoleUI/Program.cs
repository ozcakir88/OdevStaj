using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            
            Product product1 = new Product();
            
           

            productManager.GetAll();
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Name);
            }


        }
    }
}
