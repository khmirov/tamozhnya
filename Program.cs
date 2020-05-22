
/*Товар поступает на таможню.Ожидает проверки.
Проходит проверку - покидает таможню. 
Если не проходит проверку - помещается на специальных склад.
Можно реализовать ещё и отдельно этот специальный склад.
Подумайте, какие методы, классы, события можно реализовать.
Нужно сделать описание классов в отдельный библиотеки классов и подключить её к тестовой программе.
*/
using System;
using static System.Console;
using TamozhnyaClassLib;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlTypes;

namespace Tamozhnya
{
    class Program
    {
        static void Main(string[] args)
        {
            Check nextProduct = new Check();
            var storage = new List<string>();

            nextProduct.Message = Show;
            string input;
            bool t;

            do
            {
                input = nextProduct.InputProduct();
                t = nextProduct.CheckProduct();
                if (t == false)
                    storage.Add(input);
                WriteLine("\n");
            } 
            while (input != "end");


            WriteLine("Storage area: ");
            foreach (var item in storage)
            {
                WriteLine(item);
            }

           

 
        }

        public static void Show(string Message)
        {
            WriteLine(Message);
        }
    }
}
