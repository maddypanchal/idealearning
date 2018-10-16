<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="UpdateFee.aspx.cs" Inherits="Employee_UpdateFee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       
     <div id="container">
        <div class="wrapper">
            <div class="content_main">
                <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p><b>Student Fee Update </b></p>
                         <asp:Label ID="lblMsg" runat="server"   Text=" "></asp:Label>
                    </div>

             
                </div>
                <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Due payment
                             <asp:TextBox ID="txtDuepayment" runat="server" Text="" class="name_Contact"></asp:TextBox>
                            </label>
                     </div>
                      <div class="one_half">
                        <label for="author">
                             Due Date*
               
            <asp:TextBox ID="txtDate" runat="server" Text="" class="name_Contact"></asp:TextBox>
                            </label>
                     </div>
                    </div>

                 <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                                        Father Mobile *
                                 <asp:TextBox ID="txtFatherNumber" runat="server" Text="" class="name_Contact"></asp:TextBox>
         
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
                              <asp:Button ID="btnSubmit" runat="server" Text="Update" class="button large gradient orange" 
                onclick="btnSubmit_Click"  />
                            </label>
                        </div>
                     <div class="one_half">
                        <label for="author">
                              <asp:Button ID="btnSend" runat="server" Text="Send SMS" class="button large gradient orange" 
                onclick="btnSend_Click"  />
                                   <asp:Button ID="txtBack" runat="server" Text="Back" OnClick="txtBack_Click" class="button large gradient orange"  />
                            </label>
                        </div>
                     </div>
                </div>
            </div>
         </div>
    
    
      
   </asp:Content>
