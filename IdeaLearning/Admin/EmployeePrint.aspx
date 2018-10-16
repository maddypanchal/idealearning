﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EmployeePrint.aspx.cs" Inherits="Admin_EmployeePrint" %>

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

    <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
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
                 <asp:TemplateField HeaderText="Location">
                 
                    <ItemTemplate>
                     <asp:Label ID="lblCity" runat="server" Text= '<%#Eval("RegionName") %>' />
                        <asp:Label ID="lblState" runat="server" Text= '<%#Eval("StateName") %>' />
                         
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mobile">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mentor ">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblMentorsOne" runat="server" Text='<%#Eval("MentorsOne") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Date Of Join">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblDateOfJoin" runat="server" Text='<%#Eval("DateOfJoin") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Email">
                 
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                


              <%--
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

           
        
        <asp:Button ID="Button1" runat="server" Text="PRINT"  PostBackUrl="~/Admin/EmpPrint.aspx"
                class="button large gradient orange"/>
   
                 </div>
                  </div>
                        </div>
                 
</asp:Content>

