<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EmailSend.aspx.cs" Inherits="EmailSend" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="rnd5">
                            <div class="form-input clear">
                                <label class="one_half first" for="author">
                                    Name <span class="required">*</span><br>
                                    <asp:TextBox ID="txtCName" runat="server" Text=""></asp:TextBox>
                                </label>
                                <label class="one_half" for="email">
                                    Email <span class="required">*</span><br>
                                    <asp:TextBox ID="txtCMail" runat="server" Text=""></asp:TextBox>
                                </label>
                            </div>
                            <div class="form-input clear">
                                <div class="form-message">
                                    <label class="" for="email">
                                        Email <span class="required">*</span><br>
                                        <asp:TextBox ID="txtCMessage" runat="server" Text="" placeholder="Message" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                    </label>
                                </div>
                            </div>
                             <div class="form-input clear">
                                <div class="form-message">
                                    <label class="" for="email">
                                        From Email <span class="required">*</span><br>
                                        <asp:TextBox ID="txtEmail" runat="server" Text="" placeholder="Message" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                    </label>
                                </div>
                            </div>
                            <p>
                                <asp:Button ID="btnContactSubmit" runat="server" class="button small orange"
                                    Text="Submit" OnClick="btnContactSubmit_Click" />
                                &nbsp;
                                <asp:Button ID="btnContactReset" runat="server" class="button small grey"
                                    Text="Reset" OnClick="btnContactReset_Click" />
                          </p>
                       </div>
                   </div>
              </form>
</body>
</html>
