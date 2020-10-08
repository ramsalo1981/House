using MongoDB.Bson;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ApartmentRepository
    {
        /// <summary>
        /// Adds an apartment to the database
        /// </summary>
        /// <param name="apartment">The apartment to add to the db</param>
        public static void SaveApartment(Apartment apartment)
        {
            Database db = new Database();
            db.SaveApartment(apartment);
        }

        /// <summary>
        /// Gets all apartments in the database
        /// </summary>
        /// <returns>A list of all apartments in the db</returns>
        public static List<Apartment> GetApartments()
        {
            Database db = new Database();
            List<Apartment> apartments = db.GetApartments();

            return apartments;
        }

        public static Apartment GetApartmentById(ObjectId apartmentId)
        {
            Database db = new Database();
            return db.GetApartmentById(apartmentId);
        }

        public static void UpdateApartment(ObjectId id, Apartment apartment)
        {
            Database db = new Database();
            db.UpdateApartment(id, apartment);
        }

        public static void DeleteApartmentById(ObjectId apartmentId)
        {
            Database db = new Database();
            db.DeleteApartmentById(apartmentId);
        }
    }
}
