<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true"
    CodeFile="HomeWork.aspx.cs" Inherits="Employee_HomeWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
    <table width="95%" cellpadding="2" style="float: left; margin: 20px 0 20px 0;"
        cellspacing="10" bgcolor="#333">
        <tr>
            <td align="center" colspan="3">
                <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Add Home Works Details"></asp:Label>
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
                <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="message_anyquery_form_news"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
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
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="message_anyquery_form_news">
                </asp:DropDownList>
            </td>
        </tr>
            <tr>
            <td class="tdMarginLeft">
                Upload Doc file
            </td>
            <td>
                <asp:FileUpload ID="FileUploadPDF" runat="server" Font-Italic="True" multiple="true"
                class="cssControls" ToolTip="Upload Product Image Here" />
            </td>
        </tr>
        <tr>
            <td class="tdMarginLeft">
                Descriptions
            </td>
            <td>
             <asp:TextBox ID="txtDescriptions" runat="server" TextMode="MultiLine"  Text="" Class="message_box1"></asp:TextBox>
            </td>
        </tr>
    
        <tr>
            <td colspan="2" align="center">
                <div class="divClear">
                </div>
                <asp:Button ID="btnSave" runat="server" Text="ADD" class="cssBtn" OnClick="btnSave_Click" />
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
