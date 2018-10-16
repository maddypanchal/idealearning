<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DeleteAttendance.aspx.cs" Inherits="Admin_DeleteAttendance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
      <div id="container">
      <div class="page">
        <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
         <p><b>DETAILS OF ATTENDENCE</b></p>
      </div>
      </div>
      </div>
        
          <asp:Button ID="btnDeleted" runat="server" Text="Delete Attendance" OnClick="btnDeleted_Click"   />



<div class="wrapper">
         

     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="AttendanceId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="100"  CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Date">
                      <ItemTemplate>
                        <asp:Label ID="lblAbsentDate" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Attendence">
                    <ItemTemplate>
                        <asp:Label ID="lblAbsentName" runat="server" Text='<%#Eval("Absent") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
             
            </Columns>
            <HeaderStyle BackColor="Orange" Font-Bold="True" ForeColor="White" />
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
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

