using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using ChessClient.Models;

namespace ChessClient.Controllers
{
    [HandleError]
    public class AuthenticateController : Controller
    {
        [HttpGet]
        public void Login2(int id)
        {
            Response.ContentType = "plain/text";
            Response.ContentEncoding = Encoding.UTF8;
            string clients = "get-запрос";
            byte[] byteArray = Encoding.UTF8.GetBytes(clients);
            Response.OutputStream.Write(byteArray, 0, byteArray.Length); 
        }

        [HttpPost]
        public JsonResult Login(LogOnModel user)
        {
            if (ModelState.IsValid)
            {



                return Json(new TestModels { Foo = "trololo" });//new { Result = "Success" });
            }
            return Json(new { Result = "Dada validation error" });
        }
    }
}
