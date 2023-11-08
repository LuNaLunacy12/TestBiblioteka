using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProgramBibliary;


namespace TestsFromBibliary
{
    [TestClass]
    public class UnitTest1
    {
       // Проверка длины массива startTimes 
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, ProgramBibliary.ProgramBibliary.startTimes.Length );
        }
        // Проверка что каждый элемент массива startTimes имеет тип TimeSpan
        [TestMethod]
        public void TestMethod2()
        {
            foreach (TimeSpan time in ProgramBibliary.ProgramBibliary.startTimes)
            {
                Assert.IsInstanceOfType(time, typeof(TimeSpan));
            }
        }
        // Проверка что есть время начала работы сотрудника и оно равно 8 часам
        [TestMethod]
        public void TestMethod3()
        {
            TimeSpan expectedBeginWorkingTime = new TimeSpan(8, 0, 0);

            Assert.AreEqual(expectedBeginWorkingTime, ProgramBibliary.ProgramBibliary.beginWorkingTime);
        }
        // Проверить что есть время окончания работы равно 7 часам
        [TestMethod]
        public void TestMethod4()
        {
            TimeSpan expectedEndWorkingTime = new TimeSpan(18, 0, 0);

            Assert.AreEqual(expectedEndWorkingTime, ProgramBibliary.ProgramBibliary.endWorkingTime);
        }
        // значения каждого элемента массива startTimes соответствуют заданным значениям.
        [TestMethod]
        public void TestMethod5()
        {
            for (int i = 0; i < ProgramBibliary.ProgramBibliary.startTimes.Length; i++)
            {
                TimeSpan startTime = ProgramBibliary.ProgramBibliary.startTimes[i];

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
            for (int i = 0; i < ProgramBibliary.ProgramBibliary.duration.Length; i++)
            {
                int expectedDuration = i == 0 ? 60 : i == 1 ? 30 : i == 2 ? 10 : i == 3 ? 10 : i == 4 ? 40 : 0; 

                Assert.AreEqual(expectedDuration, ProgramBibliary.ProgramBibliary.duration[i]);
            }
        }
        // проверка что длина массивов одинкова
        [TestMethod]
        public void TestMethod7()
        {
            TimeSpan[] startTimes = ProgramBibliary.ProgramBibliary.startTimes;
            int[] duration = ProgramBibliary.ProgramBibliary.duration;

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

            Assert.AreEqual(expectedConsultationTime, ProgramBibliary.ProgramBibliary.consultationTime);
        }
        //
        [TestMethod]
        public void TestMethod9()
        {

        }
    }
}
