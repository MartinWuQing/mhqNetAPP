using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mhqNetAPP.Web.Models;

namespace mhqNetAPP.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //测试添加
            //new DAL.UserDAL().Add(new Model.User() { username = "kongkong", password = "123" });
            return Content("你好，Hello 约跑吧 ！");
        }

    }
}
