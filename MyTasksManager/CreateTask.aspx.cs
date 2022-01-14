using MyTasksManager.DataAccess;
using MyTasksManager.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTasksManager
{
    public partial class CreateTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                drop1.DataSource = TasksWebForm.loadUsers();
                drop1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime creationDate = DateTime.Now;

            int status = Convert.ToInt32(dropStatus.Text);
            int priority = Convert.ToInt32(dropPriority.Text);
            try
            {
                int isCreated = ProcessClass.CreateAssignment(txtTitle.Text, (Priority)priority, (Status)status, creationDate, ProcessClass.dateProcess(dateText.Text), drop1.Text);
                lblText.Text = "Assignment created successfuly";
            }
            catch
            {
                lblText.Text = "Please fill the form correctly";
            }

        }

    }
}