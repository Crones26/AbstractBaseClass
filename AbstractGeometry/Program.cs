using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Устанавливаем размер окна консоли
			Console.SetWindowSize(140, 30); // Устанавливаем ширину и высоту окна 
			Console.SetBufferSize(140, 30); // Устанавливаем размер буфера консоли

			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
			(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
			);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			Rectangle rectangle = new Rectangle(100, 50, 400, 50, 3, System.Drawing.Color.Red);
			rectangle.Info(e);

			Square square = new Square(75, 550, 50, 3, Color.DarkBlue);
			square.Info(e);

			Circle circle = new Circle(50, 700, 50, 3, Color.Purple);
			circle.Info(e);

			IsoscalesTriangle i_triangle = new IsoscalesTriangle(50, 100, 400, 200, 3, Color.Aqua);
			i_triangle.Info(e);

			EquilateralTriangle e_triangle = new EquilateralTriangle(100, 550, 200, 3, Color.GreenYellow);
			e_triangle.Info(e);

			RightTriangle right_triangle = new RightTriangle(60, 90, 750, 300, 3, Color.Orange);
			right_triangle.Info(e);
		}

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("user32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
