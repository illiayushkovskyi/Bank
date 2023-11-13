using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Bank
{
    internal class Program
    {
        static void enter(string waiting)
        {

            Console.WriteLine("[|         ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||        ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[|||       ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||||      ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[|||||     ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||||||    ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[|||||||   ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||||||||  ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||||||||| ]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[||||||||||]" + waiting);
            Thread.Sleep(1000);
            Console.Clear();
            account();
            
        }
        static void noenter(string sorry)
        {
            Console.WriteLine("Логин не найден" + sorry);
        }

        static void password(string waiting, string haslo)
        {
            metka2:
            Console.WriteLine("Введите пароль");
            waiting = "Пожалуйста подождите...";
            haslo = Console.ReadLine();
            if (haslo == "Rockfeller")
            {
                enter(waiting);
            }
            else
            {
                Console.WriteLine("Пароль не верный");
                goto metka2;
            }
        }
        static void account()
        {
            metka1:
            long money = 99999999;
            Console.WriteLine("Вы Джон Рокфеллер");
            Console.WriteLine("У вас на счету" + money);
            Console.WriteLine("Сколько вы хотите перевести?");
            int transfer = Convert.ToInt32(Console.ReadLine());

            if (transfer > 0)
            {
                Console.WriteLine("Наша банковская система может обнаружить любого получателя");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Кому вы хотите перевести?");
                Console.WriteLine("Достаточно просто ввести имя, фамилию");
                string lookyname = Console.ReadLine();
                Console.WriteLine("Введите титул перевода");
                string title = Console.ReadLine();
                Console.WriteLine(lookyname + " Вам признателен(а)!");
                goto metka1;
            }
            else
            {
                return;
            }

            
        }
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
           string sorry = "Попробуйте снова";
            string waiting = "Пожадуйста подождите...";
            string haslo = "Rockfeller";
            Metka:
            Console.WriteLine("Приветствуем во Всемирном Банке");
            Console.WriteLine("Авторизация");
            Console.WriteLine("Введите логин");
            string klientname = Console.ReadLine();

            if (klientname == "John")
            {
                password(waiting, haslo);
            }
            else
            {
                noenter(sorry);
                goto Metka;
            }

            Console.ReadKey();
        }
        
    }
}
