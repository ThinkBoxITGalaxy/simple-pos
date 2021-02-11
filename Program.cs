using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // List of products wala pani sulod ron
        static List<Product> products = new List<Product>();
<<<<<<< HEAD

        // total sa price gikan sa search
        static decimal total = 0;

        // para sa bayad ug sukli
        static decimal paymentAmount = 0;
        static decimal change = 0;
=======
>>>>>>> 063e7a11c943c978ade2e2102d5037f7fb45cb7f

        // total sa price gikan sa search
        static decimal total = 0;

        // para sa bayad ug sukli
        static decimal paymentAmount = 0;
        static decimal change = 0;
        static void Main(string[] args)
        {
<<<<<<< HEAD
             string addp = Console.ReadLine();
            products.Add(addp);
=======


>>>>>>> 063e7a11c943c978ade2e2102d5037f7fb45cb7f
        }

        // Jee Ar
        // kani na Method kay himuan nimo ug code na pag Add kag item ni List<Product> products 
        static void LoadProducts()
        {
<<<<<<< HEAD
           
        }

        // Jude
        // kani kay mag search ug item gikan sa List<Product> products
        // daun i display sa Console ang prid ug ang desc
        // pero ang price kay dapat i add sa variable na decimal total
        static void SearchProducts(string prid)
        {
        }

=======

        }

        // Jude
        // kani kay mag search ug item gikan sa List<Product> products
        // daun i display sa Console ang prid ug ang desc
        // pero ang price kay dapat i add sa variable na decimal total
        static void SearchProducts(string prid)
        {

        }

>>>>>>> 063e7a11c943c978ade2e2102d5037f7fb45cb7f
        // Payment
        // I display sa console ang total
        // kuhaon ang payment
        // i display ang sukli
        static void Pay(double total)
        {
<<<<<<< HEAD
=======
            
>>>>>>> 063e7a11c943c978ade2e2102d5037f7fb45cb7f
        }
    }

    // Kani na class mao ni template sa atong Sample data
    // kani na approach kay para sayon i treat ni siya as template
    public class Product
    {
        // ang ID sa producto gamiton sa seacrh
<<<<<<< HEAD
        public string prid { get; set; }
=======
       public string prid { get; set; }
>>>>>>> 063e7a11c943c978ade2e2102d5037f7fb45cb7f

        // description or name sa product
        string desc { get; set; }

        //ang presyo
        public decimal price { get; set; }
    }
}