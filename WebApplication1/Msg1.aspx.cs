using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Msg1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // if (!IsPostBack)
            //{
            if (this.Page.PreviousPage != null)
            {

                
                int rowIndex = int.Parse(Request.QueryString["RowIndex"]);
                //  GridView GV = (GridView)this.Page.PreviousPage.FindControl("GridView1");
                DataRow dr = SentForm.dt.Rows[rowIndex];
                //GridViewRow row = GV.Rows[rowIndex];


                lblFrom.Text = dr[0].ToString();
                //lblFrom.Text =
                //  row.Cells[0].Text;
                lblSub.Text = dr[1].ToString();
                lblMsg.Text = dr[2].ToString();
                lblTime.Text = dr[3].ToString();
            }
        }
    }
}