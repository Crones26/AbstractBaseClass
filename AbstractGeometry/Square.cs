using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Square : Shape
	{
		double side;

		public double Side
		{
			get => side;
			set => side = SizeFilter(value);
		}

		public Square(double side, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Side = side;
		}

		public override double GetArea() => Side * Side;
		public override double GetPerimeter() => 4 * Side;

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)Side, (int)Side);
		}
	}
}