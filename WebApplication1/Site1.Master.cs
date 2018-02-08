using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
       
                    
                    
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            
        }

        protected void Compose_Click(object sender, EventArgs e)
        {
            Constants.abc = 0;
            Compose.BackColor = System.Drawing.Color.Red;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            


            Response.Redirect("http://localhost:51675/Compose.aspx");
        }


        protected void Inbox_Click(object sender, EventArgs e)
        {
            Constants.abc = 1;
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.Red;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            
            Response.Redirect("http://localhost:51675/Inbox.aspx");
        }

       
        

        protected void Sent_Click(object sender, EventArgs e)
        {
            Constants.abc = 0;
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.Red;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            
            Response.Redirect("http://localhost:51675/SentForm.aspx");

        }

        protected void Drafts_Click(object sender, EventArgs e)
        {
            Constants.abc = 0;
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.Red;
            
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            
            Response.Redirect("http://localhost:51675/DraftsForm.aspx");
        }

        

        protected void Trash_Click(object sender, EventArgs e)
        {
            Constants.abc = 0;
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            
            Trash.BackColor = System.Drawing.Color.Red;
            Spam.BackColor = System.Drawing.Color.LightBlue;
            
            Response.Redirect("http://localhost:51675/TrashForm.aspx");
        }

        protected void Spam_Click(object sender, EventArgs e)
        {
            Constants.abc = 0;
            Compose.BackColor = System.Drawing.Color.LightBlue;
            Inbox.BackColor = System.Drawing.Color.LightBlue;
            Sent.BackColor = System.Drawing.Color.LightBlue;
            Drafts.BackColor = System.Drawing.Color.LightBlue;
            
            Trash.BackColor = System.Drawing.Color.LightBlue;
            Spam.BackColor = System.Drawing.Color.Red;
            
            Response.Redirect("http://localhost:51675/SpamForm.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:51675/LOGIN.aspx");
        }
    }
}