using Microsoft.VisualStudio.TestTools.UnitTesting;

using NaturalNumsLib;

using System;

namespace NaturalNUmsTests
{
    [TestClass]
    public class EvenTests
    {/// <summary>
     /// 
     /// </summary>
     /// <param name="Number"></param>
     /// <returns></returns>
        public static bool IsEven(int Number) => Number % 2 == 0;

        [TestMethod]
        public void TwoIsEvenNuber() // (eng) "2 - четное число"
        {
            // вызываем наш метод, чтобы получить фактический результат
            bool Result = NaturalNumbers.IsEven(2);
            // сравниваем с ожидаемым значением
            Assert.IsTrue(Result);
        }

        [TestMethod]
        public void FiveIsOdd() // 5 - нечетное
        {
            bool Result = NaturalNumbers.IsEven(5);
            // обратите внимание!
            // правильная работа функции должна дать для 5
            // значение false
            Assert.IsFalse(Result);
        }

        [TestMethod]
        public void Value2020IsEven() // значение 2020 - четное
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }

        [TestClass]
        public class GcdTests
        {
            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void SameValues()
            {
                // ожидаемое значение
                int Expected = 888;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(888, 888);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }


            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void DifValues()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(1, 888);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void OneDifTwo()
            {
                // ожидаемое значение
                int Expected = 15;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(45, 15);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void TwoDifOne()
            {
                // ожидаемое значение
                int Expected = 15;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(15, 45);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void DifGcd()
            {
                // ожидаемое значение
                int Expected = 8;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(24, 32);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void NoGcd()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.GCD(49, 50);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }
        }

        [TestClass]
        public class PrimeTests
        {
            [TestMethod]
            public void IsPrime()
            {
                // ожидаемое значение
                bool Expected = true;
                // фактическое значение, результат работы разработанного метода
                bool Actual = NaturalNumbers.IsPrime(37);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod]
            public void NoPrime()
            {
                // ожидаемое значение
                bool Expected = false;
                // фактическое значение, результат работы разработанного метода
                bool Actual = NaturalNumbers.IsPrime(36);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod]
            public void NumberIsNull()
            {
                // ожидаемое значение
                bool Expected = false;
                // фактическое значение, результат работы разработанного метода
                bool Actual = NaturalNumbers.IsPrime(0);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod]
            public void NumberIsNegative()
            {
                // ожидаемое значение
                bool Expected = false;
                // фактическое значение, результат работы разработанного метода
                bool Actual = NaturalNumbers.IsPrime(-1);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod]
            public void NumberIsOne()
            {
                // ожидаемое значение
                bool Expected = false;
                // фактическое значение, результат работы разработанного метода
                bool Actual = NaturalNumbers.IsPrime(1);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }
        }

        [TestClass]
        public class LCMTests
        {
            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void SameValues()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(888, 888);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }


            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void DifValues()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(1, 888);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void OneDifTwo()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(45, 15);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void TwoDifOne()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(15, 45);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void DifLCM()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(24, 32);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

            [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
            public void LCMIsOne()
            {
                // ожидаемое значение
                int Expected = 1;
                // фактическое значение, результат работы разработанного метода
                int Actual = NaturalNumbers.LCM(49, 50);
                // тест пройден, если они совпали
                Assert.AreEqual(Expected, Actual);
            }

        }
    }
}
