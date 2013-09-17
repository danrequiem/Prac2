using System;
using System.Threading; 

namespace Reloj_Crono
{
	public class Relog
	{


		public Relog ()
		{

		}

		public void Inciar()
		{

			for (; ; ) 
			{
				Console.Clear(); 
				Console.WriteLine("{0}:{1}:{2}",DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second); 
				Thread.Sleep(1000);
			}
		}
	}
}