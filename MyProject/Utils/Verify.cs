using NUnit.Framework;
using System;

/// <summary>
/// To verify test scenerios
/// </summary>
namespace MyProject.Utils
{
    public class Verify
    {
        /// <summary>
        /// To verify scenerios have single test case
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        ///

        public void SingleString(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
            LogString(expected, actual);
        }

        public void SingleInteger(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
            LogString(expected.ToString(), actual.ToString());
        }
        public void SingleDouble(double expected, double actual)
        {
            Assert.AreEqual(expected, actual);
            LogString(expected.ToString(), actual.ToString());
        }
        public void AreNotEqual(string expected, string actual)
        {
            Assert.AreNotEqual(expected, actual);
            LogString(expected, actual);
        }

        public void IsFalse(bool actual)
        {
            Assert.IsFalse(actual);
            LogString("false", actual.ToString());
        }
        public void IsFalse(string expected, bool actual)
        {
            Assert.IsTrue(actual);
            LogString("true", actual.ToString());
            Console.WriteLine("Beklenen: '" + expected + "' başarıyla gerçekleşti.");
        }

        public void IsTrue(bool actual)
        {
            Assert.IsTrue(actual);
            LogString("true", actual.ToString());
        }

        public void IsTrue(string expected, bool actual)
        {
            Assert.IsTrue(actual);
            LogString("true", actual.ToString());
            Console.WriteLine("Beklenen: '" + expected + "' başarıyla gerçekleşti.");
        }

        /// <summary>
        /// To verify scenerios have multiple test cases
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public void MultipleString(string expected, string actual)
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expected, actual);
                LogString(expected, actual);
            });
        }

        /// <summary>
        /// To log failed steps
        /// </summary>
        /// <param name="method"></param>
        public void LogString(string expected, string actual)
        {
            if (expected == actual)
            {
                Console.WriteLine("Passed");
                Console.WriteLine("Expected: " + expected + Environment.NewLine + "Actual  : " + actual + Environment.NewLine);
            }
        }
        /// <summary>
        /// To verify scenerios have single test case
        /// </summary>
        /// <param name="last"></param>
        /// <param name="first"></param>
        public void AreGreater(int last, int first)
        {
            Assert.Greater(last, first);
            Console.WriteLine("Last: " + last);
            Console.WriteLine("First: " + first);
        }

        public void AreLess(int last, int first)
        {
            Assert.Less(last, first);
            Console.WriteLine("Last: " + last);
            Console.WriteLine("First: " + first);
        }

        /// <summary>
        /// To verify scenerios have multiple test cases
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        public void IsEmpty(string actual)
        {
            Assert.IsEmpty(actual);
        }

        public void IsNull(string actual)
        {
            Assert.AreEqual("", actual);
        }

        public void AreGreaterDate(string date1, string date2)
        {
            Assert.Greater(Convert.ToDateTime(date1), Convert.ToDateTime(date2));
        }
    }
}