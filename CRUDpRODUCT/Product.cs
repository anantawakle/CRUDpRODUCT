using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPRODUCT
{
    public  class Product
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Company { get; set; }

    }

    public class ProductCRUD
    {
        private List<Product> productlist;
        public ProductCRUD() 
        {
            productlist = new List<Product>()
            {
                new Product { Id=1,Name="Laptop",Price=35000,Company="HP"},
                new Product { Id=2,Name="Laptop",Price=37000,Company="Dell"}
            };
        }
        // Display list//
        public List<Product>GetProducts() 
        {
            return productlist;
        }
        // get single product//

        public Product GetProductById(int id) 
        {
            // search for id the collection//
            Product product=new Product();
            foreach(Product p in productlist)
            {
                if(p.Id==id)// match id in colllection//
                {
                    product = p;
                    break;
                }
            }
            return product;

        }
        // Add new Product//
        public void AddProduct(Product p)// p cantain data//
        {
           productlist.Add(p);
        }

        public void UpdateProduct(Product p)
        {
            foreach(Product item in productlist)
            {
                // item cantains old product data//
                if(item.Id==p.Id) 
                {
                    item.Name = p.Name;
                    item.Price = p.Price;
                    item.Company = p.Company;
                    break;
                }
            }
        }
        // remove product//
        public void DeleteProduct(int id) 
        {
            foreach (Product item in productlist)
            {
                if (item.Id==id) 
                {
                    productlist.Remove(item);
                    break;
                }
            }
        }

    }


}
