using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExamApplication.Models
{
    public class ApiBaseUrl
    {
        string _baseUrl;
        public ApiBaseUrl()
        {
            _baseUrl = "http://localhost:6637/api/";
        }
        public string baseUrl { get { return _baseUrl; } private set {; } }
    }
}