using MongoDB.Bson;
using MongoDB.Driver;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    class Database
    {
        private const string MEMBERS_COLLECTION = "members";
        private const string RESIDENCES_COLLECTION = "residences";
        private const string APARTMENTS_COLLECTION = "apartments";
        private const string HOUSES_COLLECTION = "houses";
        private const string APPLICATIONS_COLLECTION = "applications";

        private readonly IMongoDatabase _database;

        public Database(string dbName = "housing-queue")
        {
            MongoClient dbClient = new MongoClient();

            _database = dbClient.GetDatabase(dbName);
        }

        internal void SaveApplication(Application application)
        {
            var collection = _database.GetCollection<Application>(APPLICATIONS_COLLECTION);
            collection.InsertOne(application);
        }

        internal List<Application> GetApplicationsByResidenceId(ObjectId residenceId)
        {
            var collection = _database.GetCollection<Application>(APPLICATIONS_COLLECTION);
            var findResult = collection.Find(a => a.ResidenceId == residenceId);
            return findResult.ToList();
        }

       

        internal Apartment GetApartmentById(ObjectId apartmentId)
        {
            var collection = _database.GetCollection<Apartment>(APARTMENTS_COLLECTION);
            var findResult = collection.Find(a => a.Id == apartmentId);
            return findResult.FirstOrDefault();
        }

        internal void DeleteApartmentById(ObjectId id)
        {
            var collection = _database.GetCollection<Apartment>(APARTMENTS_COLLECTION);
            collection.DeleteOne(a => a.Id == id);
        }


        /// <summary>
        /// Saves a member to the database
        /// </summary>
        /// <param name="member">The member to save</param>
        public void SaveMember(Member member)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);

            collection.InsertOne(member);
        }

        /// <summary>
        /// Saves a residence to the database
        /// </summary>
        /// <param name="residence">The residence to save</param>
        public void SaveResidence(Residence residence)
        {
            var collection = _database.GetCollection<Residence>(RESIDENCES_COLLECTION);

            collection.InsertOne(residence);
        }

        internal void DeleteMemberById(ObjectId id)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            collection.DeleteOne(m => m.Id == id);
        }



        /// <summary>
        /// Saves an apartment to the database
        /// </summary>
        /// <param name="apartment">The apartment to save</param>
        public void SaveApartment(Apartment apartment)
        {
            var collection = _database.GetCollection<Apartment>(APARTMENTS_COLLECTION);

            collection.InsertOne(apartment);
        }

        internal Member GetMemberById(ObjectId id)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            Member member = collection.Find(m => m.Id == id).FirstOrDefault();
            return member;
        }


        /// <summary>
        /// Gets all members from the database
        /// </summary>
        /// <returns>A list of all members in the database</returns>
        public List<Member> GetMembers()
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);

            var findResult = collection.Find(m => true);

            return findResult.ToList();
        }
        
        /// <summary>
        /// Gets all residences from the database
        /// </summary>
        /// <returns>A list of all residences in the database</returns>
        public List<Residence> GetResidences()
        {
            var collection = _database.GetCollection<Residence>(RESIDENCES_COLLECTION);

            var findResult = collection.Find(r => true);

            return findResult.ToList();
        }

        /// <summary>
        /// Deletes a user with the specified name
        /// </summary>
        /// <param name="name">Name of the user to delete</param>
        public void DeleteMemberByName(string name)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);

            collection.DeleteOne(m => m.Name == name);

        }

        /// <summary>
        /// Saves a house to the database
        /// </summary>
        /// <param name="house">The house to save</param>
        public void SaveHouse(House house)
        {
            var collection = _database.GetCollection<House>(HOUSES_COLLECTION);

            collection.InsertOne(house);
        }

        /// <summary>
        /// Gets all houses in the database
        /// </summary>
        /// <returns>A list of all houses in the db</returns>
        internal List<House> GetHouses()
        {
            var collection = _database.GetCollection<House>(HOUSES_COLLECTION);

            var findResult = collection.Find(h => true);

            return findResult.ToList();
        }

        /// <summary>
        /// Gets all apartments in the database
        /// </summary>
        /// <returns>A list of all apartments in the db</returns>
        internal List<Apartment> GetApartments()
        {
            var collection = _database.GetCollection<Apartment>(APARTMENTS_COLLECTION);

            var findResult = collection.Find(a => true);

            return findResult.ToList();
        }

        /// <summary>
        /// Gets all applications in the database
        /// </summary>
        /// <returns>A list of all applications in the db</returns>
        internal List<Application> GetApplications()
        {
            var collection = _database.GetCollection<Application>(APPLICATIONS_COLLECTION);

            var findResult = collection.Find(a => true);

            return findResult.ToList();
        }

        /// <summary>
        /// Updates a member in the database
        /// </summary>
        /// <param name="id">The id of the member to update</param>
        /// <param name="memberName">The updated name of the member</param>
        /// <param name="queuePoints">The updated queuePoints of the member</param>
        /// <param name="yearlySalary">The updated yearlySalary of the member</param>
        internal void UpdateMember(ObjectId id, string memberName, int queuePoints, int yearlySalary)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);

            UpdateDefinition<Member> update = Builders<Member>.Update
                .Set(m => m.Name, memberName)
                .Set(m => m.QueuePoints, queuePoints)
                .Set(m => m.YearlySalary, yearlySalary);

            collection.UpdateOne(m => m.Id == id, update);
        }
        //update member by id
        internal void UpdateMember(ObjectId id, Member member)
        {
            var collection = _database.GetCollection<Member>(MEMBERS_COLLECTION);
            UpdateDefinition<Member> update = Builders<Member>.Update
                .Set(m => m.Name, member.Name)
                .Set(m => m.QueuePoints, member.QueuePoints)
                .Set(m => m.YearlySalary, member.YearlySalary)
            .Set(m => m.Status, member.Status)
            .Set(m => m.MinRooms, member.MinRooms)
            .Set(m => m.MaxRooms, member.MaxRooms);
            collection.UpdateOne(m => m.Id == id, update);
        }

        internal void UpdateApartment(ObjectId id, Apartment apartment)
        {
            var collection = _database.GetCollection<Apartment>(APARTMENTS_COLLECTION);
            UpdateDefinition<Apartment> update = Builders<Apartment>.Update
                .Set(a => a.Floor, apartment.Floor)
                .Set(a => a.Address, apartment.Address)
                .Set(a => a.LivingArea, apartment.LivingArea)
                .Set(a => a.MonthlyCost, apartment.MonthlyCost)
            .Set(a => a.HasElevator, apartment.HasElevator);

            collection.UpdateOne(m => m.Id == id, update);
        }
    }
}
