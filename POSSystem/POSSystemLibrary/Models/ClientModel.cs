using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Models
{
    public class ClientModel
    {
        public int Id_Client { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Identification_Type { get; set; }
        public string Identification { get; set; }
        public string Email { get; set; }
        public DateTime Born_Date { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
