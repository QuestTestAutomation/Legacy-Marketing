using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Collections;

namespace ParallelSelenium.Common
{
    public class NUnitFactory
    {
        public void AreEqual<T>(T expectedValue, T actualValue, string message = "")
        {
            if (!EqualityComparer<T>.Default.Equals(expectedValue, actualValue))
            {
                this.Fail();
            }
            else
            {
                this.Pass();
            }
        }

        private void Fail()
        {
            throw new NotImplementedException();
        }

        public void AreNotEqual<T>(T expectedValue, T actualValue)
        {

        }

        public void Contains<T>(T expectedValue, ICollection<T> actualValue)
        {

        }

        //public void Fail()
        //{
        //    if (FileHandler.TestContainInInconclusiveFile(TestContext.CurrentContext.Test.FullName.Split('.').Last()))
        //    {
        //        Assert.Inconclusive(TestContext.CurrentContext.Test.FullName + " Inconclusive");
        //    }
        //    else
        //    {
        //        Assert.Fail();
        //    }
        //}

        public void Ignore(string message)
        {
        }

        public void Inconclusive(string message)
        {
        }

        public void IsTrue(bool value)
        {
        }

        public void True(bool value)
        {
        }

        public void Pass()
        {
        }

        public void IsFalse(bool value)
        {
        }

        public void False(bool value)
        {
        }

        public void IsNotEmpty(IEnumerable collection)
        {
        }

        public void LessOrEqual<T>(T expected, T Actual)
        {
        }

        public void Less<T>(T expected, T Actual)
        {
        }

    }
}
