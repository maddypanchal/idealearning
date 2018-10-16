<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="FillTask.aspx.cs" Inherits="Admin_FillTask" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>
    <script type="text/javascript">
        function init() {
            calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
        }
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

            <section>
     <%-- <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>ADD WORK DETAILS</b></p>
     </div>
      </div>


    </section>

   <div style="height:20px;"></div>

    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                             Work Done  * <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtWrokDone" runat="server"  TextMode="MultiLine"  placeholder="Work Done" Text=""
                       ></asp:TextBox>
                  </label>
        </div>
            <div class="one_half">
              <label for="author">
                             Work Pending   <span class="required"></span>
                            <br>
                   <asp:TextBox ID="txtWorkPending" runat="server"  TextMode="MultiLine" placeholder="Work Pending" Text=""></asp:TextBox>
                   
                  </label>
       
        </div>
        </div>
         


          <div class="form-input clear">

            <div class="one_half">
                <label for="author">
                              Reason for Pending   <span class="required"></span>
                            <br>
                   <asp:TextBox ID="txtReasonForPending" runat="server"  TextMode="MultiLine" placeholder="Reason for Pending" Text=""></asp:TextBox>
                   
                  </label>


            </div>

             <div class="one_half">
                <label for="author">
                              Remark  <span class="required"></span>
                        <br>
                         <asp:TextBox ID="txtRemark" runat="server"  TextMode="MultiLine"  placeholder="Remark" Text=""></asp:TextBox>
               
                  </label>


            </div>
            </div>

           <div style="height:20px;"></div>
          <div class="form-input clear">
                 
          </div>
             <div style="height:20px;"></div>
              <div class="form-input clear">
                 <asp:Button ID="btnSubmit" Text="Submit" runat="server" class="button large gradient orange" ValidationGroup="o1"
                        OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
     </section>--%>


      <div style="height:20px;"></div>

                <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>DETAILS OF TASK</b></p>
     </div>
      </div>
    
       <%--<div class="one_third">
       <a href="#" class="button large gradient orange">Contact Us</a></div>--%>

    </section>

   <div style="height:20px;"></div>

     <div class="Contact_GridView">
            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeWorkDetailsId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 13px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="200" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="2" ForeColor="#7B7B7B"  onrowdeleting="gvDetail1_RowDeleting" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
              <%-- 
              <%--  <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <asp:TemplateField HeaderText="Task Update Date">
                    <ItemTemplate>
                        <asp:Label ID="lblTaskUpdateDate" runat="server" Text='<%#Eval("TaskUpdateDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                              <asp:TemplateField HeaderText="Employee Name">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkFor" runat="server" Text='<%#Eval("EmployeeName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="WorkDone">
                    <ItemTemplate>
                        <asp:Label ID="lblWorkDone" runat="server" Text='<%#Eval("WorkDone")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Pending Work">
                    <ItemTemplate>
                        <asp:Label ID="lblPendingWork" runat="server" Text='<%#Eval("PendingWork") %>' />
                    </ItemTemplate>
        
                </asp:TemplateField>

                           <asp:TemplateField HeaderText="Reason For Pending">
                    <ItemTemplate>
                        <asp:Label ID="lblLastDateOfComplate" runat="server" Text='<%#Eval("ReasonForPending") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                           <asp:TemplateField HeaderText="Remark">
                    <ItemTemplate>
                        <asp:Label ID="lblInstruction" runat="server" Text='<%#Eval("Remark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
              
               <%--  <asp:TemplateField HeaderText="Task">
                    <ItemTemplate>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Description") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
            
                       <%--        <asp:TemplateField HeaderText="View Details">
                             <ItemTemplate>
                               <a href="FillTask.aspx?Sid=<%#Eval("EmployeeWorkId") %>">Task Details</a>
                             </ItemTemplate>
                         </asp:TemplateField>--%>

              <%--      <asp:TemplateField HeaderText="ACTION">
                    <ItemTemplate>
                       <asp:ImageButton ID="imgbtnDelete" runat="server" CommandName="Delete" Height="30px"
                            ImageUrl="~/images/Delete.png" Text="Edit" ToolTip="Delete" Width="50px" />
                    </ItemTemplate>
                </asp:TemplateField>--%>
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
            <asp:Label ID="lblMsg" runat="server" Text="" CssClass="alert-msg success" Visible="false" ForeColor="Red"></asp:Label>
            
     </div>



    
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>

</asp:Content>

