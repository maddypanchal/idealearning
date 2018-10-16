<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="HomeCoursesDetails.aspx.cs" Inherits="Employee_HomeCoursesDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="container">
      
      <!-- ################################################################################################ -->
    <section class="clear">

                <div id="portfolio">
                <%-- <div  class="clear columncolor">
     <p class="emphasise">EMPLOYEE REGISTRATION</p>
      </div>--%>
            
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>HOME COURSES DETAILS</b></p>
     </div>
      </div>
    
     <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
    <div style="height:20px;"> </div>

    <div class="Master_Contect_Heading">
      <div>
     <asp:Button ID="btnAddNew" runat="server" Text="Add Home Courses"  class="button large gradient orange"
      PostBackUrl="~/Employee/AddCoursesDetails.aspx" /></div>
     </div>
      <div style="height:20px;"></div>
    <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="CourseDetailsId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Couses Name">
                    <ItemTemplate>
                        <asp:Label ID="lblEventName" runat="server" Text='<%#Eval("CourseName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="CourseDuration">
                    <ItemTemplate>
                        <asp:Label ID="lblCourseDuration" runat="server" Text='<%#Eval("CourseDuration") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Courses Details">
                    <ItemTemplate>
                        <asp:Label ID="lblCoursesDetails" runat="server" Text='<%#Eval("CoursesDetails") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Images Name">
                    <ItemTemplate>
                 <%-- <img src="../Employee/Toppers/ImgMain/<%#Eval("ImagesName")%>" alt="" />--%>
                            <a href="../Employee/Toppers/<%#Eval("ImagesName") %>" target="_blank" >
                        <asp:Label ID="lblImagesName" runat="server" Text='<%#Eval("ImagesName") %>' />
                       </a>
                     <%--    <asp:Image ID="Image1aa" runat="server" ImageUrl="../Employee/Toppers/ImgMain/" + <%#Eval("ImagesName")%> />--%>
                </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <a href="EditHomeCourses.aspx?Sid=<%#Eval("CourseDetailsId") %>">Edit
                             </ItemTemplate>
                         </asp:TemplateField>
                      <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="50px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="70px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#ef7300" Font-Bold="True" ForeColor="White" />
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

