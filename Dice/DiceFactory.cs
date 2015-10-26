using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	/// <summary>
	/// This class is used to make die creation simplified.
	/// </summary>
	public static class DiceFactory {

		/// <summary>
		/// used to create a "coin" to flip
		/// </summary>
		/// <returns>a Die object with 2 sides</returns>
		public static Die CreateCoin() {
			return new Die(Polyhedrons.coin);
		}

		/// <summary>
		/// creates a 3 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 3 sides</returns>
		public static Die CreateD3() {
			return new Die(Polyhedrons.d3);
		}

		/// <summary>
		/// creates a 4 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 4 sides</returns>
		public static Die CreateD4() {
			return new Die(Polyhedrons.d4);
		}

		/// <summary>
		/// creates a 6 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 6 sides</returns>
		public static Die CreateD6() {
			return new Die(Polyhedrons.d6);
		}

		/// <summary>
		/// creates a 8 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 8 sides</returns>
		public static Die CreateD8() {
			return new Die(Polyhedrons.d8);
		}

		/// <summary>
		/// creates a 10 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 10 sides</returns>
		public static Die CreateD10() {
			return new Die(Polyhedrons.d10);
		}

		/// <summary>
		/// creates a 12 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 12 sides</returns>
		public static Die CreateD12() {
			return new Die(Polyhedrons.d12);
		}

		/// <summary>
		/// creates a 20 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 20 sides</returns>
		public static Die CreateD20() {
			return new Die(Polyhedrons.d20);
		}

		/// <summary>
		/// creates a 100 sided unmodified die.
		/// </summary>
		/// <returns>a Die object with 100 sides</returns>
		public static Die CreateD100() {
			return new Die(Polyhedrons.d100);
		}

		/// <summary>
		/// Creates a 10 sided die with sides in multiples of 10.
		/// </summary>
		/// <returns>a Die object with 10 sides in multiples of 10.</returns>
		public static TensDie CreateTensDie() {
			return new TensDie();
		}

		/// <summary>
		/// Creates a D and D basic Attribute Rolling set.
		/// </summary>
		/// <returns>a DieSet with 3 unmodified 6 sided dice.</returns>
		public static DiceSet CreateDDStatRoller() {
			DiceSet dieSet = new DiceSet();
			dieSet.Add(new Die());
			dieSet.Add(new Die());
			dieSet.Add(new Die());
			return dieSet;
		}
	}
}
