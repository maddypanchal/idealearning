<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddNews.aspx.cs" Inherits="Employee_AddNews" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################ -->
      <section class="clear">
        <div class="wrapper">
        <div class="content_main">
     <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b> ADD NEWS & EVENTS </b></p>
     </div>
      </div>
    </section>
    <div style="height:20px;"></div>
        <div class="form-input clear">
        <div class="one_half">
        <label for="author">
                            Title Date* <span class="required"></span>
                            <br>
                          <asp:TextBox ID="txtTitleDate" runat="server" placeholder="Enter Date" Text="" ReadOnly="true"
                        ></asp:TextBox>
                        </label>
                     
        </div>
        <div class="one_half">
         <label for="author">
                            Enter Title * <span class="required"></span>
                            <br>
                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Enter Title" Text="" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtTitle"
                        CssClass="validation1" runat="server" Display="Dynamic" ValidationGroup="o1"
                        ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                  </label>
        </div>
        
        </div>
        <div style="height:20px;"></div>
        <div class="form-input clear" >
       <div class="">
                    <CKEditor:CKEditorControl ID="CKEditor1" runat="server" Width="100%">
                    </CKEditor:CKEditorControl>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="validation1" runat="server"
                        Display="Dynamic" ValidationGroup="o1" ErrorMessage="This field is required"
                        ControlToValidate="CKEditor1"></asp:RequiredFieldValidator>
                </div>
        </div>
         <div class="form-input clear" >
            <div class="Button_Submit_news">
                    <asp:Button ID="btnSubmit" Text="Submit" runat="server" CssClass="button large gradient orange" ValidationGroup="o1"
                        OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblmsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                </div>
        </div>
        </div>
    </div>
       
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

