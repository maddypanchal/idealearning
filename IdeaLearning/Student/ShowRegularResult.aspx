﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true"
    CodeFile="ShowRegularResult.aspx.cs" Inherits="Student_ShowRegularResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">

          <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b> <asp:Label ID="lblResults" runat="server" text="PERFORMANCE OF REGULAR TEST"></asp:Label></b></p>
     </div>
      </div>
      <div style="height:20px;"></div>
      <b> <asp:Label ID="lblMsg" runat="server" text="REGULAR RESULTS DETAILS" CssClass="alert-msg warning" style="color:rgb(28, 213, 9); text-align:center;"></asp:Label></b>
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="RegularTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
            <%--    <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Name & Father's Name">
                    <ItemTemplate>
                        <asp:Label ID="lblYearName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                 </asp:TemplateField>
                          <asp:TemplateField HeaderText="Reg No">
                    <ItemTemplate>
                        <asp:Label ID="lblYearName" runat="server" Text='<%#Eval("RegNo") %>' />
                    </ItemTemplate>
                 </asp:TemplateField>
                     <asp:TemplateField HeaderText="MaxMark">
                    <ItemTemplate>
                        <asp:Label ID="lblMaxMark" runat="server" Text='<%#Eval("MaxMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                         <asp:TemplateField HeaderText="Marks Obtained">
                    <ItemTemplate>
                        <asp:Label ID="lblObtainMark" runat="server" Text='<%#Eval("ObtainMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                        <asp:TemplateField HeaderText="Class Rank">
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
           <%-- <asp:Button ID="btnExport" runat="server" Text="Export To PDF" OnClick = "ExportToPDF" />--%>
        </section>
    </div>
</asp:Content>
