using System;
using Conways_Game_of_Life_Unlimited_Edition;
using NUnit.Framework;

namespace TestProject1
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestGlider()
        {
            int[][,] gliders = 
            {
                new int[,] {{1,0,0},{0,1,1},{1,1,0}},
                new int[,] {{0,1,0},{0,0,1},{1,1,1}}
            };
            Console.WriteLine("Glider");
            int[,] res = ConwayLife.GetGeneration(gliders[0], 1);
            CollectionAssert.AreEqual(gliders[1], res, "Output doesn't match expected");
        }
    }

}