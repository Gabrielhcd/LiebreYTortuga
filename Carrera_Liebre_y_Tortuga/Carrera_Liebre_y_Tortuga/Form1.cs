using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carrera_Liebre_y_Tortuga
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Tortuga turtle;
		Liebre hare;

		private void button1_Click(object sender, EventArgs e)
		{
			turtle = new Tortuga();
			hare = new Liebre();

			while (turtle.posicion < 81 && hare.posicion < 81)
			{
				turtle.avanzar();
				hare.avanzar();
			}
			if (turtle.posicion >hare.posicion)
				MessageBox.Show("Gana Tortuga");
			else
				MessageBox.Show("Gana Liebre");
		}
	}
}
