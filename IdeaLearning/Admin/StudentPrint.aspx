<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentPrint.aspx.cs" Inherits="Admin_StudentPrint" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body onload="window.print();">
    <form id="form1" runat="server">

    <h1 style="text-align:center;"> STUDENT RECORD  </h1>
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
                        <asp:Label ID="lblRollNumber" runat="server" Text='<%#Eval("RegistrationNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Mobile">
                     <ItemTemplate>
                        <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                     <asp:TemplateField HeaderText="FatherNumber">
                     <ItemTemplate>
                        <asp:Label ID="lblFatherNumber" runat="server" Text='<%#Eval("FatherNumber") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Student Name">
                     <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text='<%#Eval("StudentName") %>' />
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
                                <asp:TemplateField HeaderText="ClassName">
                    <ItemTemplate>
                        <asp:Label ID="lblClassName" runat="server" Text='<%#Eval("ClassName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Course">
                    <ItemTemplate>
                        <asp:Label ID="lblCourseOne" runat="server" Text='<%#Eval("CourseOneText") %>' />
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

    </form>
</body>
</html>
