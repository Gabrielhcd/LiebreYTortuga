using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
	class Tortuga:Corredor
	{
		int chance;
		public override int avanzar()
		{
			chance = rand.Next(10);
			if (chance < 6)
				return _posicion += 3;
			else if (chance > 5 && chance < 8)
				return _posicion -= 6;
			else
				return _posicion += 1;
		}
	}
}
