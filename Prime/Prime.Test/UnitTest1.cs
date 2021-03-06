using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Prime.Test
{
    [TestFixture]
    public class SolutionTest
    {
        private static IEnumerable<TestCaseData> sampleTestCases
        {
            get
            {
                yield return new TestCaseData(0).Returns(false);
                yield return new TestCaseData(1).Returns(false);
                yield return new TestCaseData(2).Returns(true);
                yield return new TestCaseData(7).Returns(true);
                yield return new TestCaseData(15).Returns(false);
            }
        }

        [Test, TestCaseSource("sampleTestCases")]
        public bool SampleTest(int n) => Kata.IsPrime(n);
    }
}