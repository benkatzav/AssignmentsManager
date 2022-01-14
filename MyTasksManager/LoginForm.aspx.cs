using MyTasksManager.DataAccess;
using MyTasksManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTasksManager
{
    public partial class LoginForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TasksWebForm.users = ProcessClass.LoadUsers(txtUser.Text);

            if (TasksWebForm.users.Count() == 1 && TasksWebForm.users[0].Username.Equals(txtUser.Text) && TasksWebForm.users[0].Password.Equals(txtPass.Text))
            {
                ProcessClass.connectedUser = TasksWebForm.users[0];
                lblText1.Text = "You've Successfully logged In";
                Response.Redirect("TasksWebForm.aspx");
            }
            else
            {
                lblText1.Text = "Wrong username or password";
            }
        }
    }
}