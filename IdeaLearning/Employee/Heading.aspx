<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="Heading.aspx.cs" Inherits="Employee_Heading" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
<table width="1000px" cellpadding="2"  style="float:left; margin:20px 0 20px 0;" cellspacing="10" bgcolor="#333" >
             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Heading's Details"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <hr />
                </td>
            </tr>
            <tr>
                <td class="tdMarginLeft">
                   Heading
                </td>
                <td>
                    <asp:TextBox ID="txtHeading" runat="server" Text="" CssClass="message_anyquery_form_news"></asp:TextBox>
               </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                    <asp:Button ID="btnSave" runat="server" Text="ADD" class="cssBtn" 
                        onclick="btnSave_Click"/>
                </td>
            </tr>

            <tr>
            <td colspan="2">
            <div class="Contact_GridView">
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="HeadingId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 12px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="10" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="2" ForeColor="#7B7B7B"  
                    onrowdeleting="gvDetail1_RowDeleting" 
                    onpageindexchanging="gvDetail1_PageIndexChanging" 
                    onrowediting="gvDetail1_RowEditing" 
                    onrowcancelingedit="gvDetail1_RowCancelingEdit" 
                    onrowupdating="gvDetail1_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Heading Name">
                 <EditItemTemplate>
                <asp:TextBox ID="txtUpdateHeading" runat="server" Text='<%#Eval("name") %>'></asp:TextBox>
                   
                </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblHeadingName" runat="server" Text='<%#Eval("name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION">
                    <EditItemTemplate>
                       <asp:ImageButton ID="imgbtnUpdate" runat="server" CommandName="Update" Height="50px"
                            ImageUrl="~/images/updateimg.png" ToolTip="Update" Width="70px" />
                        <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" Height="50px"
                            ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Width="70px" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtnEdit" runat="server" CommandName="Edit" Height="50px"
                            ImageUrl="~/images/Edit.png" ToolTip="Edit" Width="70px" />
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

