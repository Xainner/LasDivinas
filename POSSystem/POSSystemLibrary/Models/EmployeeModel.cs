using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Models
{
    public class EmployeeModel
    {
        public int Id_Employee { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Identification_Type { get; set; }
        public string Identification { get; set; }
        public DateTime Born_Date { get; set; }
        public DateTime Registration_Date { get; set; }
    }
}
