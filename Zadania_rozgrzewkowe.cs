using System;
using System.Collections.Generic;


namespace Praca_Domowa
{
    class Program
    {
        static void Main(string[] args)
        {   // Rozgrzewka
            Console.WriteLine("Podaj swoje imię: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            //int result = 5 + 9;
            //Operatory
          //  int number = 0;
            //float money = 0;
            string text;
            bool isLogged;
            char myChar;
            decimal price;
            string myAge = "Age: ";
            int wifeAge = 18;
          //  var result = myAge + wifeAge;
          //  Console.WriteLine(result);
            //Wnioski, że można dodawaćdo siebie różne typy danych
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;
            Console.WriteLine("or: " + or);
            Console.WriteLine("and: " + and);
            Console.WriteLine("negative: " + negative);
            //int a = 5;
            //int b = 12;
            //var add = a + b;
            //var sub = a - b;
            //var div = a / b;
            //var mul = a * b;
            //var mod = a % b;
            //Console.WriteLine(add);
            //Console.WriteLine(sub);
            //Console.WriteLine(div);
            //Console.WriteLine(mul);
            //Console.WriteLine(mod);

            string a = "Ala ";
            string b = "ma ";
            string c = "kota ";
            var result = a + b + c;
            Console.WriteLine(result);

            //Instrukcje sterujące i pętle
            int n1 = 10;
            int n2 = 20;
            if (n1 > n2) Console.WriteLine("n1>n2");
            else Console.WriteLine("N2>N1");
            int licznik = 0;
            Console.WriteLine("While");
            while (licznik<10)
            { 
                Console.WriteLine("C#");
                licznik++;

            }
            Console.WriteLine("For");

            for(licznik=0;licznik<10;licznik++)
            {
                Console.WriteLine("C#");
            }


            int n = 10;
            if (n % 2 == 1)
            {
                Console.WriteLine("Nieparzysta ");
                
            }
            else
            {
                Console.WriteLine("Parzysta ");
            }
            int gwiazdki = 5;
            for (int i = 1; i <=gwiazdki; i++)
            { for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //Nie do końca zrozumiałem polecenie to zrobiłem po swojemu :)
            Random rand = new Random();
            int min = 0;
            int max = 100;

            int exam = rand.Next(min, max + 1);

            int point = exam;

            
            Console.WriteLine(point);

            if (point < 0 || point > 100)
            {
                Console.WriteLine("Wartość poza zakresem.");
            }
            else if (point >= 0 && point <= 39)
            {
                Console.WriteLine("Ocena Niedostateczna");
            }
            else if (point >= 40 && point <= 54)
            {
                Console.WriteLine("Ocena Dopuszczająca");
            }
            else if (point >= 55 && point <= 69)
            {
                Console.WriteLine("Ocena Dostateczna");
            }
            else if (point >= 70 && point <= 84)
            {
                Console.WriteLine("Ocena Dobra");
            }
            else if (point >= 85 && point <= 98)
            {
                Console.WriteLine("Ocena Bardzo Dobra");
            }
            else if (point >= 99 && point <= 100)
            {
                Console.WriteLine("Ocena Celująca");
            }

            string[] colors = new string[] { "red", "green", "blue", "Yellow" };

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);
            //tu się bawiłem int = 10, i<liczby.length -10
           
            int[] liczby = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("For");
        
            for (int i =10; i <liczby.Length; i++ )
            {
                Console.WriteLine(liczby[i]);
            }
            Console.WriteLine("Foreach");
            foreach (int liczba in liczby)
            {
                Console.WriteLine(liczba);
     
                
            }

            Console.WriteLine("while");
            while (licznik<=liczby.Length-9)
            {
                Console.WriteLine(liczby[licznik]);
                licznik++;
            }

            List<string> fruits = new List<string>();
            fruits.Add("Tomato");
            fruits.Add("Apple");
            fruits.Add("Paer");
            fruits.Add("Lemon");
            string output = string.Join(", ", fruits);
            Console.WriteLine(output);
            fruits.Remove("Tomato");
            fruits.Remove("Lemon");
            string outpu2t = string.Join(", ", fruits);
            Console.WriteLine(outpu2t);

        }

    }
}
