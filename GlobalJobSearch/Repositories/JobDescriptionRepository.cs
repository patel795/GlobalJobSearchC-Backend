using GlobalJobSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GlobalJobSearch.Repositories
{
    public class JobDescriptionRepository
    {
        public static bool getSQLConnection(string query)
        {
            var connectionString = "Data Source=dbr.fast.sheridanc.on.ca;Initial Catalog=section8;user id = s8u26; password = Sher1dan";
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                return true;
            }
            catch (Exception)
            {
                //throw
                return false;
            }
        }
        public static bool AddJobDescriptionToDB(JobDescription jobDescription)
        {
            var query = "INSERT INTO JobDescriptionData(Country, Program, [Job Description], CompanyName, Language) Values ('@Country', '@Program', '@JobDescription', '@CompanyName', '@Language')";

            query = query.Replace("@Country", jobDescription.Country)
                .Replace("@Program", jobDescription.Program)
                .Replace("@JobDescription", jobDescription.jobDescription)
                .Replace("@CompanyName", jobDescription.CompanyName)
            .Replace("@Language", jobDescription.language) ;

            return getSQLConnection(query);
        }

        public static bool getCompanyName()
        {
            var query = "Select CompanyName from JobDescriptionData";

            return getSQLConnection(query);
        }
    }
}