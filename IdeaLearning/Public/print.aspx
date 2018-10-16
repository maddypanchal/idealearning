<%@ Page Language="C#" AutoEventWireup="true" CodeFile="print.aspx.cs" Inherits="Public_print" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script >
        function printData() {
           var divToPrint = document.getElementById("xyz");
            newWin = window.open("");
            newWin.document.write(divToPrint.outerHTML);
            newWin.print();
            newWin.close();

        }
</script>
</head>
<body >
    <form id="form1" runat="server">
     <asp:Button ID="btnPrint" runat="server" Text="Print" OnClientClick = "return printData();" />
    <%-- <input type="button" name="print" onclick="printData();" value="print" />--%>
    <div id="xyz" >


  rakesh is the bast
    </div>

    </form>
</body>
</html>
