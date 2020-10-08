using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Repository.Models
{
    public class Member
    {
        public ObjectId Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Queue points")]
        public int QueuePoints { get; set; }
        [Display(Name = "Yearly Salary")]
        public int YearlySalary { get; set; }
        public Enums.Status Status { get; set; } = Enums.Status.Active;
        [Display(Name = "Minimum Roos")]
        public int MinRooms { get; set; }
        [Display(Name = "Maximum Roos")]
        public int MaxRooms { get; set; }

        public Member()
        {

        }

        public Member(string name, int queuePoints, int yearlySalary)
        {
            Name = name;
            QueuePoints = queuePoints;
            YearlySalary = yearlySalary;
        }

        public int GetSalaryPoints()
        {
            return YearlySalary * QueuePoints;
        }
    }
}
