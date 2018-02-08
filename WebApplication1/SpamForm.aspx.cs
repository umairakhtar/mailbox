using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class SpamForm : System.Web.UI.Page
    {


        public static DataTable dt = new DataTable();
        public int flag = 1;
        public static SqlConnection Conn;
        public SqlDataAdapter mda;
        public DataSet myDataSet;
        public SqlCommand cmd;
        string query;
        public SqlDataReader reader;
        public DataTable dt1 = new DataTable();
        public static int connect()
        {
            try
            {
                Conn = new SqlConnection(@"server=UMAIR\SQLEXPRESS;database=MD;integrated security=sspi");
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                bindGrid();
        }
        public void bindGrid()
        {
            int a = connect();
            if (a == 1)
            {

                query = "select FromUser, MessageSubject, InboxMessage, Intime  from " + Constants.d2.INBOXTBL+" where SpamFlag=1";
                cmd = new SqlCommand(query, Conn);

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
                Conn.Open();
                dt.Clear();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    //gv expects tabular source
                    dt.Load(reader);//so load reader into a data table
                    GridView1.DataSource = dt;//then set GV source to table
                    reader = cmd.ExecuteReader();
                    GridView1.DataBind();
                }
            }
        }


    }
}