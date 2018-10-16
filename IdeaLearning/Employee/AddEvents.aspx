<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true"
    CodeFile="AddEvents.aspx.cs" Inherits="Employee_AddEvents" %>

<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">

        <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b style="text-transform: uppercase;">  Add Importants Download</b></p>
     </div>
      </div>
     
    </section>
        <div style="height: 20px;">
        </div>
        <div class="form-input clear">
            <div class="one_half">
                <label for="author">
                    Date * <span class="required"></span>
                    <br>
                    <asp:TextBox ID="txtTitleDate" runat="server" placeholder="Enter Date" Text="" ReadOnly="true"
                       ></asp:TextBox>
                </label>
            </div>
            <div class="one_half">
                <label for="author">
                   Heading Name * <span class="required"></span>
                    <br>
                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Enter Heading" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtTitle"
                        CssClass="validation1" runat="server" Display="Dynamic" ValidationGroup="o1"
                        ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                </label>
            </div>
        </div>
        <div class="form-input clear">
            <div class="one_half">
                <label for="author">
                    Upload File * <span class="required"></span>
                    <br>
                    <asp:FileUpload ID="FileUploadResume" runat="server" />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="FileUploadResume"
                        Text="* fields required" />
                </label>
            </div>
            <div class="one_half">
                <label for="author">
                      <span class="required"></span>
                    <br>
                    <asp:Button ID="btnSubmit" Text="Submit" runat="server" CssClass="button large gradient orange" ValidationGroup="o1"
                        OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                </label>
            </div>
        </div>
        </section>
    </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear">
    </div>
</asp:Content>
