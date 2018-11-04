using JobsTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobsTable
{
    public class IJobsService
    {
        List<JobsModel> GetAll();
        int Create(JobsCreateModel model);

    }
}