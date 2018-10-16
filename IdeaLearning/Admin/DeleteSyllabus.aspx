﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="DeleteSyllabus.aspx.cs" Inherits="Admin_DeleteSyllabus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="container">
      <!-- ################################################################################################ -->
     <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b> DETAILS OF SYLLABUS</b></p>
     </div>
      </div>


      <div style="height:20px;"></div>

              
      <div>

          <asp:Label ID="lblMsg1" Text="" runat="server"></asp:Label>

      </div>

      <div style="height:20px;"></div>
      <div class="form-input clear">
  

        <div class="one_fifth">
        
        <asp:Button ID="btnDeleteAdd" runat="server" Text="Delete" 
                class="button large gradient orange" onclick="btnDeleteAdd_Click"/>
        
        </div>
   
        </div>

      
      <div style="height:20px;"></div>

    <div class="Contact_GridView">
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="SyllabusId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
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
                <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mentor">
                    <ItemTemplate>
                        <asp:Label ID="lblname" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Chapter (Topic)">
                      <ItemTemplate>
                        <asp:Label ID="lblContentBy" runat="server" Text='<%#Eval("ContentBy") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Syllabus Covered (Sub Topic)" HeaderStyle-Width="600px" >
                    <ItemTemplate>
                        <asp:Label ID="lblSyllabusDescription" runat="server" Text='<%#Eval("SyllabusDescription") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

               <%--  <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <a href="EditNewsAndEvent.aspx?Sid=<%#Eval("NewsTitleId") %>">Edit
                             </ItemTemplate>
                         </asp:TemplateField>--%>

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

       <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg success" ></asp:Label>
        </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>


</asp:Content>

