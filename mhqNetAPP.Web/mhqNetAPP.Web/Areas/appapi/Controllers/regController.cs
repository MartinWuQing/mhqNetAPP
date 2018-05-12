using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace mhqNetAPP.Web.Areas.appapi.Controllers
{
    [Area("appapi")]
    public class regController : Controller
    {
        // GET: APPAPI/Login 用户注册
        public IActionResult Index(string username, string password)
        {
            //前端判断后台也要判断用户名和密码是否为空等情况
            if (string.IsNullOrEmpty(username))
            {
                return Json(new { status = "n", info = "请输入用户名！" });
            }
            if (string.IsNullOrEmpty(password))
            {
                return Json(new { status = "n", info = "请输入密码！" });
            }

            //判断是否注册过
            DAL.UserDAL udal = new DAL.UserDAL();
            int x = udal.CalcCount("username=@username", new SqlParameter[] { new SqlParameter("@username", username) });

            if(x>0)
            {
                return Json(new { status = "n", info = "用户已被注册，请重新输入！" });
            }
            //否则就加入数据库
           int userid= udal.Add(new Model.User() { username = username, password = password });
            
            //语法糖 4.5以上才能用 ，原始的  info = "恭喜您（+username+）注册成功！" 

            return Json(
                new {
                    status = "y",
                    info = $"恭喜您（{username}）注册成功！",
                    userid = userid,
                    // face = Tool.GetHostUrl() + $"/{u.face}"  ,  //upload//aa.jpg -》http://mhqapp.net/upload/aa.jpg

                    face = "upload/face.jpg" ,
                    username = username,
                    usertype = "普通会员" 

                });

        }
    }
}