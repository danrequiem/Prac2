using System;

namespace Tarea1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Bienvenido \n");

			Persona P =new Persona();

			Console.Write("Nombre:");
			P.nombre = Console.ReadLine();

			Console.Write("Correo:");
			P.correo = Console.ReadLine();

			Console.Write("Edad:");
			P.edad = int.Parse(Console.ReadLine());

			Console.Write("\nLos datos ingresados son estos \n");
			Console.Write("\nNombre:"+P.nombre);
			Console.Write("\nCorreo:"+P.correo);
			Console.Write("\nEdad:"+P.edad );


			Console.Write("\n\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}