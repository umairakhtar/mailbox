using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Constants.flagi==1)
            {

                string script = "alert(\"INVALID LOGIN ATTEMPT\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Constants.flagi = 0;

            }
            if(Constants.al==1)
            {
                string script = "alert(\"Sign UP Succesfull Try to Login\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                Constants.al = 0;

            }

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if(UserText.Text.Equals("") && PassText.Text.Equals(""))
            {
                string script = "alert(\"FIELDS CANNOT BE LEFT BLANK\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script,true);
        
            }
            else
            {
                btnLogin.BackColor = System.Drawing.Color.Peru;
                //  Response.Redirect("http://localhost:51675/Inbox.aspx");



                Login1 l = new Login1();
                l.USERNAME = UserText.Text.ToString();
                l.PASSWORD = PassText.Text.ToString();

                Constants.d1 = l;
                Constants.abc = 1;



                Response.Redirect("/Main/LoginUser");

            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:51675/SignUp.aspx");
        }
    }
}