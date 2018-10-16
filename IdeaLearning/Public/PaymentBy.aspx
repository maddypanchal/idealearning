<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="PaymentBy.aspx.cs" Inherits="Public_PaymentBy" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/courses.css" rel="stylesheet" type="text/css"/>
      <script language="javascript" type="text/javascript">
          $(document).ready(function () {
              $(".customProduct a").fancybox({
                  'zoomSpeedIn': 0,
                  'zoomSpeedOut': 0,
                  'overlayShow': true,
                  'hideOnContentClick': false
              });
          });
          var lastDiv = "";
          function showDiv(divName) {
              // hide last div
              if (lastDiv) {
                  document.getElementById(lastDiv).className = "hiddenDiv";
              }
              //if value of the box is not nothing and an object with that name exists, then change the class
              if (divName && document.getElementById(divName)) {
                  document.getElementById(divName).className = "visibleDiv";
                  lastDiv = divName;
              }
          }
      </script>
    <style type="text/css" media="screen">
        .hiddenDiv
        {
            display: none;
        }
        .visibleDiv
        {
            display: block;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="course_wrapper">
  <div class="course_contentner">
  <h1>   Due to maintinance work this facility is disabled.
         You have to Submit the fee at Our Office.   </h1>
         Please call for any help at Mob. +91 98965-45257 

                           <h2> Payment Method&nbsp; </h2>
                           <asp:DropDownList ID="ddlPayment_Mode" class="dropdownlist" runat="server"
                                onchange="showDiv(this.value);">
                                <asp:ListItem Value="-1" Selected>Select</asp:ListItem>
                                <asp:ListItem Value="1">Challan</asp:ListItem>
                                <asp:ListItem Value="2">Online Pay</asp:ListItem>
                                </asp:DropDownList>
                 
                   <div id="1" class="hiddenDiv">
                    <table >
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                            <td >
                       Name 
                            </td>
                            <td>
                            Name
                           </td>
                        </tr>
                        <tr>
                        <td>
                        <asp:Button ID="btnChallan" runat="server" Text="Create Challan" 
                                onclick="btnChallan_Click"/>
                        </td>
                        </tr>
                    </table>
                </div>
                <div id="2" class="hiddenDiv">
                    <table>
                        <tr>
                            <td valign="top">
                        
                            </td>
                            <td>
                         
                            </td>
                        </tr>
                        <tr>
                        <td>
                        <asp:Button ID="btnOnlinePay" runat="server" Text="Online Payment"  PostBackUrl="~/Public/OnlinePayment.aspx" />
                        </td>
                        </tr>
                    </table>
                </div>
                

   </div>
    </div>
</asp:Content>

