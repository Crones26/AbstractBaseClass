using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal interface IHaveRadius
	{
		double GetRadius();
		void DrawRadius(PaintEventArgs e);
	}
}
