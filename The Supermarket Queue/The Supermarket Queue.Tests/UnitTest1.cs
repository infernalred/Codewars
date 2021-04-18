using NUnit.Framework;

namespace The_Supermarket_Queue.Tests
{
    using NUnit.Framework;

    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void ExampleTest1()
        {
            long expected = 0;

            long actual = Kata.QueueTime(new int[] { }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest2()
        {
            long expected = 10;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4 }, 1);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest3()
        {
            long expected = 9;

            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4 }, 2);

            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void ExampleTest5()
        {
            long expected = 14;

            long actual = Kata.QueueTime(new int[] { 2, 2, 3, 3, 4, 4, 5 }, 2);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ExampleTest4()
        {
            long expected = 5;

            long actual = Kata.QueueTime(new int[] { 1, 2, 3, 4, 5 }, 100);

            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void ExampleTest6()
        {
            long expected = 78;

            long actual = Kata.QueueTime(new int[] { 8, 18, 2, 39, 32, 8, 31, 1, 33, 39, 6, 17, 33, 19, 34 }, 5);

            Assert.AreEqual(expected, actual);
        }
    }
}