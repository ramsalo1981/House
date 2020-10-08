using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HousingQueueTests
{
    [TestClass]
    public class MemberTests
    {
        [TestMethod]
        [DataRow(10, 10, 100), DataRow(100, 200, 20000), DataRow(500, 50, 25000)]
        public void TestMemberGetSalaryPoints(int salary, int points, int expected)
        {
            Member member = new Member("", salary, points);
            int salaryPoints = member.GetSalaryPoints();

            Assert.AreEqual(expected, salaryPoints);
        }


        
    }
}
