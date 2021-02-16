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
              Students();
			  
			  searching();
              Console.Read();
        }

        static void searching()
        {
            foreach(studentslist tss in stt)
			{
				Console.WriteLine(tss.id + " " + tss.name + " " + tss.age + " " + tss.address);
			}
        }

        static void Students()
        {
            studentslist st = new studentslist();
            st.id = 001;
            st.name = "Ricardo";
            st.age = 12;
            st.address = "Taga bukid";
            stt.Add(st);

             studentslist st1 = new studentslist();
            st1.id = 002;
            st1.name = "Bruno";
            st1.age = 16;
            st1.address = "Taga suba";
            stt.Add(st1);

             studentslist st2 = new studentslist();
            st2.id = 003;
            st2.name = "marlo";
            st2.age = 12;
            st2.address = "Taga baybay";
            stt.Add(st);
            
        }

        public class studentslist
        {
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