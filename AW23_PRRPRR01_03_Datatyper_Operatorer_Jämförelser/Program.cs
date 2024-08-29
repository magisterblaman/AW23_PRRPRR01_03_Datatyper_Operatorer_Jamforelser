using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_03_Datatyper_Operatorer_Jämförelser {
	internal class Program {
		static void Main(string[] args) {

			int a = 34;
			int b = 35;
			int sum = a + b;

			Console.WriteLine(sum);

			// inkrementera
			a = a + 1;
			a += 1;
			a++;
			++a;

			// dekrementera
			a = a - 1;
			a -= 1;
			a--;
			--a;

			a = a * 2;
			a *= 2;

			if (a != 3) {
				Console.WriteLine("Hej");
			}

		}
	}
}
