using JobsTable.Models;
using JobsTable.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JobsTable.Controllers
{
    public class JobsTableController : ApiController
    {
        readonly IJobsService jobsService;
        public JobsTableController(IJobsService jobsService)
        {
            this.jobsService = jobsService;
        }
        [Route("api/jobs"), HttpGet]
        public HttpResponseMessage GetAll()
        {
            var results = jobsService.GetAll();
            return Request.CreateResponse(HttpStatusCode.OK, results);
        }

        [Route("api/jobs"), HttpPost]
        public HttpResponseMessage Create(JobsCreateModel model)
        {
            if (model == null)
            {
                ModelState.AddModelError("", "You did not send any data!");
            }
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(
                    HttpStatusCode.BadRequest,
                    ModelState
                    );
            }
            IJobsService jobsService = new JobsService();
            int id = jobsService.Create(model);
            return Request.CreateResponse(HttpStatusCode.Created, id);
        }
    }
}

