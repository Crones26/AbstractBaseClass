using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	internal class HomeCat:Cat
	{
		public override void Sound()
		{
			Console.WriteLine("Мяу");
		}
	}
}
