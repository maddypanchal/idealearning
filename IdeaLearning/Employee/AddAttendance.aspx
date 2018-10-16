<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddAttendance.aspx.cs" Inherits="Employee_AddAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################-->
    <section class="clear">

      <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b style="text-transform: uppercase;">Add Attendance's Details</b></p>
      </div>
      </div>
      </section>
    
      <div style="height:20px;"></div>
      <div class="from-input clear">
        <div class="one_half">
              <label for="author">
                Date * <span class="required"></span>
                            <br>
                <asp:TextBox ID="txtDate" runat="server" Text="" ></asp:TextBox>
                             </label>
                             </div>
                             <div class="one_half">
                               <label for="author">
                               Class Name <span class="required"></span>
                               <br>
                     <asp:DropDownList ID="ddlClass" runat="server"  AutoPostBack="true" CssClass="Ddl_Css" onselectedindexchanged="ddlClass_SelectedIndexChanged" >
                     </asp:DropDownList>
                            </label>
                             </div>
              </div>
              <div class="from-input clear">
              <div class="one_half">
              <label for="author">
               Course Name * <span class="required"></span>
                            <br>
                             <asp:DropDownList ID="ddlCourselist" runat="server" CssClass="Ddl_Css" AutoPostBack="true" 
                    onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
              </label>
               </div>
                 <div class="one_half">
                 <label for="author">
                Subject Name * <span class="required"></span>
                             <br>
                <asp:DropDownList ID="ddlSubject" runat="server"  AutoPostBack="true"  CssClass="Ddl_Css" onselectedindexchanged="ddlSubject_SelectedIndexChanged">
                </asp:DropDownList>
               </label>
               </div>
               </div>
              
            <div style="height:20px;"></div>
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="50" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Student Id">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentId" runat="server" Text='<%#Eval("StudentId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Roll Number">
                     <ItemTemplate>
                        <asp:Label ID="lblRollNumber" runat="server" Text='<%#Eval("RollNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student Name">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Father Name">
                    <ItemTemplate>
                        <asp:Label ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile">
                    <ItemTemplate>
                        <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("FatherNumber") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Attendence">
                   <ItemTemplate>
                       <asp:CheckBox ID="chkAttendence" runat="server" />
                   </ItemTemplate>
               </asp:TemplateField>
                 <%--<asp:TemplateField HeaderText="View Details">
                         <ItemTemplate>
                         <a href="ShowStudentDetails.aspx?Sid=<%#Eval("StudentId")%>">View</a>
                         </ItemTemplate>
                         </asp:TemplateField> --%>
                 <%-- <asp:TemplateField HeaderText="ACTION">
                     <ItemTemplate>
                     <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="40px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="60px" />
                    </ItemTemplate>
                </asp:TemplateField>--%>
            </Columns>
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#657477" ForeColor="White" HorizontalAlign="Center"/>
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        
      <div style="height:20px;"></div>
        <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg warning" ForeColor="Green" Visible="false"></asp:Label>
        <asp:Button ID="btnSaveButton" runat="server" Text="Mark Addtendance" class="button large gradient orange" Visible="false" onclick="btnSaveButton_Click" />
         
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

