using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebExamApplication.Models;

namespace WebExamApplication.Controllers
{
    public class ExamController : Controller
    {
        IApiClient apiClient;
        public ExamController()
        {
            apiClient = new WebApiClient();
        }

        // GET: Exam
        public ActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetExam()
        {
            List<VMtblExam> QuestionList = new List<VMtblExam>();
            try
            {
                string relativePath = "APIExam";
                var responseApi = await apiClient.GetAsync(relativePath);
                QuestionList = JsonConvert.DeserializeObject<List<VMtblExam>>(responseApi.Data);
            }
            catch (Exception ex)
            {

            }
            return Json(new { data = QuestionList }, JsonRequestBehavior.AllowGet);
        }
    }
}