using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class Application
    {
        public ObjectId Id { get; set; }
        public ObjectId MemberId { get; set; }
        public ObjectId ResidenceId { get; set; }

        public Application(ObjectId memberId, ObjectId residenceId)
        {
            MemberId = memberId;
            ResidenceId = residenceId;
        }
    }
}
