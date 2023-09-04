using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_OPERATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            ProductCURD curd=new ProductCURD(); 
            do
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1. Product List");
                Console.WriteLine("2. Get Product By Id");
                Console.WriteLine("3. Add Product");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("Select your option");

                int option = Convert.ToInt32(Console.ReadLine());

                switch(option)
                {
                      case 1:
                        List<Product> list= curd.GetProducts();
                        Console.WriteLine("Id\t Name\t  Price\t  Company");
                        foreach(Product product in list)
                        {
                            Console.WriteLine($"{product.Id}\t {product.Name}\t {product.Price}\t {product.Company}\t");
                        }
                        break;
//------------------------------------------------------------------------------------------------------//
                      case 2:
                        Console.WriteLine("Enter the product Id");
                        int id=Convert.ToInt32(Console.ReadLine()); 
                        Product p=curd.GetProductById(id);
                        Console.WriteLine("Id\t  Name\t   Price\tCompany\t");
                        Console.WriteLine($"{p.Id}\t {p.Name}\t  {p.Price}\t        {p.Company}");
                        break;
//------------------------------------------------------------------------------------------------------//
                      case 3:
                        Product p1 = new Product();
                        Console.WriteLine("Enert product id:");
                        p1.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name:");
                        p1.Name=Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        p1.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entert Company name:");
                        p1.Company=Console.ReadLine();
                        curd.AddProduct(p1);
                        Console.WriteLine("Product saved..");
                        break;
//------------------------------------------------------------------------------------------------------//
                      case 4:
                        Product p2 = new Product();
                        Console.WriteLine("Enter product id:");
                        p2.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name:");
                        p2.Name=Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        p2.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Company name:");
                        p2.Company=Console.ReadLine();
                        curd.AddProduct(p2);
                        Console.WriteLine("Product updated");
                        break;
//------------------------------------------------------------------------------------------------------//
                      case 5:
                        Console.WriteLine("Enter the product id");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        curd.DeleteProduct(id2);
                        Console.WriteLine($"{id2}product deleted..");

                        break;



                }
                Console.WriteLine("Press 1 for continue");
                no = Convert.ToInt32(Console.ReadLine());
            }
            while(no == 1);
        }
    }
}
