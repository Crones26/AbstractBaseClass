using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractBaseClass
{
	class Program
	{
		static void Main(string[] args)
		{
			//Animal animal = new Animal();
			//Cat cat = new Cat();
			Lion lion = new Lion();
			lion.Sound();

			HomeCat cat = new HomeCat();
			cat.Sound();
		}
	}
}
