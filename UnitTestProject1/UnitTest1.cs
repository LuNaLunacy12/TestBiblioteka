using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BibliaryLukina;


namespace TestsFromBibliary
{
    [TestClass]
    public class UnitTest1
    {
       // Проверка длины массива startTimes 
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, BibliaryLukina.ProgramBibliary.startTimes.Length );
        }
        // Проверка что каждый элемент массива startTimes имеет тип TimeSpan
        [TestMethod]
        public void TestMethod2()
        {
            foreach (TimeSpan time in BibliaryLukina.ProgramBibliary.startTimes)
            {
                Assert.IsInstanceOfType(time, typeof(TimeSpan));
            }
        }
        // Проверка что есть время начала работы сотрудника и оно равно 8 часам
        [TestMethod]
        public void TestMethod3()
        {
            TimeSpan expectedBeginWorkingTime = new TimeSpan(8, 0, 0);

            Assert.AreEqual(expectedBeginWorkingTime, BibliaryLukina.ProgramBibliary.beginWorkingTime);
        }
        // Проверить что есть время окончания работы равно 7 часам
        [TestMethod]
        public void TestMethod4()
        {
            TimeSpan expectedEndWorkingTime = new TimeSpan(18, 0, 0);

            Assert.AreEqual(expectedEndWorkingTime, BibliaryLukina.ProgramBibliary.endWorkingTime);
        }
        // значения каждого элемента массива startTimes соответствуют заданным значениям.
        [TestMethod]
        public void TestMethod5()
        {
            for (int i = 0; i < BibliaryLukina.ProgramBibliary.startTimes.Length; i++)
            {
                TimeSpan startTime = BibliaryLukina.ProgramBibliary.startTimes[i];

                if (i == 0)
                {
                    Assert.AreEqual(new TimeSpan(10, 0, 0), startTime);
                }
                else if (i == 1)
                {
                    Assert.AreEqual(new TimeSpan(11, 0, 0), startTime);
                }
                else if (i == 2)
                {
                    Assert.AreEqual(new TimeSpan(15, 0, 0), startTime);
                }
                else if (i == 3)
                {
                    Assert.AreEqual(new TimeSpan(15, 30, 0), startTime);
                }
                else if (i == 4)
                {
                    Assert.AreEqual(new TimeSpan(16, 50, 0), startTime);
                }
                
            }
        }
        // Проверка что значения массива duration соответствуют ожидаемым значениям.
        [TestMethod]
        public void TestMethod6()
        {
            for (int i = 0; i < BibliaryLukina.ProgramBibliary.duration.Length; i++)
            {
                int expectedDuration = i == 0 ? 60 : i == 1 ? 30 : i == 2 ? 10 : i == 3 ? 10 : i == 4 ? 40 : 0; 

                Assert.AreEqual(expectedDuration, BibliaryLukina.ProgramBibliary.duration[i]);
            }
        }
        // проверка что длина массивов одинкова
        [TestMethod]
        public void TestMethod7()
        {
            TimeSpan[] startTimes = BibliaryLukina.ProgramBibliary.startTimes;
            int[] duration = BibliaryLukina.ProgramBibliary.duration;

            if (startTimes.Length != duration.Length)
            {
                throw new Exception("Массивы startTimes и duration быть одинаковой длины");
            }

            return;
        }
        // проверка что время консультаций совпаает с 30 минутами
        [TestMethod]
        public void TestMethod8()
        {
            int expectedConsultationTime = 30;

            Assert.AreEqual(expectedConsultationTime, BibliaryLukina.ProgramBibliary.consultationTime);
        }
       
    }
}
