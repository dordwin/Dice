using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	public class ModifiedDie : Die, IRollable {
		protected int mModifier;

		/// <summary>
		/// Used to set/change the modifier to this die object.
		/// </summary>
		public int dieModifier {
			get { return mModifier; }
			set { mModifier = value; }
		}

		/// <summary>
		/// Used to instantiate the ModifiedDie object.
		/// </summary>
		/// <param name="type">a Polyhedrons object</param>
		/// <param name="modifier">an integer to add to the total.  Can be positive or negative.</param>
		public ModifiedDie(Polyhedrons type = Polyhedrons.d6, int modifier = 0) {
			dieType = type;
			mModifier = modifier;
		}

		/// <summary>
		/// used to determine ("roll") the die object for an outcome.
		/// </summary>
		/// <returns>the result of the die  plus modifier as an integer.</returns>
		public override int Roll() {
			mRollResult = base.Roll() + mModifier;
			return mRollResult;
		}
	}
}
