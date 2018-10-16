<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="DailyReport.aspx.cs" Inherits="Employee_DailyReport" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="wrapper row3">
        <div id="container">
         <div id="portfolio">
          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;">Daily Status Report Details</b></p>
     </div>
      </div>
    
     <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
    <table >
         <%--    <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text="Daily Status Report Details"></asp:Label>
                </td>
            </tr>--%>
            <tr>
            <td colspan="3">
            <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeWorkId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 13px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="200" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="2" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
              <%-- 
              <%--  <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                 
                  <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Task Title/Name">
                    <ItemTemplate>
                        <asp:Label ID="lblTopic" runat="server" Text='<%#Eval("Topic") %>' />
                    </ItemTemplate>
                       </asp:TemplateField>

                           <asp:TemplateField HeaderText="Last Date Of Complition">
                    <ItemTemplate>
                        <asp:Label ID="lblLastDateOfComplate" runat="server" Text='<%#Eval("LastDateOfComplate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                           <asp:TemplateField HeaderText="Instruction">
                    <ItemTemplate>
                        <asp:Label ID="lblInstruction" runat="server" Text='<%#Eval("Instruction") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                           <asp:TemplateField HeaderText="Work Given To">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkFor" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Task">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                       <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbtn_IS_LOCKED" runat="server" BorderStyle="None" BorderWidth="0"
                                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "EmployeeWorkId")%>' OnCommand="IS_LOCKED_Activate_Deactivate"
                                            Text='<%#DataBinder.Eval(Container.DataItem, "Status")%>'>

                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>

                     <asp:TemplateField HeaderText="View Details">
                             <ItemTemplate>
                               <a href="FillTaskByEmployee.aspx?Sid=<%#Eval("EmployeeWorkId") %>">Task Details</a>
                             </ItemTemplate>
                         </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#ef7300" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#657477" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            </div>
            </td>
            </tr>
        </table>
             </div>
            <!-- ################################################################################################ -->
            <div class="clear">
            </div>
        </div>
    </div>

</asp:Content>

