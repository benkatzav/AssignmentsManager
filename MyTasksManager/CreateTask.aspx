
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateTask.aspx.cs" Inherits="MyTasksManager.CreateTask" %>


<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://cdn.jsdelivr.net/momentjs/2.14.1/moment.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/js/bootstrap-datetimepicker.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/css/bootstrap-datetimepicker.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">

<script>
    $(function () {
        $('#datetimepicker1').datetimepicker({
            format: 'DD/MM/YYYY HH:mm:ss'
        });
    });
</script>


<!DOCTYPE html>
 <form id="form1" runat="server">
     <div class="container">
  <div class="panel panel-primary">
    <div class="panel-heading">New Assignment</div>
      <div class="panel-body">
         <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                  <label class="control-label">Title</label>
                   <asp:TextBox id="txtTitle" class="form-control" runat="server"></asp:TextBox>
               </div>
            </div>
            <div class="col-md-6">
               <div class="form-group">
                  <label class="control-label">Priority</label>
                  <asp:DropDownList id="dropPriority" runat="server" class="form-control">
                    <asp:ListItem Value="0">Low</asp:ListItem>
                    <asp:ListItem Value="1">Medium</asp:ListItem>
                    <asp:ListItem Value="2">High</asp:ListItem>
                  </asp:DropDownList>
               </div>
            </div>
         </div>
         <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                  <label class="control-label">Status</label>
                  <asp:DropDownList id="dropStatus" runat="server" class="form-control">
                    <asp:ListItem Value="0">Pending</asp:ListItem>
                    <asp:ListItem Value="1">In Progress</asp:ListItem>
                    <asp:ListItem Value="2">Done</asp:ListItem>
                  </asp:DropDownList>
               </div>
            </div>
            <div class='col-md-6'>
               <div class="form-group">
                  <label class="control-label">Deadline Date</label>
                  <div class='input-group date' id='datetimepicker1'>
                     <asp:TextBox id="dateText" type='text' class="form-control" runat="server"></asp:TextBox>
                     <span class="input-group-addon">
                     <span class="glyphicon glyphicon-calendar"></span>
                     </span>
                  </div>
               </div>
            </div>
        </div>
        <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                  <label class="control-label">Responsible Username</label>
                  <asp:DropDownList id="drop1" runat="server" class="form-control">
                  </asp:DropDownList>
               </div>
            </div>
        </div>
        <asp:Button ID="btnCreate" runat="server" Height="30px" OnClick="Button1_Click" Text="Create Task" />
        <asp:Button ID="btnConfirm" runat="server" Height="30px" Text="Back to assignments" PostBackUrl="~/TasksWebForm.aspx" />
        <div>
            <asp:Label ID="lblText" runat="server" Text=" "></asp:Label>
        </div>
      </div>

   </div>
</div>

 </form>
