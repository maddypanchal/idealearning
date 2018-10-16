<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Calculate Age</title>
<script type="text/javascript">

function CalculateAge(birthday) {

var re=/^(0[1-9]|1[0-12])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d+$/;

if (birthday.value != '') {

if(re.test(birthday.value ))
{
birthdayDate = new Date(birthday.value);
dateNow = new Date();

var years = dateNow.getFullYear() - birthdayDate.getFullYear();
var months=dateNow.getMonth()-birthdayDate.getMonth();
var days=dateNow.getDate()-birthdayDate.getDate();
if (isNaN(years)) {

document.getElementById('lblAge').innerHTML = '';
document.getElementById('lblError').innerHTML = 'Input date is incorrect!';
return false;

}

else {
document.getElementById('lblError').innerHTML = '';

if(months < 0 || (months == 0 && days < 0)) {
years = parseInt(years) -1;
document.getElementById('lblAge').innerHTML = years +' Years '
}
else {
document.getElementById('lblAge').innerHTML = years +' Years '
}
}
}
else
{
document.getElementById('lblError').innerHTML = 'Date must be mm/dd/yyyy format';
return false;
}
}
}
</script>
</head>
<body>
    <form id="form1" runat="server">
   <div>
Date of Birth :<asp:TextBox ID="txtAge" runat="server" onblur="CalculateAge(this)" />(mm/dd/yyyy)
<span style="color: Red">
<asp:Label ID="lblError" runat="server"></asp:Label></span>
<br />
Age&nbsp;&nbsp;&nbsp; : <span id="lblAge"></span>
</div>
    </form>
</body>
</html>
