<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DeletehomeWork.aspx.cs" Inherits="Admin_DeletehomeWork" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <div id="container">
      <!-- ################################################################################################ -->
          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>Home Work's Details</b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>


                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=""></asp:Label>
        
               select Class * <span class="required"></span>
                            <br>
                     <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>

             <tr>
                 <td class="tdMarginLeft">
                    select Course                </td>
                 <td>
                  <asp:DropDownList ID="ddlCourselist" runat="server" CssClass="message_anyquery_form_news" AutoPostBack="true" 
                    onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                </td>
                </tr>

         <asp:Button ID="btnDelete" runat="server" Text="Delete All" OnClick="btnDelete_Click"/>


       <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="HomeWorkId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Class">
                    <ItemTemplate>
                        <asp:Label ID="lblClass" runat="server" Text='<%#Eval("ClassId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Subject">
                    <ItemTemplate>
                        <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("SubjectId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                       <asp:TemplateField HeaderText="DocFile">
                    <ItemTemplate>
                        <asp:Label ID="lblDocFile" runat="server" Text='<%#Eval("DocFile") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Courses">
                    <ItemTemplate>
                        <asp:Label ID="lblClassCoursesId" runat="server" Text='<%#Eval("ClassCoursesId") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                      <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date") %>' />
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
  
          

</asp:Content>

