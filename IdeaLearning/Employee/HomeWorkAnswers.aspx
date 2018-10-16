<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="HomeWorkAnswers.aspx.cs" Inherits="Employee_HomeWorkAnswers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

<table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text="Home Work Answer Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
             <tr>
               <td class="tdMarginLeft" colspan="3">
               Home work file download 
                </td>
            </tr>
                <tr>
                <td class="tdMarginLeft">
           select Class 
                </td>
                <td>
                    <asp:DropDownList ID="ddlClass" runat="server"  AutoPostBack="true"   CssClass="message_anyquery_form_news" 
                        onselectedindexchanged="ddlClass_SelectedIndexChanged" >
                     </asp:DropDownList>
               </td>
            </tr>

            <tr>
                <td class="tdMarginLeft">
                   select Course                </td>
                <td>
                 <asp:DropDownList ID="ddlCourselist" runat="server" CssClass="message_anyquery_form_news" AutoPostBack="true" 
                    onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
               </td>
            </tr>

            <tr>
                <td class="tdMarginLeft">
                  Select Subject
                </td>
                <td>
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="message_anyquery_form_news" AutoPostBack="true"   onselectedindexchanged="ddlSubject_SelectedIndexChanged" >
                  
                </asp:DropDownList>
               </td>
            </tr>
        <asp:Repeater ID="rephw" runat="server">
        <ItemTemplate>
         <tr>
                <td>
                <a href ='../Employee/DocFile/<%#Eval("DocFile")%>' target="_blank">
                <asp:Image ID="imgdoc" runat="server" ImageUrl="~/images/docxfile.png" Width="30px" Height="30px" />
                </a>
                <p style="margin:5px 0 5px 42px; font-size:18px; color:#8e8e8e;"> <%#Eval("Date")%></p>
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

