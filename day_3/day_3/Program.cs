using System;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {


			int mainigais = Funkcija2(); //return f-cijas rezultātu ieveto mainīgajā
			Console.WriteLine(mainigais); //return f-cijas mainīgā izvade

			int a, b;
			Console.Write("ievadi a:");
			a = Convert.ToInt32(Console.ReadLine());

			Console.Write("ievadi b:");
            b = Convert.ToInt32(Console.ReadLine());

			int fcija4 = Funkcija4(a, b);
			Console.WriteLine("F-cija4 rezultats:" + fcija4);

			Funkcija(); //void f-cijas palaišana
			Funkcija3(5, 6);

			Console.ReadLine(); //"pauze" windows consolei

        }
		static void Funkcija()
		{
			int a, b, c;
			a = 3;
			b = 2;
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

		static void Funkcija3(int skaitlis1, int skaitlis2)
		{
			int c = skaitlis1 + skaitlis2;
			Console.WriteLine("f-cija ar parametru " + c);

		}
		static int Funkcija4(int skaitlis1, int skaitlis2)
		{
			int c = skaitlis1 + skaitlis2;

			return c;
		}
    }
}
