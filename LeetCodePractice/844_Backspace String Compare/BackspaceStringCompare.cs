using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodePractice._844_Backspace_String_Compare
{
	[TestClass]
	public class BackspaceStringCompare
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsTrue(BackspaceCompare("ab#c", "ad#c"));
			Assert.IsTrue(BackspaceCompare("ab##", "c#d#"));
			Assert.IsTrue(BackspaceCompare("a##c", "#a#c"));
			Assert.IsFalse(BackspaceCompare("a#c", "b"));
		}

		public bool BackspaceCompare(string S, string T)
		{
			do
			{
				var index = S.IndexOf('#');
				if (index < 0)
					break;

				S = S.Remove(index, 1);
				if (index > 0)
					S = S.Remove(index - 1, 1);
			} while (true);

			do
			{
				var index = T.IndexOf('#');
				if (index < 0)
					break;

				T = T.Remove(index, 1);
				if (index > 0)
					T = T.Remove(index - 1, 1);
			} while (true);

			return S == T;
		}
	}
}
