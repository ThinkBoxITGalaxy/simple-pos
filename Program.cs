using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<Product> products = new List<Product>();
  

        static decimal total = 0;

        // para sa bayad ug sukli
        static decimal paymentAmount = 0;
        static decimal change = 0;


        static void Main(string[] args)
        {
                LoadProducts();

                Console.WriteLine("Search Code");

                string isearch = Console.ReadLine();
                SearchProducts(isearch);


            Console.ReadKey();
        }

        // Jee Ar
        // kani na Method kay himuan nimo ug code na pag Add kag item ni List<Product> products 
        static void LoadProducts()
        {
            Product p1 = new Product();
            p1.prid = "001";
            p1.desc = "Milo 25g";
            p1.price = 15;
            products.Add(p1);

            Product p2 = new Product();
            p2.prid = "002";
            p2.desc = "RedHorse";
            p2.price = 150;
            products.Add(p2);
        }

        // Jude
        // kani kay mag search ug item gikan sa List<Product> products
        // daun i display sa Console ang prid ug ang desc
        // pero ang price kay dapat i add sa variable na decimal total

      
        static void SearchProducts(string isearch)
        {
           
            foreach (Product pr in products)
            {
                if (pr.prid == isearch)
                {
                    total = pr.price;
                    Console.WriteLine(pr.prid+ " " + pr.desc +" subtotal: "+total.ToString());
                   
                }
            }
        }


        // Payment
        // I display sa console ang total
        // kuhaon ang payment
        // i display ang sukli
        static void Pay(double total)
        {
            
        }
    }
    
}