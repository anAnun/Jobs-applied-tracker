using JobsTable.Models;
using System.Collections.Generic;

namespace JobsTable.Controllers
{
    public interface IJobsService
    {
        List<JobsModel> GetAll();
        int Create(JobsCreateModel model);

    }
}