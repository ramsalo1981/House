using MongoDB.Bson;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MemberRepository
    {
        /// <summary>
        /// Saves a member to the database
        /// </summary>
        /// <param name="member">The member to save to the db</param>
        public static void SaveMember(Member member)
        {
            Database db = new Database();
            db.SaveMember(member);
        }
        
        /// <summary>
        /// Get all members from the database
        /// </summary>
        /// <returns>A list of all members in the db</returns>
        public static List<Member> GetMembers()
        {
            Database db = new Database();
            List<Member> members = db.GetMembers();

            return members;
        }

        /// <summary>
        /// Deletes a member in the database
        /// </summary>
        /// <param name="name">The name of the member to delete</param>
        public static void DeleteMemberByName(string name)
        {
            Database db = new Database();
            db.DeleteMemberByName(name);
        }

        /// <summary>
        /// Updates a member in the database
        /// </summary>
        /// <param name="id">The id of the member to update</param>
        /// <param name="name">The updated name of the member</param>
        /// <param name="queuePoints">The updated queuePoints of the member</param>
        /// <param name="yearlySalary">The updated yearlySalary of the member</param>
        public static void UpdateMember(ObjectId id, string name, int queuePoints, int yearlySalary)
        {
            Database db = new Database();
            db.UpdateMember(id, name, queuePoints, yearlySalary);
        }

        public static Member GetMemberById(ObjectId id)
        {
            Database db = new Database();
            return db.GetMemberById(id);
        }
        // update member by id
        public static void UpdateMember(ObjectId id, Member member)
        {
            Database db = new Database();
            db.UpdateMember(id,member);
        }

        public static void DeleteMemberById(ObjectId memberId)
        {
            Database db = new Database();
            db.DeleteMemberById(memberId);
        }
    }
}
