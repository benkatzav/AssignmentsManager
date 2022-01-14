using MyTasksManager.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MyTasksManager.DataAccess
{
    public static class ProcessClass
    {
        public static User connectedUser = null;
        public static int CreateAssignment(string aTitle, Priority aPriority, Status aStatus, DateTime aCreationDate, DateTime aDeadlineDate, string aResponsibleUser)
        {
            Assignment data = new Assignment(aTitle, aPriority, aStatus, aCreationDate, aDeadlineDate, aResponsibleUser);

            string sql = @"INSERT INTO dbo.Assignments (Title, Priority, Status, CreationDate, DeadlineDate, ResponsibleUser)
                            values ('"+ aTitle + "', '" + (int)aPriority + "', '" + (int)aStatus + "', '" + aCreationDate.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture) + "', '" + aDeadlineDate.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture) + "', '" + @aResponsibleUser + "');";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static int DeleteAssignment(int aId)
        {
            string sql = @"DELETE FROM dbo.Assignments WHERE Id='" + @aId + "';";
            return SqlDataAccess.Execute(sql);
        }

        public static int EditAssignment(int aId, string aTitle, Priority aPriority, Status aStatus, DateTime aDeadlineDate, string aResponsibleUser)
        {
            string sql = @"UPDATE dbo.Assignments
                            SET Title='" + aTitle + "', Priority='" + (int)aPriority + "', Status='" + (int)aStatus + "', DeadlineDate='" + aDeadlineDate.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture) + "', ResponsibleUser='" + @aResponsibleUser +
                            "' WHERE Id='" + @aId + "';";
            return SqlDataAccess.Execute(sql);
        }

        public static List<Assignment> LoadAssignments()
        {
            string sql = @"SELECT Id, Title, Priority, Status, CreationDate, DeadlineDate, ResponsibleUser FROM dbo.Assignments;";
            return SqlDataAccess.LoadData<Assignment>(sql);
        }

        public static int CreateUser(string userName, string password)
        {
            User data = new User(userName, password);

            string sql = @"INSERT INTO dbo.Users (UserName, Password)
                            values  (@userName, @password);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<User> LoadUsers(string uname = "")
        {
            string sql;
            if(uname.Equals(""))
            {
                sql = @"SELECT UserName, Password FROM dbo.Users;";
            }
            else
            {
                sql = @"SELECT UserName, Password FROM dbo.Users WHERE UserName='" + @uname + "';";
            }
            return SqlDataAccess.LoadData<User>(sql);
        }

        public static DateTime dateProcess(string date)
        {
            DateTime deadline;
            DateTime.TryParse(date, out deadline);
            return deadline;
        }

    }
}