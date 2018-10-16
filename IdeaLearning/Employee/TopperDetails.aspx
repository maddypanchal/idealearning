<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="TopperDetails.aspx.cs" Inherits="Employee_TopperDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

        <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;"> Details of Toppers</b></p>
     </div>
      </div>
     
    </section>
     <div style="height:20px;"></div>

    <asp:Button ID="btnAddNew" runat="server" Text="Add Toppers"  class="button large gradient orange"
      PostBackUrl="~/Employee/AddToppers.aspx" />
       <div style="height:20px;">
       </div>
      
 <div class="form-input clear">      
         
    <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="ToppersId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="10" Width="100%" CssClass="tabl"
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
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblImages" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Roll Number">
                      <ItemTemplate>
                        <asp:Label ID="lblImagesName" runat="server" Text='<%#Eval("RollNumber") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                   <asp:TemplateField HeaderText="Exam">
                      <ItemTemplate>
                        <asp:Label ID="lblExam" runat="server" Text='<%#Eval("Courses") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Toppers">
                      <ItemTemplate>
                        <asp:Label ID="lblToppers" runat="server" Text='<%#Eval("Toppers") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Rank">
                      <ItemTemplate>
                        <asp:Label ID="lblRank" runat="server" Text='<%#Eval("Rank") %>' />
                    </ItemTemplate>
                </asp:TemplateField>


                   <asp:TemplateField HeaderText="Topper Image">
                      <ItemTemplate>

                       <a href="../Employee/Toppers/ImgMain/<%#Eval("ImagesName") %>" target="_blank" title="Download Images">

                         <img src="../Employee/Toppers/ImgMain/<%#Eval("ImagesName")%>" alt="" style="width:160px; height:125px; border: 1px solid #e6e6e6" />
                    
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

     </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

