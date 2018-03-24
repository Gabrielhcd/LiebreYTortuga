using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrera_Liebre_y_Tortuga
{
	class Liebre:Corredor
	{
		int chance;
		public override int avanzar()
		{
			chance = rand.Next(10);
			if (chance < 3)
				return _posicion += 0;
			else if (chance > 2 && chance < 5)
				return _posicion += 9;
			else if (chance > 4 && chance < 6)
				return _posicion -= 12;
			else if (chance > 5 && chance < 9)
				return _posicion += 1;
			else
				return _posicion -= 2;
			
		}
	}
}
