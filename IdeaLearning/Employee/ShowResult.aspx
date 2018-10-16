<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true"
    CodeFile="ShowResult.aspx.cs" Inherits="Employee_ShowResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">

     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b> <asp:Label ID="lblResults" runat="server" text="RESULTS DETAILS"></asp:Label></b></p>
     </div>
      </div>
     
           <div style="height:20px;"></div>
                   <div class="form-input clear">
        <div class="one_half">

         <label for="author">
            <b style="font-size:20px; padding:10px;" >  Select Reslut Type * </b><span class="required"></span>
                            <br>
                             
        <asp:DropDownList ID="ddlResult" runat="server" AutoPostBack="true" onselectedindexchanged="ddlResult_SelectedIndexChanged" CssClass="Ddl_Css">
            <asp:ListItem Value="0">Select One</asp:ListItem>
            <asp:ListItem Value="1">ScholarShip Test</asp:ListItem>
            <asp:ListItem Value="2">ITSE TEST</asp:ListItem>
            <asp:ListItem Value="3">DRISHTI TEST</asp:ListItem>
            <asp:ListItem Value="4">REGULAR TEST</asp:ListItem>
      <%--      <asp:ListItem Value="5">KVPY/NTSE/Olympiad/Other Test</asp:ListItem>--%>
            </asp:DropDownList>
            </label>
          </div>
          </div>

           <%--Start panel for Itse Schoolar Test --%>
            <asp:UpdatePanel ID="UpScholarShipTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>


          <div class="form-input clear">

            <asp:GridView ID="GvScholerShip" runat="server" AutoGenerateColumns="False" DataKeyNames="ScholerTestResultId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
      
                <asp:TemplateField HeaderText="Test Code">
                       <ItemTemplate>
                        <asp:Label ID="lblTestCode" runat="server" Text='<%#Eval("ScholerTestCode") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Test Name">
          
                    <ItemTemplate>
                        <asp:Label ID="lblTestName" runat="server" Text='<%#Eval("ScholerTestName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Test Date">
          
                    <ItemTemplate>
                        <asp:Label ID="lblTestDate" runat="server" Text='<%#Eval("ScholerTestDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

               <asp:TemplateField HeaderText="Result Sheet">
                             <ItemTemplate>
                                <a href="ShowScholerShipSheet.aspx?Sid=<%#Eval("ScholerTestResultId") %>">Show Result Sheet </a>
                             </ItemTemplate>
                         </asp:TemplateField>

               <%--     <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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


           </ContentTemplate>
          </asp:UpdatePanel>
            <%--End panel for Schoolar test --%>

         
             <%--Start Panel for Itse test --%>
          
            <asp:UpdatePanel ID="UpItseTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
              <div style="height:20px;"></div>
                 <div class="form-input clear">
                    <div class="one_half">
                <label for="author">
                Select Year * <span class="required"></span>
                            <br>
            <asp:DropDownList ID="ddlselectYear" runat="server" CssClass="dropdownlist" AutoPostBack="true" onselectedindexchanged="ddlselectYear_SelectedIndexChanged">
                </asp:DropDownList>
                </label>
                </div>
          </div>
             <div class="form-input clear">

            <asp:GridView ID="gvItse" runat="server" AutoGenerateColumns="False" DataKeyNames="ItseResultId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"   >
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

                
                        <asp:TemplateField HeaderText="Roll Number ">
                       <ItemTemplate>
                        <asp:Label ID="lblRollNumber" runat="server" Text='<%#Eval("RollNumber") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="School">
                       <ItemTemplate>
                        <asp:Label ID="lblSchool" runat="server" Text='<%#Eval("School") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Father Name">
          
                    <ItemTemplate>
                        <asp:Label ID="lblFatherName" runat="server" Text='<%#Eval("FatherName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Mobile No">
          
                    <ItemTemplate>
                        <asp:Label ID="lblMobileNo" runat="server" Text='<%#Eval("MobileNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Max Mark">
                    <ItemTemplate>
                        <asp:Label ID="lblMaxMark" runat="server" Text='<%#Eval("MaxMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Obtain Mark">
                    <ItemTemplate>
                        <asp:Label ID="lblObtainMark" runat="server" Text='<%#Eval("ObtainMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Percentage Mark">
                     <ItemTemplate>
                        <asp:Label ID="lblPercentageMark" runat="server" Text='<%#Eval("PercentageMark") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Rank">
                     <ItemTemplate>
                        <asp:Label ID="lblRank" runat="server" Text='<%#Eval("Rank") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Scholoar Ship">
                    <ItemTemplate>
                        <asp:Label ID="lblScholoarShip" runat="server" Text='<%#Eval("ScholoarShip") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Year">
          
                    <ItemTemplate>
                        <asp:Label ID="lblYear" runat="server" Text='<%#Eval("Year") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <%--<asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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

            <div class="form-input clear">
            <asp:Button ID="btnAllDelete" Text="Delete All" runat="server" 
                    class="button large gradient orange" onclick="btnAllDelete_Click" />
            </div>


             </ContentTemplate>
             </asp:UpdatePanel>

       <%--End panel for Itse test --%>
       
       

        <%--Start panel for Itse Schoolar Test --%>
                             <asp:UpdatePanel ID="UpDristhiTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
              <div style="height:20px;"></div>
          

          <div class="Form-input clear">
          <div class="one_half">
             
          
                                  <label for="author">
            
                     Class*  <span class="required"></span>                                           
                <asp:DropDownList ID="ddlClassDristhi" runat="server" CssClass="Ddl_Css" >
                </asp:DropDownList>
                            </label>
                             </div>
                <div class="one_half">
                <label for="author">
                Test Type * <span class="required"></span>
                            <br>
            <asp:DropDownList ID="ddlDrishti" runat="server" CssClass="dropdownlist" AutoPostBack="true"
                        onselectedindexchanged="ddlDrishti_SelectedIndexChanged"> 
            <asp:ListItem Value="0">Select One</asp:ListItem>
            <asp:ListItem Value="1">IIT-JEE-ADVANCE </asp:ListItem>
            <asp:ListItem Value="2">JEE-MAINS</asp:ListItem>
            <asp:ListItem Value="3">AIPMT</asp:ListItem>
            <asp:ListItem Value="4">AIIMS</asp:ListItem>
            <asp:ListItem Value="5">BITS</asp:ListItem>
            <asp:ListItem Value="6">KVPY</asp:ListItem>
            <asp:ListItem Value="7">NTSE</asp:ListItem>
            <asp:ListItem Value="8">OLYMPIAD</asp:ListItem>
            <asp:ListItem Value="9">OTHER</asp:ListItem>
            </asp:DropDownList>

                            </label>
                </div>
                
               </div>
          <div class="form-input clear">


          <asp:GridView ID="gvDristhi" runat="server" AutoGenerateColumns="False" DataKeyNames="DristhiTestResultId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"
            onrowdeleting="gvDristhi_RowDeleting"
            >
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Test Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("DristhiTestName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Date">
                       <ItemTemplate>
                        <asp:Label ID="lblSchool" runat="server" Text='<%#Eval("DristhiTestDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Test Code">
          
                    <ItemTemplate>
                        <asp:Label ID="lblDristhiTestCode" runat="server" Text='<%#Eval("DristhiTestCode") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
              
                       <asp:TemplateField HeaderText="Result Sheet">
                             <ItemTemplate>
                                <a href="ShowDristhiResult.aspx?Sid=<%#Eval("DristhiTestResultId") %>">Show Result Sheet </a>
                                
                                </ItemTemplate>
                         </asp:TemplateField>
            
                   <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

            
             </div>
           </ContentTemplate>
       
            </asp:UpdatePanel>
            <%--End panel for Itse test --%>




        <%--Start Panel for Regular test --%>
          <asp:UpdatePanel ID="UpRegularTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
             <div style="height:20px;"></div>

             <div class="form-input clear">
               <div class="one_half">
             
          
                                  <label for="author">
            
                     Class*  <span class="required"></span>                                           
                <asp:DropDownList ID="ddlClassRegular" runat="server" CssClass="Ddl_Css">
                </asp:DropDownList>
                            </label>
                             </div>
                             </div>

              <div class="form-input clear">
                   <div class="one_half">
                <label for="author">
             Select Test Type<span class="required"></span>
                            <br>
                  <asp:DropDownList ID="ddlDpp" runat="server" CssClass="dropdownlist"> 
            <asp:ListItem Value="0">Select One</asp:ListItem>
            <asp:ListItem Value="1">Objective DPP</asp:ListItem>
            <asp:ListItem Value="2">Subjective DPP/Test</asp:ListItem>
          
            </asp:DropDownList>
                            </label>
                            </div>
              <div class="one_half">
                <label for="author">
             Select Test Type<span class="required"></span>
                            <br>
                 
            <asp:DropDownList ID="ddlRegularTestType" runat="server" CssClass="dropdownlist" AutoPostBack="true" onselectedindexchanged="ddlRegularTestType_SelectedIndexChanged" > 
            <asp:ListItem Value="0">Select One</asp:ListItem>
            <asp:ListItem Value="1">Chemistry</asp:ListItem>
            <asp:ListItem Value="2">Maths(XI to XII)</asp:ListItem>
            <asp:ListItem Value="3">Maths(VI to X)</asp:ListItem>
            <asp:ListItem Value="4">Science(VI to X)</asp:ListItem>
            <asp:ListItem Value="5">English(VI to X)</asp:ListItem>
            <asp:ListItem Value="6">Biological</asp:ListItem>
             <asp:ListItem Value="7">Physics</asp:ListItem>
            </asp:DropDownList>
              </label>
              </div>
              
              </div>
      
          
                  <div class="form-input clear">   
                
                          <asp:Label  ID="lblError" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
                         </div>
                           <div class="form-input clear">

            <asp:GridView ID="GvReguler" runat="server" AutoGenerateColumns="False" DataKeyNames="RegularTestId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B" onrowdeleting="GvReguler_RowDeleting" >
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Test Type">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("TestType") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Test Name">
                    <ItemTemplate>
                        <asp:Label ID="lblMaxMark" runat="server" Text='<%#Eval("TestName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Test Date">
                    <ItemTemplate>
                        <asp:Label ID="lblObtainMark" runat="server" Text='<%#Eval("RegularTestDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                
       <asp:TemplateField HeaderText="Result Sheet">
                             <ItemTemplate>
                                <a href="ShowRegularResult.aspx?Sid=<%#Eval("RegularTestId") %>">Show Result Sheet </a>
                                
                                </ItemTemplate>
                         </asp:TemplateField>
                            <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
             </div>

            </ContentTemplate>
         
           </asp:UpdatePanel>

       <%--End panel for Regular test --%>
         
    </section>
    </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear">
    </div>
</asp:Content>
