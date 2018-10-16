<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="demo_Default3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter the frist number"></asp:Label>
        <asp:TextBox ID="txtFrist" runat="server" Text=""></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Enter the Second number"></asp:Label>
        <asp:TextBox ID="txtSecond" runat="server" Text=""></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Sum of two numbers"></asp:Label>
        <asp:TextBox ID="txtSum" runat="server" Text=""></asp:TextBox>
        
        
         <asp:Button ID="btnsubmit" runat="server" Text="Add" onclick="btnsubmit_Click" />
    </div>
    </form>
</body>
</html>
