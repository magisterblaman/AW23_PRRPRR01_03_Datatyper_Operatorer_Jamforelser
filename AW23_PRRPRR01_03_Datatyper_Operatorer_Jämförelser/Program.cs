using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_03_Datatyper_Operatorer_Jämförelser {
	internal class Program {
		static void Main(string[] args) {

			int a = 3;
			int b = 3;

			if (a == 3 && b == 2) {
				Console.WriteLine("If-sats 1");
			}

			if (!(a == 3 || b == 2)) {
				Console.WriteLine("If-sats 2");
			}

			if (a == 3 && b == 2 || a + b == 6) {
				Console.WriteLine("If-sats 3");
			}
		}
	}
}
