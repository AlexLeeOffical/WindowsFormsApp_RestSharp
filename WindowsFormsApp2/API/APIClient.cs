using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.API
{
    internal class APIClient
    {
        public VehicleModel PresentVehicle_GET_ByLPN(string LPN)
        {
            VehicleModel presentVehicle = null;

            var client = new RestClient("https://localhost:10443");
            
            var request = new RestRequest("api/PresentVehicle/{LPN}", Method.Get);
            request.AddUrlSegment("LPN", LPN);

            var respone = client.Execute(request);

            if(respone.StatusCode != System.Net.HttpStatusCode.OK) 
            { 
                MessageBox.Show(respone.ErrorMessage);
                return presentVehicle;
            }

            presentVehicle = JsonConvert.DeserializeObject<VehicleModel>(respone.Content);
            return presentVehicle;
        }
    }
}
