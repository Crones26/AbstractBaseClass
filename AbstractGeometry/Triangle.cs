using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Triangle : Shape
	{
		double baseLength;
		double height;

		public double BaseLength
		{
			get => baseLength;
			set => baseLength = SizeFilter(value);
		}

		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}

		public Triangle(double baseLength, double height, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			BaseLength = baseLength;
			Height = height;
		}

		public override double GetArea() => 0.5 * BaseLength * Height;
		public override double GetPerimeter()
		{
			double side = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(BaseLength / 2, 2));
			return BaseLength + 2 * side;
		}

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = 
			{
				new Point(StartX, StartY),
				new Point(StartX + (int)(BaseLength / 2), StartY - (int)Height),
				new Point(StartX + (int)BaseLength, StartY)
			};
			e.Graphics.DrawPolygon(pen, points);
		}
	}
}