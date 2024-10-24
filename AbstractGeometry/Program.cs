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
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
            (
                Console.WindowLeft, Console.WindowTop,
                Console.WindowWidth, Console.WindowHeight
            );
            PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

            int startX = 50; 
            int startY = 300;

            // Прямоугольник
            Rectangle rectangle = new Rectangle(100, 50, startX, startY, 3, System.Drawing.Color.Red);
            rectangle.Info(e);
            // Квадрат
            startX += 100 + 50;
            Square square = new Square(75, startX, startY, 3, Color.DarkBlue);
            square.Info(e);
            // Круг
            startX += 75 + 50; 
            Circle circle = new Circle(50, startX, startY, 3, Color.Purple);
            circle.Info(e);
            // Равнобедренный треугольник
            startX += 100 + 50;
            IsoscalesTriangle i_triangle = new IsoscalesTriangle(60, 90, startX, startY, 3, Color.Aqua);
            i_triangle.Info(e);
            // Равносторонний треугольник
            startX += 50 + 50;
            EquilateralTriangle e_triangle = new EquilateralTriangle(90, startX, startY, 3, Color.GreenYellow);
            e_triangle.Info(e);
            // Прямоугольный треугольник
            startX += 70 + 60;
            RightTriangle right_triangle = new RightTriangle(60, 90, startX, startY, 3, Color.Orange);
            right_triangle.Info(e);
        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
    }
}
