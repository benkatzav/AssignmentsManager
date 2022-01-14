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
    public partial class EditTask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtTitle.Text = Session["title"].ToString();
                dateText.Text = Session["date"].ToString();

                dropUsers.DataSource = TasksWebForm.loadUsers();
                dropUsers.DataBind();
            }
        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                int isEdited = ProcessClass.EditAssignment(Convert.ToInt32(Session["id"].ToString()), txtTitle.Text, (Priority)Convert.ToInt32(dropPriority.Text), (Status)Convert.ToInt32(dropStatus.Text), ProcessClass.dateProcess(dateText.Text), dropUsers.Text);
                lblText.Text = "Assignment created successfuly";
            }
            catch
            {
                lblText.Text = "Please fill the form correctly";
            }
        }
    }
}