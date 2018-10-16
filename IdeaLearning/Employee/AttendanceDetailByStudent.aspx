<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AttendanceDetailByStudent.aspx.cs" Inherits="Employee_AttendanceDetailByStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

     <section>
       <div class="calltoaction opt4 clear">
       <div style="text-align:center;">
       <p><b style="text-transform: uppercase;">Details of Student Attendence</b></p>
       </div>
       </div>
       </section>

         <div style="height:20px;"></div>

         <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="AttendanceId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="2000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="RegistrationNo">
                     <ItemTemplate>
                        <asp:Label ID="lblRegistrationNo" runat="server" Text='<%#Eval("RegistrationNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
               
                <asp:TemplateField HeaderText="Student Name">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>' />
                    </ItemTemplate>
                                       
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Class Name">
                     <ItemTemplate>
                        <asp:Label ID="lblClassName" runat="server" Text='<%#Eval("ClassName") %>' />
                    </ItemTemplate>
                                       
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Attendence">
                     <ItemTemplate>
                        <asp:Label ID="lblAbsent" runat="server" Text='<%#Eval("Absent") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Date">
                     <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>                           
                         <%--<asp:TemplateField HeaderText="View Details">
                             <ItemTemplate>
                                <a href="ShowStudentDetails.aspx?Sid=<%#Eval("StudentId") %>">View
                             </ItemTemplate>
                         </asp:TemplateField>--%>

                 <%--<asp:TemplateField HeaderText="ACTION">
                     <ItemTemplate>
                     <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="40px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="60px" />
                    </ItemTemplate>
                </asp:TemplateField>--%>


            </Columns>
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#657477" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>



       
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

