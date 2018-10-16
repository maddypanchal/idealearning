<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IdeaLogin.aspx.cs" Inherits="Public_IdeaLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/tabcontent.js" type="text/javascript"></script>
    <link href="../css/IdeaLogin.css" rel="stylesheet" type="text/css" />
    <link href="../css/tabcontent.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
<div class="header">
<h1>Idea Learning Academy</h1>
</div>
<div class="wrapper">
<div class="loginImages">
<a href ="#">
    <img alt="" src="../images/Adminlogin.png" width="100%" height="50%" />
</a>
</div>
<div class="center">

<ul class="tabs" data-persist="true">
            <li><a href="#view1">Student</a></li>
            <li><a href="#view2">Employee</a></li>
            <li><a href="#view3">Administrator</a></li>
</ul>
 <div class="tabcontents">
 <div id="view1">
<div class="student">
<p>Username*</p>
<asp:TextBox ID="txtUserName" runat="server" CssClass="name_Contact"></asp:TextBox>
<%--  <input type="text" name="Enter your name" class="name_Contact">--%>
 </div>
  <div class="student">
<p>Password*</p>
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="name_Contact"></asp:TextBox>

 </div>
 <div class="BtnSubmit">
   <asp:Button ID="btnStudent" runat="server" class="submit" text="Submit" 
         onclick="btnStudent_Click" />
 
 
 </div>
 
 </div>
 <div id="view2">
 <div class="student">
<p>Username*</p>
<asp:TextBox ID="txtEmp" runat="server" CssClass="name_Contact"></asp:TextBox>
  </div>
  <div class="student">
<p>Password*</p>
<asp:TextBox ID="txtEmpPassword" runat="server"  TextMode="Password" CssClass="name_Contact"></asp:TextBox>

 </div>
  <div class="BtnSubmit">
    <asp:Button ID="btnEmpSubmit" runat="server" class="submit" text="Submit" 
          onclick="btnEmpSubmit_Click" />

 </div>
 </div>
 <div id="view3">
 <div class="student">
<p>Username*</p>
<asp:TextBox ID="txtAdmin" runat="server" CssClass="name_Contact"></asp:TextBox>

 </div>
  <div class="student">
<p>Password*</p>
<asp:TextBox ID="txtAdminPassword" runat="server" TextMode="Password" CssClass="name_Contact"></asp:TextBox>

 </div>
  <div class="BtnSubmit">
 <asp:Button ID="btnAdminLoign" runat="server" Text="Submit"   class="submit" 
          onclick="btnAdminLoign_Click" />



 </div>
 </div>
 </div>
 


 </div>
 </div>

    </form>
</body>
</html>
