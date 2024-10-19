using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Создаем изображение и графику для рисования
			int width = 1280;
			int height = 960;
			Bitmap bitmap = new Bitmap(width, height);
			Graphics graphics = Graphics.FromImage(bitmap);

			// Заполняем фон белым цветом
			graphics.Clear(Color.White);

			// Создаем и выводим прямоугольник
			Rectangle rectangle = new Rectangle(100, 50, 50, 50, 3, Color.Red);
			rectangle.Info(graphics);
			// Создаем квадрат с промежутком в 50 пикселей справа от прямоугольника
			Square square = new Square(80, rectangle.StartX + (int)rectangle.Width + 50, rectangle.StartY, 3, Color.Blue);
			square.Info(graphics);
			// Высчитываем координату Y для треугольника так, чтобы его основание совпадало с нижней границей квадрата
			int triangleStartY = square.StartY + (int)square.Side;
			// Создаем треугольник с основанием на одном уровне с нижней границей квадрата
			Triangle triangle = new Triangle(100, 80, square.StartX + (int)square.Side + 50, triangleStartY, 3, Color.Green);
			triangle.Info(graphics);
			// Создаем круг с промежутком в 50 пикселей справа от треугольника
			Circle circle = new Circle(50, triangle.StartX + (int)triangle.BaseLength + 50, square.StartY, 3, Color.Purple);
			circle.Info(graphics);
			// Сохраняем изображение в файл
			string filename = "shapes.bmp";
			bitmap.Save(filename);
			// Открываем изображение в MS Paint
			System.Diagnostics.Process.Start("mspaint.exe", filename);
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	} 
}
