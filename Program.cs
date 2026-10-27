using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CultureInfo.CurrentCulture = new CultureInfo("hu-HU");
			Console.OutputEncoding = Encoding.UTF8;

			private List<Jatekos> jatekosok = new List<Jatekos>();

			public void Beolvas(string balkezesek){
			string[] sorok = File.ReadAllLines(balkezesek, Encoding.UTF8);

			for (int i = 1; i < sorok.Length; i++)
			{
				if (sorok[i].Trim() != ""){
					jatekosok.Add(new Jatekos(sorok[i]));
				}
			}
		}

		public void Feladat3(){
			Console.WriteLine("3. feladat: " + jatekosok.Count);
		}

		public void Feladat4()
		{
			Console.WriteLine("4. feladat: ");
			foreach (Jatekos j in jatekosok)
			{
				if (j.Utolso.Year == 1999 && j.Utolso.Month == 10)
				{
					Console.WriteLine("\t" + j.Nev + ", " + j.MagassagCm().ToString("F1") + " cm");
				}
			}
		}

		public void Feladat5()
		{
			Console.WriteLine("5. feladat: ");
			Console.Write("Kérek egy 1990 és 1999 közötti évszámot: ");
			int ev = int.Parse(Console.ReadLine());

			while (ev < 1990 || ev > 1999)
			{
				Console.Write("Hibás adat! Kérek egy 1990 és 1999 közötti évszámot: ");
				ev = int.Parse(Console.ReadLine());
			}

			return ev;
		}

		public void Feladat6(int ev)
		{
			int osszeg = 0;
			int db = 0;
			foreach (Jatekos j in jatekosok)
			{
				if (j.Elso.Year <= ev && j.Utolso.Year >= ev)
				{
					osszeg += j.Suly;
					db++;
				}
			}
			double atlag = (double)osszeg / db;
			Console.WriteLine("\t" + atlag.ToString("F1") + " kg az átlagos súly.");
		}
	}
	
}
