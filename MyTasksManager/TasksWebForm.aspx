<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TasksWebForm.aspx.cs" Inherits="MyTasksManager.TasksWebForm" %>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://cdn.jsdelivr.net/momentjs/2.14.1/moment.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/css/bootstrap-datetimepicker.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">

<!DOCTYPE html>
 <form id="form1" runat="server">
     <div class="container">
  <div class="panel panel-primary">
    <div class="panel-heading">Professional Task Manager</div>
      <div class="panel-body">
           <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                    <asp:Button ID="btnLogin" runat="server" Height="25px" Text="Sign in" Width="100px" PostBackUrl="~/LoginForm.aspx" />
                    <asp:Button ID="btnRegister" runat="server" Height="25px" Text="Sign up" Width="100px" PostBackUrl="~/SignUp.aspx" />
                    <asp:Button ID="btnLogOut" runat="server" Height="25px" Text="Log Out" Width="100px" OnClick="btnLogOut_Click" />
               </div>
            </div>
         </div>
         <div class="row">
            <div class="col-md-6">
               <div>
                   <asp:Label ID="lblText2" runat="server" Text=" "></asp:Label>
               </div>
               <div class="form-group">
                    <asp:Button ID="Button2" runat="server" Height="30px" OnClick="Button2_Click" Text="Show all Assignments" Width="250px" />
               </div>
            </div>
         </div>

           <div class="row">
            <div class="col-md-6">
               <div style="width:1000px; height:350px; overflow:scroll;">
                   <asp:GridView ID="GridBox1" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Width="980px" OnSelectedIndexChanged="GridBox1_SelectedIndexChanged">
                       <Columns>
                          <asp:CommandField SelectText="Select" ShowSelectButton="True" />
                       </Columns>
                       <rowstyle Height="35px" />
                       <alternatingrowstyle  Height="35px"/>
                       <SelectedRowStyle BackColor="#CCCCFF" />
                   </asp:GridView>
               </div>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="btnCreateTask" runat="server" Height="25px" OnClick="Button3_Click" Text="New Assignment" Width="200px" />
                        <td border="10px">
                            <asp:Button ID="btnEdit" runat="server" Height="25px" OnClick="BtnEdit_Click" Text="Edit" Width="200px" />
                        <td>
                            <asp:Button ID="btnDelete" runat="server" Height="25px" Text="Delete Assignment" Width="200px" OnClick="btnDelete_Click" />               
                    </table>
            </div>
         </div>

        <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                  <label class="control-label">Responsible User:</label>
                  <asp:DropDownList id="dropUsers" runat="server" Width="1000px" class="form-control" >
                  </asp:DropDownList>
               </div>
             <div>
               <asp:Button ID="Button4" runat="server" Height="30px" OnClick="Button1_Click" Text="Search tasks by the responisble Username" Width="280px" />
            </div>
            </div>

        </div>

      </div>

   </div>
</div>

 </form>
