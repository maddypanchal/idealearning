<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="EditSyllabus.aspx.cs" Inherits="Admin_EditSyllabus" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div id="container">
      <!-- ################################################################################################ -->
      <section class="clear">
        <div class="wrapper">
        <div class="content_main">
            <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>  UPDATE SYLLABUS</b></p>
     </div>
      </div>
      <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
    <div style="height:20px;"></div>
        <div class="form-input clear">
        <div class="one_half">

         <label for="author">
                            Title Date* <span class="required"></span>
                            <br>
                          <asp:TextBox ID="txtTitleDate" runat="server" placeholder="Enter Date" Text="" ReadOnly="true" ></asp:TextBox>
                        </label>
                     
        </div>
        <div class="one_half">
         <label for="author">
                         Syllabus Covered * <span class="required"></span>
                         <br>
                  
             <asp:TextBox ID="txtContent" runat="server"  Text=""  ></asp:TextBox>
                  </label>
        </div>
        
        </div>

        <div class="form-input clear">
        <div class="one_half">

         <label for="author">
                          Tought By* <span class="required"></span>
                            <br>
                         <asp:DropDownList ID="ddlEmployee" runat="server" CssClass="Ddl_Css" >
                  <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
               
                        </label>
                     
        </div>
        <div class="one_half">
         <label for="author">
                           select Class * <span class="required"></span>
                            <br>
                     <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                  </label>
        </div>
        
        </div>
        <div class="form-input clear">
        <div class="one_half">

         <label for="author">
                         select Course  * <span class="required"></span>
                            <br>
                 
                  <asp:DropDownList ID="ddlCourselist" runat="server"  AutoPostBack="true" CssClass="Ddl_Css"
                    onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                        </label>
                     
        </div>
        <div class="one_half">
         <label for="author">
                              Select Subject * <span class="required"></span>
                            <br>
                
            
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="Ddl_Css" >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                  </label>
        </div>
        
        </div>
             <div class="form-input clear">
      
           </div>


        <div style="height:20px;"></div>

        
        <div class="form-input clear" >
         <label for="author">
                             Content * <span class="required"></span>
                            <br>
                            </label>
       <div class="">
                    <CKEditor:CKEditorControl ID="CKEditor1" runat="server" Width="100%">
                    </CKEditor:CKEditorControl>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="validation1" runat="server"
                        Display="Dynamic" ValidationGroup="o1" ErrorMessage="This field is required"
                        ControlToValidate="CKEditor1"></asp:RequiredFieldValidator>
                </div>
        </div>
            <div style="height:20px;"></div>
         <div class="form-input clear" >
          <div class="one_half">
            <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" CssClass="button large gradient orange" OnClick="btnSave_Click" />
            </div>
         
          <div class="one_half">
          <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg success" ></asp:Label>
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

