using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDetails
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your details.\n");

            Console.Write("Name     : ");
            string name = Console.ReadLine();

            Console.Write("ID       : ");
            string id = Console.ReadLine();

            Console.Write("CGPA     : ");
            double cgpa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Semester : ");
            int sem = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gender   : ");
            string gen = Console.ReadLine();


            if (gen == "M" || gen == "m")
            {
                gen = "Male";
            }
            else if(gen == "F" || gen == "f")
            {
                gen = "Female";
            }
            else
            {
                gen = "Unspecified";
            }

            Console.WriteLine("\n\nYour semester details.\n");
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("ID       : " + id);
            Console.WriteLine("CGPA     : " + cgpa);
            Console.WriteLine("Semester : " + sem);
            Console.WriteLine("Gender   : " + gen);

            Console.ReadKey();
        }
    }
}