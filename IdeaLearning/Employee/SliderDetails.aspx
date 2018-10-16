<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="SliderDetails.aspx.cs" Inherits="Employee_SliderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

           
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;">Details of Slider</b></p>
     </div>
      </div>
     
    </section>

      <div style="height:20px;"></div>
     <div class="form-input clear">
        <div class="one_half">

                             <asp:Button ID="btnAddNew" runat="server" Text="Add Slider Images"  class="button large gradient orange"
      PostBackUrl="~/Employee/AddSlider.aspx" />

                        
                            </div>
                            </div>
                              <div style="height:20px;"></div>

<asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="SliderImageId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" 
            onpageindexchanging="gvDetail1_PageIndexChanging" 
            onrowcancelingedit="gvDetail1_RowCancelingEdit" 
            onrowdeleting="gvDetail1_RowDeleting" onrowupdating="gvDetail1_RowUpdating">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Images Title">
                    <ItemTemplate>
                        <asp:Label ID="lblImages" runat="server" Text='<%#Eval("ImagesTitle") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Images Name">
                      <ItemTemplate>

                        <a href="../UploadedFile/ImgMain/<%#Eval("ImagesName") %>" target="_blank" title="Download Images">

                         <img src="../UploadedFile/ImgMain/<%#Eval("ImagesName")%>" alt="" style="width:160px; height:125px; border: 1px solid #e6e6e6" />
                        <asp:Label ID="lblImagesName" runat="server" Text='<%#Eval("ImagesName") %>' />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
               <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="50px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="70px" />
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
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

