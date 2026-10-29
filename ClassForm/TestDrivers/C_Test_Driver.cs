using System;
using System.IO;
using TestDrivers;
using ClassLibrary1;

namespace TestDrivers
{
    public class CTest_Driver
    {
        CMassive? massTesting;
        StreamWriter log;
        string fileName = "logFile.dat";
        public CTest_Driver()
        {
            log = new StreamWriter(fileName, true);
            run();
        }
        private void run()
        {
            log.WriteLine("////////////////// Лог начат: " + DateTime.Now + "///////////////////");
            GetCount_WithPositiveAndNegativeNumbers_CorrectCount();
            GetCount_WithCorrectIndex_CorrectCount();
            GetCount_WithCorrectThreshold_CorrectCount();
            GetCount_WithOnlyPositiveNumbers_CorrectCount();
            GetCount_WithEmptyArray_CorrectCount();
            GetCount_WithOnlyNegativityNumbers_CorrectCount();
            log.WriteLine("////////////////// Лог окончен: " + DateTime.Now + "///////////////////");
            log.Flush();
            log.Close();
        }
        private void GetCount_WithPositiveAndNegativeNumbers_CorrectCount()
        {
            double[] testData = { 5.0, -6.0, 84.45, -2.89, 7.74, -9.78 };
            massTesting = new CMassive(testData);
            int result = massTesting.GetCount();
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + result);
        }
        private void GetCount_WithCorrectIndex_CorrectCount()
        {
            double[] testData = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            massTesting = new CMassive(testData);
            int rezult = massTesting.GetCount(2);
            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + rezult);
        }
        private void GetCount_WithCorrectThreshold_CorrectCount()
        {
            double[] testData = { -10.0, -3.0, -1.0, 5.0 };
            massTesting = new CMassive(testData);
            int rezult = massTesting.GetCount(-5.0);

            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + rezult);
        }
        private void GetCount_WithEmptyArray_CorrectCount()
        {
            double[] testData = { };
            massTesting = new CMassive(testData);

            int result = massTesting.GetCount();

            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + result);
        }
        private void GetCount_WithOnlyPositiveNumbers_CorrectCount()
        {
            double[] testData = { 1.5, 2.3, 3.8, 4.96, 5.56, 10.964, 20.789, 30.00 };
            massTesting = new CMassive(testData);

            int result = massTesting.GetCount(-100.0);

            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + result);
        }
        private void GetCount_WithOnlyNegativityNumbers_CorrectCount()
        {
            double[] testData = { -1.0, -2.0, -3.0, -4.0, -5.0, -10.0, -20.0 };
            massTesting = new CMassive(testData);

            int result = massTesting.GetCount(3);

            log.WriteLine(DateTime.Now + ": Метод: " + System.Reflection.MethodInfo.GetCurrentMethod() + ": Результат: " + result);
        }
    }
}