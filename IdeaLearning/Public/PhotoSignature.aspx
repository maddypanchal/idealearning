<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="PhotoSignature.aspx.cs" Inherits="Public_PhotoSignature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <link href="../css/courses.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="course_wrapper">
  <div class="course_contentner">
    <div class="course_head">
     <h1>Upload Photo & Signature  </h1>
     <div class="photo_upload">
   <div class="PhotoLeft"> 
   <p> Photo upload* <p>
     <asp:FileUpload ID="FileUploadPhoto" runat="server" />
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FileUploadPhoto" Text="* Upload Photo" />
     <p>Maximum photo size 500kb</p>
     </div> 
     <div class="PhotoRight"> 
     <p> Signature upload* <p>
     <asp:FileUpload ID="FileUploadSignature" runat="server" />
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FileUploadSignature" Text="* Upload Signature" />
     <p>Maximum Signature size 200kb</p>
     </div> 
              
           <div class="upload_btn">
           <asp:Button ID="btnConfirm" runat="server" Text="Confirm" onclick="btnConfirm_Click" />
           <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
           </div>
  
   </div>
      </div>
   </div>
    </div>
</asp:Content>

