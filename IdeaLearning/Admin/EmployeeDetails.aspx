<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeeDetails.aspx.cs" Inherits="Admin_EmployeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <div class="wrapper row3">
        <div id="container">
            <!-- ################################################################################################ -->
            <div id="portfolio">

              <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;">DETAILS OF EMPLOYEE   </b></p>
     </div>
      </div>
   </section>
                <div style="width: 100%; height: 20px;">
                </div>
  <asp:Button ID="btnAddNew" runat="server" Text="Add Employee"  CssClass="button large gradient orange"
      PostBackUrl="~/Admin/AddEmployee.aspx" />
           <div style="width: 100%; height: 20px;">
                </div>


                <div class="form-input clear">
        <div class="one_fifth">
          <label for="author">
                            Email <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtEmail" runat="server" Text="" CssClass=""></asp:TextBox>
                  </label>
        </div>
         <div class="one_fifth">
          <label for="author">
                               Employee Name  <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtName" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        <div class="one_fifth">
          <label for="author">
                              Mobile Number  <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtMobile" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        <div class="one_fifth">
          <label for="author">
                            Employee Code<span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtEmployeeCode" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        <div class="one_fifth">
        
        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" 
                class="button large gradient orange" onclick="btnSearch_Click"/>
        
        </div>
   
        </div>
                   <div style="width: 100%; height: 20px;">
                </div>
    <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 14px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  
            onrowdeleting="gvDetail1_RowDeleting" 
            onpageindexchanging="gvDetail1_PageIndexChanging" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Employee Code">
                  
                    <ItemTemplate>
                        <asp:Label ID="lblEmployeeCode" runat="server" Text='<%#Eval("EmployeeCode") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Disgnation">
                <ItemTemplate>
                <asp:Label ID="lblDisgnation" runat="server" Text='<%#Eval("Designation")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee Name">
                  
                    <ItemTemplate>
                        <asp:Label ID="lblEmployeeName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Father Name ">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <%--<asp:TemplateField HeaderText="Location">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblLocations" runat="server" Text='<%#Eval("City") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
              
                   <asp:TemplateField HeaderText="Status">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbtn_IS_LOCKED" runat="server" BorderStyle="None" BorderWidth="0"
                                            CommandArgument='<%#DataBinder.Eval(Container.DataItem, "EmployeeId")%>' OnCommand="IS_LOCKED_Activate_Deactivate"
                                            Text='<%#DataBinder.Eval(Container.DataItem, "IsActive")%>'>
                                        </asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>

                    <asp:TemplateField HeaderText="View Details">
                            <ItemTemplate>
                                <a href="PreviewEmployeeDetails.aspx?Eid=<%#Eval("EmployeeId") %>">View</a>
                            </ItemTemplate>
                        </asp:TemplateField>
                <asp:TemplateField HeaderText="ACTION">
                  
                    <ItemTemplate>
             
                        <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="50px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="70px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
           <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="NotSet"   />
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
                 </div>
                  </div>
                       <div class="form-input clear">
        <div class="one_fifth">
               <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg error" Visible="false"></asp:Label>
               </div>
                   </div>


</asp:Content>

