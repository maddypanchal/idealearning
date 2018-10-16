<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="CarrerDetails.aspx.cs" Inherits="Admin_CarrerDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="wrapper row3">
        <div id="container">
         <div id="portfolio">
             <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>CAREER DETAILS</b></p>
      </div>
      </div>
      </section>
            <%--<tr>
                <td align="center" colspan="3">
                <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=" Carrer Details"></asp:Label>
                </td>
            </tr>--%>
           <div style="width: 100%; height: 20px;">
                </div>
            <div class="form-input clear">
            <div class="one_fifth">
            <label for="author">
                            Qualification <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtQualification" runat="server" Text="" CssClass=""></asp:TextBox>
                  </label>
          </div>
          <div class="one_fifth">
          <label for="author">
                                Name  <span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtName" runat="server" Text="" CssClass=""></asp:TextBox>

                                </label>
        </div>
        <div class="one_fifth">
          <label for="author">
                              Mobile Number  <span class="required"></span>
                               <br>
                               <asp:TextBox ID="txtMobile" runat="server" Text="" CssClass=""></asp:TextBox>
                                </label>
         </div>
         <div class="one_fifth">
         <label for="author">
                            PostApplied<span class="required"></span>
                            <br>
                               <asp:TextBox ID="txtPostApplied" runat="server" Text="" CssClass=""></asp:TextBox>
                               </label>
        </div>
        <div class="one_fifth">
        
        <asp:Button ID="btnSearch" runat="server" Text="SEARCH" 
                class="button large gradient orange" onclick="btnSearch_Click"/>
        
        </div>
   
        </div>

                   <div style="width: 100%; height: 20px;">
                </div>
          
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="CarrerId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 13px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="200" Width="100%" CssClass=""
            GridLines="None" CellPadding="2" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Gender">
                    <ItemTemplate>
                        <asp:Label ID="lblGender" runat="server" Text='<%#Eval("Gender") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Current Employer">
                    <ItemTemplate>
                        <asp:Label ID="lblCurrentEmployee" runat="server" Text='<%#Eval("CurrentEmployee") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Current Designation">
                    <ItemTemplate>
                        <asp:Label ID="lblCurrentDesignation" runat="server" Text='<%#Eval("CurrentDeisgnation") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
                  <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="lblEmail" runat="server" Text='<%#Eval("Email") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Mobile">
                    <ItemTemplate>
                        <asp:Label ID="lblMobile" runat="server" Text='<%#Eval("Mobile") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Position Applied for">
                    <ItemTemplate>
                        <asp:Label ID="lblPosition" runat="server" Text='<%#Eval("PositionAppliying") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Qualification">
                    <ItemTemplate>
                        <asp:Label ID="lblDegree" runat="server" Text='<%#Eval("Degree") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Experience">
                    <ItemTemplate>
                        <asp:Label ID="lblExperience" runat="server" Text='<%#Eval("Experience") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Current CTC">
                    <ItemTemplate>
                        <asp:Label ID="lblCurrentCTC" runat="server" Text='<%#Eval("CurrentCTC") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Expected CTC">
                    <ItemTemplate>
                        <asp:Label ID="lblExpectedCTE" runat="server" Text='<%#Eval("ExpectedCTC") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Resume">
                    <ItemTemplate>
                    <a href="../UploadedFile/<%#Eval("Resume") %>" target="_blank" title="Download Resume">
                        <asp:Label ID="lblresume" runat="server" Text='<%#Eval("Resume") %>' />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="photo">
                    <ItemTemplate>
                 
                    <a href="../UploadedFile/<%#Eval("UploadImages") %>" target="_blank" title="Download Image">
                       <img style="width:160px; height:125px; border: 1px solid #e6e6e6" alt="" src='../UploadedFile/<%#Eval("UploadImages")%>' />
                  
                        <asp:Label ID="lblUploadImages" runat="server" Text='<%#Eval("UploadImages") %>' />
                        </a>
                    </ItemTemplate>
                </asp:TemplateField>
                 
                  <asp:TemplateField HeaderText="Job Title">
                    <ItemTemplate>
                        <asp:Label ID="lbljobTitle" runat="server" Text='<%#Eval("JobTitle") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="30px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="50px" />
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

        <asp:Label ID="lblmsg" runat="server" text="" CssClass="alert-msg error" Visible="false"></asp:Label>
        <asp:Button ID="btnDeleteAll" runat="server" Text="DELETE ALL" 
                    class="button large gradient orange" onclick="btnDeleteAll_Click"  /></div>
  
        
        </div>
        </div>
</asp:Content>

