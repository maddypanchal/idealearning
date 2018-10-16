<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="NewsEvent.aspx.cs" Inherits="Employee_NewsEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



        <div id="container">
        <div class="wrapper">
            <div class="content_main">
                <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p><b>Add News and Event Details </b></p>
                         <asp:Label ID="lblMsg" runat="server"   Text=" "></asp:Label>
                    </div>
                </div>
                <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Class* <span class="required"></span>
                            <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"  OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                            </asp:DropDownList>
                        </label>
                    </div>
                    <div class="one_half">
                        <label for="author">
                            Select Course* <span class="required"></span>
                     <asp:DropDownList ID="ddlCourselist" runat="server"  AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlCourseList_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                        </label>
                    </div>
                </div>
                <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Subject
                        <asp:DropDownList ID="ddlSubject" runat="server" CssClass="Ddl_Css" >
                        </asp:DropDownList>
                            </label>
                        </div>
                      <div class="one_half">
                        <label for="author">
                             Title 
                            <asp:TextBox ID="txtTitle" runat="server" Text="" CssClass="Ddl_Css" ></asp:TextBox>
                            </label>
                        </div>
                     </div>
                    <div class="form-input clear">
                       <div class="one_half">
                        <label for="author">
                         Descriptions
                       <asp:TextBox ID="txtDescriptions" runat="server" Text="" TextMode="MultiLine" CssClass="Ddl_Css" ></asp:TextBox>
                        </label>
                        </div>
                      <div class="one_half">
                         <label for="author">
                         <asp:Button ID="btnSave" runat="server" Text="ADD" class="button large gradient red" onclick="btnSave_Click"/>
                         </label>
                        </div>
                     </div>

                <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="NewsEventId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 14px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" PagerSettings-Position="Top" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="2" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" onpageindexchanging="gvDetail1_PageIndexChanging"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="News And Event Name">
                    <ItemTemplate>
                        <asp:Label ID="lblYearName" runat="server" Text='<%#Eval("TitleName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="News And Event Date" >
                    <ItemTemplate>
                        <asp:Label ID="lblTitleDate" runat="server" Text='<%#Eval("TitleDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="News And Event Description">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
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
            <SortedAscendingCellStyle BackColor="#F5F7FB"/>
            <SortedAscendingHeaderStyle BackColor="#6D95E1"/>
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE"/>
         </asp:GridView>
          </div>
                </div>
            </div>
        </div>
    

            
     
</asp:Content>

