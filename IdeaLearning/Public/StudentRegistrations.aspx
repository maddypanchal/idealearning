<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true"
    CodeFile="StudentRegistrations.aspx.cs" Inherits="Public_StudentRegistrations" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
  <link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>

    <script type="text/javascript">
        function init() {
            calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="wrapper row3">
        <div id="container">
            <div class="clear columncolor">
                <p class="emphasise">
                    STUDENT REGISTRATIONS</p>
                <div class="one_third first ">
                    <code class="">
                        <img src="../images/StudentRegisrtations.jpg" />
                    </code>
                </div>
                <div class="two_third">
                    <code class="code">
                        <div class="form-input clear">
                            <div class="one_half">
                               <p>
                                        Student Name*</p>
                                    <asp:TextBox ID="txtStudentName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStudentName"
                                        Text="* fields required" />
                            </div>
                            <div class="one_half">
                                <p>
                                        Father Name*</p>
                                    <asp:TextBox ID="txtFatherName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtFatherName"
                                        Text="* fields required" />
                            </div>
                        </div>
                        <div class="form-input clear">
                            <div class="one_half">
                              <p>
                                        Mother Name*</p>
                                    <asp:TextBox ID="txtMotherName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtMotherName"
                                        Text="* fields required" />
                            </div>
                            <div class="one_half">
                               <p>
                                        Date of Birth*</p>
                                    <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" class="name_Contact1 tcal"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDateOfBirth"
                                        Text="* fields required" />
                            </div>
                        </div>
                        <div class="form-input clear">
                            <div class="one_half">
                                <p>Gender*</p>
                                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Male</asp:ListItem>
                                        <asp:ListItem Value="2">Female</asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                            <div class="one_half">
                                <p>Category*</p>
                                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Gen</asp:ListItem>
                                        <asp:ListItem Value="2">OBC</asp:ListItem>
                                        <asp:ListItem Value="3">SC</asp:ListItem>
                                        <asp:ListItem Value="4">ST</asp:ListItem>
                                        <asp:ListItem Value="5">Other</asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                        </div>
                    <div class="form-input clear">
                            <div class="one_half">
                                 <p>
                                        Country*</p>

                    <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True" CssClass="dropdownlist"
                    OnSelectedIndexChanged="ddlCountryRegion_SelectedIndexChanged">
                    </asp:DropDownList>
                    </div>

                    <div class="one_half"> 
                    
                         <p>
                                        State*</p>

                                           <asp:DropDownList ID="ddlStateRegion" runat="server" CssClass="dropdownlist" AutoPostBack="true"
                     OnSelectedIndexChanged="ddlStateRegion_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
              </asp:DropDownList> 
                    
                    </div>
                    </div>


                        <div class="form-input clear">
                            <div class="one_half">
                                 <p>
                                        City*</p>
                                         <asp:DropDownList ID="ddlCity" runat="server" CssClass="dropdownlist">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                                   
                            </div>
                            <div class="one_half">
                                   <p>
                                        Course*</p>
                                    <asp:DropDownList ID="ddlCourse" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                  
                                    </asp:DropDownList>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                               ErrorMessage="Please select Courses" ControlToValidate="ddlCourse" ValidationGroup="rr" InitialValue="-1"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                    

                        <div class="form-input clear">
                            <div class="one_half">
                                      <p>
                                        Email Id*</p>
                                    <asp:TextBox ID="txtEmail" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtEmail"
                                        Text="* fields required" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                                        Display="Dynamic" ValidationGroup="rr" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ErrorMessage="Enter valid Email Id" ForeColor="Red"></asp:RegularExpressionValidator>
                            </div>
                            <div class="one_half">
                          
                                <p>
                                        User Name*</p>
                                    <asp:TextBox ID="txtUserName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtUserName"
                                        Text="* fields required" />
                            </div>
                        </div>


                            <div class="form-input clear">
                            <div class="one_half">
                              <p>
                                        Mobile No*</p>
                                    <asp:TextBox ID="txtMobile" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtMobile"
                                        Text="* fields required" />
                            </div>
                            <div class="one_half">
                              <p>
                                        Password*</p>
                                    <asp:TextBox ID="txtPassword" runat="server" Text="" TextMode="Password" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="req6" runat="server" ControlToValidate="txtPassword"
                                        Text="* fields required" />
                            </div>
                        </div>


                            <div class="form-input clear">
                            <div class="one_half">
                                 <p>
                                        Address*</p>
                                    <asp:TextBox ID="txtaddress" runat="server" Text="" TextMode="MultiLine" class="message_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress"
                                        Text="* fields required" />
                            </div>
                            <div class="one_half">
                              <p>
                                        Confirm Password*</p>
                                    <asp:TextBox ID="txtConfirmPasword" runat="server" Text="" TextMode="Password" class="name_Contact1"></asp:TextBox>
                                    <asp:CompareValidator runat="server" ID="Comp1" ControlToValidate="txtPassword" ControlToCompare="txtConfirmPasword"
                                        Text="Password mismatch" />
                            </div>
                        </div>

                            <div class="form-input clear">
                            <div class="one_half">
                                <p style="margin-top: 15px;">
                                        <asp:Button ID="btnNext" runat="server" Text="Next" class="button small orange" OnClick="btnNext_Click" />
                                        &nbsp;&nbsp;
                                        <asp:Button ID="btnBack" runat="server" Text="Back" class="button small grey" />
                                    </p>
                            </div>
                            <div class="one_half">
                            
                            </div>
                        </div>
                        <div style="float: left; width: 48%;">
                    
                            <div class="one_half1 first">
                                <code class="code">
                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                               
                                </code>
                            </div>
                        </div>
                    
                   
                </div>
            </div>
        </div>
    </div>
</asp:Content>
