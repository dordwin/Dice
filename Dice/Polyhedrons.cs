using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	/// <summary>
	/// Used to standardize the type of die objects created.
	/// </summary>
    public enum Polyhedrons {
		coin = 2,
		d3 = 3,
		d4 = 4,
		d6 = 6,
		d8 = 8,
		d10 = 10,
		d12 = 12,
		d20 = 20,
		d100 = 100
    }
}
