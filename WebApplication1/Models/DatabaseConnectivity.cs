using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DatabaseConnectivity
    {




        public static SqlConnection con;
        public static SqlCommand cmd, cmd2;
        public static SqlDataReader reader;
        public static string query;
        public static DataTable dt1 = new DataTable();
        public static DataTable dt = new DataTable();

        public static int connect()
        {
            try
            {
                con = new SqlConnection(@"server=UMAIR\SQLEXPRESS;database=MD;integrated security=sspi");
                return 1;
            }
            catch (Exception e2)
            {
                return 0;
            }
        }

        public static int insert(SignUpDetails e1)
        {
            // query = "insert into emp values(" + t1.Text + ",'" + t2.Text + "'," + t3.Text + "," + t4.Text + ")";
            query = "insert into Users(FirstName,LastName,UserName,Password,DOB,Gender,MobileNo ,Country,InboxTable,SentTable,DraftTable) values(@FirstName,@LastName,@UserName,@Password,@DOB,@Gender,@MobileNo,@Country,@InboxTable,@SentTable,@DraftTable)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FirstName", e1.FIRSTNAME);
            cmd.Parameters.AddWithValue("@LastName", e1.LASTNAME);
            cmd.Parameters.AddWithValue("@UserName", e1.EMAIL);
            cmd.Parameters.AddWithValue("@Password", e1.PASSWORD);
            cmd.Parameters.AddWithValue("@DOB", e1.DOB);
            cmd.Parameters.AddWithValue("@Gender", e1.GENDER);
            cmd.Parameters.AddWithValue("@MobileNo", e1.PHONE);
            cmd.Parameters.AddWithValue("@Country", e1.COUNTRY);
            cmd.Parameters.AddWithValue("@InboxTable", e1.EMAIL + "inbox");
            cmd.Parameters.AddWithValue("@SentTable", e1.EMAIL + "sent");
            cmd.Parameters.AddWithValue("@DraftTable", e1.EMAIL + "draft");



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }









        public static int messagedraft(MessageDraft e1,SignUpDetails e2)
        {
        
            // query = "insert into emp values(" + t1.Text + ",'" + t2.Text + "'," + t3.Text + "," + t4.Text + ")";
            query = "insert into "+e2.EMAIL+"draft "+"(MessageSubject,InboxMessage,ToUser) values(@FirstName,@LastName,@UserName)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@FirstName", e1.SUB);
            cmd.Parameters.AddWithValue("@LastName", e1.MSG);
            cmd.Parameters.AddWithValue("@UserName", e1.TO);
           



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        
    }



















        public static int Create_UserSentTable(SignUpDetails e1)
        {
            //if (con.State == ConnectionState.Open)
            //{
            //    con.Close();
            //}
            //cmd = new SqlCommand("CreateSentTable", con);
            ////by default cmd executes text queries so we have to change its type to a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter p = new SqlParameter();//create new parameter
            //p.SqlDbType = SqlDbType.VarChar;//specify datatype
            //p.Direction = ParameterDirection.Input;//specify direction
            //p.ParameterName = "@tablename";//specify name
            //p.Value = e1.EMAIL+"sent";//assigning value to the i/p parameter above 5 lines=@eno int
            ////-->of sql
            //cmd.Parameters.Add(p);
            //con.Open();
            //reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}



            // query = "insert into emp values(" + t1.Text + ",'" + t2.Text + "'," + t3.Text + "," + t4.Text + ")";
            query = "create table " + e1.EMAIL + "sent " + "(SentID bigint identity(1,1) primary key, MessageSubject varchar(255), SentMessage varchar(1000), ToUser varchar(255), OutDate varchar(255), OutTime varchar(255) ,TrashFlag int,outboxflag int)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tbl", e1.EMAIL + "inbox");



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }



        public static int Create_UserInboxTable(SignUpDetails e1)
        {
            //if (con.State == ConnectionState.Open)
            //{
            //    con.Close();
            //}
            //cmd = new SqlCommand("CreateInboxTable", con);
            ////by default cmd executes text queries so we have to change its type to a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter p = new SqlParameter();//create new parameter
            //p.SqlDbType = SqlDbType.VarChar;//specify datatype
            //p.Direction = ParameterDirection.Input;//specify direction
            //p.ParameterName = "@tablename";//specify name
            //p.Value = e1.EMAIL+"inbox";//assigning value to the i/p parameter above 5 lines=@eno int
            ////-->of sql
            //cmd.Parameters.Add(p);
            //con.Open();
            //reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}



            query = "create table " + e1.EMAIL + "inbox " + "(FromID bigint identity(1,1) primary key, MessageSubject varchar(255), InboxMessage varchar(1000), FromUser varchar(255),InDate varchar(255), InTime varchar(255), TrashFlag int, ReadFlag int, SpamFlag int,outboxflag int)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@tbl", e1.EMAIL + "inbox");



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }








        public static int Create_UserDraftTable(SignUpDetails e1)
        {
            //if (con.State == ConnectionState.Open)
            //{
            //    con.Close();
            //}
            //cmd = new SqlCommand("CreateInboxTable", con);
            ////by default cmd executes text queries so we have to change its type to a stored procedure
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter p = new SqlParameter();//create new parameter
            //p.SqlDbType = SqlDbType.VarChar;//specify datatype
            //p.Direction = ParameterDirection.Input;//specify direction
            //p.ParameterName = "@tablename";//specify name
            //p.Value = e1.EMAIL+"inbox";//assigning value to the i/p parameter above 5 lines=@eno int
            ////-->of sql
            //cmd.Parameters.Add(p);
            //con.Open();
            //reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}



            query = "create table " + e1.EMAIL + "draft" + " (draftID bigint identity(1,1) primary key, MessageSubject varchar(255), InboxMessage varchar(1000), ToUser varchar(255))";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            //cmd.Parameters.AddWithValue("@tbl", e1.EMAIL + "inbox");



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }


        }


















        public static int update1(SignUpDetails d)
        {
            query = "update "+d.INBOXTBL+" set SpamFlag=1 where FromID="+Constants.sn;
            //create cmd with query + con
            cmd = new SqlCommand(query, con);
            int a = 0;

            

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static int updateTrash(SignUpDetails d)
        {
            query = "update " + d.INBOXTBL + " set TrashFlag=1 where FromID=" + Constants.sn;
            //create cmd with query + con
            cmd = new SqlCommand(query, con);
            int a = 0;



            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }






        public static int Login(Login1 e1)
        {
            query = "select * from Users where UserName=@username and Password=@pass";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", e1.USERNAME);
            cmd.Parameters.AddWithValue("@pass", e1.PASSWORD);
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            //execute created cmd over the connection
            //& store the result set in reader
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                SignUpDetails d = new SignUpDetails();
                d.EMAIL = reader[3].ToString();
                d.INBOXTBL = reader[9].ToString();
                d.SENTTBL = reader[10].ToString();
                d.DRAFTTABLE= reader[11].ToString();
                Constants.d2 = d;
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public static int inbox_load()
        {
            query = "select FromUser,InboxMessage,Intime from abcdinbox";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }   

            //open created connection
            con.Open();
            //execute created cmd over the connection
            //& store the result set in reader
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                DataTable dt = new DataTable();
                //gv expects tabular source
                dt.Load(reader);
                dt1.Load(reader);//so load reader into a data table
                                 //  GridView1.DataSource = dt;//then set GV source to table

                reader = cmd.ExecuteReader();//refill the exhausted reader
                                             //DataSet myDataSet = new DataSet();
                                             //mda.Fill(myDataSet);
                                             //GridView1.DataSource = myDataSet;
                                             // GridView1.DataBind();
                return 1;
            }
            else
            {
                return 0;
            }
        }

