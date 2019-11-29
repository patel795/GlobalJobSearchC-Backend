using GlobalJobSearch.Models;
using GlobalJobSearch.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalJobSearch.Processors
{
    public class JobDescriptionProcessor
    {
        public static bool ProcessJobDescription(JobDescription jobDescription)
        {
            //Processing

            return JobDescriptionRepository.AddJobDescriptionToDB(jobDescription);
        }

        public static bool GetCompanyName()
        {
            //Processing

            return JobDescriptionRepository.getCompanyName();
        }
    }
}