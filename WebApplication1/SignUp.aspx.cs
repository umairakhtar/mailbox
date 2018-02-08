using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;
namespace WebApplication1
{
    public partial class SignUP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Calender1_SelectionChanged(object sender, EventArgs e)
        {
            txtDOB.Text = Calender1.SelectedDate.ToLongDateString();
            Calender1.Visible = false;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Calender1.Visible = true;
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            //Response.Redirect("http://localhost:51675/InboxForm.aspx");

            btnSignUp.BackColor = System.Drawing.Color.Red;

            // Response.Redirect("http://localhost:51675/InboxForm.aspx");


            SignUpDetails d = new SignUpDetails();
            d.FIRSTNAME = txtFirst.Text.ToString();
            d.LASTNAME = txtLast.Text.ToString();
            d.EMAIL = txtEmail.Text.ToString();
            d.PASSWORD = txtPass.Text.ToString();
            d.COUNTRY = txtCountry.Text.ToString();
            d.DOB = txtDOB.Text.ToString();
            d.GENDER = RadioButtonList1.Text.ToString();

            d.PHONE = int.Parse(txtMobile.Text);

            Constants.d = d;

            Response.Redirect("/Main/CreateUser");

        }

        protected void txtDOB_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void txtFirst_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            //Loop through all the control present on the web page/form        
            foreach (Control ctrl in form1.Controls)
            {
                //check for all the TextBox controls on the page and clear them
                if (ctrl.GetType() == typeof(TextBox))
                {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
                //check for all the Label controls on the page and clear them
                else if (ctrl.GetType() == typeof(Label))
                {
                    ((Label)(ctrl)).Text = string.Empty;
                }
                //check for all the DropDownList controls on the page and reset it to the very first item e.g. "-- Select One --"
                else if (ctrl.GetType() == typeof(DropDownList))
                {
                    ((DropDownList)(ctrl)).SelectedIndex = 0;
                }
                //check for all the CheckBox controls on the page and unchecked the selection
                else if (ctrl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
                //check for all the CheckBoxList controls on the page and unchecked all the selections
                else if (ctrl.GetType() == typeof(CheckBoxList))
                {
                    ((CheckBoxList)(ctrl)).ClearSelection();
                }
                //check for all the RadioButton controls on the page and unchecked the selection
                else if (ctrl.GetType() == typeof(RadioButtonList))
                {
                    ((RadioButtonList)(ctrl)).ClearSelection();
                }
                else if (ctrl.GetType() == typeof(Calendar))
                {
                    ((Calendar)(ctrl)).Dispose();
                }

            }
        }

    }
}