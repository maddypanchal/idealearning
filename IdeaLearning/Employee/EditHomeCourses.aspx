<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="EditHomeCourses.aspx.cs" Inherits="Employee_EditHomeCourses" %>

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
      <p  > <b> UPDATE COURSES DETAILS </b></p>
     </div>
      </div>
      <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
    <div style="height:20px;"></div>

        <div class="form-input clear">
        <div class="one_half">

             <label for="email" >Courses Image*<span class="required"></span><br>
                        <asp:Image ID="imgUser" runat="server" Height="100" Width="300" ImageUrl="~/UploadedFile/Defultuser.png" />
                <a href="#">
                    <p>
                      Update Image*</p>
                </a>
             
              <div class="photo">
          
          <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Visible="true" Font-Italic="True"
                        multiple="true" ForeColor="#FF6600"  ToolTip="Upload Product Image Here" />

                         
                </div>
              </label>
      <%--    <label for="author">
                              Courses Images  * <span class="required"></span>
                            <br>
                   <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                       multiple="true" class="" ToolTip="Upload Product Image Here" />
                  </label>--%>
        </div>
         <div class="one_half">
          <label for="author">
                               Course Name  * <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtCourse" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        </div>
          <div class="form-input clear">
          <div class="one_half">
          <label for="author">
                            Description  * <span class="required"></span>
                            <br>
                             <asp:TextBox ID="txtDescriptions" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
                            </label>
                            </div>

                            <div class="one_half">
                            <label for="author">
                             CourseDuration  * <span class="required"></span>
                            <br>
                              <asp:TextBox ID="txtCourseDuration" runat="server" Text="" ></asp:TextBox>
                            </label>

                            </div>
                            </div>

                               <div class="form-input clear">
                                  <CKEditor:CKEditorControl ID="CKEditor1" runat="server" >
                    </CKEditor:CKEditorControl>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  runat="server"
                        Display="Dynamic" ValidationGroup="o1" ErrorMessage="This field is required"
                        ControlToValidate="CKEditor1"></asp:RequiredFieldValidator>
                               </div>
                             <div style="height:20px;"></div>

                                <div class="form-input clear">
                                 
                                   <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=""></asp:Label>
                                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" 
                                        class="button large gradient orange" onclick="btnUpdate_Click" />
                                </div>
                             



            
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>

</asp:Content>

