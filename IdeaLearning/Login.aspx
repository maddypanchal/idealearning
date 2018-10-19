
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Login....  !</title>
    <link href="css/Logincss.css" rel="stylesheet" type="text/css" />
    
    <link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon"/>
<link rel="icon" href="images/favicon.ico" type="image/x-icon" />
    <script src="tabcontent/tabcontent.js" type="text/javascript"></script>
    <link href="tabcontent/template1/tabcontent.css" rel="stylesheet" type="text/css" />

    <style  type="text/css" >
    .header > a {
    text-decoration: none;
     }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
    <a href ="Index.aspx" target="_blank">
    <h1>Idea Learning Academy </h1>
    </a>
    </div>
<div class="wrapper">
<div class="loginImages">
<a href ="Index.aspx" target="_blank">
    <img alt="" src="images/logo_3.jpg" width="100%" height="50%" />
</a>
</div>
<div class="center">
<ul class="tabs" data-persist="true">
            <li><a href="#view1">Student</a></li>
            <li><a href="#view2">Employee</a></li>
            <li><a href="#view3">Administrator</a></li>
</ul>
 <div class="tabcontents">
 <asp:Panel ID="p" runat="server" DefaultButton="btnSSubmit">
<div id="view1">
  <div class="student">
  <p>Student Id*</p>
  <asp:TextBox ID="txtSName" runat="server" Text="" ValidationGroup="val_1" class="name_Contact"> </asp:TextBox>
  </div>
  <div class="student">
  <p>Password*</p>
  <asp:TextBox ID="txtSPassword" runat="server" Text="" ValidationGroup="val_1" TextMode="Password" class="name_Contact"> </asp:TextBox>
 </div>
 
 <div class="BtnSubmit">
<%-- <div class="Forgetpsssword"> <a href="ForgottenPassword.aspx"> Forgot Password</a> </div>--%>

 <asp:Button ID="btnSSubmit" runat="server"  class="submit" Text="Student Login" ValidationGroup="val_1" 
         onclick="btnSSubmit_Click" />
  </div>
  <div class="Forgetpsssword"> <a href="ForgottenPassword.aspx"> Forgot Password</a> </div>
  </div>
</asp:Panel>
  

  <asp:Panel ID="Panel1" runat="server" DefaultButton="btnESubmit">
<div id="view2">
 <div class="student">
 <p>Employee Id*</p>
 <asp:TextBox ID="txtEName" runat="server" Text="" class="name_Contact" ValidationGroup="val_2"> </asp:TextBox>
 </div>
 <div class="student">
 <p>Password*</p>
 <asp:TextBox ID="txtEPasswrod" runat="server" Text="" TextMode="Password" class="name_Contact" ValidationGroup="val_2"> </asp:TextBox>
 </div>
 <div class="BtnSubmit">
  
 <asp:Button ID="btnESubmit" runat="server"  class="submit" Text="Employee Login" ValidationGroup="val_2"
        onclick="btnESubmit_Click"  />
 </div>
 <div class="Forgetpsssword"> <a href="ForgottenPassword.aspx"> Forgot Password</a> </div>
 </div>
</asp:Panel>
 

 <asp:Panel ID="Panel2" runat="server" DefaultButton="btnASubmit">
<div id="view3">
 <div class="student">
 <p>Admin Id*</p>
 <asp:TextBox ID="txtAName" runat="server" Text="" class="name_Contact" ValidationGroup="val_3"> </asp:TextBox>
  </div>
 <div class="student">
 <p>Password*</p>
 <asp:TextBox ID="txtAPassword" runat="server" Text="" TextMode="Password" class="name_Contact" ValidationGroup="val_3"> </asp:TextBox>
</div>
 <div class="BtnSubmit">
  <asp:Button ID="btnASubmit" runat="server"  class="submit" Text="Admin Login" ValidationGroup="val_3"
         onclick="btnASubmit_Click"  />
  </div>
 </div>
</asp:Panel>
   </div>
   <asp:Label ID="lblLoginMsg" Text="" runat="server" class="loginLable" ></asp:Label>

  </div>
  </div>
  </form>
</body>
</html>
