using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static List<studentslist> stt = new List<studentslist>();
        // Create a list of students wiht property id,name,age,address
        // and search student in the list using id
        static void Main(string[] args)
        {

              int ss = Convert.ToInt32(Console.ReadLine()); // Converting the Console.ReadLine() to 'int' since this was already been set to string 
              Students(); // To add a data from Students to studentslist
              searching(ss); // Passing the data came from ss to seaching
              
              Console.Read();
        }

        static void searching(int n) // 'int n' Retrieving the data from Main method 'int ss' and store it to n.
        {
            foreach(studentslist tss in stt)
			{
                if (tss.id == n)
                {
                    Console.WriteLine(tss.id + " " + tss.name + " " + tss.age + " " + tss.address);
                }	
			}
        }

        static void Students()
        {
            studentslist st = new studentslist();
            st.id = 001;
            st.name = "Ricardo";
            st.age = 12;
            st.address = "Taga bukid";
            stt.Add(st); //To store the data from stt to studentslist

            studentslist st1 = new studentslist();
            st1.id = 002;
            st1.name = "Bruno";
            st1.age = 16;
            st1.address = "Taga suba";
            stt.Add(st1); //To store the data from stt to studentslist

            studentslist st2 = new studentslist();
            st2.id = 003;
            st2.name = "marlo";
            st2.age = 12;
            st2.address = "Taga baybay";
            stt.Add(st2); //To store the data from stt to studentslist
            
        }

        public class studentslist
        {
            //To store all the data from Students()
            public int id 
            {
                get;
                set;
            }

            public string name 
            {
                get;
                set;
            }

            public int age
            {
                get;
                set;
            }

            public string address
            {
                get;
                set;
            }
        }
    }
    
}