using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square : Rectangle
	{
		public double Side
		{
			get => Width;
			set
			{
				Width = SizeFilter(value);
				Height = SizeFilter(value);
			}
		}
		
		public Square(double side, int startX, int startY, int lineWidth, Color color)
			: base(side, side, startX, startY, lineWidth, color){}
	}
}