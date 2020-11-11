using System;
using System.Windows;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Assistant.Hello;

namespace Assistant
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //throw new Class1();
            Console.Beep();
            if (DateTime.Now.Hour>18&&DateTime.Now.Hour<23)//вечер
            {
            Console.WriteLine($"Добрый вечер, {Environment.UserName}!");
            }
            else if (DateTime.Now.Hour > 21 && DateTime.Now.Hour < 4)//ночь
            {
                Console.WriteLine($"Доброй ночи, {Environment.UserName}!");
            }
            Console.WriteLine("Добрый дк");
            Console.ReadKey();
        }
    }
}
