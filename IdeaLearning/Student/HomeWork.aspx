<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="HomeWork.aspx.cs" Inherits="Student_HomeWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <div id="container">
      <!-- ################################################################################################ -->
          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>Home Work's Details</b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>
    <section class="clear">

<table >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=""></asp:Label>
                </td>
            </tr>
         
          
        <asp:Repeater ID="rephw" runat="server">
    <ItemTemplate>
     <tr>
      <td>
                        <p Font-Bold="true" style="float:left; color: #fe7300; font-size: 22px; font-weight: bold; margin: 3px 0 5px 42px; width: 100%;" ><%#Eval("Description")%> </p>
                         <p style="margin:5px 0 5px 42px; font-size:18px; color:#8e8e8e;"> <%#Eval("Date")%></p>
                      </td>
                <td>
              
                <a href ='../Employee/DocFile/<%#Eval("DocFile")%>' target="_blank">Download 
                <asp:Image ID="imgdoc" runat="server" ImageUrl="~/images/docxfile.png" Width="70px" Height="70px" />
                </a>
             
                      </td>
                     
            </tr>
     </ItemTemplate>
    </asp:Repeater>
            
               <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                   </td>
            </tr>
            <tr>
            <td colspan="2">
            </td>
            </tr>
        </table>

             
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

