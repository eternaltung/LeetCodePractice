using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePractice._841_KeysAndRooms
{
	[TestClass]
	public class KeysAndRooms
	{
		[TestMethod]
		public void TestMethod1()
		{
			IList<IList<int>> case1 = new List<IList<int>>();
			case1.Add(new List<int>() { 1 });
			case1.Add(new List<int>() { 2 });
			case1.Add(new List<int>() { 3 });
			case1.Add(new List<int>());
			Assert.AreEqual(true, CanVisitAllRooms(case1));

			IList<IList<int>> case2 = new List<IList<int>>();
			case2.Add(new List<int>() { 1, 3 });
			case2.Add(new List<int>() { 3, 0, 1 });
			case2.Add(new List<int>() { 2 });
			case2.Add(new List<int>() { 0 });
			Assert.AreEqual(false, CanVisitAllRooms(case2));
		}

		public bool CanVisitAllRooms(IList<IList<int>> rooms)
		{
			var walkedRoom = new HashSet<int> { 0 };
			var keys = new HashSet<int>();
			foreach (var key in rooms[0])
				keys.Add(key);

			while (keys.Any())
			{
				var key = keys.First();
				if (walkedRoom.Add(key))
				{
					foreach (var item in rooms[key])
						keys.Add(item);
				}
				keys.Remove(key);
			}
			return walkedRoom.Count == rooms.Count;
		}
	}
}
