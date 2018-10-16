<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="OnlineForm.aspx.cs" Inherits="Public_OnlineForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/Master.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper">
    <div class="navigation">
<div class="nav">
<ul>
<li><a href="DashBord.aspx" runat="server" id="Admin">Employee Info</a></li>
<li><a href="StudentDetails.aspx">Employee</a></li>
<li><a href="EventsDetails.aspx">Events</a></li>
<li><a href="NewsDetails.aspx">News</a></li>
<li><a href="#">Reports</a></li>
</ul>
</div>
</div>
<div class="center1">
<h1> Student Registration </h1>
<div class="name">
<p>Registration No:-</p>
 <asp:TextBox ID="txtRegistrations" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
  <div class="name">
<p>Date of Reg. -</p>
 <asp:TextBox ID="txtDateOfReg" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
         </div>
        <div class="info">
 <div class="student">
<p>Student Name*</p>
 <asp:TextBox ID="txtStudentName" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
 </div>
  <div class="student">
<p>Father Name*</p>
 <asp:TextBox ID="txtFatherName" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
   </div>
   <div class="student">
<p>Mother Name*</p>
 <asp:TextBox ID="txtMotherName" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
    <div class="student">
<p>Date of Birth*</p>
 <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
     <div class="student">
     <p>Gender*</p>
         <asp:DropDownList ID="ddlGender" runat="server" CssClass="gender1">
         <asp:ListItem Value="-1">Select One</asp:ListItem>
         <asp:ListItem Value="1">Male</asp:ListItem>
         <asp:ListItem Value="2">Female</asp:ListItem>
         </asp:DropDownList>
  </div>
     <div class="student">
<p>Category*</p>
 <asp:DropDownList ID="ddlCategory" runat="server" CssClass="gender1">
         <asp:ListItem Value="-1">Select One</asp:ListItem>
         <asp:ListItem Value="1">Gen</asp:ListItem>
         <asp:ListItem Value="2">OBC</asp:ListItem>
         <asp:ListItem Value="3">SC</asp:ListItem>
         <asp:ListItem Value="4">ST</asp:ListItem>
         <asp:ListItem Value="5">Othre</asp:ListItem>
 </asp:DropDownList>
 </div>
 
         <div class="student ">
<p>City*</p>
 <asp:TextBox ID="txtCity" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
   </div>
    <div class="student ">
<p>State*</p>
 <asp:TextBox ID="txtState" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
   </div>  
 </div>
 <div class="info">
       
         <div class="student margin">
<p>Email id*</p>
 <asp:TextBox ID="txtEmail" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
           <div class="student margin">
<p>Course*</p>
 <asp:DropDownList ID="ddlCourse" runat="server" CssClass="gender1">
         <asp:ListItem Value="-1">Select One</asp:ListItem>
         <asp:ListItem Value="1">PMT</asp:ListItem>
         <asp:ListItem Value="2">IIT</asp:ListItem>
         <asp:ListItem Value="3">JEE</asp:ListItem>
         <asp:ListItem Value="4">AIEEE</asp:ListItem>
  </asp:DropDownList>
 </div>
 <div class="student margin">
 <p>Batch*</p>
 <asp:DropDownList ID="ddlbatch" runat="server" CssClass="gender1">
         <asp:ListItem Value="-1">Select One</asp:ListItem>
         <asp:ListItem Value="1">Ist Sem.</asp:ListItem>
         <asp:ListItem Value="2">2nd Sem.</asp:ListItem>
       </asp:DropDownList>
     </div>
          <div class="student margin">
<p>Course Duration</p>
 <asp:TextBox ID="txtCourseDuration" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
 </div>
    <%-- <div class="student margin">
<p>Roll No*</p>
 <asp:TextBox ID="txtRollNo" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
   </div>--%>
 <%--   <div class="student margin">
<p>Fee*</p>
 <asp:TextBox ID="txtFee" runat="server" Text="" class="name_Contact"></asp:TextBox> 
 </div>--%>
    <div class="student margin">
<p>Mobile No*</p>
 <asp:TextBox ID="txtMobile" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
 <div class="student margin">
<p>User Name*</p>
 <asp:TextBox ID="txtUserName" runat="server" Text="" class="name_Contact1"></asp:TextBox> 
  </div>
 <div class="student margin">
<p>Password*</p>
 <asp:TextBox ID="txtPassword" runat="server" Text="" TextMode="Password" class="name_Contact1"></asp:TextBox> 
  </div>
 <div class="student margin">
  <p>Confirm Password*</p>
 <asp:TextBox ID="txtConfirmPasword" runat="server" Text="" TextMode="Password" class="name_Contact1"></asp:TextBox>  
  </div>

  </div>
  <div class="info1">
    <div class="studentText">
 <p>Address*</p>
  <asp:TextBox ID="txtaddress" runat="server" Text="" TextMode="MultiLine" class="message_Contact1"></asp:TextBox> 
       </div>
        <asp:Button ID="btnSubmit" runat="server"  Text="Next" class="submit" PostBackUrl="~/PhotoSignature.aspx"/>
       </div>
 </div>
 
 </div>
</asp:Content>

