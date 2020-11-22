using RunningClubServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace RunningClubServices.Dao
{
    public class MembersSqlDao : IMembersDao
    {
        private const string connectionString = "Data Source=TODD-PC\\SQLEXPRESS;Initial Catalog=RunningClub;Integrated Security=True;"; //Asynchronous Processing=true;";  



        public MembersSqlDao()
        {

        }


        public void Delete(MembersModel membersModel)
        {
            throw new NotImplementedException();
        }

        public List<MembersModel> Load()
        {

            //     String commandText = "Select Count([CourseID]) FROM [MySchool].[dbo].[Course] Where Year=@Year";

            var memberList = new List<MembersModel>();

            string queryString = "SELECT Id,FirstName,LastName FROM dbo.Members;";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var model = new MembersModel();
                        model.Id = (int)reader[0];
                        model.FirstName = (string)reader[1];
                        model.LastName = (string)reader[2];
                        memberList.Add(model);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

            }


            return memberList;

        }

        public MembersModel Load(int id)
        {

            var model = new MembersModel();
            string queryString = "SELECT Id,FirstName,LastName FROM dbo.Members Where id = @Id;";

            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var cmd = new SqlCommand(queryString, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        model.Id = (int)reader[0];
                        model.FirstName = (string)reader[1];
                        model.LastName = (string)reader[2];
                    }

                }
            }
            catch(Exception ex)
            {

            }


            return model;

        }

        public void Save(MembersModel membersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var transaction = connection.BeginTransaction())
            {

                transaction.Commit();
            }
        }

        public void Save(List<MembersModel> membersModels)
        {
            throw new NotImplementedException();
        }

        public void Update(MembersModel membersModel)
        {

            string commandText = "UPDATE Members SET first_name = @FirstName, last_name = @LastName Where id = @Id;";


             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@FirstName", membersModel.FirstName);
                command.Parameters.AddWithValue("@LastName", membersModel.LastName);
                command.Parameters.AddWithValue("@Id", membersModel.Id);
                try
                 {
                    connection.Open();
                    command.ExecuteNonQuery();
                    var rowsAffected = command.ExecuteNonQuery();
                   //  Console.WriteLine("RowsAffected: {0}", rowsAffected);
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine(ex.Message);
                 }
             }
            
        }
    }
}
