<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DeleteStudent.aspx.cs" Inherits="Admin_deleteStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <!-- ################################################################################################ -->
    <section class="clear">

              <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;">DETAILS OF STUDENT</b></p>

     </div>
      </div>
     
    </section>
     <div style="height:20px;"></div>
       <%-- <asp:Button ID="btnAddNew" runat="server" Text="Add Student"   class="button large gradient orange" PostBackUrl="~/Employee/AddStudent.aspx" />--%>
         <div style="height:20px;"></div>
       
        <div class="form-input clear">
        <div class="one_fifth">
        <label for="author">
               Class Name  <span class="required"></span>
                            <br>
                          <asp:DropDownList ID="ddlClass" runat="server" CssClass="Ddl_Css" ValidationGroup="aa" >
                </asp:DropDownList>
                  </label>
        </div>

        <div class="one_third">
          <asp:Button ID="btnSearch" runat="server" Text="SEARCH" ValidationGroup="aa"
                class="button large gradient orange" onclick="btnSearch_Click"/>
              <asp:Button ID="btnDelete" runat="server" Text="Delete" ValidationGroup="aa"
                class="button large gradient orange" onclick="btnDelete_Click"/>
         <asp:Label ID="lblmsg" runat="server" Text="" ></asp:Label>
 

            
        </div>
        </div>
        <div style="height:20px;"></div>

         <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="50" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" onpageindexchanging="gvDetail1_PageIndexChanging" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="RegistrationNo">
                     <ItemTemplate>
                        <asp:Label ID="lblRollNumber" runat="server" Text='<%#Eval("RegistrationNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
            
              
                <asp:TemplateField HeaderText="Student Name">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  
                <asp:TemplateField HeaderText="Father Name ">
                    <ItemTemplate>
                        <asp:Label ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>


                   <asp:TemplateField HeaderText="Email ">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Date Of Birth">
                    <ItemTemplate>
                        <asp:Label ID="lblDateOfBirth" runat="server" Text='<%#Eval("DateOfBirth") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="User Name ">
                    <ItemTemplate>
                        <asp:Label ID="lblUserName" runat="server" Text='<%#Eval("UserName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Password">
                    <ItemTemplate>
                        <asp:Label ID="lblPassword" runat="server" Text='<%#Eval("Password") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <%--  <asp:TemplateField HeaderText="ClassName">
                    <ItemTemplate>
                        <asp:Label ID="lblClassName" runat="server" Text='<%#Eval("ClassName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                    <%--            <asp:TemplateField HeaderText="Course">
                    <ItemTemplate>
                        <asp:Label ID="lblCourseOne" runat="server" Text='<%#Eval("CourseOne") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>

           <%--    <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbtn_IS_LOCKED" runat="server" BorderStyle="None" BorderWidth="0"
                                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "StudentId")%>' OnCommand="IS_LOCKED_Activate_Deactivate"
                                            Text='<%#DataBinder.Eval(Container.DataItem, "IsActive")%>'>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                             <asp:TemplateField HeaderText="View Details">
                             <ItemTemplate>
                                <a href="ShowStudentDetails.aspx?Sid=<%#Eval("StudentId") %>">View
                             </ItemTemplate>
                         </asp:TemplateField>--%>
                  <%--     <asp:TemplateField HeaderText="ACTION">
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
    
        <div class="one_half">
        
      
        
        </div>

    <div class="clear"></div>



</asp:Content>

