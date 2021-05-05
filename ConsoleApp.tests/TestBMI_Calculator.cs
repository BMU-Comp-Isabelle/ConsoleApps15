using System;
using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp.tests
{
    [TestClass]
    public class TestBMI_Calculator
    {
        // Metric Tests
        [TestMethod]
        public void TestMetricUnderweightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.93;
            calculator.Weight = 45.5;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 12.22);
        }

        [TestMethod]
        public void TestMetricUnderweightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.57;
            calculator.Weight = 45.5;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 18.46);
        }

        [TestMethod]
        public void TestMetricNormalWeightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.93;
            calculator.Weight = 70.5;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 18.93);
        }

        [TestMethod]
        public void TestMetricNormalWeightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 56.8;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 24.26);
        }

        [TestMethod]
        public void TestMetricOverWeightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.93;
            calculator.Weight = 93.2;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 25.02);
        }

        [TestMethod]
        public void TestMetricOverWeightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 68.2;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 29.13);
        }

        [TestMethod]
        public void TestMetricObeseIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.83;
            calculator.Weight = 97.7;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 29.17);
        }

        [TestMethod]
        public void TestMetricObeseIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 90.9;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 38.83);
        }

        [TestMethod]
        public void TestMetricObeseIIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.55;
            calculator.Weight = 97.7;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 40.67);
        }

        [TestMethod]
        public void TestMetricObeseIIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 97.7;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 41.74);
        }

        [TestMethod]
        public void TestMetricObeseIIIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 100;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 42.72);
        }

        [TestMethod]
        public void TestMetricObeseIIIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 1.53;
            calculator.Weight = 181.4;

            calculator.CalculateMetric();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 77.49);
        }


        // Imperial Tests
        [TestMethod]
        public void TestImperialUnderweightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 75.98;
            calculator.Weight = 100.3;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 12.21);
        }

        [TestMethod]
        public void TestImperialUnderweightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 61.81;
            calculator.Weight = 100.3;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 18.46);
        }

        [TestMethod]
        public void TestImperialNormalWeightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 75.98;
            calculator.Weight = 155.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 18.92);
        }

        [TestMethod]
        public void TestImperialNormalWeightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 125.2;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 24.25);
        }

        [TestMethod]
        public void TestImperialOverWeightMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 75.98;
            calculator.Weight = 205.5;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 25.02);
        }

        [TestMethod]
        public void TestImperialOverWeightMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 150.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 29.14);
        }

        [TestMethod]
        public void TestImperialObeseIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 72.05;
            calculator.Weight = 215.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 29.17);
        }

        [TestMethod]
        public void TestImperialObeseIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 200.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 38.82);
        }

        [TestMethod]
        public void TestImperialObeseIIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 61.02;
            calculator.Weight = 215.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 40.67);
        }

        [TestMethod]
        public void TestImperialObeseIIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 215.4;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 41.73);
        }

        [TestMethod]
        public void TestImperialObeseIIIMin()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 220.5;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 42.72);
        }

        [TestMethod]
        public void TestImperialObeseIIIMax()
        {
            BMI_Calculator calculator = new BMI_Calculator();

            calculator.Height = 60.24;
            calculator.Weight = 399.9;

            calculator.CalculateImperial();
            double index = Math.Round(calculator.BMI_Index, 2);

            Assert.AreEqual(index, 77.47);
        }
    }
}
        