using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MyTasksManager.Models
{
    public class Assignment
    {
        public int assignmentId { get; set; }
        public string title { get; set; }
        public Priority priority { get; set; }
        public Status status { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime deadlineDate { get; set; }
        public string responsibleUser { get; set; }

        public Assignment(Int32 Id, String Title, Int32 Priority, Int32 Status, DateTime CreationDate, DateTime DeadlineDate, string ResponsibleUser)
        {
            DateTime dt = new DateTime(2018, 03, 01);

            this.assignmentId = Id;
            this.title = Title;
            this.priority = (Priority)Priority;
            this.status = (Status)Status;
            this.creationDate = CreationDate;
            this.deadlineDate = DeadlineDate;
            this.responsibleUser = ResponsibleUser;
        }

        public Assignment(string aTitle, Priority aPriority, Status aStatus, DateTime aCreationDate, DateTime aDeadlineDate, string aResponsibleUserId)
        {
            this.title = aTitle;
            this.priority = aPriority;
            this.status = aStatus;
            this.creationDate = aCreationDate;
            this.deadlineDate = aDeadlineDate;
            this.responsibleUser = aResponsibleUserId;
        }

        //ToString Task
        public override string ToString()
        {
            return assignmentId + ", " + title + ", " + priority + ", " + status + ", " + creationDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) + ", " + deadlineDate.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture) + ", " + responsibleUser.ToString();
        }
    }
}