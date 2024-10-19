using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
			(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
			);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			// Задаем смещение по оси Y
			int yOffset = 200;
			// Создаем и выводим прямоугольник
			Rectangle rectangle = new Rectangle(100, 50, 50, 50 + yOffset, 3, System.Drawing.Color.Red);
			rectangle.Info(e);
			// Создаем квадрат с промежутком в 50 пикселей справа от прямоугольника
			Square square = new Square(80, rectangle.StartX + (int)rectangle.Width + 50, rectangle.StartY, 3, System.Drawing.Color.Blue);
			square.Info(e);
			// Высчитываем координату Y для треугольника так, чтобы его основание совпадало с нижней границей квадрата
			int triangleStartY = square.StartY + (int)square.Side;
			// Создаем треугольник с основанием на одном уровне с нижней границей квадрата
			Triangle triangle = new Triangle(100, 80, square.StartX + (int)square.Side + 50, triangleStartY, 3, System.Drawing.Color.Green);
			triangle.Info(e);
			// Создаем круг с промежутком в 50 пикселей справа от треугольника
			Circle circle = new Circle(50, triangle.StartX + (int)triangle.BaseLength + 50, square.StartY, 3, System.Drawing.Color.Purple);
			circle.Info(e);
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
