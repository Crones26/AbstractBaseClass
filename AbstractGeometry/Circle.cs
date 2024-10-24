using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Circle : Shape, IHaveDiameter, IHaveRadius
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

		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (int)(2 * Radius), (int)(2 * Radius));
			DrawDiameter(e); // Рисуем диаметр
			DrawRadius(e);   // Рисуем радиус
		}

		// Реализация интерфейса IHaveDiameter
		public double GetDiameter() => 2 * Radius;

		public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
		{
			int dx = (int)(Radius * (1 - 1 / Math.Sqrt(2)));
			e.Graphics.DrawLine
				(
					new Pen(Color, 3),
					StartX + dx, StartY + dx,
					StartX + (int)GetDiameter() - dx, StartY + (int)GetDiameter() - dx
				);
		}

		// Реализация интерфейса IHaveRadius
		public double GetRadius() => Radius;

		public void DrawRadius(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, 2);
			int centerX = StartX + (int)Radius;
			int centerY = StartY + (int)Radius;

			int endX = centerX + (int)(Radius / Math.Sqrt(2));
			int endY = centerY - (int)(Radius / Math.Sqrt(2));

			e.Graphics.DrawLine(pen, centerX, centerY, endX, endY);
		}
	}
}