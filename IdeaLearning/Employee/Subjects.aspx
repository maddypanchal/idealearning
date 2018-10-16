<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="Subjects.aspx.cs" Inherits="Employee_Subjects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
    <table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg"  style="text-transform: uppercase;" runat="server" CssClass="footer_title" Text=" Add Subject's Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="tdMarginLeft">
           Select Class 
                </td>
                <td>
                    <asp:DropDownList ID="ddlClass" runat="server"  AutoPostBack="true"
                        CssClass="message_anyquery_form_news" 
                        onselectedindexchanged="ddlClass_SelectedIndexChanged" >
                  
                    </asp:DropDownList>
               </td>
            </tr>

            <tr>
                <td class="tdMarginLeft">
           Select Courses 
                </td>
                <td>
                    <asp:DropDownList ID="ddlSeletedCourses" runat="server"  AutoPostBack="true"
                        CssClass="message_anyquery_form_news" 
                        onselectedindexchanged="ddlSeletedCourses_SelectedIndexChanged" >
                  
                    </asp:DropDownList>
               </td>
            </tr>
            <tr>
                <td class="tdMarginLeft">
                   Subject
                </td>
                <td>
                    <asp:TextBox ID="txtSubjectName" runat="server" Text="" CssClass="message_anyquery_form_news"></asp:TextBox>
               </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="ADD" class="cssBtn" onclick="btnSave_Click"/>
                </td>
            </tr>
            <tr>
            <td colspan="3">
            <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="SubjectId"
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
                <asp:TemplateField HeaderText="Subject Name">
                    <ItemTemplate>
                    <asp:Label ID="lblSubjectName" runat="server" Text='<%#Eval("SubjectName") %>' />
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

            </td>
            </tr>



        </table>

         </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

