using System;
using System.Collections.Generic;
using System.Linq;
using Repository.Models;

namespace HousingQueue
{
    public class MemberSorter
    {
        public static List<Member> Sort(List<Member> members, string sortParameter)
        {
            if (sortParameter == "Q")
            {
                members = members.OrderBy(m => m.QueuePoints).ToList();
            }
            else if (sortParameter == "S")
            {
                members = members.OrderBy(m => m.YearlySalary).ToList();
            }
            else if (sortParameter == "SP")
            {
                members = members.OrderBy(m => m.GetSalaryPoints()).ToList();
            }

            return members;
        }
    }
}