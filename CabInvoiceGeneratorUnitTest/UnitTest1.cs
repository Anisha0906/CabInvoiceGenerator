using CabInvoiceGenerator;
using CabInvoiceGeneratorTest;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void GivenDistanceAndTimeToInvoiceGenerator_WhenCalculate_ShouldReturnTotalFare()
        {
            double cabRunningDistance = 5.0;
            double cabRunningTime = 2.0;
            InvoiceGenerator invoice = new InvoiceGenerator();
            Assert.AreEqual(52, invoice.CalculateCabFare(cabRunningDistance, cabRunningTime));
        }

        [Test]
        public void GivenDistanceAndTimeToInvoiceGenerator_WhenCalculate_ShouldReturnMinimumFare()
        {
            double cabRunningDistance = 0.1;
            double cabRunningTime = 1.0;
            InvoiceGenerator invoice = new InvoiceGenerator();
            Assert.AreEqual(5, invoice.CalculateCabFare(cabRunningDistance, cabRunningTime));
        }
        [Test]
        public void GivenDistanceAndTimeOfMultiRidesToInvoiceGenerator_WhenCalculate_ShouldReturnTotalFare()
        {
            Ride[] rides =
                {
                new Ride(2.0,1.0),
                new Ride(2.5,1.5)
                };
            InvoiceGenerator invoice = new InvoiceGenerator();
            Assert.AreEqual(47.5, invoice.CalculateCabFare(rides));
        }
    }
}