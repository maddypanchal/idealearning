<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="HomeWorkDetails.aspx.cs" Inherits="Student_HomeWorkDetails" %>

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
    <section class="clear">

<table >



             <tr>
                <td align="center" colspan="3">
                 <asp:Label ID="lblMsg" runat="server" CssClass="footer_title" Text=""></asp:Label>
                </td>
            </tr>
              <tr>
                  <td>
                      <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Class* <span class="required"></span>
                             <asp:DropDownList ID="ddlClass" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
                    OnSelectedIndexChanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                        </label>
                    </div>
                    <div class="one_half">
                        <label for="author">
                            Select Course* <span class="required"></span>
                            <asp:DropDownList ID="ddlCourselist" runat="server" AutoPostBack="true" CssClass="Ddl_Css"
                                OnSelectedIndexChanged="ddlCourseList_SelectedIndexChanged">
                                <asp:ListItem>--Select--</asp:ListItem>
                            </asp:DropDownList>
                        </label>
                    </div>
                </div>

                   <div class="form-input clear">
                    <div class="one_half">
                        <label for="author">
                            Select Subject* <span class="required"></span>
                <asp:DropDownList ID="ddlSubject" runat="server" AutoPostBack="true"   OnSelectedIndexChanged="ddlSubject_SelectedIndexChanged"  CssClass="Ddl_Css">
                </asp:DropDownList>
                   </label>
                   </div>
                       </div>

                  </td>

</tr>



            
    <tr>


        <td colspan="2">

            <div class="Contact_GridView">
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="HomeWorkId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="20" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" OnRowDeleting="gvDetail1_RowDeleting"    >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Uploaded Date">
                    <ItemTemplate>
                        <asp:Label ID="lblEventName" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Attachment">
                      <ItemTemplate>
                    <a href ='../Employee/DocFile/<%#Eval("DocFile")%>' target="_blank">Download 
                <asp:Image ID="imgdoc" runat="server" ImageUrl="~/images/docxfile.png" Width="70px" Height="70px" />
                </a>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Description">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                 </asp:TemplateField>
             <%--    <asp:TemplateField HeaderText="Send SMS">
                             <ItemTemplate>
                                <a href="SendSmsHomeWork.aspx?Sid=<%#Eval("HomeWorkId") %>">Send
                             </ItemTemplate>
                 </asp:TemplateField>
                   <asp:TemplateField HeaderText="ACTION">
                   <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="40px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="60px" />
                   </ItemTemplate>
                </asp:TemplateField>--%>
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
        </td>
    </tr>





        <%--<asp:Repeater ID="rephw" runat="server">
    <ItemTemplate>
     <tr>
      <td>




                        <p Font-Bold="true" style="float:left; color: #fe7300; font-size: 22px; font-weight: bold; margin: 3px 0 5px 42px; width: 100%;" ><%#Eval("Description")%> </p>
                         <p style="margin:5px 0 5px 42px; font-size:18px; color:#8e8e8e;"> <%#Eval("Date")%></p>
                      </td>
                <td>
              
                <a href ='../Employee/DocFile/<%#Eval("DocFile")%>' target="_blank">Download 
                <asp:Image ID="imgdoc" runat="server" ImageUrl="~/images/docxfile.png" Width="70px" Height="70px" />
                </a>
             
                      </td>
                     
            </tr>
     </ItemTemplate>
    </asp:Repeater>--%>
            
               <tr>
                <td colspan="2" align="center">
                    <div class="divClear">
                    </div>
                   </td>
            </tr>
            <tr>
            <td colspan="2">
            </td>
            </tr>
        </table>

             
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

