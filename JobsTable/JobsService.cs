using JobsTable.Controllers;
using JobsTable.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JobsTable.Services
{
    public class JobsService : IJobsService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]
            .ConnectionString;


        public List<JobsModel> GetAll()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var command = con.CreateCommand();
                command.CommandText = "JobsTable_GetAll";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    var results = new List<JobsModel>();
                    while (reader.Read())
                    {
                        var job = new JobsModel();
                        job.Id = (int)reader["Id"];
                        job.Company = (string)reader["Company"];
                        job.Position = (string)reader["Position"];
                        job.DateApplied = (string)reader["DateApplied"];
                        job.Website = (string)reader["Website"];
                        job.FollowUp = (string)reader["FollowUp"];
                        results.Add(job);
                    }
                    return results;
                }
            }
        }
        public int Create(JobsCreateModel model)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "JobsTable_Create";
                cmd.Parameters.AddWithValue("@Company", model.Company);
                cmd.Parameters.AddWithValue("@Position", model.Position);
                cmd.Parameters.AddWithValue("@DateApplied", model.DateApplied);
                cmd.Parameters.AddWithValue("@Website", model.Website);
                cmd.Parameters.AddWithValue("@FollowUp", model.FollowUp);
                cmd.Parameters.Add("@Id", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                return (int)cmd.Parameters["@Id"].Value;
            }
        }
    }
}