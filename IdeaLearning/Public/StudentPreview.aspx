<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="StudentPreview.aspx.cs" Inherits="Public_StudentPreview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper">
<div class="header">
<h1>IDEA Learning Academy</h1>
</div>
<div class="nav">
<ul>
<li><a href="#">Home</a></li>
<li><a href="#">Student form</a></li>
<li><a href="#">Employee Form</a></li>
<li><a href="#">Admin Form</a></li>
</ul>
</div>
<div class="center">
<h1> Student Registration Form</h1>
<div class="name">
<p>Registration No:-</p>
  <input type="text" name="Enter your name" class="name_Contact">
  </div>
  <div class="name">
<p>Date of Reg. -</p>
        <input type="text" name="Enter your name" class="name_Contact">
        </div>
        <div class="info">
 <div class="student">
<p>Student Name*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
  <div class="student">
<p>Father Name*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
   <div class="student">
<p>Mother Name*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
    <div class="student">
<p>Date of Birth*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
     <div class="student">
<p>Gender*</p>
 <select class="gender">
   <option value="" disabled selected ></option>
  <option value="">Male</option>
  <option value="">Female</option>
</select>
 </div>
     <div class="student">
<p>Category*</p>
 <select class="gender">
   <option value="" disabled selected ></option>
  <option value="">Gen.</option>
  <option value="">SC</option>
</select>
 </div>
 <div class="student">
 <p>Address*</p>
        <textarea rows="2" cols="30" class="message_Contact"></textarea>
       </div>
           <div class="student">
<p>City*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
    <div class="student">
<p>State*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
         <div class="student">
<p>Email id*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
 </div>
 <div class="info">
     <div class="student margin">
<a href="#"><p>Upload Image*</p></a>
<div class="image">
</div>
  </div>
           <div class="student margin">
<p>Course*</p>
 <select class="gender">
   <option value="" disabled selected ></option>
  <option value="">B.C.A</option>
  <option value="">M.C.A</option>
</select>
 </div>
 <div class="student margin">
<p>Batch*</p>
 <select class="gender">
   <option value="" disabled selected ></option>
  <option value="">Ist Sem.</option>
  <option value="">2nd Sem.</option>
</select>
 </div>
          <div class="student margin">
<p>Course Duration</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
     <div class="student margin">
<p>Roll No*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
    <div class="student margin">
<p>Fee*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
    <div class="student margin">
<p>Mobile No*</p>
  <input type="text" name="Enter your name" class="name_Contact">
 </div>
 <button type="button" class="submit">Submit</button>
 </div>
 </div>
</div>
</asp:Content>

