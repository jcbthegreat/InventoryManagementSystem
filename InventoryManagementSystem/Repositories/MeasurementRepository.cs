using InventoryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Repositories
{
    public class MeasurementRepository : BaseRepository,   IMeasurementRepository
    {
        private readonly SqlConnection connection;
        public MeasurementRepository(string connectionString)
        {
            this.connection = new SqlConnection(connectionString);
        }



        public IEnumerable<MeasurementModel> GetByValue(string measurementName, string code)
        {
            var measures = new List<MeasurementModel>();
            using (var cmd = new SqlCommand())
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * ";
                cmd.CommandText += " FROM [dbo].[IV_Measurement] mm " +
                    " WHERE mm.MeasurementName = @MeasurementName AND mm.Code = @Code";
                cmd.Parameters.Add("@MeasurementName", SqlDbType.VarChar).Value = measurementName;
                cmd.Parameters.Add("@Code", SqlDbType.VarChar).Value = code;
               
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var measure = new MeasurementModel();
                        measure.MeasurementName = reader["MeasurementName"].ToString();
                        measure.Code = reader["Code"].ToString();
                       
                        measures.Add(measure);
                    }
                }
            }

            connection.Close();
            return measures;
        }
    }
}