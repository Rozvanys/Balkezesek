using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
	internal class Jatekos
	{
		private string nev;
		private DateTime elso;
		private DateTime utolso;
		private int suly;
		private int magassag;

		public Jatekos(string sor)
		{
			string[] adatok = sor.Split(';');
			this.nev = adatok[0];
			this.elso = DateTime.Parse(adatok[1]);
			this.utolso = DateTime.Parse(adatok[2]);
			this.suly = int.Parse(adatok[3]);
			this.magassag = int.Parse(adatok[4]);
			
		}

		public string Nev { get => nev; set => nev = value; }
		public DateTime Elso { get => elso; set => elso = value; }
		public DateTime Utolso { get => utolso; set => utolso = value; }
		public int Suly { get => suly; set => suly = value; }
		public int Magassag { get => magassag; set => magassag = value; }

		public double MagassagCm(){
			return this.magassag * 2.54;
		}
	}
}
