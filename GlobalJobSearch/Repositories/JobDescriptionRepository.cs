﻿using GlobalJobSearch.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GlobalJobSearch.Repositories
{
    public class JobDescriptionRepository
    {
        public static bool AddJobDescriptionToDB(JobDescription jobDescription)
        {
            var connectionString = "Data Source=.;Initial Catalog=GlobalJobSearchApp;user id = sa; password = deep06";
            var query = "INSERT INTO JobDescriptionData(Country, Program, [Job Description]) Values ('@Country', '@Program', '@JobDescription')";

            query = query.Replace("@Country", jobDescription.Country)
                .Replace("@Program", jobDescription.Program)
                .Replace("@JobDescription", jobDescription.jobDescription);

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
    }
}