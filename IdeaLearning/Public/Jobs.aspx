<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true"
    CodeFile="Jobs.aspx.cs" Inherits="Public_Jobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="wrapper row3">
        <div id="container">
            <div class="clear columncolor">
                <p class="emphasise">
                    Career </p>
                    <div class="one_third first ">
                    <code class="">
                        <img src="../images/career.jpg" />
                    </code>
                </div>
                <div class="two_third">
                        <code class="code">
                        <div style="float: left; width: 48%;">
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Name*</p>
                                    <asp:TextBox ID="txtName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Father Name*</p>
                                    <asp:TextBox ID="txtFatherName" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFatherName"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Gender*</p>
                                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Male</asp:ListItem>
                                        <asp:ListItem Value="2">Female</asp:ListItem>
                                    </asp:DropDownList>
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Job Title*</p>
                                    <asp:DropDownList ID="ddlJobTitle" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Teaching</asp:ListItem>
                                        <asp:ListItem Value="2">Non-Teaching</asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlJobTitle"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Position Applied For*</p>
                                    <asp:TextBox ID="txtPosition" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtPosition"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Current Employer & Organization
                                    </p>
                                    <asp:TextBox ID="txtCurrentEmployee" runat="server" Text="" class="message_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCurrentEmployee"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Experience*</p>
                                    <asp:TextBox ID="txtExperience" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtExperience"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Expected CTC</p>
                                    <asp:TextBox ID="txtexpected" runat="server" Text="" class="message_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtexpected"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 first">
                                <code class="code">
                                    <p>
                                        Current CTC
                                    </p>
                                    <asp:TextBox ID="txtcurrentctc" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtcurrentctc"
                                        Text="* fields required" />
                                </code>
                            </div>
                        </div>
                        <div style="float: right; width: 48%;">
                            <div class="one_half1  ">
                                <code class="code">
                                    <p>
                                        Qualifications
                                    </p>
                                    <asp:TextBox ID="txtDegree" runat="server" Text="" class="message_Contact1" placeholder="Qualification 1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDegree"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1  ">
                                <code class="code">
                                    <p>
                                        &nbsp;
                                    </p>
                                    <asp:TextBox ID="txtQual2" runat="server" Text="" class="message_Contact1" placeholder="Qualification 2"></asp:TextBox>
                                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtQual2" Text="* fields required" />--%>
                                </code>
                            </div>
                            <div class="one_half1">
                                <code class="code">
                                    <p>
                                        Mobile No*</p>
                                    <asp:TextBox ID="txtMobile" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtMobile"
                                        Text="* fields required" />
                                </code>
                            </div>
                             <div class="one_half1">
                                <code class="code">
                                    <p>
                                        Current Deisgnation*</p>
                                    <asp:TextBox ID="txtCurrentDeisgnation" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtMobile"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 ">
                                <code class="code">
                                    <p>
                                        Email id*</p>
                                    <asp:TextBox ID="txtEmail" runat="server" Text="" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtEmail"
                                        Text="* fields required" />
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail"
                                        Display="Dynamic" ValidationGroup="rr" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                        ErrorMessage="Enter valid Email Id" ForeColor="Red"></asp:RegularExpressionValidator>
                                </code>
                            </div>
                            <div class="one_half1 ">
                                <code class="code">
                                    <p>
                                        Address*</p>
                                    <asp:TextBox ID="txtAddress" runat="server" Text="" TextMode="MultiLine" class="name_Contact1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtAddress"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 ">
                                <code class="code">
                                    <div class="PhotoLeft">
                                        <p>
                                           <b>upload Photo * </b>Max File Size 8 MB
                                            <p> jpeg,jpg,png,jpe & gif files Only
                                             </p>
                                           <br />
                                                <asp:FileUpload ID="FileUploadPhoto" runat="server" />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="FileUploadPhoto"
                                                    Text="* fields required" />
                                                <%-- <p>Photo is Mandatory for the online Application</p>--%>
                                    </div>
                                </code>
                            </div>
                            <div class="one_half1">
                                <code class="code">
                                    <p>
                                        <b>Upload Resume *</b> Max File Size 8 MB  </p>
                                        <p>pdf,doc & docx files Only</p>
                                     
                                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="FileUploadResume"
                                        Text="* fields required" />
                                </code>
                            </div>
                            <div class="one_half1 ">
                                <code class="code">
                                    <p style="margin-top: 20px; text-align: center;">
                                        <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label><br />
                                        <asp:Button ID="btnNext" runat="server" Text="SUBMIT" class="button small orange"
                                            OnClick="btnNext_Click" />
                                        <%--           &nbsp;&nbsp;
            <asp:Button ID="btnBack" runat="server" Text="Back" class="button small grey" />--%>
                                    </p>
                                </code>
                            </div>
                        </div>
                    </code>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
