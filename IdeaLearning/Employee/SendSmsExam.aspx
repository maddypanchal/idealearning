<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="SendSmsExam.aspx.cs" Inherits="Employee_SendSmsExam" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       <div id="container">
        <div class="wrapper">
            <div class="content_main">
                <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p><b>Exam Info Sms
                           </b></p>
                         <asp:Label ID="lblMsg" runat="server"   Text=" "></asp:Label>
                    </div>
                </div>
                 <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                                        Date *
                                 <asp:TextBox ID="txtDate" runat="server" Text="" class="name_Contact"></asp:TextBox>
                        </label>
                        </div>
                     <div class="one_half">
                        <label for="author">
                                   Message*
                                 <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="7" Text="" ></asp:TextBox>
                         </label>
                        </div>
                     </div>
                </div>
               <div class="form-input clear">
                  <div class="one_half">
                        <label for="author">
                            <asp:Button ID="btnBack" runat="server" Text="Back" class="button large gradient orange" OnClick="btnBack_Click" />  
                            <asp:Button ID="btnSend" runat="server" Text="Send SMS" class="button large gradient orange" OnClick="btnSend_Click" />
                            </label>
                        </div>
                     </div>
                </div>
            </div>
         </div>
    
</asp:Content>

