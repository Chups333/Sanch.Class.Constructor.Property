using System;

namespace Sanch.Class.Constructor.Property
{
    public class Person
    {

     

        public string SecondName { get; private set; }
        public string Name { get; private set; }

        public Person(string secondName, string name, int age) // конструктор 
        {
            if (age<0)
            { 
                throw new ArgumentNullException("Меньше");// быстрое выявление ошибки
            }
            SecondName = secondName;
            Name = name;
        }













        //public string Name; - нельзя так делать
        //private string _name;// - можно





        ////////////////////////////
        // Сокращенные свойства
        /////////////////////////////////

        //public string SecondName { get; /*protected  только для наследника*/ set; } // тоже самое что нижнее только проще


       /* public string FullName //полное имя
        {
            get
            {
                return SecondName + " " + Name;
            }
        }*/
        /*public string ShortName // короткое имя
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";
            }
        }*/

        ////////////////////////////
        // Свойства get и set
        /////////////////////////////////
       /* public string Name //cвойства
        {
            get
            {
                return _name;
            }
            set
            {
                /* if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя не может быть пустым");// быстрое выявление ошибки
                }
                _name = value;
            }
        }*/






        //////////////////////////////////////// 
        //Ниже конструкция которую ты пишешь сам ручками
        ////////////////////////////////////////
        /*public string GetName()// конструкция 1
        {
            return _name;

        }
        public void SetName(string name)// конструкция 2
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя не может быть пустым");// быстрое выявление ошибки
            }
            _name = name;
        }*/
    }
}
