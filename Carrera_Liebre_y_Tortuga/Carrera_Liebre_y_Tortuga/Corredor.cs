using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
	abstract class Corredor
	{
		protected int _posicion;
		protected static Random rand = new Random();

		public Corredor()
		{
			_posicion = 0;
		}
		public int posicion
		{
			get { return _posicion; }
		}
		public virtual int avanzar() { return _posicion; }
	}
}
