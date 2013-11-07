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
        public void Login(LogOnModel user)
        {
            if (ModelState.IsValid)
            {
                Response.ContentType = "plain/text";
                Response.ContentEncoding = Encoding.UTF8;
                string clients = "param:'success'";
                byte[] byteArray = Encoding.UTF8.GetBytes(clients);
                Response.OutputStream.Write(byteArray, 0, byteArray.Length);
            }
        }
    }
}

// Content-Type: application/x-www-form-urlencoded

//{
//UserName : 'Иванов',
//Password : '123456',
//RememberMe : true
//}