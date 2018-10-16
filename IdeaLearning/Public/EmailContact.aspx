<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmailContact.aspx.cs" Inherits="Public_EmailContact" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style >
    .textbox
    {
         font-family: Comic Sans MS;
    height: 33px;
    margin: 5px 0 6px;
    width: 300px;
    }
    
       .button
    {
    font-family: Arial;
    font-size: 20px;
      margin: 5px 0 6px;
    padding: 4px 0;
    width: 112px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Name : <br />
      <asp:TextBox ID="txtName" runat="server" Text="" CssClass="textbox" > </asp:TextBox><br />
      Mobile : <br />
      <asp:TextBox ID="txtMobile" runat="server" Text="" CssClass="textbox">  </asp:TextBox><br />
       Email : <br />
        <asp:TextBox ID="txtEmail" runat="server" Text="" CssClass="textbox"> </asp:TextBox><br />
       Purpose : <br />
      <asp:TextBox ID="txtPurpose" runat="server" Text="" CssClass="textbox"> </asp:TextBox><br />
          <br />
      <asp:Button ID="btnSend"  runat="server" Text="Send" onclick="btnSend_Click" CssClass="button"  />
    </div>
    </form>
</body>
</html>
