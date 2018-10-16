<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DashBord.aspx.cs" Inherits="Admin_DashBord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="content">
<div class="content_left">
<div class="photo">
    <asp:Image ID="imgphoto" runat="server" ImageUrl="~/images/stu.jpg" width="230px" height="257px" />
</div>
<div class="detail">
<p>Name-<asp:Label ID="lblAdmin" runat="server"  Text=""></asp:Label><br />
Batch- 3:00 to 5:00 pm <br />
Course- JEE
</p>
</div>
</div>
    <asp:ScriptManager ID="ScriptManager1" runat="server" >
    </asp:ScriptManager>
<div class="content_right">
<div class="attend_head">
<p> Subject Name</p>
<p> Delivered</p>
<p> Attended</p>
<p> Late</p>
<p>Percentage</p>
</div>
<%--<asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="attendance"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" 
            onpageindexchanging="gvDetail1_PageIndexChanging" 
            onrowcancelingedit="gvDetail1_RowCancelingEdit" 
            onrowdeleting="gvDetail1_RowDeleting" onrowupdating="gvDetail1_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Sr. No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Subject">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtImages" runat="server" Text='<%#Eval("ProductTitle") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblImages" runat="server" Text='<%#Eval("ProductTitle") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delivered">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtImagesDescription" runat="server" Text='<%#Eval("ProductDescription") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblImagesDescription" runat="server" Text='<%#Eval("ProductDescription") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Attended">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtImagesName" Width="100px" runat="server" Text='<%#Eval("ProductName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblImagesName" runat="server" Text='<%#Eval("ProductName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Percentage">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtImagesName" Width="100px" runat="server" Text='<%#Eval("ProductName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblImagesName" runat="server" Text='<%#Eval("ProductName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION">
                <%--    <EditItemTemplate>
                        <asp:ImageButton ID="imgbtnUpdate" runat="server" CommandName="Update" Height="20px"
                            ImageUrl="~/images/updateimg.png" ToolTip="Update" Width="20px" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" Height="20px"
                            ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Width="20px" />
                    </EditItemTemplate>--%>
                    <%--<ItemTemplate>
                <%--        <asp:ImageButton ID="imgbtnEdit" runat="server" CommandName="Edit" Height="20px"
                            ImageUrl="~/images/Edit.png" ToolTip="Edit" Width="20px" />&nbsp;&nbsp;&nbsp;&nbsp;--%>
                        <%--<asp:ImageButton ID="imgbtnDownload" runat="server" CommandName="Download" Height="40px"
                            ImageUrl="~/images/download.png" Text="Download" ToolTip="Delete" Width="40px" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <HeaderStyle BackColor="#00c0ff" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#657477" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" BackColor="#EFF3FB" />
            <EditRowStyle BackColor="" BorderStyle="None" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>   --%>
          
               

</div>

</div>
</asp:Content>

