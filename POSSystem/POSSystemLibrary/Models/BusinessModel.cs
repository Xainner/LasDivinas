using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POSSystemLibrary.Models
{
    public class BusinessModel
    {
        public int Id_Business { get; set; }
        public string Name { get; set; }
        public string Society_Name { get; set; }
        public string LegalCertification { get; set; }
        public string Telephone { get; set; }
        public string Main_Address { get; set; }
        public string Email { get; set; }
        public string WebPage { get; set; }
        public byte[] Logo { get; set; }
    }
}
