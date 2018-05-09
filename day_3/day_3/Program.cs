using System;

namespace day_3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("ievadi pirmo vardu: ");
			string virkne1 = Console.ReadLine();
			Console.Write("ievadi otro vardu: ");
            string virkne2 = Console.ReadLine();
			Console.Write("ievadi trešo vardu: ");
            string virkne3 = Console.ReadLine();
          
			string teikums = Funkcija5(virkne1, virkne2, virkne3);
			Console.WriteLine(teikums);
            // funkcija5 - izvada beigas

			int mainigais = Funkcija2(); //return f-cijas rezultātu ieveto mainīgajā
			Console.WriteLine(mainigais); //return f-cijas mainīgā izvade

			int a, b;
			Console.Write("ievadi a:");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("ievadi b:");
            b = Convert.ToInt32(Console.ReadLine());

			int fcija4 = Funkcija4(a, b);
			Console.WriteLine("F-cija4 rezultats:" + fcija4);
            //Funkcija4 izvada beigas

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

		static string Funkcija5(string vards1, string vards2, string vards3)
		{
			string teikums = vards1 + " " + vards2 + " " + vards3 + "!";

			return teikums;
		}
    }
}
