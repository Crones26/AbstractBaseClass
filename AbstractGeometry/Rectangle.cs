﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Rectangle : Shape
	{
		double width;
		double height;

		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}

		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}

		public Rectangle(double width, double height, int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}

		public override double GetArea() => Width * Height;
		public override double GetPerimeter() => 2 * (Width + Height);

		public override void Draw(Graphics graphics)
		{
			Pen pen = new Pen(color, LineWidth);
			Brush brush = new SolidBrush(color);
			graphics.FillRectangle(brush, StartX, StartY, (int)Width, (int)Height);
			graphics.DrawRectangle(pen, StartX, StartY, (int)Width, (int)Height);
		}
	}
}