using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Nlog_lab
{
    [Attribut("Волоков", 23)]
    class Program
    {

        static double a;
        static double b;
        static double result;
        static char oper;
        static char again = 'д';
        private static NLog log = new NLog();

        public static void GetAttribute(Type t)
        {
            Attribut MyAttribute = (Attribut)Attribute.GetCustomAttribute(t, typeof(Attribut));

           
                Console.WriteLine("Разработчик: {0}", MyAttribute.Name);
                Console.WriteLine("ID: {0}\n", MyAttribute.ID);
           
        }


        public static void Main(string[] args)
        {
            GetAttribute(typeof(Program));
            Starting();

        }


        public static void Starting()
        {

            Hi();
            while (again == 'д')
            {


                Entering();
                Operation();
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }

        }



        public static void Hi()
        {
            Console.WriteLine("Привет. Вы запустили Калькуляшку.");
        }


        public static void Entering()
        {

            a = OneNumber();

            oper = Operations();

            b = TwoNumber();
        }

        public static void Operation()
        {

            if (oper == '+')
            {
                result = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".");
            }

            else if (oper == '-')
            {
                result = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".");
            }

            else if (oper == '*')
            {
                result = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + result + ".");
            }

            else if (oper == '/')
            {
                result = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + result + ".");
            }
            else
            {
                Console.WriteLine("Неизвестная хрень вместо оператора.");

            }



        }



        static double OneNumber()
        {

            Console.WriteLine("Ввидите первое число:");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Ошибочка вышла(Error): вводим только числа!");
                log.ErrorParse();
                return OneNumber();
            }
        }


        static Char Operations()
        {

            Console.WriteLine("Ввидите оператор:");
            try { return Convert.ToChar(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Ошибочка вышла(Error): вводим только оператор!");
                log.ErrorParse();
                return Operations();
            }
        }



        static double TwoNumber()
        {

            Console.WriteLine("Ввидите второе число:");
            try { return Convert.ToDouble(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Ошибочка вышла(Error): вводим только числа!");
                log.ErrorParse();
                return TwoNumber();
            }
        }
    }


}
