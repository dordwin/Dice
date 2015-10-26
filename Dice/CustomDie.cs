using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	/// <summary>
	/// Not yet ready for primetime.
	/// </summary>
	public class CustomDie : Die, IRollable {

		protected new int dieType;

		public new int Type {
			get { return dieType; }
			set { dieType = value; }
		}

		public CustomDie(int polyType = 6) {
			dieType = polyType;
		}

		public override int Roll() {
			try {
				mRollResult = Randomizer.Next(mMinimum, dieType + 1);
			}
			catch {
				int tempMinimum;
				int tempDieType;

				tempMinimum = Math.Min(mMinimum, dieType);
				tempDieType = Math.Max(mMinimum, dieType);
				mMinimum = tempMinimum;
				dieType = tempDieType;
				mRollResult = Randomizer.Next(tempMinimum, tempDieType + 1);
			}
			return mRollResult;
		}

		public override string ToString() {
			return "d" + dieType.ToString() + " (Custom)";
		}
	}
}
