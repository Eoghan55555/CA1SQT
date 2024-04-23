using Microsoft.VisualStudio.TestTools.UnitTesting;
using CA1SQT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace CA1SQT.Tests
{
    [TestClass()]
    public class InsuranceServiceTests
    {
        
        [TestMethod()]
        public void CalcPremiumTest1()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "";
            int age = 1;
            double expectedpremium = 0;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, expectedpremium);
        }
        [TestMethod()]
        public void CalcPremiumTest2()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "rural";
            int age = 1;
            double expectedpremium = 0;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, expectedpremium);
        }
        [TestMethod()]
        public void CalcPremiumTest3()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "rural";
            int age = 25;
            double expectedpremium = 5;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, expectedpremium);
        }
        [TestMethod()]
        public void CalcPremiumTest4()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "rural";
            int age = 60;
            double exectedpremium = 2;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, exectedpremium);
        }
        [TestMethod()]
        public void CalcPremiumTest5()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "urban";
            int age = 22;
            double exectedpremium = 6;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, exectedpremium);
        }
        [TestMethod()]
        public void CalcPremiumTest6()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(.8);
            InsuranceService insuranceService = new InsuranceService();
            string location = "urban";
            int age = 39;
            double exectedpremium = 5;
            //Act
            double premium = insuranceService.CalcPremium(age, location, mockDiscountService.Object);
            //Assert
            Assert.AreEqual(premium, exectedpremium);
        }
    }
}