<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="FillTaskByEmployee.aspx.cs" Inherits="Employee_FillTaskByEmployee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

            <section>
 
  <div style="height:20px;"></div>

                <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>DETAILS OF TASK</b></p>
     </div>
      </div>
    
       <%--<div class="one_third">
       <a href="#" class="button large gradient orange">Contact Us</a></div>--%>

    </section>

   <div style="height:20px;"></div>

     <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeWorkDetailsId"
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
                  <asp:TemplateField HeaderText="Task Update Date">
                    <ItemTemplate>
                        <asp:Label ID="lblTaskUpdateDate" runat="server" Text='<%#Eval("TaskUpdateDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                              <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkFor" runat="server" Text='<%#Eval("EmployeeName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="WorkDone">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkDone" runat="server" Text='<%#Eval("WorkDone")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Pending Work">
                    <ItemTemplate>
                        <asp:Label ID="lblPendingWork" runat="server" Text='<%#Eval("PendingWork") %>' />
                    </ItemTemplate>
        
                </asp:TemplateField>

                           <asp:TemplateField HeaderText="Reason For Pending">
                    <ItemTemplate>
                        <asp:Label ID="lblLastDateOfComplate" runat="server" Text='<%#Eval("ReasonForPending") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                           <asp:TemplateField HeaderText="Remark">
                    <ItemTemplate>
                        <asp:Label ID="lblInstruction" runat="server" Text='<%#Eval("Remark") %>' />
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

             <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg success" Visible="false" ForeColor="Red"></asp:Label>
     </div>



    
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>

</asp:Content>

