using MyTasksManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTasksManager
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            if(ProcessClass.connectedUser != null)
            {
                lblSignUp.Text = "Already Signed In";
            }
            else if(txtPassword.Text.Equals(txtConfirm.Text) && !txtUsername.Text.Equals("") && !txtPassword.Text.Equals(""))
            {
                int isCreated = 0;
                try
                {
                    isCreated = ProcessClass.CreateUser(txtUsername.Text, txtPassword.Text);
                }
                catch
                {
                    lblSignUp.Text = "Username Already Exist!";
                }
                if(isCreated == 1)
                {
                    Response.Redirect("TasksWebForm.aspx");
                }
            }
            else
            {
                lblSignUp.Text = "Please fill the form correctly";
            }
        }
    }
}