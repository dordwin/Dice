using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice {
	/// <summary>
	/// Interface for all "Rollable" items.
	/// </summary>
	public interface IRollable {
		int RollResult { get; }
		int Roll();
	}
}
