﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddState.aspx.cs" Inherits="Employee_AddState" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">
<div class="page">
  <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b> ADD STATE DETAILS</b></p>
     </div>
      </div>
     
    </section>

      <div style="height:20px;"></div>
     <div class="form-input clear">
        <div class="one_half">

         <label for="author">
              Select  Country * <span class="required"></span>
                            <br>
                               <asp:DropDownList ID="ddlCountryState" runat="server" AutoPostBack="True"  class="Ddl_Css" onselectedindexchanged="ddlCountryState_SelectedIndexChanged" >
                </asp:DropDownList>
                            </label>
                            <//div>
                            </div>
  <div class="form-input clear">

                               <div class="one_half">

         <label for="author">
                State* <span class="required"></span>
                            <br>
                         
                <asp:TextBox ID="txtState" runat="server"></asp:TextBox>
                </label>
                            <//div>
                            </div>
   <div style="height:20px;"></div>
  <div class="form-input clear">

                               <div class="one_half">
                                 <asp:Button ID="Button1" runat="server" Text="SAVE" class="button large gradient orange" onclick="Button1_Click" />
                <asp:Label ID="lblState" runat="server" Text=""></asp:Label>
                                  <//div>
                            </div>

  <div style="height:20px;"></div>             
        
      
    <div class="Contact_GridView">
           <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="StateId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="10" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  
                    onrowdeleting="gvDetail1_RowDeleting" 
                    onpageindexchanging="gvDetail1_PageIndexChanging" 
                    onrowcancelingedit="gvDetail1_RowCancelingEdit" 
                    onrowediting="gvDetail1_RowEditing" 
                    onrowupdating="gvDetail1_RowUpdating"   >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="State Name">
                <EditItemTemplate>
                <asp:TextBox ID="txtUpdateState" runat="server" Text='<%#Eval("StateName") %>'></asp:TextBox>
                   
                </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblHeadingName" runat="server" Text='<%#Eval("StateName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
                     <EditItemTemplate>
                       <asp:ImageButton ID="imgbtnUpdate" runat="server" CommandName="Update" Height="50px"
                            ImageUrl="~/images/updateimg.png" ToolTip="Update" Width="70px" />&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ImageButton ID="imgbtnCancel" runat="server" CommandName="Cancel" Height="50px"
                            ImageUrl="~/images/Cancel.jpg" ToolTip="Cancel" Width="70px" />
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:ImageButton ID="imgbtnEdit" runat="server" CommandName="Edit" Height="50px"
                            ImageUrl="~/images/Edit.png" ToolTip="Edit" Width="70px" />&nbsp;&nbsp;&nbsp;&nbsp;
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

        <div class="clear">
        </div>
    </div>

       
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

