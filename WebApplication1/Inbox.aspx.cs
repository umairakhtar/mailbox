using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

using WebApplication1.Models;
namespace WebApplication1
{
    public partial class Inbox : System.Web.UI.Page
    {
       public static DataTable dt = new DataTable();

        public int flag = 1;
        public static SqlConnection Conn;
        public static SqlDataAdapter mda=new SqlDataAdapter();
        public DataSet myDataSet;
        public SqlCommand cmd;
        string query;
        public SqlDataReader reader;
        public static DataTable dt1 = new DataTable();
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
            if(Constants.compose==1)
            {
                string script = "alert(\"YOUR MESSAGE SENT SUCCESSFULLY\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            if (!IsPostBack)
            {
                             bindGrid();
               
            }
                

          
        }
        public void bindGrid()
        {

            add();
            int a = connect();
            
            if (a == 1)
            {

                query = "select FromID,FromUser, MessageSubject, InboxMessage, Intime from "+Constants.d2.INBOXTBL+" where TrashFlag=0 and SpamFlag=0";
                cmd = new SqlCommand(query, Conn);

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
                Conn.Open();
                dt.Clear();
                mda.SelectCommand = new SqlCommand(query, Conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(mda);
                //mda.UpdateCommand = cb.GetUpdateCommand();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt2 = new DataTable();
                   //gv expects tabular source
                    dt.Load(reader);//so load reader into a data table
                  //  dt2.Load(reader);
                    
                    GridView1.DataSource = dt;//then set GV source to table
                    reader = cmd.ExecuteReader();
                    GridView1.DataBind();
                 
                }
                reader.Close();
                mda.Fill(dt);
            }
        }

        public void add()
        {
            int a = connect();
            if (a == 1)
            {

                query = "select FromID,FromUser, MessageSubject, InboxMessage, InDate,Intime,TrashFlag,ReadFlag,SpamFlag,outboxflag  from " + Constants.d2.INBOXTBL;
                cmd = new SqlCommand(query, Conn);

                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();
                }
                Conn.Open();
                dt1.Clear();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    //gv expects tabular source
                    dt1.Load(reader);//so load reader into a data table
                    reader = cmd.ExecuteReader();
                   
                }
                Conn.Close();
            }
        }

    }
}
