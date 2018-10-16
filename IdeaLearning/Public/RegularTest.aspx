<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="RegularTest.aspx.cs" Inherits="Public_RegularTest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div >
<asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="RegularTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblYearName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="MaxMark">
                    <ItemTemplate>
                        <asp:Label ID="lblMaxMark" runat="server" Text='<%#Eval("MaxMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Obtain Mark">
                    <ItemTemplate>
                        <asp:Label ID="lblObtainMark" runat="server" Text='<%#Eval("ObtainMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Rank">
                    <ItemTemplate>
                        <asp:Label ID="lblRank" runat="server" Text='<%#Eval("Rank") %>' />
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
   
      <asp:Button ID="btnExport" runat="server" Text="Export To PDF" OnClick = "ExportToPDF" />


</asp:Content>

