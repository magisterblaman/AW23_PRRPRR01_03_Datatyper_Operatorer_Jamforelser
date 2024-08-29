using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_03_Datatyper_Operatorer_Jämförelser {
	internal class Program {
		static void Main(string[] args) {

			Console.WriteLine("Skriv in ett värde");
			string a = Console.ReadLine();

			double b = double.Parse(a);

			Console.WriteLine(b);
		}
	}
}
