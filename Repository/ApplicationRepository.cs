using MongoDB.Bson;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ApplicationRepository
    {
        /// <summary>
        /// Gets all applications in the database
        /// </summary>
        /// <returns>A list of all applications in the db</returns>
        public static List<Application> GetApplications()
        {
            Database db = new Database();
            List<Application> applications = db.GetApplications();

            return applications;
        }

        public static void SaveApplication(Application application)
        {
            Database db = new Database();
            db.SaveApplication(application);
        }

        public static List<Application> GetApplicationsByResidenceId(ObjectId residenceId)
        {
            Database db = new Database();
            return db.GetApplicationsByResidenceId(residenceId);
        }
    }
}
