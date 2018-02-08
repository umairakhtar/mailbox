using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult abc()
        {
            int a = DatabaseConnectivity.update1(Constants.d2);
            if(a==1)
            {
                Response.Redirect("http://localhost:51675/Inbox.aspx");
            }
            return View();

        }
        public ActionResult abc1()
        {
            int a = DatabaseConnectivity.updateTrash(Constants.d2);
            if (a == 1)
            {
                Response.Redirect("http://localhost:51675/Inbox.aspx");
            }
            return View();

        }

        public ActionResult compose()
        {
            try
            {
                int a = DatabaseConnectivity.Compose(Constants.cd, Constants.d2);
                int b = DatabaseConnectivity.ComposeSend(Constants.cd, Constants.d2);

                if (a == 1 && b == 1)
                {
                    Constants.compose = 1;
                    Response.Redirect("http://localhost:51675/Inbox.aspx");


                }
                else
                {


                }
            }
            catch (Exception e1)
            {

                throw;
            }
           
            return View();
        }



        public ActionResult LoginUser(Login1 e1)
        {
            int a = DatabaseConnectivity.connect();
            if (a == 1)
            {
                int lo = DatabaseConnectivity.Login(Constants.d1);
                if (lo == 1)
                {
                    Response.Redirect("http://localhost:51675/Inbox.aspx");
                }
                else
                {
                    Constants.flagi = 1;
                    Response.Redirect("http://localhost:51675/LOGIN.aspx");
                }

            }

            return View();
        }




        public ActionResult MessageDraft()
        {

            int a = DatabaseConnectivity.messagedraft(Constants.md,Constants.d2);
            if(a==1)
            {
                Response.Redirect("http://localhost:51675/Inbox.aspx");
            }
            return View();
        }




        public ActionResult CreateUser()
        {
            int a = DatabaseConnectivity.connect();
            int b = 0, sent = 0, inbox = 0;
            if (a == 1)
            {

                sent = DatabaseConnectivity.Create_UserSentTable(Constants.d);
                inbox = DatabaseConnectivity.Create_UserInboxTable(Constants.d);
                int draft = DatabaseConnectivity.Create_UserDraftTable(Constants.d);
                b = DatabaseConnectivity.insert(Constants.d);

                if (b == 1)
                {
                    Response.Redirect("http://localhost:51675/LOGIN.aspx");
                }
                else
                {
                    Response.Redirect("http://localhost:51675/SignUP.aspx");
                }

            }
            return View();
        }
    }
}