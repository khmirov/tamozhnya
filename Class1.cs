/*Товар поступает на таможню.Ожидает проверки.
Проходит проверку - покидает таможню. 
Если не проходит проверку - помещается на специальных склад.
Можно реализовать ещё и отдельно этот специальный склад.
Подумайте, какие методы, классы, события можно реализовать.
Нужно сделать описание классов в отдельный библиотеки классов и подключить её к тестовой программе.
*/
using System;
using static System.Console;


namespace TamozhnyaClassLib
{
    public class Check
    {

        public delegate void Show(string message);
        public Show Message;
        string product;
       
        public Check() 
        { }

        public Check (string product)
        {
            this.product = product;
        }

        public string InputProduct()
        {
            Console.Write("Input Your Product: ");
            product = Console.ReadLine();
            return product;
        }

        public bool CheckProduct ()
        {
                if (product == "drug" || product == "slave" || product == "gun" || product == "whore")
                {
                    Message?.Invoke($"Attention! Your product is {product}.");
                    Message?.Invoke("It went to the storage area.");
                    return false;
                }
                else
                {
                    Message?.Invoke($"OK. Next product, please.");
                    return true;
                }
            
        }

    }
}
