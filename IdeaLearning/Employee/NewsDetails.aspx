<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="NewsDetails.aspx.cs" Inherits="Employee_NewsDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">
    <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p>
      <b>
           DETAILS OF NEWS & EVENT
      </b>
      </p>
     </div>
      </div>
   </section>
    <div style="height:20px;"></div>
     <div class="Master_Contect_Heading">
      <div>
     <asp:Button ID="btnAddNew" runat="server" Text="Add News & Events"  class="button large gradient orange"
      PostBackUrl="~/Employee/AddNews.aspx" /></div>
     </div>
     <div style="height:20px;"></div>
    <div class="Contact_GridView">
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="NewsTitleId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"   onrowdeleting="gvDetail1_RowDeleting" 
                    onpageindexchanging="gvDetail1_PageIndexChanging" 
                    onrowediting="gvDetail1_RowEditing" 
                    onrowcancelingedit="gvDetail1_RowCancelingEdit" 
                    onrowupdating="gvDetail1_RowUpdating" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Event Name">
                    <ItemTemplate>
                        <asp:Label ID="lblEventName" runat="server" Text='<%#Eval("TitleName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Event Date">
                      <ItemTemplate>
                        <asp:Label ID="lblEventDate" runat="server" Text='<%#Eval("TitleDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <a href="EditNewsAndEvent.aspx?Sid=<%#Eval("NewsTitleId") %>">Edit
                             </ItemTemplate>
                         </asp:TemplateField>
                   <asp:TemplateField HeaderText="ACTION">
                   <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="40px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="60px" />
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

        </section>
    </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

