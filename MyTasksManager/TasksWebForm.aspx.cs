using MyTasksManager.DataAccess;
using MyTasksManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyTasksManager
{
    public partial class TasksWebForm : System.Web.UI.Page
    {
        private DataTable dtAssignments = null;
        public static List<Assignment> assignments = null;
        public static List<User> users = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnDelete.BackColor = Color.Salmon;

            if (ProcessClass.connectedUser != null)
            {
                btnRegister.Visible = false;
                btnLogin.Visible = false;
                lblText2.Text = "Hello " + ProcessClass.connectedUser.Username;
            }
            else
            {
                btnLogOut.Visible = false;
            }

            assignments = ProcessClass.LoadAssignments();
            users = ProcessClass.LoadUsers();

            if (!IsPostBack)
            {
                dropUsers.DataSource = loadUsers();
                dropUsers.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FillAssignments(dropUsers.SelectedItem.Text);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            FillAssignments();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (ProcessClass.connectedUser == null)
            {
                lblText2.Text = "You must Log In first";
            }
            else
            {
                Response.Redirect("CreateTask.aspx");
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            ProcessClass.connectedUser = null;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int deleted = ProcessClass.DeleteAssignment(Convert.ToInt32(GridBox1.SelectedRow.Cells[1].Text));
            Response.Redirect(Request.RawUrl);
        }

        private void FillAssignments(string uid = "")
        {
            dtAssignments = new DataTable();
            char deli = ',';
            List<string[]> tasksList = new List<string[]>();
            if(uid.Equals(""))
            {
                foreach (Assignment task in assignments)
                {
                    tasksList.Add(task.ToString().Split(deli));
                }
            }
            else
            {
                foreach (Assignment task in assignments)
                {
                    if(task.responsibleUser.Equals(uid))
                    {
                        tasksList.Add(task.ToString().Split(deli));
                    }
                }
            }

            dtAssignments.Columns.Add("ID");
            dtAssignments.Columns.Add("Title");
            dtAssignments.Columns.Add("Priority");
            dtAssignments.Columns.Add("Status");
            dtAssignments.Columns.Add("Created At");
            dtAssignments.Columns.Add("Deadline");
            dtAssignments.Columns.Add("Responsible User");

            for(int i = 0; i < tasksList.Count; i++)
            {
                dtAssignments.Rows.Add(tasksList[i][0], tasksList[i][1], tasksList[i][2], tasksList[i][3], tasksList[i][4], tasksList[i][5], tasksList[i][6]);
            }
            GridBox1.DataSource = dtAssignments;
            GridBox1.DataBind();
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ProcessClass.connectedUser == null)
            {
                lblText2.Text = "You must Log In first";
            }
            else
            {
                Session["id"] = GridBox1.SelectedRow.Cells[1].Text;
                Session["title"] = GridBox1.SelectedRow.Cells[2].Text;
                Session["date"] = GridBox1.SelectedRow.Cells[6].Text;

                Response.Redirect("EditTask.aspx");
            }
        }

        protected void GridBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
        }

        public static List<string> loadUsers()
        {
            List<string> stringList = new List<string>();
            foreach (User user in users)
            {
                stringList.Add(user.Username);
            }
            return stringList;
        }
    }
}