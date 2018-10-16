<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="UpdateStudentThreeCourses.aspx.cs" Inherits="Employee_UpdateStudentThreeCourses" %>

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
                           Course Third<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_Third" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlCourse_Third_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                          Subject Frist <span class="required"></span>
                  
                <asp:DropDownList ID="ddlCourse_Third_Subject_Frist" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
       <div class="one_half">
          <label for="author">
                               Subject Second  <span class="required"></span>
         
                <asp:DropDownList ID="ddlCourse_Third_Subject_Second" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>



    </div>




     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                               Subject Third  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Third_Subject_Third" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
                               </div>
     <div class="form-input clear">
        
        <div class="one_half">
          <label for="author">
                           Subject fourth  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Third_Subject_fourth" runat="server" CssClass="Ddl_Css">
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

