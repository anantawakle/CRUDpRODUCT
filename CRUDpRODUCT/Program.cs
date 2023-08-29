using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDPRODUCT
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int no = 0;
            ProductCRUD  crud = new ProductCRUD();
            do
            {
                Console.WriteLine("_______________________________________");
                Console.WriteLine("1.Product List");
                Console.WriteLine("2.Get Product By Id");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.Update Product");
                Console.WriteLine("5.Delet Product");
                Console.WriteLine(" Select your option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Product> list = crud.GetProducts();
                        Console.WriteLine("Id\t Name\t Price\t Company");
                        foreach (Product product in list)
                        {
                            Console.WriteLine($" {product.Id} \t {product.Name} \t{product.Price}\t {product.Company}");
                        }
                        break;
                        case 2:
                        Console.WriteLine("Enter the product id");
                        int id=Convert.ToInt32(Console.ReadLine());
                        Product p=crud.GetProductById(id);
                        Console.WriteLine("Id\t Name\t Price\t Company");
                        Console.WriteLine($"{p.Id}\t {p.Name} \t {p.Price} \t{p.Company}");
                        break;
                        case 3:
                        Product p1=new Product();
                        Console.WriteLine("Enter product id");
                        p1.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name");
                        p1.Name=Console.ReadLine();
                        Console.WriteLine("Enter the price");
                        p1.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the company name");
                        p1.Company=Console.ReadLine();
                        crud.AddProduct(p1);
                        Console.WriteLine("product save");
                        break;
                        case 4:
                        Product p2=new Product();
                        Console.WriteLine("Enter the product id");
                        p2.Id=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the product name");
                        p2.Name=Console.ReadLine();
                        Console.WriteLine("Enter the product price");
                        p2.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the company");
                        p2.Company = Console.ReadLine();

                        crud.UpdateProduct(p2);
                        Console.WriteLine("product updated");
                        break;
                        case 5:
                        Console.WriteLine("Enter the product id");
                        int id2=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id2);
                        Console.WriteLine($"{id2} product deleted");
                        break;


                }
                Console.WriteLine("Press 1 for continue");
                no=Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);
        }
    }
}
