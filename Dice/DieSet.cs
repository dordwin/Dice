using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	public class DiceSet : IRollable {
		protected List<IRollable> mDiceBag;

		/// <summary>
		/// returns the last value "rolled" on the dice objects.
		/// </summary>
		public int RollResult {
			get {
				int mRollResult = 0;
				foreach (IRollable die in mDiceBag) {
					mRollResult += die.RollResult;
				}
				return mRollResult; 
			}
		}

		/// <summary>
		/// Method used to instantiate the DiceSet object.
		/// </summary>
		public DiceSet() {
			mDiceBag = new List<IRollable>();
		}

		/// <summary>
		/// Method used to add a single "die" (IRollable) object.
		/// </summary>
		/// <param name="die">IRollable object.</param>
		public void Add(IRollable die) {
			mDiceBag.Add(die);
		}

		//public void AddMultipleDice() {}

		/// <summary>
		/// Used to verify the number of IRollable objects in the DiceSet.
		/// </summary>
		/// <returns>the number of items as an integer.</returns>
		public int Count() {
			return mDiceBag.Count();
		}

		/// <summary>
		/// Used to clear out the contents of the DiceSet.
		/// </summary>
		public virtual void Reset() {
			mDiceBag.Clear();
		}

		/// <summary>
		/// used to determine ("roll") the die object for an outcome.
		/// </summary>
		/// <returns>the result of the die as an integer.</returns>
		public virtual int Roll() {
			int mRollResult = 0;
			foreach (IRollable die in mDiceBag) {
				mRollResult += die.Roll();
			}
			return mRollResult;
		}

		/// <summary>
		/// Used to descriibe the DiceSet object.
		/// </summary>
		/// <returns>The list of internal IRollable objects assigned to this DiceSet.</returns>
		public override string ToString() {
			return GetSelfDescription();
		}

		// Method to build the information for the ToString() Method.
		private string GetSelfDescription() {

			Dictionary<string, int> diceCountByType = new
				Dictionary<string, int>();

			StringBuilder diceText = new StringBuilder();

			// Builds the unique list of IRollable objects in this DiceSet.
			foreach (IRollable die in mDiceBag) {
				if (!diceCountByType.ContainsKey(die.ToString())) {
					diceCountByType.Add(die.ToString(), 0);
				}
			}

			//Counts the different types of IRollable objects in this DiceSet.
			foreach (IRollable die in mDiceBag) {
				diceCountByType[die.ToString()] =
					diceCountByType[die.ToString()] + 1;
			}

			//Builds the string listing of IRollable objects in this DiceSet.
			foreach (KeyValuePair<string, int> pair in diceCountByType) {
				if (diceText.Length > 0) {
					diceText.Append(", ");
				}
				string pairValueKey;
				pairValueKey = pair.Value.ToString() + " " + pair.Key;
				diceText.Append(pairValueKey);
			}

			//Finalizes and returns the list of IRollable objects in the DiceSet.
			string description =
				String.Format("DieSet({0})", diceText.ToString());
			return description;
		}
	}
}
