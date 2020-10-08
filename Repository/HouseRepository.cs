using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class HouseRepository
    {
        /// <summary>
        /// Adds a house to the database
        /// </summary>
        /// <param name="house">The house to save to the db</param>
        public static void SaveHouse(House house)
        {
            Database db = new Database();
            db.SaveHouse(house);
        }

        /// <summary>
        /// Gets all houses from the database
        /// </summary>
        /// <returns>A list of all houses in the db</returns>
        public static List<House> GetHouses()
        {
            Database db = new Database();
            List<House> houses = db.GetHouses();

            return houses;
        }
    }
}
