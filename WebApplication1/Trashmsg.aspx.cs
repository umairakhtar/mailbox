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
    public partial class Trashmsg : System.Web.UI.Page
    {

        int rowIndex;
        DataRow dr1;
        DataRow dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (!IsPostBack)
            //{
            if (this.Page.PreviousPage != null)
            {


                rowIndex = int.Parse(Request.QueryString["RowIndex"]);
                //  GridView GV = (GridView)this.Page.PreviousPage.FindControl("GridView1");
                //GridViewRow row = GV.Rows[rowIndex];
               // dr1 = Inbox.dt1.Rows[rowIndex];

                dr = TrashForm.dt.Rows[rowIndex];
                Constants.sn = dr[0].ToString();
                lblFrom.Text = dr[1].ToString();
                //lblFrom.Text =
                //  row.Cells[0].Text;
                lblSub.Text = dr[2].ToString();
                lblMsg.Text = dr[3].ToString();
                //lblTime.Text = dr[4].ToString();
            }
            //}
        }
    }
}
