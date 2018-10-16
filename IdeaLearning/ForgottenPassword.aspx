<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgottenPassword.aspx.cs" Inherits="ForgottenPassword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Forget Password.....  !</title>
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
    <h1>Idea Learning Academy</h1>
    </a>
    </div>
<div class="wrapper">
<div class="loginImages">
<a href ="Index.aspx">
    <img alt="" src="images/logo_3.jpg" width="100%" height="50%" />
</a>
  </div>
  <div class="center_Forget">
  <ul class="tabs" data-persist="true">
            <li><a href="#view1">Student</a></li>
            <li><a href="#view2">Employee</a></li>
  </ul>
  <div class="tabcontents">
  <div id="view1">
  <asp:Panel ID="panel_SMobile" runat="server" DefaultButton="btnSSubmit">
  <div class="student">
  <p>Enter Mobile Number*</p>
  <asp:TextBox ID="txtSMobileNo" runat="server" Text="" ValidationGroup="val_1" class="name_Contact"> </asp:TextBox>
  </div>
  <div class="BtnSubmit">
  <asp:Button ID="btnSSubmit" runat="server"  class="submit_Forget" Text="Submit" ValidationGroup="val_1" 
         onclick="btnSSubmit_Click" />
  </div>
  </asp:Panel>
  <asp:Panel ID="Panel_SOTP" runat="server" Visible="false" DefaultButton="btnSSubmit">
   <div class="student">
  <p>Enter OTP *</p>
  <asp:TextBox ID="txtOTP" runat="server" Text="" ValidationGroup="val_3" class="name_Contact"> </asp:TextBox>
  </div>
    <div class="BtnSubmit">
  <asp:Button ID="BtnSOPT" runat="server"  class="submit_Forget" Text="Submit" 
            ValidationGroup="val_3" onclick="BtnSOPT_Click"/>
                    <asp:Button ID="BtnSBack" runat="server" PostBackUrl="~/Login.aspx"  class="submit_Forget" Text="Go to Login" 
         ValidationGroup="val_3"  />
  </div>
    </asp:Panel>

      <asp:Panel ID="panel_Slogin" runat="server" Visible="false" DefaultButton="Button2">
  
    <div class="BtnSubmit">
 
                    <asp:Button ID="Button2" runat="server" PostBackUrl="~/Login.aspx"  class="submit_Forget" Text="Go to Login" 
         ValidationGroup="val_6"  />
  </div>
    </asp:Panel>
  </div>



<div id="view2">
 <asp:Panel ID="Panel_Employee" runat="server" DefaultButton="btnESubmit">
 <div class="student">
 <p>Enter Mobile Number *</p>
 <asp:TextBox ID="txtEMobile" runat="server" Text="" class="name_Contact" ValidationGroup="val_2"> </asp:TextBox>
 </div>
 <div class="BtnSubmit">
 <asp:Button ID="btnESubmit" runat="server"  class="submit_Forget" Text="Submit" ValidationGroup="val_2" onclick="btnESubmit_Click"/>
 </div>
 </asp:Panel>

  <asp:Panel ID="Panel_EOTP" runat="server" Visible="false"  DefaultButton="btnESubmit">
 <div class="student">
 <p>Enter OTP *</p>
 <asp:TextBox ID="txtEOTP" runat="server" Text="" class="name_Contact" ValidationGroup="val_4"> </asp:TextBox>
 </div>
 <div class="BtnSubmit">
 <asp:Button ID="BtnEOtp" runat="server"  class="submit_Forget" Text="Submit" 
         ValidationGroup="val_4" onclick="BtnEOtp_Click" />
         
          <asp:Button ID="BtnEBack" runat="server" PostBackUrl="~/Login.aspx"  class="submit_Forget" Text="Go to Login" 
         ValidationGroup="val_4"  />
         
 </div>
 </asp:Panel>

   <asp:Panel ID="panel_Elogin" runat="server" Visible="false" DefaultButton="Button1">
  
    <div class="BtnSubmit">
 
                    <asp:Button ID="Button1" runat="server" PostBackUrl="~/Login.aspx"  class="submit_Forget" Text="Go to Login" 
         ValidationGroup="val_5"  />
  </div>
    </asp:Panel>
 </div>

  </div>
 
  <asp:Label ID="lblLoginMsg" Text="" runat="server" class="loginLable" ></asp:Label>
  </div>
    </div>
  </form>
</body>
</html>
