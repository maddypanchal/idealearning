<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SMS.aspx.cs" Inherits="SMS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox ID="txtmsg" runat="server" Text=""></asp:TextBox>
        <asp:Button ID="send" runat="server" Text="send" OnClick="send_Click" />
    </div>
    </form>
</body>
</html>
