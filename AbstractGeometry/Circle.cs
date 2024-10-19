using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		double radius;

		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}

		public Circle(double radius, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}

		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => 2 * Math.PI * Radius;

		public override void Draw(Graphics graphics)
		{
			Pen pen = new Pen(color, LineWidth);
			Brush brush = new SolidBrush(color);
			graphics.FillEllipse(brush, StartX, StartY, (int)(2 * Radius), (int)(2 * Radius));
			graphics.DrawEllipse(pen, StartX, StartY, (int)(2 * Radius), (int)(2 * Radius));
		}
	}
}