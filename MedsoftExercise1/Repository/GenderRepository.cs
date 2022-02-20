using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace MedsoftExercise1.Repository
{
    class GenderRepository : BaseRepository
    {
        public int GetGenderID(string GenderName)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = "GetGenderID_sp";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@GenderName", Value = GenderName });
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                return (int)command.ExecuteScalar();
            } 
        }

        public string GetGender(int id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = "GetGender_sp";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter { ParameterName = "@GenderID", Value = id });
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                return command.ExecuteScalar().ToString();
            }

        }
    }
}
