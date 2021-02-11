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
            Product p = new Product
            {
				prid = "001",	
				desc = "Video Card",
				price = 200
            };
            products.Add(p);
        }

        // Jee Ar
        // kani na Method kay himuan nimo ug code na pag Add kag item ni List<Product> products 
        static void LoadProducts()
        {
           
        }

        // Jude
        // kani kay mag search ug item gikan sa List<Product> products
        // daun i display sa Console ang prid ug ang desc
        // pero ang price kay dapat i add sa variable na decimal total
        static void SearchProducts(string prid)
        {
        }


        // Payment
        // I display sa console ang total
        // kuhaon ang payment
        // i display ang sukli
        static void Pay(double total)
        {

        }
    }

    // Kani na class mao ni template sa atong Sample data
    // kani na approach kay para sayon i treat ni siya as template
    public class Product
    {
        // ang ID sa producto gamiton sa seacrh
       public string prid { get; set; }

        // description or name sa product
        public string desc { get; set; }

        //ang presyo
        public decimal price { get; set; }
    }
}