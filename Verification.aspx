<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Verification.aspx.cs" Inherits="Verification" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <meta charset="utf-8">
  <title>Verification</title>
  <meta name="viewport" content="width=device-width, initial-scale=1.0">

  <!-- Loading Bootstrap -->
  <link href="login/css/bootstrap.css" rel="stylesheet" />

  <!-- Loading Stylesheets -->    
  
  
    <link href="login/css/bootstrap.css" rel="stylesheet" />
<link href="login/css/font-awesome.css" rel="stylesheet" />
  
    <link href="login/css/login.css" rel="stylesheet" />
</head>
<body>
   <form id="form1" runat="server">
    <div class="login-box">
    <h1><i class='fa fa-bookmark'></i>&nbsp;Welcome To Stufan </h1>
    <hr>
    <h5>Verification Code</h5>

    <div class="input-box">
      <div class="row">
        <div class="col-md-8 col-md-offset-2 col-xs-10 col-xs-offset-1">
          <form  role="form"  action="../index.php">
            <div class="input-group form-group">
              <%--<span class="input-group-addon"><i class='fa fa-envelope'></i></span>
              <asp:TextBox ID="txt_username" class="form-control" placeholder="Email" runat="server"></asp:TextBox>
            </div>--%>
            <div class="input-group form-group">
              <span class="input-group-addon"><i class='fa fa-key'></i></span>
           <asp:TextBox ID="txt_vericode" runat="server" class="form-control" placeholder="Enter Verification Code"></asp:TextBox>
              
            </div>
            <div class="form-group">
               <asp:Button ID="btn_submit" runat="server" class="btn  btn-block  btn-submit pull-right"  Text="Submit"  OnClick="btn_submit_Click"/>
            </div>
          </form>
        </div>
        <!-- col -->
      </div>
      <!-- row -->
    </div>
    <!-- input-box -->
  </div>
  <!-- lock-box -->
    </form>

</body>
</html>
