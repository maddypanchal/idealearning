<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Challan.aspx.cs" Inherits="Public_Challan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Challan</title>
    <link href="../css/Challan.css" rel="stylesheet" type="text/css" />
    <script language="javascript" type="text/javascript">

        function printpage() {
            window.print();
        }
    </script>
</head>
<body onload="window.print();">
    <form id="form1" runat="server">
<div class="wrapper">
<div class="content">
<div class="left">
<h1>(Applicant's Copy)</h1>
<h1 style="font-weight: normal; margin:15px 0 0 0px;">STATE BANK OF INDIA</h1>
<h2>Challan for remittance of application fees for BHEL, HERP,
Varanasi & CFP Rudrapur Recruitment of Artisans</h2>
<h2>'Power Jyoti' Account No. 31508804711 At SBI, Main Branch, Varanasi (Code: 0201)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px">
<h2>(Applicants Name (To be filled in by the applicant)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Mr./Mrs. &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<asp:Label ID="lblName" runat="server" Text=""></asp:Label> 
<%--<input type="text" class="input" />--%>
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of Birth &nbsp; &nbsp; &nbsp; :</p>
<asp:Label ID="lblDateOfBirth" runat="server" Text=""></asp:Label>
<%--<input type="text" class="input" />--%>
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp;&nbsp;  :</p>
<asp:Label ID="lblFatherName" runat="server" Text=""></asp:Label>
<%--<input type="text" class="input" />--%>
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Trade.&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
<%--<input type="text" class="input" />--%>
</div>
</div>
<h2 style="float:left; margin:5px 230px 10px 5px;width: 43%">To be filled by Branch</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Name &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Code &nbsp; &nbsp; &nbsp;   :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp; &nbsp;  :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of deposit &nbsp;&nbsp; :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width:93%; margin:10px 0 100px 12px">
<h2 style="text-decoration:none;">Application Fee : Rs. 125/-</h2>
<h2 style="text-decoration:none;">Bank Charges	: Rs. 50/-</h2>
<h2 style="text-decoration:none;">Total	:Rs. 175/-</h2>
<h2 style="text-decoration:none;">(Rupees One Hundred and Seventy Five only)</h2>
</div>
<div class="remit">
<div class="sign">
<h2 style="float:left; margin:0px 0 8px 8px;">Signature of Remitter</h2>
</div>
<div class="sign">
<h2 style="float:left; margin:0px 0 0px 8px; text-decoration:none;">Signature of authorized</h2>
<h2 style="float:left; margin:0px 0 8px 8px;">official with Branch Seal</h2>
</div>
</div>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should collect Rs. 50/- extra (Total Rs. 125 + Rs. 50/- =Rs. 175/-) from the remitter as Bank charges and to be credited to Branch Commission account.</p>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should write the Branch name, Branch Code, Journal No. and Date of remittance invariably and hand over both the BHEL's copy and the applicant's copy to the remitter duly signed.</p>
<h2>Last date for online submission of application : 1st jan., 2011</h2>
</div>

<div class="left">
<h1>(Applicant's Copy)</h1>
<h1 style="font-weight: normal; margin:15px 0 0 0px;">STATE BANK OF INDIA</h1>
<h2>Challan for remittance of application fees for BHEL, HERP,
Varanasi & CFP Rudrapur Recruitment of Artisans</h2>
<h2>'Power Jyoti' Account No. 31508804711 At SBI, Main Branch, Varanasi (Code: 0201)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px">
<h2>(Applicants Name (To be filled in by the applicant)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Mr./Mrs. &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of Birth &nbsp; &nbsp; &nbsp; :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp;&nbsp;  :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Trade.&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
</div>
<h2 style="float:left; margin:5px 230px 10px 5px;width: 43%">To be filled by Branch</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Name &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Code &nbsp; &nbsp; &nbsp;   :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp; &nbsp;  :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of deposit &nbsp;&nbsp; :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width:93%; margin:10px 0 100px 12px">
<h2 style="text-decoration:none;">Application Fee : Rs. 125/-</h2>
<h2 style="text-decoration:none;">Bank Charges	: Rs. 50/-</h2>
<h2 style="text-decoration:none;">Total	:Rs. 175/-</h2>
<h2 style="text-decoration:none;">(Rupees One Hundred and Seventy Five only)</h2>
</div>
<div class="remit">
<div class="sign">
<h2 style="float:left; margin:0px 0 8px 8px;">Signature of Remitter</h2>
</div>
<div class="sign">
<h2 style="float:left; margin:0px 0 0px 8px; text-decoration:none;">Signature of authorized</h2>
<h2 style="float:left; margin:0px 0 8px 8px;">official with Branch Seal</h2>
</div>
</div>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should collect Rs. 50/- extra (Total Rs. 125 + Rs. 50/- =Rs. 175/-) from the remitter as Bank charges and to be credited to Branch Commission account.</p>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should write the Branch name, Branch Code, Journal No. and Date of remittance invariably and hand over both the BHEL's copy and the applicant's copy to the remitter duly signed.</p>
<h2>Last date for online submission of application : 1st jan., 2011</h2>
</div>

<div class="left" style="border:none;">
<h1>(Applicant's Copy)</h1>
<h1 style="font-weight: normal; margin:15px 0 0 0px;">STATE BANK OF INDIA</h1>
<h2>Challan for remittance of application fees for BHEL, HERP,
Varanasi & CFP Rudrapur Recruitment of Artisans</h2>
<h2>'Power Jyoti' Account No. 31508804711 At SBI, Main Branch, Varanasi (Code: 0201)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px">
<h2>(Applicants Name (To be filled in by the applicant)</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Mr./Mrs. &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of Birth &nbsp; &nbsp; &nbsp; :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp;&nbsp;  :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Trade.&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
</div>
<h2 style="float:left; margin:5px 230px 10px 5px;width: 43%">To be filled by Branch</h2>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Name &nbsp; &nbsp; &nbsp;:</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Branch Code &nbsp; &nbsp; &nbsp;   :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Father's Name &nbsp; &nbsp;  :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width: 98%; margin: 0 0 2px 2px; border:none;">
<p>Date of deposit &nbsp;&nbsp; :</p>
<input type="text" class="input" />
</div>
<div class="content" style="width:93%; margin:10px 0 100px 12px">
<h2 style="text-decoration:none;">Application Fee : Rs. 125/-</h2>
<h2 style="text-decoration:none;">Bank Charges	: Rs. 50/-</h2>
<h2 style="text-decoration:none;">Total	:Rs. 175/-</h2>
<h2 style="text-decoration:none;">(Rupees One Hundred and Seventy Five only)</h2>
</div>
<div class="remit">
<div class="sign">
<h2 style="float:left; margin:0px 0 8px 8px;">Signature of Remitter</h2>
</div>
<div class="sign">
<h2 style="float:left; margin:0px 0 0px 8px; text-decoration:none;">Signature of authorized</h2>
<h2 style="float:left; margin:0px 0 8px 8px;">official with Branch Seal</h2>
</div>
</div>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should collect Rs. 50/- extra (Total Rs. 125 + Rs. 50/- =Rs. 175/-) from the remitter as Bank charges and to be credited to Branch Commission account.</p>
<p style="width: 96%; text-align: justify; margin: 0 0 10px 8px;">Branch should write the Branch name, Branch Code, Journal No. and Date of remittance invariably and hand over both the BHEL's copy and the applicant's copy to the remitter duly signed.</p>
<h2>Last date for online submission of application : 1st jan., 2011</h2>
</div>

</div>
</div>
    </form>
</body>
</html>
