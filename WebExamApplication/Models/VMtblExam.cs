using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExamApplication.Models
{
    public class VMtblExam
    {
        public int QueSr { get; set; }
        public string Question { get; set; }
        public string QOption1 { get; set; }
        public string QOption2 { get; set; }
        public string QOption3 { get; set; }
        public string QOption4 { get; set; }
        public string QAns { get; set; }
    }
}