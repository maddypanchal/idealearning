<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AttendanceDetails.aspx.cs" Inherits="Employee_AttendanceDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">


       <section>
       <div class="calltoaction opt4 clear">
       <div style="text-align:center;">
       <p><b >DETAILS OF STUDENT</b></p>
       </div>
       </div>
       </section>

           <div style="width: 100%; height: 20px;">
                </div>
           <div class="form-input clear">
        <div class="one_fifth">
          <label for="author">
                            Registration no <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtRegistration" runat="server" Text="" CssClass=""></asp:TextBox>
                  </label>
        </div>
         <div class="one_fifth">
          <label for="author">
                             Student Name  <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtName" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        
        <div class="one_fifth">
        
        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" 
                class="button large gradient orange" onclick="btnSearch_Click"/>
        
        </div>
   
        </div>

                   <div style="width: 100%; height: 20px;">
                </div>


    
           <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId"
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
                <asp:TemplateField HeaderText="Class">
                     <ItemTemplate>
                        <asp:Label ID="lblClassName" runat="server" Text='<%#Eval("ClassName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Subject">
                     <ItemTemplate>
                        <asp:Label ID="lblSubjectName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Courses">
                     <ItemTemplate>
                        <asp:Label ID="lblCoursesName" runat="server" Text='<%#Eval("CoursesName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student Name">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            <%--      
                <asp:TemplateField HeaderText="Father Name ">
                    <ItemTemplate>
                        <asp:Label ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                                <%--<asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbtn_IS_LOCKED" runat="server" BorderStyle="None" BorderWidth="0"
                                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "StudentId")%>' OnCommand="IS_LOCKED_Activate_Deactivate"
                                            Text='<%#DataBinder.Eval(Container.DataItem, "IsActive")%>'>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>--%>
                             <asp:TemplateField HeaderText="View Details">
                             <ItemTemplate>
                                <a href="AttendanceDetailByStudent.aspx?Sid=<%#Eval("StudentId") %>">View
                             </ItemTemplate>
                         </asp:TemplateField>
                    <%--    <asp:TemplateField HeaderText="Update Fee">
                    <ItemTemplate>
                     <a href="UpdateFee.aspx?Sid=<%#Eval("StudentId") %>">
                        <asp:Label ID="lblDuePayment" runat="server" Text='<%#Eval("DuePayment") %>' />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>--%>

                <asp:TemplateField HeaderText="ACTION">
                     <ItemTemplate>
                     <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="40px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="60px" />
                    </ItemTemplate>
                </asp:TemplateField>
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
    
     <asp:Label ID="lblmsg" runat="server" text="" CssClass="alert-msg error" Visible="false"></asp:Label>

       
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

