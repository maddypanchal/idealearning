<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DemoResult.aspx.cs" Inherits="Employee_DemoResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
            <tr>
  
            </tr>
            <tr>
                <td>
                <br />
                <br />
                    <asp:FileUpload ID="FlUploadcsv" runat="server"  ForeColor="White"/>
                    <asp:Button ID="btnIpload" runat="server" Text="Import" OnClick="btnIpload_Click" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvEmployee" runat="server" ForeColor="White" width="100%" EmptyDataText="No records found">
                        <HeaderStyle BackColor="#89A0FE" />
                    </asp:GridView>
                </td>
            </tr>
         
        </table>
    </div>
    </form>
</body>
</html>
