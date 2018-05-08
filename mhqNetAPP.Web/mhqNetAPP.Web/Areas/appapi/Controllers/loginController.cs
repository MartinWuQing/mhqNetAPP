using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace mhqNetAPP.Web.Areas.appapi.Controllers
{
    [Area("appapi")]
    
    public class loginController : Controller
    {
       
        // GET: APPAPI/Login 用户登录
        public ActionResult Index(string username, string password)
        {
            if (username == "mhq" && password == "123")
            {
                return Json(new { status = "y", info = "恭喜你登录成功！" });
                //登录成功
            }
            else
            {
                return Json(new { status = "n", info = "登录失败！" });
            }
        }
    }
}