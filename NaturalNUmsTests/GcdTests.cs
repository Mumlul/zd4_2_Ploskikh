using Microsoft.VisualStudio.TestTools.UnitTesting;
using NaturalNumsLib;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNUmsTests
{
    [TestClass]
    public class GcdTests
    {
        [TestMethod]
        // важно написать [Test], чтобы метод был виден как тестовый!
        public void SameValues()
        {
            // ожидаемое значение
            int Expected = 888;
            // фактическое значение, результат работы разработанного метода
            int Actual = NaturalNumbers.GCD(888, 888);
            // тест пройден, если они совпали
            Assert.AreEqual(Expected, Actual);
        }
    }
   
}
