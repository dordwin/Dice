using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	public class TensDie : Die, IRollable {

		/// <summary>
		/// Method to instantiate the TensDie.  There are no parameters needed.
		/// </summary>
		public TensDie() {
			dieType = Polyhedrons.d10;
		}

		/// <summary>
		/// Rolls a "die" object
		/// </summary>
		/// <returns>Returns a number between 0 and 90 in increments of 10.</returns>
		public override int Roll() {
			return ((base.Roll() - 1) * 10);
		}

		/// <summary>
		/// used to verify what die type is currently assigned to the object.
		/// </summary>
		/// <returns>the Polyhedron value.</returns>
		public override string ToString() {
			return base.ToString() + "x10";
		}

	}
}
