using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	public class SuccessDiceSet : DiceSet, IRollable {
		protected int mTarget;

		/// <summary>
		/// sets the target value to be be rolled on the "dice" in the set.
		/// </summary>
		protected int Target {
			get { return mTarget; }
			set { mTarget = value; }
		}

		/// <summary>
		/// Used to instantiate the SuccessDiceSet.  
		/// </summary>
		/// <param name="target">
		/// Must be a number 
		/// between 1 and the max value of the dice with the least number 
		/// of sides in the set.
		/// </param>
		public SuccessDiceSet(int target)
			: base() {
				mTarget = target;
		}

		/// <summary>
		/// used to determine ("roll") the die object for an outcome.
		/// </summary>
		/// <returns>
		/// the number of dice that have met/exceeded the target number.
		/// </returns>
		public override int Roll() {
			int successes = 0;
			int currentResult = 0;
			foreach (IRollable die in mDiceBag) {
				currentResult = die.Roll();
				if (currentResult >= mTarget) {
					successes++;
				}
			}

			return successes;
		}

		/// <summary>
		/// Creates the description of items in the SuccessDiceSet and 
		/// to what the intended Target is set.
		/// </summary>
		/// <returns>the Description of the SucessDiceSet</returns>
		public override string ToString() {
			return base.ToString() + " Success is " + mTarget + " or higher.";
		}

	}
}
