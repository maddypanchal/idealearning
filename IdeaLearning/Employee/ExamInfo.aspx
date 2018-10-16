<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="ExamInfo.aspx.cs" Inherits="Employee_ExamInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="container">
        <div class="wrapper">
            <div class="content_main">
                <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p><b>ADD EXAM INFORMATIONS </b></p>
                        <asp:Label ID="lblMsg" runat="server" CssClass="" Text=" "></asp:Label>
                    </div>
                </div>
                 <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Class* <span class="required"></span>
                            <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"  OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                            </asp:DropDownList>
                        </label>
                    </div>
                    <div class="one_half">
                        <label for="author">
                            Select Course* <span class="required"></span>
                     <asp:DropDownList ID="ddlCourselist" runat="server"  AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlCourseList_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                        </label>
                    </div>
                </div>
                <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Subject* <span class="required"></span>
                <asp:DropDownList ID="ddlSubject" runat="server"  CssClass="Ddl_Css">
                </asp:DropDownList>
                   </label>
                   </div>
                   <div class="one_half">
                        <label for="author">
                             Type of Test* <span class="required"></span>
                      
                <asp:DropDownList ID="ddlTest" runat="server" CssClass="Ddl_Css">
                    <asp:ListItem Value="-1">Select One</asp:ListItem>
                    <asp:ListItem Value="1">Online Test</asp:ListItem>
                    <asp:ListItem Value="2">Offline Regular Test (Objective)</asp:ListItem>
                    <asp:ListItem Value="2">Offline Regular Test (Subjective)</asp:ListItem>
                    <asp:ListItem Value="3">Offline Drishti Test</asp:ListItem>
                    <asp:ListItem Value="4">DPP Test (Subjective)</asp:ListItem>
                    <asp:ListItem Value="5">DPP Test (Objective)</asp:ListItem>
                  </asp:DropDownList>
                        </label>
                     </div>
                  </div>

                    <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Name of the Exam* <span class="required"></span>
                            <asp:TextBox ID="txtSubjectName" runat="server" Text="" CssClass="Ddl_Css"></asp:TextBox>
                                       </label>
                        </div>

                         <div class="one_half">
                      <label for="author">
                          Venue* <span class="required"></span>
                        <asp:TextBox ID="txtVenue" runat="server" Text="" CssClass="Ddl_Css"></asp:TextBox>
                         </label>
                        </div>
                        </div>
                    <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Test Date & Time* <span class="required"></span>
                 <asp:TextBox ID="txtTestDate" runat="server" Text="" CssClass="Ddl_Css"></asp:TextBox>
                             </label>  
                    </div>
                         <div class="one_half">
                     

                                  <label for="author">
                        Syllabus* <span class="required"></span>
                        <asp:TextBox ID="txtSyllabus" runat="server" Text="" TextMode="MultiLine" Rows="5" CssClass="Ddl_Css"></asp:TextBox>
                        </label>
                        </div>
                        </div>
                       <div class="form-input clear">
                    <div class="one_half">
                    <asp:Button ID="btnSave" runat="server" Text="ADD" class="button large gradient red" OnClick="btnSave_Click" />
                 </div>
                </div>
             </div>
          </div>
       </div>     
</asp:Content>

