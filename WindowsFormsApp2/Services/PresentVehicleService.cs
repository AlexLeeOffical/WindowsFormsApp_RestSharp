using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Controllers;
using WindowsFormsApp2.DataAccess;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Services
{
    internal class PresentVehicleService
    {
        public VehicleModel Get_PresentVehicle_ByLPN(String LPN)
        {
            DbPresentVehicleAccess dbPresentVehicle = new DbPresentVehicleAccess();
            VehicleModel presentVehicle = dbPresentVehicle.GetPresentVehicle_ByLPN(LPN);

            return presentVehicle;
        }


    }
}