public static int Compose(ComposeDetails cd,SignUpDetails sd)
        {

            query = "insert into "+cd.TO+"inbox"+ " values(@a,@b,@c,@d,@e,@f,@g,@h,@i)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);
            int a = 0;
           

            cmd.Parameters.AddWithValue("@a",cd.SUB);
            cmd.Parameters.AddWithValue("@b", cd.MSG);
            cmd.Parameters.AddWithValue("@c", sd.EMAIL);
            cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString("D:MM:YY"));
            cmd.Parameters.AddWithValue("@e", DateTime.Now.ToString("H:MM:S"));
            cmd.Parameters.AddWithValue("@f",0 );
            cmd.Parameters.AddWithValue("@g", 0);
            cmd.Parameters.AddWithValue("@h", 0);
            cmd.Parameters.AddWithValue("@i", 0);


            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }




        public static int ComposeSend(ComposeDetails cd, SignUpDetails sd)
        {

            query = "insert into " + sd.EMAIL + "sent" + " values(@a,@b,@c,@d,@e,@f,@g)";
            //create cmd with query + con
            cmd = new SqlCommand(query, con);
            int a = 0;


            cmd.Parameters.AddWithValue("@a", cd.SUB);
            cmd.Parameters.AddWithValue("@b", cd.MSG);
            cmd.Parameters.AddWithValue("@c", cd.TO);
            cmd.Parameters.AddWithValue("@d", DateTime.Now.ToString("D:MM:YY"));
            cmd.Parameters.AddWithValue("@e", DateTime.Now.ToString("H:MM:S"));
            cmd.Parameters.AddWithValue("@f", 0);
            cmd.Parameters.AddWithValue("@g", 0);




            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            //open created connection
            con.Open();
            int ans = cmd.ExecuteNonQuery();
            if (ans > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    //    public static int outboxdata()
    //    {
           

    //}

    }
}