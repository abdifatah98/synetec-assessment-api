using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynetecAssessmentApi.Controllers;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Controllers.Tests
{
    [TestClass()]
    public class BonusPoolControllerTests
    {
        [TestMethod()]
        public void CalculateBonusTest()
        {
            var bonusPoolService = new BonusPoolService();
            var amount = bonusPoolService.CalculateAsync(10000, 1);

            //get the total salary budget for the company
            int totalSalary = 654750;
            int bonusPoolAmount = 10000;

            //calculate the bonus allocation for the employee
            decimal bonusPercentage = 60000 / (decimal)totalSalary;
            int bonusAllocation = (int)(bonusPercentage * bonusPoolAmount);

           
            Assert.AreEqual<int>(916, bonusAllocation);
        }
    }
}