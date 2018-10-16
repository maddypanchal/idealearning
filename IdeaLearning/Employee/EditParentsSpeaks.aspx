<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="EditParentsSpeaks.aspx.cs" Inherits="Employee_EditParentsSpeaks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
    <table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Update Parents Speaks Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
            <tr>
             <td class="tdMarginLeft">
               Gallery Images 
                </td>
                <td>
                <asp:Image ID="imgUser" runat="server" Height="350" Width="800" ImageUrl="~/UploadedFile/Defultuser.png" />
                <br />
                      <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                        multiple="true" class="cssControls" ToolTip="Upload Image Here" />
               </td>
            </tr>
            <tr>
                <td class="tdMarginLeft">
                   Title Name
                </td>
                <td>
                    <asp:TextBox ID="txtTitleName" runat="server" Text="" CssClass="message_anyquery_form_news"></asp:TextBox>
               </td>
            </tr>
                <tr>
                <td class="tdMarginLeft">
                   Description
                </td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
               </td>
            </tr>
           <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="Update" class="button small orange" onclick="btnSave_Click"/>
                </td>
            </tr>
      </table>
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

