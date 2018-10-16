<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="DetailsOfExamInfo.aspx.cs" Inherits="Employee_DetailsOfExamInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <div class="wrapper">
            <div class="content_main">
                <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p><b>Details of Exam Information </b></p>
                        <asp:Label ID="lblMsg" runat="server" CssClass="" Text=" "></asp:Label>
                    </div>
                </div>



                <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Class* <span class="required"></span>
                             <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                        </label>
                    </div>
                    <div class="one_half">
                        <label for="author">
                            Select Course* <span class="required"></span>
                            <asp:DropDownList ID="ddlCourselist" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
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
                <asp:DropDownList ID="ddlSubject" runat="server" AutoPostBack="true"   OnSelectedIndexChanged="ddlSubject_SelectedIndexChanged"  CssClass="Ddl_Css">
                </asp:DropDownList>
                   </label>
                   </div>
                       </div>



                <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="ExamInfoId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="100"  CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" OnRowDeleting="gvDetail1_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Class">
                    <ItemTemplate>
                        <asp:Label ID="lblClassName" runat="server" Text='<%#Eval("ClassName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Courses">
                    <ItemTemplate>
                        <asp:Label ID="lblCoursesName" runat="server" Text='<%#Eval("CoursesName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Subject">
                    <ItemTemplate>
                        <asp:Label ID="lblclassSubject" runat="server" Text='<%#Eval("classSubject") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Name of the Test">
                    <ItemTemplate>
                        <asp:Label ID="lblSubjectName" runat="server" Text='<%#Eval("SubjectName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Venue">
                    <ItemTemplate>
                        <asp:Label ID="lblVenue" runat="server" Text='<%#Eval("Venue") %>' />
                    </ItemTemplate>
                </asp:TemplateField>


                <asp:TemplateField HeaderText="Syllabus">
                    <ItemTemplate>
                        <asp:Label ID="lblSyllabus" runat="server" Text='<%#Eval("Syllabus") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Date">
                    <ItemTemplate>
                        <asp:Label ID="lblTestDate" runat="server" Text='<%#Eval("TestDate")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Type Of Test">
                    <ItemTemplate>
                        <asp:Label ID="lblTypeOfTest" runat="server" Text='<%#Eval("TypeOfTest") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
          

                <asp:TemplateField HeaderText="Send SMS">
                             <ItemTemplate>
                                <a href="SendSmsExam.aspx?Sid=<%#Eval("ExamInfoId") %>">Send
                             </ItemTemplate>
                 </asp:TemplateField>

                <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="50px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="70px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#657477" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

            </div>
        </div>
    </div>


   
    





</asp:Content>

