using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	public class Die : IRollable {
		public static Random Randomizer = new Random();

		protected Polyhedrons dieType;
		protected int mRollResult;
		protected int mMinimum = 1;

		/// <summary>
		/// used to change the number of sides on the die using the Polyhedrons enum.
		/// </summary>
		public Polyhedrons Type {
			get { return dieType; }
			set { dieType = value; }
		}

		/// <summary>
		/// used to save the last roll from the die object.
		/// </summary>
		public int RollResult {
			get { return mRollResult; }
		}

		/// <summary>
		/// allows the Die class to not require the number of sides on the die.  Polyhedrons.d6 is the default.
		/// </summary>
		public Die() {
			dieType = Polyhedrons.d6;
		}

		/// <summary>
		/// used to instantiate the Die class with a die type
		/// </summary>
		/// <param name="polyType">Uses the Polyhedron enum</param>
		public Die(Polyhedrons polyType = Polyhedrons.d6) {
			dieType = polyType;
		}

		/// <summary>
		/// used to determine ("roll") the die object for an outcome.
		/// </summary>
		/// <returns>the result of the die as an integer.</returns>
		/// <exception cref="System.ArgumentOutOfRange">Minimum value cannot be greater than Max value.  
		/// If the minimum is greater than the maximum, the minimum is set to the lesser of the two.</exception>
		public virtual int Roll() {
			try {
				mRollResult = Randomizer.Next(mMinimum, (int)dieType + 1);
			}
			catch {
				int tempMinimum;
				int tempDieType;

				tempMinimum = Math.Min(mMinimum, (int)dieType);
				tempDieType = Math.Max(mMinimum, (int)dieType);
				mMinimum = tempMinimum;
				mRollResult = Randomizer.Next(tempMinimum, tempDieType + 1);
			}

			return mRollResult;
		}

		/// <summary>
		/// used to verify what die type is currently assigned to the object.
		/// </summary>
		/// <returns>the Polyhedron value.</returns>
		public override string ToString() {
			return dieType.ToString();
		}

	}
}
