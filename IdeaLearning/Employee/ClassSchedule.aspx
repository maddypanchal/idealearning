<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="ClassSchedule.aspx.cs" Inherits="Employee_ClassSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>
     <script type="text/javascript">
         function init() {
             calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
         }
    </script>

    
</asp:Content>


 

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
<table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Add Class Schedule"></asp:Label>
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
                    <asp:DropDownList ID="ddlClass" runat="server" CssClass="message_anyquery_form_news" >
                  
                    </asp:DropDownList>
               </td>
            </tr>
           
            <tr>
                <td class="tdMarginLeft">
                With Effect From
                </td>
                <td>
                    <asp:TextBox ID="txtDateFrom" runat="server" Text="" CssClass="message_anyquery_form_news tcal"></asp:TextBox>
               </td>
            </tr>
              <tr>
                <td class="tdMarginLeft">
                 Valid Upto
                </td>
                <td>
                    <asp:TextBox ID="txtTillDate" runat="server" Text="" AutoPostBack="true"  CssClass="message_anyquery_form_news tcal" 
                        ></asp:TextBox>
               </td>
            </tr>
            <tr>
               <td class="tdMarginLeft">
               Upload pdf file
                </td>
                <td>
                      <asp:FileUpload ID="FileUploadPDF" runat="server" Font-Italic="True" multiple="true" class="cssControls" ToolTip="Upload Product Image Here" />
               </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="ADD" class="cssBtn" onclick="btnSave_Click" OnClientClick="return validate();"/>
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

