using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание 1.");
            Console.WriteLine("Введите год: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
                try
                {
                    Console.WriteLine("Високосный год!!!");
                    string[] arr = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
                    Console.Write("Введите число: ");
                    int x = int.Parse(Console.ReadLine());
                    int i = 0;

                    if (x < 32)
                    {
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 61 && x > 31)
                    {
                        i++;
                        x -= 31;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 92 && x > 60)
                    {
                        i += 2;
                        x -= 60;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 122 && x > 91)
                    {
                        i += 3;
                        x -= 91;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 153 && x > 121)
                    {
                        i += 4;
                        x -= 121;
                        Console.WriteLine(x + " " + arr[i]);   
                    }
                    else if (x < 183 && x > 152)
                    {
                        i += 5;
                        x -= 152;
                        Console.WriteLine(x + " " + arr[i]);  
                    }
                    else if (x < 214 && x > 182)
                    {
                        i += 6;
                        x -= 182;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 243 && x > 213)
                    {
                        i += 7;
                        x -= 213;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 273 && x > 244)
                    {
                        i += 8;
                        x -= 244;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 304 && x > 274)
                    {
                        i += 9;
                        x -= 274;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 334 && x > 305)
                    {
                        i += 10;
                        x -= 305;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if(x < 367 && x > 335)
                    {
                        i += 11;
                        x -= 335;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!! Вы вели число не соответвующию диапазону [1...366]");
                }



            else
            {
                try
                {
                    Console.WriteLine("Обычный год!!!");
                    string[] arr = { "Января", "Февраля", "Марта", "Апреля", "Мая", "Июня", "Июля", "Августа", "Сентября", "Октября", "Ноября", "Декабря" };
                    Console.Write("Введите число: ");
                    int x = int.Parse(Console.ReadLine());
                    int i = 0;

                    if (x < 32)
                    {
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 60 && x > 31)
                    {
                        i++;
                        x -= 31;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 91 && x > 59)
                    {
                        i += 2;
                        x -= 59;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 121 && x > 90)
                    {
                        i += 3;
                        x -= 90;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 152 && x > 120)
                    {
                        i += 4;
                        x -= 120;
                        Console.WriteLine(x + " " + arr[i]);   
                    }
                    else if (x < 182 && x > 151)
                    {
                        i += 5;
                        x -= 151;
                        Console.WriteLine(x + " " + arr[i]);  
                    }
                    else if (x < 213 && x > 181)
                    {
                        i += 6;
                        x -= 181;
                        Console.WriteLine(x + " " + arr[i]); 
                    }
                    else if (x < 243 && x > 212)
                    {
                        i += 7;
                        x -= 212;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 274 && x > 242)
                    {
                        i += 8;
                        x -= 242;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 304 && x > 273)
                    {
                        i += 9;
                        x -= 273;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 335 && x > 303)
                    {
                        i += 10;
                        x -= 303;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                    else if (x < 366 && x > 334)
                    {
                        i += 11;
                        x -= 334;
                        Console.WriteLine(x + " " + arr[i]);
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!! Вы вели число не соответвующию диапазону [1...365]");
                }
            }
            Console.ReadKey();
        }
      
    }
}
