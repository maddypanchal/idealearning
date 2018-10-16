<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="Course_Details.aspx.cs" Inherits="Public_Course_Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <link href="../css/courses.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <div id="gallery">
 <section>
            
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b><asp:Label ID="lblCourseName" runat="server" Text=""></asp:Label></b></p>
     </div>
      </div>
    
    </section>
     <div style="height:20px;"></div>
    <div class="from-input clear" style="color: #1e1313;font-family: message-box; font-size: 17px;">   
     <asp:Label ID="lblCoursesDetails" runat="server" Text=""></asp:Label>
     
     </div>
      <div style="height:20px;"></div>
      <div class="from-input clear">
       <h1 style="text-align:left">Course Duration</h1>
  
      <asp:Label ID="lblCourseDuration" runat="server"   style="color: #1e1313;font-family: message-box; font-size: 17px;" Text=""></asp:Label>
      </div>
       <div style="height:20px;"></div>
       <div class="from-input clear" >
       <asp:Button ID="btnapply" runat="server" Text="Apply Online" class="button large gradient orange"  PostBackUrl="~/Public/StudentRegistrations.aspx"/>
<%--       <asp:Button ID="Button1" runat="server" Text="Apply Offline" class="button large gradient orange" />--%>
       <asp:Button ID="btnback" runat="server" Text="Go Back" class="button large gradient orange" PostBackUrl="~/Public/Courses.aspx"/>
    </div>

    </div>
    </div>
    </div>




</asp:Content>

