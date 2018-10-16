<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddCity.aspx.cs" Inherits="Employee_AddCity" %>

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
      <p  > <b> ADD CITY DETAILS</b></p>
     </div>
      </div>
     
    </section>

      <div style="height:20px;"></div>
     <div class="form-input clear">
        <div class="one_half">

         <label for="author">
              Select Country * <span class="required"></span>
                            <br>
                             
               <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True"  class="Ddl_Css"
                     onselectedindexchanged="ddlCountryRegion_SelectedIndexChanged"  >
        </asp:DropDownList>

                            </label>
                            </div>
                            </div>
                            

                            <div class="form-input clear">
        <div class="one_half">

         <label for="author">
              Select State  * <span class="required"></span>
                            <br>
                            
        <asp:DropDownList ID="ddlStateRegion" runat="server"  class="Ddl_Css" 
                AutoPostBack="true" 
                onselectedindexchanged="ddlStateRegion_SelectedIndexChanged1"  >
             <asp:ListItem>--Select--</asp:ListItem>
        </asp:DropDownList>

                            </label>
                            </div>
                            </div>

                            <div class="form-input clear">
        <div class="one_half">

         <label for="author">
              City * <span class="required"></span>
                            <br>
                             <asp:TextBox ID="txtRegion" runat="server" ></asp:TextBox>

                            </label>
                            </div>
                            </div>

                                               <div class="form-input clear">
        <div class="one_half">

         <label for="author">
              <span class="required"></span>
                            <br>
                               <asp:Button ID="Button1" runat="server"  Text="SAVE" class="button large gradient orange" onclick="Button1_Click1" />
        <asp:Label ID="lblregion" runat="server" Text=""></asp:Label>

                            </label>
                            </div>
                            </div>
                                

     <div class="Contact_GridView">
           <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="RegionId"
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
                <asp:TemplateField HeaderText="City Name">
                <EditItemTemplate>
                <asp:TextBox ID="txtUpdateCity" runat="server" Text='<%#Eval("RegionName") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblHeadingName" runat="server" Text='<%#Eval("RegionName") %>' />
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
    
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>
