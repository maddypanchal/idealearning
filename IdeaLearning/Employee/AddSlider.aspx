<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddSlider.aspx.cs" Inherits="Employee_AddSlider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
        <table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
            <tr>
                <td align="center" colspan="3">
                    <asp:Label ID="lblMsg" runat="server" CssClass="add" Text=" Add Image Gallery Detail"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="3" align="left">
                    <h3 style="text-decoration: underline; font-style: italic; color: #ef7300">
                        Gallery Images</h3>
                </td>
            </tr>
            <tr>
                <td class="tdMarginLeft" colspan="2">
                    &nbsp;&nbsp;
                    <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                        multiple="true" ForeColor="#FF6600" class="cssControls" ToolTip="Upload Product Image Here" />
                 
                </td>
                <td>
                   <asp:RequiredFieldValidator ID="rfvFileUploadOnLocalComputer" CssClass="validation_Gallery" Display="Dynamic"
                        runat="server" ControlToValidate="FileUploadOnLocalComputer" ErrorMessage="Please upload product image"
                        ValidationGroup="o1"></asp:RequiredFieldValidator>
                
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
            <tr>
                <td colspan="3" align="left">
                    <h3 style="text-decoration: underline; font-style: italic; color: #333333">
                        Gallery Details</h3>
                </td>
            </tr>
            <tr>
                <td class="tdMarginLeft">
                    Image Title
                </td>
                <td>
                    <asp:TextBox ID="txtProductTitle" CssClass="message_anyquery_form_news" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtProductTitle"
                        CssClass="validation_Gallery" runat="server" Display="Dynamic" ValidationGroup="o1"
                        ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
                <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" class="button small orange" ValidationGroup="o1"
                        OnClick="btnSave_Click" />
                </td>
            </tr>
        </table>
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

