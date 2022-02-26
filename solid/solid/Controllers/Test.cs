using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            //HttpContext.Session.SetString("group","p411");

            //Response.Cookies.Append("name", "mamed", new CookieOptions
            //{
            //    MaxAge = TimeSpan.FromMinutes(20)
            //});

            return View();
        }

        //public IActionResult GetSession()
        //{
        //    return Content(Request.Cookies[".AspNetCore.Session"]);
        //    string res = $"session: {HttpContext.Session.GetString("group")}, cookies: {Request.Cookies["name"]}";

        //    return Content(res);
        //}
    }
}
