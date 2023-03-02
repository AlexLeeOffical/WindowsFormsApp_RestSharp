using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WindowsFormsApp2.API
{
    internal class APIResponse
    {

        public class PresentVehicle
        {
            public string LPN { get; set; }
            public DateTime EntryTime { get; set; }
        }

    }
}
