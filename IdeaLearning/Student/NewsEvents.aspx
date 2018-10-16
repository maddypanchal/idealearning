<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="NewsEvents.aspx.cs" Inherits="Student_NewsEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div id="container">
      <!-- ################################################################################################ -->
          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>DETAILS OF NEWS AND EVENTS </b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>
    <section class="clear">
<%-- <h1>News and Events</h1>--%>
      <table>
        <thead>
         
        <asp:Repeater ID="repnews" runat="server">
    <ItemTemplate>
     <tr>
    <td>
         <br />
    <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("TitleName") %>' Font-Bold="true" style="float:left; color: #fe7300; font-size: 22px; font-weight: bold;
    margin: 3px 0 5px 42px; width: 100%;"/>

      <p style="margin:5px 0 5px 42px; font-size:18px; color:#8e8e8e;">
     <asp:Label ID="lblComment" runat="server" Text='<%#Eval("Description") %>'/>
     </p>
    
     <p style="margin:5px 0 5px 42px; font-size:18px; color:#686868;">
     Modified Date :  <asp:Label ID="lblDate" runat="server" Text='<%#Eval("TitleDate") %>'/>
     </p>

    </td>

    </tr>
     
   
     </ItemTemplate>
   
    </asp:Repeater>
    
       
        
          </thead>
          </table>

      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

