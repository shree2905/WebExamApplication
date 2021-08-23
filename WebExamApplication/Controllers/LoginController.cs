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
    public class LoginController : Controller
    {
        IApiClient apiClient;
        public LoginController()
        {
            apiClient = new WebApiClient();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<JsonResult> Login(VMtblLogin reg)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string relativePath = "APILogin";
                    var responseApi = await apiClient.PostAsync(relativePath, reg);
                    reg = JsonConvert.DeserializeObject<VMtblLogin>(responseApi.Data);
                }
                catch (Exception ex)
                {
                }
                return Json(reg);
                //var details = (from userlist in db.Users
                //               where userlist.userName.Equals(reg.userName) && userlist.userPwd.Equals(reg.userPwd)
                //               select new
                //               {
                //                   userlist.userId,
                //                   userlist.userName,
                //                   userlist.IsActive,
                //                   userlist.IsAdmin
                //               }).ToList();
                //string result = "";
                //if (details.FirstOrDefault() != null)
                //{
                //    Session["Username"] = details.FirstOrDefault().userName;
                //    if (details.FirstOrDefault().IsAdmin == true)
                //    {
                //        Session["UserId"] = details.FirstOrDefault().userId;
                //        result = "Admin";
                //    }
                //    else if (details.FirstOrDefault().IsActive == true)
                //    {
                //        result = "User";
                //    }
                //    else
                //    {

                //        result = "You are not Active Yet";
                //    }
                //}
                //else
                //{
                //    result = "Invalid Credentials!!!!!!!";
                //}
                //return Content(result);
            }
            return Json("Please Fill both the Fields!!!");
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> Register(VMtblRegistration reg)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    string relativePath = "APIRegistration";
                    var responseApi = await apiClient.PostAsync(relativePath, reg);
                    reg = JsonConvert.DeserializeObject<VMtblRegistration>(responseApi.Data);
                }
                catch (Exception ex)
                {
                }
                return Json(reg);
            }
            return Json(reg);
        }
    }
}