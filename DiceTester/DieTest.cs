using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dice;
using System.Collections.Generic;

namespace DiceTester {
	[TestClass]
	public class DieTest {
		[TestMethod]
		public void TestAllCustomD10Values() {
			int sideCount = 10;
			// create die
			CustomDie d = new CustomDie(sideCount);

			// populate "not yet found" list
			List<int> notFound = new List<int>();

			for (int i = 1; i <= sideCount; i++) {
				notFound.Add(sideCount);
			}

			// attempt to find each value
			for (int i = 1; i < (sideCount * 100); i++) {
				int result = d.Roll(); // 1 To 100 times the sides of the object.
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on the custom d" + sideCount.ToString() + ".");
		}

		[TestMethod]
		public void TestDieSetRoll() {
			// create dice and set
			Die d1 = new Die();
			Die d2 = new Die();
			Die d3 = new Die();
			DiceSet set = new DiceSet();
			set.Add(d1);
			set.Add(d2);
			set.Add(d3);

			// roll dice bag
			set.Roll();

			// add rolls of dice
			int total = d1.RollResult + d2.RollResult + d3.RollResult;

			// test that the set roll matches the dice rolls
			Assert.AreEqual<int>(total, set.RollResult, "Dieset roll does not match total value of rolled dice.");
		}

		[TestMethod]
		public void TestDieSetRollDiceIndividually() {
			// create dice and set
			Die d1 = new Die();
			Die d2 = new Die();
			Die d3 = new Die();
			DiceSet set = new DiceSet();
			set.Add(d1);
			set.Add(d2);
			set.Add(d3);

			// roll dice individually
			d1.Roll();
			d2.Roll();
			d3.Roll();

			// add rolls of dice
			int total = d1.RollResult + d2.RollResult + d3.RollResult;

			// test that the set roll matches the individual dice
			Assert.AreEqual<int>(total, set.RollResult, "Dieset roll does not match total value of individually rolled dice.");
		}

		[TestMethod]
		public void TestAllCoinValues() {
			// create Coin
			var d = DiceFactory.CreateCoin();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2 });

			// attempt to find each value
			for (int i = 1; i < 10; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 2
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a coin.");
		}

		[TestMethod]
		public void TestAllD3Values() {
			// create D3
			var d = DiceFactory.CreateD3();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 3
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d3");
		}

		[TestMethod]
		public void TestAllD4Values() {
			// create D4
			var d = DiceFactory.CreateD4();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 2
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d4.");
		}

		[TestMethod]
		public void TestAllD6Values() {
			// create D6
			var d = DiceFactory.CreateD6();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 6
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d6.");
		}

		[TestMethod]
		public void TestAllD8Values() {
			// create D8
			var d = DiceFactory.CreateD8();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 8
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d8.");
		}

		[TestMethod]
		public void TestAllD10Values() {
			// create D10
			var d = DiceFactory.CreateD10();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 10
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d10.");
		}

		[TestMethod]
		public void TestAllD12Values() {
			// create D12
			var d = DiceFactory.CreateD12();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 });

			// attempt to find each value
			for (int i = 1; i < 100; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 12
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d12.");
		}

		[TestMethod]
		public void TestAllD20Values() {
			// create D20
			var d = DiceFactory.CreateD20();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

			// attempt to find each value
			for (int i = 1; i < 1000; i++) { // arbitrary limit of 10 maximum tries
				int result = d.Roll(); // 1 To 20
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d20.");
		}

		[TestMethod]
		public void TestAllD100Values() {
			// create D100
			var d = DiceFactory.CreateD100();

			// populate "not yet found" list
			List<int> notFound = new List<int>();
			//notFound.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 });

			for (int i = 1; i <= 100; i++) {
				notFound.Add(i);
			}

			// attempt to find each value
			for (int i = 1; i < 10000; i++) { // arbitrary limit of 10000 maximum tries
				int result = d.Roll(); // 1 To 20
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on a d100.");
		}

		[TestMethod]
		public void TestDDStatRollerAllValuesCheck() {
			IRollable d = new DiceSet();

			IRollable dd1 = DiceFactory.CreateDDStatRoller();
			((DiceSet)d).Add(dd1);

			// populate "not yet found" list
			List<int> notFound = new List<int>();

			notFound.AddRange(new int[] { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 });

			// attempt to find each value
			for (int i = 1; i < 1000; i++) { // arbitrary limit of 10000 maximum tries
				int result = d.Roll(); // 3 to 18
				notFound.Remove(result);
				if (notFound.Count <= 0) {
					break; // all found
				}
			}
			// test
			Assert.AreEqual<int>(0, notFound.Count, "Some values were not rolled on 3 d6.");

		}

		[TestMethod]
		public void RollTest() {
			List<int> rollResults = new List<int>();
			IRollable d = DiceFactory.CreateD10();
			for (int i = 0; i < 100000000; i++) {
				rollResults.Add(d.Roll());
			}
			Assert.AreEqual(rollResults.Count, 100000000, "Count is " + rollResults.Count.ToString());
		}
	}
}
