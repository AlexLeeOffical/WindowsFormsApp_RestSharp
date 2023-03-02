using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.API;
using WindowsFormsApp2.Models;
using WindowsFormsApp2.Services;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string LPN = tboxLPN.Text;
            //PresentVehicleService service = new PresentVehicleService();
            //VehicleModel result = service.Get_PresentVehicle_ByLPN(LPN);

            if (LPN == "") return;
            //if (result == null) return;

            //lblLPN_Output.Text = result.LPN.ToString();
            //lblDateTime_Output.Text = result.EntryTime.ToString();


            // Service Call API, MainFrm call Service return Model.
            APIClient apiClient = new APIClient();
            VehicleModel presentVehicle = apiClient.PresentVehicle_GET_ByLPN(LPN);
            lblLPN_Output.Text = presentVehicle.LPN.ToString();
            lblDateTime_Output.Text = presentVehicle.EntryTime.ToString();
        }
    }
}
