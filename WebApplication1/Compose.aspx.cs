using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class Compose : System.Web.UI.Page
    {
        public MessageDraft d = new MessageDraft();

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception e2)
            {
                int rowIndex = int.Parse(Request.QueryString["RowIndex"]);
                Constants.fl = int.Parse(Request.QueryString["Index"]);
                //  GridView GV = (GridView)this.Page.PreviousPage.FindControl("GridView1");
                DataRow dr = DraftsForm.dt.Rows[rowIndex];
                //GridViewRow row = GV.Rows[rowIndex];

                //MessageDraft d = new MessageDraft();
                string to = dr[0].ToString();
                //lblFrom.Text =
                //  row.Cells[0].Text;
                string SUB = dr[1].ToString();
                string MSG = dr[2].ToString();

                if (Constants.fl == 1)
                {
                    txtTo.Text = to;
                    txtSub.Text = SUB;
                    txtMsg.Text = MSG;
                    Constants.fl = 0;
                }


            }


        }
        
    
    

    protected void btnSend_Click(object sender, EventArgs e)
        {
            
            ComposeDetails d = new ComposeDetails();
            d.TO=txtTo.Text.ToString();
            d.SUB = txtSub.Text.ToString();
            d.MSG = txtMsg.Text.ToString();

            Constants.cd = d;
            Response.Redirect("/Main/compose");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MessageDraft d = new MessageDraft();
            d.TO=txtTo.Text.ToString();
            d.SUB = txtSub.Text.ToString();
            d.MSG = txtMsg.Text.ToString();
            Constants.md = d;
            Response.Redirect("/Main/MessageDraft");
        }
    }
}
