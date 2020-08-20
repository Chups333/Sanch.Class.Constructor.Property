using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Class.Constructor.Property
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person p = new Person("Пупкин", "Вася", 11); //удобнее


            //p.SetName("Вася"); - выдаст имя Вася 
            /* p.SetName("");//перейдет на строку с ошибкой

            Console.WriteLine(p.GetName());
            Console.ReadKey();*/

            /* p.Name = "Вася";

            Console.WriteLine(p.Name);
            Console.ReadKey();*/


        }
    }
}
