<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Public_Results" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login..... !</title>
    <link href="../css/result.css" rel="stylesheet" type="text/css" />
    <link href="../css/Results.css" rel="stylesheet" type="text/css" />
    <link rel="shortcut icon" href="../images/favicon.ico" type="image/x-icon" />
    <link rel="icon" href="../images/favicon.ico" type="image/x-icon" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <div class="wrapper row3">
        <div id="container">
            <table width="1000px" cellspacing="0" cellpadding="0" align="center" style="border: 1px solid #999999;
                margin-bottom: 10px;">
                <tbody>
                    <tr>
                        <td valign="top" colspan="2" style="background-color: #333333; padding: 15px 0 15px 80px;">
                            <img alt="Logo" src="../images/idea-final-logo.png">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <hr style="color: #cccccc;" size="1px;">
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <table width="90%" border="0" cellpadding="0" cellspacing="0" align="center">
                                <tbody>
                                    <tr>
                                        <td align="center" colspan="3">
                                            <div id="searchResultDiv">
                                                <form name="searchResultForm" id="searchResultForm" action="" method="post">
                                                <table width="100%" border="0" align="center" class="">
                                                    <tbody>
                                                        <tr>
                                                            <th colspan="2" align="left" style="font-size: 16px;">
                                                                &nbsp;Result
                                                            </th>
                                                        </tr>
                                                        <tr class="tablebody">
                                                            <td colspan="2">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr class="tablebody">
                                                            <td style="padding-left: 10px;" align="right">
                                                                Select Exam:
                                                            </td>
                                                            <td style="padding-left: 10px;" align="left">
                                                                <div class="row_field">
                                                                    <asp:DropDownList ID="ddlResult" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlResult_SelectedIndexChanged"
                                                                        CssClass="dropdownlist">
                                                                        <asp:ListItem Value="0">Select One</asp:ListItem>
                                                                        <asp:ListItem Value="1">ScholarShip Test</asp:ListItem>
                                                                        <asp:ListItem Value="2">ITSE TEST</asp:ListItem>
                                                                    </asp:DropDownList>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="2">
                                                                <asp:UpdatePanel ID="UpScholarShipTest" UpdateMode="Conditional" Visible="false"
                                                                    runat="server">
                                                                    <ContentTemplate>
                                                                        <div class="form-input clear">
                                                                            <asp:GridView ID="GvScholerShip" runat="server" AutoGenerateColumns="False" DataKeyNames="ScholerTestResultId"
                                                                                HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
                                                                                EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
                                                                                font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
                                                                                GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
                                                                                <AlternatingRowStyle BackColor="White" />
                                                                                <Columns>
                                                                                    <asp:TemplateField HeaderText="S No.">
                                                                                        <ItemTemplate>
                                                                                            <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Test Code">
                                                                                        <ItemTemplate>
                                                                                            <asp:Label ID="lblTestCode" runat="server" Text='<%#Eval("ScholerTestCode") %>' />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Test Name">
                                                                                        <ItemTemplate>
                                                                                            <asp:Label ID="lblTestName" runat="server" Text='<%#Eval("ScholerTestName") %>' />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Test Date">
                                                                                        <ItemTemplate>
                                                                                            <asp:Label ID="lblTestDate" runat="server" Text='<%#Eval("ScholerTestDate") %>' />
                                                                                        </ItemTemplate>
                                                                                    </asp:TemplateField>
                                                                                    <asp:TemplateField HeaderText="Result Sheet">
                                                                                        <ItemTemplate>
                                                                                            <a href="ScholerShipResult.aspx?Sid=<%#Eval("ScholerTestResultId") %>">Show Result Sheet </a>
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
                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                                <asp:UpdatePanel ID="UpItseTest" UpdateMode="Conditional" Visible="false" runat="server">
                                                                    <ContentTemplate>
                                                                        <div>
                                                                                   Select Year * 
           
            <asp:DropDownList ID="ddlselectYear" runat="server" CssClass="dropdownlist" >  
            
            
            </asp:DropDownList>    
            <br />                                                 
                                                                                    Roll No:
                                                                            
                                                                                
                                                                                        <asp:TextBox ID="txtRollNo" runat="server" Text="" CssClass="text1"></asp:TextBox>
                                                                                                                                                 
                                                                                    <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="submit" OnClick="btnSearch_Click" />
                                                                           
                                                                           
                                                                        </div>
                                                                    </ContentTemplate>
                                                                </asp:UpdatePanel>
                                                            </td>
                                                        </tr>
                                                        <tr class="tablebody">
                                                            <td colspan="2">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                    </tbody>
                                                </table>
                                                </form>
                                            </div>
                                            <div class="class1" style="margin: 30px 0px 0px 0px;">
                                            </div>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3">
                                            <hr style="color: #cccccc;" size="1px;" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="3" align="center">
                                            <div class="copyrighttxt">
                                                Idea Learning Academy, Ambala, India. All rights reserved.<br />
                                                Website designed &amp; maintained by <a href="http://oraexprts.in" class="copyrighttxt">
                                                Sonraitsolutions, Kurukshetra</a></div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
