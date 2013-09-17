using System;

namespace Reloj_Crono
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Menu");
			Console.WriteLine ("1)Relog");
			Console.WriteLine("2)Cronometro");


			string opc = Console.ReadLine();

			Convert.ToInt16 (opc);

			switch (opc) {

				case "1":
				Relog r = new Relog ();
				r.Inciar ();
				break;
				case "2":
				Cronometro c = new Cronometro ();
				c.Inciar ();
				break;
				default:
				Console.Clear();
				Console.WriteLine ("No valido");
				break;




			}
		}
	}
}