using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group6.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public string TokenNo { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        
    }
}