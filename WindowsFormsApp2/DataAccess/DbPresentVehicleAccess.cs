using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Controllers;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.DataAccess
{
    internal class DbPresentVehicleAccess
    {
        public VehicleModel GetPresentVehicle_ByLPN(string LPN)
        {
            DbAccess dbAccess = new DbAccess();
            VehicleModel result = null;

            string sql = $"Select * from VIEW_PRESENT_VEHICLES WHERE lpn LIKE '{LPN}'";

            try
            {
                using (SqlConnection connection = dbAccess.Connection())
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (!dr.HasRows) return null;

                        dr.Read();
                        result = new VehicleModel
                        {
                            LPN = dr["LPN"]?.ToString(),
                            EntryTime = Convert.ToDateTime(dr["EfZtpkt"])
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.ToString() + "\r\nType: " + ex.GetType().ToString());
            }
            return result;
        }
    }
}
