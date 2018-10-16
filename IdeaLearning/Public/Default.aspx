<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Public_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<%--
    <script src="fancybox/jquery-1.4.3.min.js" type="text/javascript"></script>
    <script src="fancybox/jquery.fancybox-1.3.4.pack.js" type="text/javascript"></script>
    <link href="fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" type="text/css" />--%>


    <script src="../SimpalPopUp/fancybox/jquery-1.4.3.min.js" type="text/javascript"></script>
    <script src="../SimpalPopUp/fancybox/jquery.easing-1.3.pack.js" type="text/javascript"></script>
    <link href="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" type="text/css" />
    <script src="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.js" type="text/javascript"></script>
    <script src="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.pack.js" type="text/javascript"></script>
    <script src="../SimpalPopUp/fancybox/jquery.mousewheel-3.0.4.pack.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".Panchal").fancybox({
                'width': '50%',
                'height': '85%',
                'autoScale': false,
                'transitionIn': 'elastic',
                'transitionOut': 'elastic',
                'type': 'iframe'
            });
        });
        function msg() {
            alert("Entry Done!!!")
            window.parent.location = 'sideForm';
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<a  class="Panchal" href="../Public/EmailContact.aspx">Popup</a>
</asp:Content>

