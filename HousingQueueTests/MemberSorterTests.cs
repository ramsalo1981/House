using HousingQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousingQueueTests
{
    [TestClass]
    public class MemberSorterTests
    {
        [TestMethod]
        [DataRow("Q", "1")]
        [DataRow("S", "2")]
        [DataRow("SP", "3")]
        public void TestSort(string sortParameter, string expectedName)
        {
            List<Member> members = new List<Member>()
            {
                new Member("1", 10, 5), // 50   // highest queuePoints
                new Member("2", 5, 50), // 250  // highest yearlySalary
                new Member("3", 9, 49)  // 441  // highest salaryPoints
            };

            members = MemberSorter.Sort(members, sortParameter);
            Assert.AreEqual(expectedName, members.Last().Name);
        }
    }
}
