using System;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {
			int mainigais = Funkcija2(); //return f-cijas rezultātu ieveto mainīgajā
			Console.WriteLine(mainigais); //return f-cijas mainīgā izvade

			Funkcija(); //void f-cijas palaišana

			Console.ReadLine(); //"pauze" windows consolei

        }
		static void Funkcija()
		{
			int a, b, c;
			a = 2;
			b = 3;
			c = a + b;

			Console.WriteLine(c);
		}

		static int Funkcija2()
		{
			int a, b, c;
            a = 2;
            b = 3;
            c = a + b;

			return c;
		}
    }
}
