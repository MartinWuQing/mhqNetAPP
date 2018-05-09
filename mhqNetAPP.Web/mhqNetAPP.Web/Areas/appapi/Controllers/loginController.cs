using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace mhqNetAPP.Web.Areas.appapi.Controllers
{
    [Area("appapi")]
    
    public class loginController : Controller
    {      
        // GET: APPAPI/Login 用户登录
        public ActionResult Index(string username, string password)
        {
            //前端判断后台也要判断用户名和密码是否为空等情况
            if(string.IsNullOrEmpty(username))
            {
                return Json(new { status = "n", info = "请输入用户名！" });
            }
            if (string.IsNullOrEmpty(password))
            {
                return Json(new { status = "n", info = "请输入密码！" });
            }


            Model.User u = new DAL.UserDAL().GetModelByCond("username=@username and password=@password", new SqlParameter[] {
                new SqlParameter("@username",username),
                new SqlParameter("@password",password)
            });

            if (u !=null)
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