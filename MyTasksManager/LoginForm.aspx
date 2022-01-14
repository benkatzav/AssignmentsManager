<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="MyTasksManager.LoginForm" %>

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://cdn.jsdelivr.net/momentjs/2.14.1/moment.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js"></script>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datetimepicker/4.17.37/css/bootstrap-datetimepicker.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css">

<!DOCTYPE html>

 <form id="login" runat="server">
     <div class="container">
  <div class="panel panel-primary">
    <div class="panel-heading">Log in Page</div>
      <div class="panel-body">
         <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                   <asp:TextBox id="txtUser" runat="server" class="form-control" width="50%" placeholder="Username"></asp:TextBox>
               </div>
            </div>
         </div>

           <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                   <asp:TextBox id="txtPass" runat="server" class="form-control" width="50%"  placeholder="Password"></asp:TextBox>
               </div>
            </div>
         </div>

        <div class="row">
            <div class="col-md-6">
               <div class="form-group">
                  <asp:Button ID="btnLogin" runat="server" Height="30px" OnClick="Button4_Click" Text="Sign in" Width="100px" />
                  <asp:Button ID="btnBack1" runat="server" Height="30px" Text="Back" Width="100px" PostBackUrl="~/TasksWebForm.aspx" />
                  <asp:Label ID="lblText1" runat="server" Text=" "></asp:Label>
               </div>
            </div>
        </div>

      </div>

   </div>
</div>

 </form>
