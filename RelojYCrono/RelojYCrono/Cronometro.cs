using System;
using System.Threading; 

namespace Reloj_Crono
{
	public class Cronometro
	{

		int h=0;
		int m=0;
		int s=0;

		public Cronometro ()
		{
		}

		public void Inciar()
		{
			for (; ;)
			{
				s++;
				if(s==60) { m++; s=0; } 
				if(m==60) { h++; m=0; } 
				if(h==24) h=0; 


				Console.Clear (); 
				Console.WriteLine ("{0}:{1}:{2}", h, m, s);
				Thread.Sleep (1000);


			}

		}
	}
}

