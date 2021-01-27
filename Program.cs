using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.з__2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2.1
            //Console.WriteLine("Введите значение первой переменной:");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("Введите значение второй переменной:");
            //int b = int.Parse(Console.ReadLine());

            //if (a != b && b!=a)
            //{
            //    if (a > b)
            //    {
            //        b = a;
            //    }
            //    else if(a<b)
            //    {
            //        a = b;
            //    }

            //}
            //else
            //{
            //    a = 0;
            //    b = 0;
            //}
            //Console.WriteLine($"a = {a}\n" +
            //    $"b = {b}");



            //2.2

            //Console.WriteLine("Введите первое число: ");
            //double firstnumber = double.Parse(Console.ReadLine());
            //Console.WriteLine("Ввидите второе число: ");
            //double secondnumber = double.Parse(Console.ReadLine());
            //double value = 0;
            //Console.WriteLine("Выберите знак арифметической операции: + , - , * , /");
            //string arithmeticoperation = Console.ReadLine();

            //switch (arithmeticoperation)
            //{
            //    case "+":
            //        Console.WriteLine($"Сумма двух чисел = {value = firstnumber + secondnumber}");
            //        break;
            //    case "-":
            //        Console.WriteLine($"Разность двух чисел = {value = firstnumber - secondnumber}");
            //        break;
            //    case "/":
            //        Console.WriteLine($"Частное двух чисел = {value = firstnumber / secondnumber}");
            //        break;
            //    case "*":
            //        Console.WriteLine($"Произведение двух чисел = {value = firstnumber * secondnumber}");
            //        break;
            //    default:
            //        if(firstnumber == 0 || secondnumber ==0)
            //            Console.WriteLine("На ноль делить нельзя!!!");
            //        else
            //        {
            //            Console.WriteLine("Ошибка. Введен некорректный символ!!!");
            //        }
            //        break;
            //}




            //2,1

            int first = first = int.Parse(Console.ReadLine());



            if (first >= 0 && first <= 14)
            {
                Console.WriteLine("|0 - 14|");
            }
            else if (first >= 15 && first <= 35)
            {
                Console.WriteLine("|15 - 35|");
            }
            else if (first >= 36 && first <= 50)
            {
                Console.WriteLine("|36 - 50|");
            }
            else if (first >= 51 && first <= 100)
            {
                Console.WriteLine("|51 - 100|");
            }
            else if (first > 100)
            {
                Console.WriteLine("Введенное вами число, не входит ни в один" +
                            " из имеющихся числовых промежутков!");
            }
            else
            {
                Console.WriteLine("Ошибка, введен не корректный символ.");
            }



            //2.1

            double sum = double.Parse(Console.ReadLine());
            if (sum > 500)
            {
                sum = sum * (100 - 3) / 100;
            }
            else if (sum > 1000)
            {
                sum = sum * (100 - 5) / 100;
            }
            Console.WriteLine(sum);





            //2.2
            /*
            int firstnumber = int.Parse(Console.ReadLine());
            int secondnumber = int.Parse(Console.ReadLine());
            int thirdnumber = int.Parse(Console.ReadLine());
            int fourthnumber = int.Parse(Console.ReadLine());
            
            if (firstnumber< secondnumber && secondnumber < thirdnumber && thirdnumber< fourthnumber)
            {
                Console.WriteLine("Числа расположенны по возрастанию");
            }
            else if (firstnumber == secondnumber && secondnumber==thirdnumber && thirdnumber == fourthnumber)
            {
                Console.WriteLine(firstnumber*secondnumber*thirdnumber*firstnumber);
            }
            else
            {
                if(firstnumber < secondnumber && firstnumber < thirdnumber && firstnumber < fourthnumber)
                {
                    Console.WriteLine(firstnumber);
                }
                else if(secondnumber < firstnumber && secondnumber < thirdnumber && secondnumber < fourthnumber)
                {
                    Console.WriteLine(secondnumber);
                }
                else if(thirdnumber < firstnumber && thirdnumber < secondnumber && thirdnumber < fourthnumber)
                {
                    Console.WriteLine(thirdnumber);
                }
                else if(fourthnumber < firstnumber && fourthnumber < secondnumber && fourthnumber < thirdnumber)
                {
                    Console.WriteLine(fourthnumber);
                }
            }

            */


            //2.3

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = 0;


            if (a < b && b < c)
            {
                d = a;
                a = c;
                c = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
            else if (a > b && b < c && c < a)
            {
                d = b;
                b = c;
                c = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }

            else if (b > a && b > c && a < c)
            {
                d = c;
                c = a;
                a = b;
                b = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
            else if (c > b && c > a && a < b)
            {
                d = a;
                a = c;
                c = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
            else if (a > b && a < c && b < c)
            {
                d = b;
                b = a;
                a = c;
                c = d;
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
            else
            {
                Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            }
        }
    }
}
