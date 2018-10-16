<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true"
    CodeFile="ClassSchedule.aspx.cs" Inherits="Student_ClassSchedule" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

   <div id="container">
      <!-- ################################################################################################ -->

        <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>Class Schedule Details</b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>


    <section class="clear">
    <table>
        <tr>
            <td align="center" colspan="3">
                <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" "></asp:Label>
            </td>
        </tr>
      
        <tr>
            
            <td>
                <asp:Repeater ID="repCs" runat="server">
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td class="tdMarginLeft">
                                Valid From
                                </td>
                                <td>
                                    <asp:Label ID="lblFormDate" runat="server" Text='<%#Eval("FormDate") %>' Font-Bold="true" /></h2>
                                </td>
                            </tr>
                            <tr>
                                <td class="tdMarginLeft">
                               Valid Till 
                                </td>
                                <td>
                                  <asp:Label ID="lblTillDate" runat="server" Text='<%#Eval("TillDate") %>' />
                                </td>
                            </tr>
                            <tr>
                                <td class="tdMarginLeft">
                                File download
                                </td>
                                <td>
                                 <a href='../Employee/PdfFile/<%#Eval("PdfFile")%>' target="_blank">
                                <asp:Image ID="imgdoc" runat="server" ImageUrl="~/images/pdf-word-icons.png" Width="100px"
                                Height="100px" />
                        </a>
                                </td>
                            </tr>
                        </table>
                    
                      
                       </div>
                    </ItemTemplate>
                </asp:Repeater>
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
