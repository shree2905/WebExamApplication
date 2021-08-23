using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExamApplication.Models
{
    public class VMtblRegistration
    {
        public int RegId { get; set; }
        public string FirstNameName { get; set; }
        public string LastNameName { get; set; }
        public string CollegeName { get; set; }
        public string Branch { get; set; }
        public string Semester { get; set; }
        public string Email { get; set; }
        public System.DateTime DOB { get; set; }
    }
}