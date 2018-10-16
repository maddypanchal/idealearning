<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="StudentAnsHW.aspx.cs" Inherits="Student_StudentAnsHW" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

   <div id="container">
      <!-- ################################################################################################ -->
    
        <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>DETAILS OF ANSWERS FOR HOME WORK</b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>
    
    <section class="clear">
    <table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Add Answer's Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
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
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="message_anyquery_form_news" >
                  
                </asp:DropDownList>
               </td>
            </tr>
       
            <tr>
               <td class="tdMarginLeft">
               Upload Answers file
                </td>
                <td>
                      <asp:FileUpload ID="FileUploadPDF" runat="server" Font-Italic="True"
                      multiple="true" class="cssControls" ToolTip="Upload Product Image Here" />
               </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="ADD" class="cssBtn" onclick="btnSave_Click"/>
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

