using System.Data;
using System.Data.SqlClient;


namespace MedsoftExercise1.Repository
{
    class PatientRepository : BaseRepository
    {
        public void InsertOrUpdate(params SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = con.CreateCommand();
                command.CommandText = "InsertOrUpdatePatient_sp";
                command.CommandType = CommandType.StoredProcedure;
                foreach (var p in parameters)
                {
                    command.Parameters.Add(p);
                }
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();

                command.ExecuteScalar();
            }
        }
    }
}
