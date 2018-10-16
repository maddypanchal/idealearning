<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="UpdateStudentSecondCourses.aspx.cs" Inherits="Employee_UpdateStudentSecondCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div class="form-input clear">
        <div class="one_half">
             <label for="author">
                               Class*  <span class="required"></span>                                           
                <asp:DropDownList ID="ddlClass" runat="server" CssClass="Ddl_Css" AutoPostBack="true"  onselectedindexchanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                            </label>
                                   </div>
    </div>

     <div class="form-input clear">
      <div class="one_half">
          <label for="author">
                         Course Second  <span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourselistSecond" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlCourselistSecond_SelectedIndexChanged"
                 >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
       
        <div class="one_half">
             <label for="author">
                    Subject Frist <span class="required"></span>
                    <asp:DropDownList ID="ddlCourse_Second_Subject_Frist" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                   </asp:DropDownList>
                            </label>
                            </div>
    </div>

    <div class="form-input clear">
      
        <div class="one_half">
          <label for="author">
                               Subject Second  <span class="required"></span>
         
                <asp:DropDownList ID="ddlCourse_Second_Subject_Second" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>

     <div class="form-input clear">
     
        <div class="one_half">
          <label for="author">
                                Subject Third  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Second_Subject_third" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
       
        <div class="one_half">
          <label for="author">
                          Subject Forth  <span class="required"></span>
                    <asp:DropDownList ID="ddlCourse_Second_Subject_Forth" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>

      <div class="form-input clear">
        <div class="one_half">
         <asp:Button ID="btnSubmit" runat="server" Text="UPDATE" class="button large gradient red" OnClick="btnSubmit_Click" />
           
            <p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </p>
            </div>
            </div>


</asp:Content>

