using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork24._09._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Влезит ли голова в форточку");
            Console.Write("Введите длину форточки: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину форточки: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите диаметр головы: ");
            int d = int.Parse(Console.ReadLine());
            int v = d + 2;
            if (v <= a && v <= b)
            {
                Console.WriteLine("Голова пролезит в форточку");
            }
            else
            {
                Console.WriteLine("Голова не пролезит в форточку");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 2. Таблица умножения");
            Console.Write("Введите число[1;9]: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                int a2 = n * i;
                Console.WriteLine(n + " * " + i + " = " + a2);
            }
            Console.ReadKey();


            Console.WriteLine("Задание 3. Вывод фразы от деления");
            Console.Write("Введите число: ");
            int x = int.Parse(Console.ReadLine());
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (x % 3 == 0)
            {
                Console.Write("Бэнг");
            }
            else if (x % 5 == 0)
            {
                Console.Write("Бум");
            }
            else
            {
                Console.Write("Мимо");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 4. Проверка как написана строка");
            Console.Write("Введите какую-нибудь строку или символ: ");
            string String = Console.ReadLine();
            int n4 = 0;
            for (int i = 0; i < String.Length; i++)
            {
                if (String[i] == (String.ToUpper()[i]))
                {
                    n4++;
                }
            }
            if (n4 == String.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 5. Овцы");
            Console.Write("Введите число овец: ");
            int sheep = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sheep; i++)
            {
                Console.Write(i + " овца...");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 6. Последовательность");
            Console.Write("Введите длину последовательности: ");
            byte longArr = byte.Parse(Console.ReadLine());

            int[] arr5 = new int[longArr];
            try
            {
                for (int i = 0; i < longArr; i++)
                {
                    Console.Write("Введите " + i + " элемент последовательности: ");
                    arr5[i] = int.Parse(Console.ReadLine());
                }
                int arif = 0;
                for (int i = 0; i < longArr; i++)
                {
                    arif += arr5[i];
                }
                double arif5 = (double)arif / (longArr - 1);
                Console.WriteLine($"Среднее арифметическое = {arif5}");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 7. Карты");
            Console.Write("Введите число [6;14]: ");
            byte karta = byte.Parse(Console.ReadLine());
            switch (karta)
            {
                case 6:
                    Console.WriteLine("Выпала карта 6");
                    break;
                case 7:
                    Console.WriteLine("Выпала карта 7");
                    break;
                case 8:
                    Console.WriteLine("Выпала карта 8");
                    break;
                case 9:
                    Console.WriteLine("Выпала карта 9");
                    break;
                case 10:
                    Console.WriteLine("Выпала карта 10");
                    break;
                case 11:
                    Console.WriteLine("Выпала карта валет");
                    break;
                case 12:
                    Console.WriteLine("Выпала карта дама");
                    break;
                case 13:
                    Console.WriteLine("Выпала карта король");
                    break;
                case 14:
                    Console.WriteLine("Выпала карта тус");
                    break;
                default:
                    Console.WriteLine("Вы вели что-то не так");
                    break;
            }
            Console.ReadKey();


            Console.WriteLine("Задание 8. Карты");
            string[] arr7 = { "Hello Kitty", "Matreshka", "Hello Kitty", "Balalaika", "Barbie doll" };
            int k = 0;
            foreach (string str in arr7)
            {
                if (str == "Hello Kitty" || str == "Barbie doll")
                {
                    k++;
                }
            }
            Console.WriteLine($"В сумке {k} куклы");
            Console.ReadKey();


            Console.WriteLine("Задание 9. Дни недели");
            Console.WriteLine("Введите какой по счету день недели: ");
            byte dayofweek = byte.Parse(Console.ReadLine());
            switch (dayofweek - 1)
            {
                case 0:
                    Console.WriteLine(week.Monday);
                    break;
                case 1:
                    Console.WriteLine(week.Monday);
                    break;
                case 2:
                    Console.WriteLine(week.Monday);
                    break;
                case 3:
                    Console.WriteLine(week.Monday);
                    break;
                case 4:
                    Console.WriteLine(week.Monday);
                    break;
                case 5:
                    Console.WriteLine(week.Monday);
                    break;
                case 6:
                    Console.WriteLine(week.Monday);
                    break;
            }
            Console.ReadKey();


            Console.WriteLine("Задание 10. Сравнение массива");
            Console.Write("Введите длину массива: ");
            int longArr10 = int.Parse(Console.ReadLine());
            int[] arr10 = new int[longArr10];
            for (int i = 0; i < longArr10; i++)
            {
                Console.Write("Введите " + i + " элемент последовательности: ");
                arr10[i] = int.Parse(Console.ReadLine());
            }

            int a10 = 0;
            for (int i = 0; i < arr10.Length; i++)
            {
                for (int j = i + 1; j < arr10.Length; j++)
                {
                    if (arr10[i] > arr10[j])
                    {
                        a10 = arr10[i];
                        arr10[i] = arr10[j];
                        arr10[j] = a10;
                    }
                }
            }
            for (int i = 0; i < arr10.Length; i++)
            {
                Console.Write(arr10[i] + " ");
            }
            Console.ReadKey();


            Console.WriteLine("Задание 11. Последовательна ли последовательность?))");
            const byte longArr11 = 10;
            int[] arr11 = new int[longArr11];
            for (int i = 0; i < longArr11; i++)
            {
                Console.Write("Введите " + i + " элемент последовательности: ");
                arr11[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < arr11.Length; i++)
            {
                if (arr11[i] <= arr11[i - 1])
                {
                    Console.WriteLine(arr11[i + 1]);
                    break;
                }
            }
            Console.ReadKey();


        }
        enum week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
