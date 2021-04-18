using Digitize;
using NUnit.Framework;

namespace Test.Digitize
{
	[TestFixture]
	public class Tests
	{
		[Test]
		public void Test()
		{
			Assert.AreEqual(new int[] { 1, 2, 3 }, Kata.digitize(123));
			Assert.AreEqual(new int[] { 1 }, Kata.digitize(1));
			Assert.AreEqual(new int[] { 0 }, Kata.digitize(0));
			Assert.AreEqual(new int[] { 1, 2, 3, 0 }, Kata.digitize(1230));
			Assert.AreEqual(new int[] { 8, 6, 7, 5, 3, 0, 9 }, Kata.digitize(8675309));
		}
	}
}