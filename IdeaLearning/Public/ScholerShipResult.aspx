<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ScholerShipResult.aspx.cs" Inherits="Public_ScholerShipResult" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

       <div class="wrapper row3">
  <div id="container">
<div id="mainDiv" style="border:1px solid #999999;">
<div id="contentbody">
 <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

<table width="800" cellspacing="0" cellpadding="0" align="center" style="border:1px solid #999999; margin-bottom:10px;">
  	<tbody><tr>
    	<td valign="top" colspan="2" style="background-color:#333333;  padding: 15px 0 15px 80px;"> 
        <img alt="Logo" src="../images/idea-final-logo.png" />
        </td>
		
    </tr>
	<tr>
  	  <td colspan="2"><hr style="color:#cccccc;" size="1px;" /></td>
	</tr>
	
	<tr>
		<td colspan="2">
        <table width="90%" border="0" cellpadding="0" cellspacing="0" align="center">
		<tbody>
		<tr>
	    <td align="center" colspan="3"> 
		<div> Enter Roll No <asp:TextBox ID="txtRollNo" Text="" runat="server" ></asp:TextBox>  
        <asp:Button ID="btnScholerSeach" runat="server" Text="Seach" 
                onclick="btnScholerSeach_Click"  />
         </div>
               <asp:UpdatePanel ID="UpScholerShip" UpdateMode="Conditional" Visible="false" runat="server">
               <ContentTemplate>
               
                <table border="0" align="center" class="tablebgcolor" style="border:solid 0px #999999; width:550px;">
		  <tbody>
          <tr>
          <th align="left" style="font-size:16px;">Congratulations
          </th>
          </tr>
				<tr class="tablebody"><td>&nbsp;</td>
                </tr>
                <tr>
                <td>
                <div>
                Dear <b><asp:Label ID="lblName"  runat="server" Text=""></asp:Label></b> Your Roll No is <b><asp:Label ID="lblRollNo"  runat="server" Text=""></asp:Label></b>
                <br/> & Your ScholarShip Test <b><asp:Label ID="LblYear" runat="server" Text=""></asp:Label></b>  Rank is <b><asp:Label ID="lblRank"  runat="server" Text=""></asp:Label></b>
                <br />
                You won <b><asp:Label ID="lblPrice"  runat="server" Text=""></asp:Label></b><br />
                Venue & Date Of Celebration When you will receive Prizes and Scholarship will be informed soon through SMS
                <br /> Please visit IDEA Office to collect Your prise & Career Advice
                <br />
                For Appointment :- 01744-226768,9416141315
                <br /> Regards IDEA Admin Team
                </div>
                </td>
                </tr>
                
				<%--<tr class="tablebody">
					<td align="right" style="padding-left:10px;">Roll No. : </td>
					<td class="row_field">&nbsp;390752</td>
				</tr>
				
				<tr class="tablebody">
					<td align="right" style="padding-left:10px;">Reg No. : </td>
					<td class="row_field">&nbsp;07-DMK-193</td>
				</tr>
				<tr class="tablebody"> 
					<td align="right" class="tablebody">Name : </td>
					<td class="row_field">&nbsp;UMA RANI</td>
				</tr>
				<tr class="tablebody">
					<td align="right" style="padding-left:10px;">Father Name : </td>
					<td class="row_field">&nbsp;PURAN SINGH</td>
				</tr>
				<tr class="tablebody">
					<td align="right" style="padding-left:10px;">Result : </td>
					<td class="row_field">&nbsp;0476</td>
				</tr>--%>
				<tr class="tablebody">
					<td align="center"><b></b></td>
				</tr>
				
				<tr class="tablebody"><td>&nbsp;</td></tr>
			<%--	<tr class="tablebody"><td align="center" colspan="2"><a href="#">Back to Results</a></td></tr>--%>
				</tbody></table>
                
                </ContentTemplate>
                </asp:UpdatePanel>
                  </div>
		    <div class="class1" style="margin:30px 0px 0px 0px;">
                </div>
				</td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;
                    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </td>
				</tr>
	   			<tr>
    				<td colspan="3">&nbsp;</td>
 				</tr>
  				<tr>
    				<td colspan="3"><hr style="color:#cccccc;" size="1px;"></td>
 				</tr>
				<tr>
				<td colspan="3" align="center">
				<div class="copyrighttxt">IDEA Learning Academy, Kurukshetra, India. All rights reserved.ra, India. All rights reserved.<br>Website designed &amp; maintained by <a href="#" class="copyrighttxt">Rakesh Panchal</a></div>
					</td>
				</tr>
			</tbody></table>
					</td>
				</tr>
			</tbody></table>

 </div>
  </div>
</div>
</div>
   
    </form>
</body>
</html>
