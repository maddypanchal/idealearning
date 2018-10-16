<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cropimages.aspx.cs" Inherits="Admin_Cropimages" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../_script/jquery-1.5.1.min.js" type="text/javascript"></script>
    <script src="../_script/jquery.Jcrop.min.js" type="text/javascript"></script>
    <link href="../_script/jquery.Jcrop.css" rel="stylesheet" type="text/css" />
     <script type="text/javascript">
         $(function () {
             $('#ImFullImage').Jcrop({
                 onSelect: updateCoords,
                 onChange: updateCoords
             });
         });
         function updateCoords(c) {
             $('#hfX').val(c.x);
             $('#hfY').val(c.y);
             $('#hfHeight').val(c.h);
             $('#hfWidth').val(c.w);
         }
    </script>
      <script type="text/javascript">
          function UploadFile(fileUpload) {
              if (fileUpload.value != '') {
                  document.getElementById("<%=btnUpload1.ClientID %>").click();
              }
          }
    </script>
</head>
<body style="background-color: transparent;">
      
 <form id="form1" runat="server">
       <asp:ScriptManager EnablePartialRendering="true" ID="ScriptManager1" runat="server" />
      <%--<asp:UpdatePanel ID="UpdatePanel1" UpdateMode="Conditional" runat="server">
            <ContentTemplate>--%>
    <asp:HiddenField ID="hfX" runat="server" />
     <asp:HiddenField ID="hfY" runat="server" />
     <asp:HiddenField ID="hfHeight" runat="server" />
     <asp:HiddenField ID="hfWidth" runat="server" />
     <div class="images">
     <div>  
     Original Image: <br />
   
                       <asp:FileUpload ID="FileUpload1" runat="server" />
      <br />
       <asp:Label ID="lblMessage" runat="server" Text="File uploaded successfully." ForeColor="Green"
       Visible="false" />
       <asp:Button ID="btnUpload1" Text="Upload" runat="server" OnClick="Upload" Style="display: none" />
       <asp:Image ID="ImFullImage" ImageUrl=""  runat="server" Visible="false"  /><br />
       <asp:Button ID="btnCrop" runat="server" Text="Crop Image" onclick="btnCrop_Click" /><br />
    </div>
    <br />
    <div>
    <div style="color:green; margin:0 0 0 0px; font-size:19px;"><b> <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>  </b></div> <br />
           <asp:Image ID="imCropped" runat="server" Visible="false" />
     </div>    
          
     </div>

       
    </form>
</body>
</html>
