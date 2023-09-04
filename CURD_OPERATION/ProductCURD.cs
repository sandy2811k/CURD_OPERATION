using System;
using System.Collections.Generic;
using System.Linq;  
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CURD_OPERATION
{
    public class ProductCURD
    { 
        private List<Product> productlist; 
        public ProductCURD()
        {            
            productlist=new List<Product>()
            {
                new Product { Id = 1, Name = "Laptop", Price = 35000,Company = "asus" },
                new Product { Id = 2, Name = "Laptop", Price = 37000,Company = "Hp" }
                
            };
        }
        //Display List
        public List <Product>GetProducts()
        {
            return productlist;
        }
        //Get single Product
        public Product GetProductById(int id)
        {
            //search for id in the collection
            Product product = new Product();
            foreach(Product p in productlist)
            {
                if(p.Id == id)//match id in he collection
                {
                    product = p;
                    break;
                }
            }
            return product;
        }
        //add new product
        public void AddProduct(Product p)
        {
            productlist.Add(p);
        }
        //Modify the product
        public void UpdateProduct(Product p)
        {
            foreach(Product item in productlist)
            {
                //item contains old product data
                if(item.Id == p.Id)
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;
                }
            }
        }
        //Remove Product
        public void DeleteProduct(int id)
        {
            foreach(Product item in productlist)
            {
                if(item.Id == id)
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }
    }
}
