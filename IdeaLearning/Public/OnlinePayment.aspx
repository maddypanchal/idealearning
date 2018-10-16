<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="OnlinePayment.aspx.cs" Inherits="Public_OnlinePayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/courses.css" rel="stylesheet" type="text/css" />
    <script src="../js/Print.js" type="text/javascript"></script>
    <script>
        function printData() {

            var divToPrint = document.getElementById("xyz");
            newWin = window.open("");
            newWin.document.write(divToPrint.outerHTML);
            newWin.print();
            newWin.close();

        }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="course_wrapper">
  <div class="course_contentner">
  <div id="printdata" style="margin:0 0 20px 140px; float:left;">
    <asp:Image ID="Image1"  ImageUrl="~/images/construction.jpg" runat="server" />
    </div>
    </div>
    </div>
</asp:Content>

