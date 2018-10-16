<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="StudentDetails.aspx.cs" Inherits="Employee_StudentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
      <section class="clear">
      <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>DETAILS OF STUDENT</b></p>
      </div>
      </div>
      </section>
     <div style="height:20px;"></div>
         <div class="form-input clear">
          <div class="one_half">
          <asp:Button ID="btnAddNew" runat="server" Text="Add Student"   class="button large gradient orange" PostBackUrl="~/Employee/AddStudent.aspx" />
        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" 
                class="button large gradient orange" onclick="btnSearch_Click"/>
        </div>
        </div>
         <div style="height:20px;"></div>
       
        <div class="form-input clear">
        <div class="one_sixth">
          <label for="author">
               Class Name  <span class="required"></span>
                            <br>
                          <asp:DropDownList ID="ddlClass" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                  </label>
                  </div>

                <%--<div class="one_sixth">
          <label for="author">
               Course <span class="required"></span>
                            <br>
                     <asp:DropDownList ID="ddlCourselist" runat="server" CssClass="Ddl_Css" AutoPostBack="true" 
                    onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                  </label>
                  </div>



                <div class="one_sixth">
          <label for="author">
               Subject  <span class="required"></span>
                            <br>
                  <asp:DropDownList ID="ddlSubject" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                  </label>
        </div>--%>

         <div class="one_sixth">
          <label for="author">
                               Student Name  <span class="required"></span>
                               <br>
                               <asp:TextBox ID="txtName" runat="server" Text="" CssClass=""></asp:TextBox>
                                </label>
        </div>
        <div class="one_sixth">
          <label for="author">
                              Mobile Number  <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtMobile" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        <div class="one_sixth">
          <label for="author">
                             Registration Number <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtRegistration" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
      
   
        </div>
        <div style="height:20px;"></div>
         <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="30" Width="100%" CssClass="tabl"
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
           <%--     <asp:TemplateField HeaderText="Data Of Birth">
                     <ItemTemplate>
                        <asp:Label ID="lblDateOfBirth" runat="server" Text='<%#Eval("DateOfBirth") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
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
               <asp:TemplateField HeaderText="Status">
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
                         </asp:TemplateField>
                        <asp:TemplateField HeaderText="Update Fee">
                    <ItemTemplate>
                     <a href="UpdateFee.aspx?Sid=<%#Eval("StudentId") %>">
                        <asp:Label ID="lblDuePayment" runat="server" Text='<%#Eval("DuePayment") %>' />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>

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

    <div class="clear"></div>
</asp:Content>

