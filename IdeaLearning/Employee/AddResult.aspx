<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true"
    CodeFile="AddResult.aspx.cs" Inherits="Employee_AddResult" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>
    <script type="text/javascript">
        function init() {
            calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">

        <!-- ################################################################################################ -->
        <section class="clear">

     <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b> <asp:Label ID="lblResults" runat="server" text="ADD RESULTS DETAILS"></asp:Label></b></p>
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
            <%--<asp:ListItem Value="5">KVPY/NTSE/Olympiad/Other Test</asp:ListItem>--%>
            </asp:DropDownList>
            </label>
          </div>
          </div>

           <%--Start panel for Itse Schoolar Test --%>
                             <asp:UpdatePanel ID="UpScholarShipTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
              <div style="height:20px;"></div>
          <div class="form-input clear">
            
            <div class="Form-input clear">
            
                      Excel File Download For <asp:Label ID="lblTestName" runat="server" Text=""> </asp:Label>
             <a href="Excel/ScholerResult.xlsx"> <img src="../images/ExcelFileIcon.png" width="50px !importent" height="50px !importent" /> </a>
             </div>
   
    <div class="Form-input clear">
                <div class="one_half">
                <label for="author">


                Test Code * <span class="required"></span>
                            <br>
                                <asp:TextBox ID="txtScholarCode" runat="server" ValidationGroup="ScholarShip" Text=""></asp:TextBox> 
                            </label>
                </div>
                <div class="one_half">
                              <label for="author">
              Test Name * <span class="required"></span>
                            <br>
                                         <asp:TextBox ID="txtScholarName" runat="server" Text=""></asp:TextBox>
                            </label>
                            </div>
                </div>

 <div class="Form-input clear">
                <div class="one_half">
               
         
             
         <label for="author">


            Test Date * (Date should be dd-mm-yyyy) <span class="required"></span>
                            <br>
                   
                            <asp:TextBox ID="txtScholarDate" runat="server" Text="" class="Ddl_Css tcal"></asp:TextBox>
                            </label>


                            </div>
                <div class="one_half">
                              <label for="author">
                Upload File * <span class="required"></span>
                            <br>
                                
            <asp:FileUpload ID="FuScholar" runat="server"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="FuScholar" Text="* Upload File" />
                            </label>
                            </div>

                            </div>
   
            <div class="form-input clear">
                  <asp:Button ID="btnScholar" runat="server" Text="Upload" OnClick="Scholar_Click" CssClass="button large gradient orange"  />
                 <asp:Label  ID="lblMsgScholar" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
            </div>
             

             <div class="form-input clear">

            <asp:GridView ID="GvScholerShip" runat="server" AutoGenerateColumns="False" DataKeyNames="ScholerTestSheetId"
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
          <asp:TemplateField HeaderText="Roll No">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                    <asp:TemplateField HeaderText="Roll Number">
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
               <%--   <asp:TemplateField HeaderText="Year">
          
                    <ItemTemplate>
                        <asp:Label ID="lblYear" runat="server" Text='<%#Eval("Year") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
         <%--           <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
 
          </div>
           </ContentTemplate>
            <Triggers>
            <asp:PostBackTrigger ControlID="btnScholar" />
            </Triggers>
            </asp:UpdatePanel>
            <%--End panel for Itse test --%>

             <%--Start Panel for Itse test --%>
          
            <asp:UpdatePanel ID="UpItseTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
              <div style="height:20px;"></div>
            <div class="form-input clear">
            <div class="one_half">

         <label for="author">
             Excel File Download For<span class="required"></span>
                            <br>
             <asp:Label ID="Label1" runat="server" Text=""> </asp:Label>
             <a href="Excel/ITSE.xlsx"> <img src="../images/ExcelFileIcon.png" width="50px !importent" height="50px !importent" /> </a>
             </label>
             </div>
                 <div class="one_half">

         <label for="author">
              File Upload * <span class="required"></span>
                            <br>

                                  <asp:FileUpload ID="FlUploadcsv" runat="server"  />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="FlUploadcsv" Text="* Upload File" />
            
                            </label>
                            </div>
             </div>
            
            <div class="form-input clear">
          
             <div class="one_half">
         
                                    <asp:Button ID="btnIpload" runat="server" Text="Upload" class="button large gradient orange" OnClick="btnIpload_Click" />
                                <%--  <asp:DropDownList ID="ddlselectYear" runat="server" CssClass="dropdownlist"  AutoPostBack="true"
                                        ValidationGroup="g1" 
                                        onselectedindexchanged="ddlselectYear_SelectedIndexChanged"> 
            
                                   </asp:DropDownList>
                                     <asp:Button ID="btnDelete" runat="server" Text="Delete" ValidationGroup="g1" class="button large gradient orange" OnClick="btnDelete_Click" />
                             --%>         </div>

                   </div>
                   <div style="height:20px;"></div>
             <div class="form-input clear">

            <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="ItseResultId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"    >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                
                 <asp:TemplateField HeaderText="Roll Number">
                    <ItemTemplate>
                        <asp:Label ID="lblRollNumber" runat="server" Text='<%#Eval("RollNumber") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
          <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
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
         <%--           <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
            <Triggers>
            <asp:PostBackTrigger ControlID="btnIpload"  />
           
            </Triggers>
            </asp:UpdatePanel>

       <%--End panel for Itse test --%>
   
        <%--Start panel for Dristhi Test --%>
                             <asp:UpdatePanel ID="UpDristhiTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>
              <div style="height:20px;"></div>
          <div class="form-input clear">
            
            <div class="Form-input clear">
            
                      Excel File Download For <asp:Label ID="lblDristhi" runat="server" Text=""> </asp:Label>
             <a href="Excel/Dristhi.xlsx"> <img src="../images/ExcelFileIcon.png" width="50px !importent" height="50px !importent" /> </a>
             </div>
   
               <div class="Form-input clear">
                <div class="one_half">
                <label for="author">
                Test Name * <span class="required"></span>
                            <br>
            <asp:DropDownList ID="ddlDrishti" runat="server" CssClass="dropdownlist"> 
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
                <div class="one_half">
                              <label for="author">
               Test Code * <span class="required"></span>
                               <br>
                                         <asp:TextBox ID="txtDristhiTestName"  runat="server" Text=""></asp:TextBox>
                             </label>
                             </div>
               </div>

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
                Date *  (Date should be dd-mm-yyyy) <span class="required"></span>
                       

                         <asp:TextBox ID="txtDristhiDate"   runat="server" Text=" "  class="Ddl_Css tcal"></asp:TextBox>
                            </div>

                <div class="Form-input clear">
                <div class="one_half">
                  
            <label for="author">
                Test Syllabus* <span class="required"></span>
                          
                            <asp:TextBox ID="txtSyllabus" TextMode="MultiLine" runat="server" Text=""></asp:TextBox>
                            </label>
                            </div>
                <div class="one_half">
                              <label for="author">
                Upload File * <span class="required"></span>
                        
                                
            <asp:FileUpload ID="FuDristhi" runat="server"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FuDristhi" Text="* Upload File" />
                            </label>
                            </div>

                            </div>
   
            <div class="form-input clear">
                  <asp:Button ID="btnDristhi" runat="server" Text="Upload" OnClick="btnDristhi_Click"  CssClass="button large gradient orange" />
            </div>
             
 
          </div>

          <div class="form-input clear">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DristhiTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Roll No">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RegNo">
                       <ItemTemplate>
                        <asp:Label ID="lblRegNo" runat="server" Text='<%#Eval("RegNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mm Phy">
          
                    <ItemTemplate>
                        <asp:Label ID="lblMmPhy" runat="server" Text='<%#Eval("MmPhy") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Mm Che">
          
                    <ItemTemplate>
                        <asp:Label ID="lblMobileNo" runat="server" Text='<%#Eval("MmChe") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Mm Math">
                    <ItemTemplate>
                        <asp:Label ID="lblMaxMark" runat="server" Text='<%#Eval("MmMath") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Mm Bio">
                    <ItemTemplate>
                        <asp:Label ID="lblMmBio" runat="server" Text='<%#Eval("MmBio") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Mm GK">
                    <ItemTemplate>
                        <asp:Label ID="lblMmGk" runat="server" Text='<%#Eval("MmGk") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Mm ENG">
                    <ItemTemplate>
                        <asp:Label ID="lblMmEng" runat="server" Text='<%#Eval("MmEng") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Mm Science">
                    <ItemTemplate>
                        <asp:Label ID="lblMmScience" runat="server" Text='<%#Eval("MmScience") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Mo Phy">
                     <ItemTemplate>
                        <asp:Label ID="lblMoPhy" runat="server" Text='<%#Eval("MoPhy") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                    <asp:TemplateField HeaderText="Mo Che">
                     <ItemTemplate>
                        <asp:Label ID="lblMoChe" runat="server" Text='<%#Eval("MoChe") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                
                    <asp:TemplateField HeaderText="MoBio">
                    <ItemTemplate>
                        <asp:Label ID="lblMoBio" runat="server" Text='<%#Eval("MoBio") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="Mo GK">
                    <ItemTemplate>
                        <asp:Label ID="lblMoGk" runat="server" Text='<%#Eval("MoGk") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Mo ENG">
                    <ItemTemplate>
                        <asp:Label ID="lblMoEng" runat="server" Text='<%#Eval("MoEng") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                     <asp:TemplateField HeaderText="Mo Science">
                    <ItemTemplate>
                        <asp:Label ID="lblMoScience" runat="server" Text='<%#Eval("MoScience") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Total Max Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMaxMarks" runat="server" Text='<%#Eval("TotalMaxMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Total Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMarks" runat="server" Text='<%#Eval("TotalMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 
                      <asp:TemplateField HeaderText="Cut Of Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblCutOfMarks" runat="server" Text='<%#Eval("CutOfMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Percentage">
                    <ItemTemplate>
                        <asp:Label ID="lblScross" runat="server" Text='<%#Eval("Percentage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="AIR Rank">
                    <ItemTemplate>
                        <asp:Label ID="lblAIRRank" runat="server" Text='<%#Eval("AIRRank") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Totol Marks Of Topper">
                    <ItemTemplate>
                        <asp:Label ID="lblTotolMarkesOfTopper" runat="server" Text='<%#Eval("TotolMarksOfTopper") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
         <%--           <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
              </label>
           </ContentTemplate>
            <Triggers>
            <asp:PostBackTrigger ControlID="btnDristhi" />
            </Triggers>
            </asp:UpdatePanel>
            <%--End panel for Itse test --%>

        <%--Start Panel for Regular test --%>
          <asp:UpdatePanel ID="UpRegularTest" UpdateMode="Conditional" Visible="false" runat="server">
            <ContentTemplate>

             <div style="height:20px;"></div>

               <div class="form-input clear">
                <div class="one_half">
             
          
                                  <label for="author">
            
                     Excel File Download For Regular Test  <span class="required"></span> 
                
                <a href="Excel/RegularResult.xlsx"> <img src="../images/ExcelFileIcon.png" width="50px !importent" height="50px !importent" /> </a>
                </label>
                </div>
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
                 
            <asp:DropDownList ID="ddlRegularTestType" runat="server" CssClass="dropdownlist"> 
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
                 <div class="one_half">
                <label for="author">
             Test Name <span class="required"></span>
                            <br>
             <asp:TextBox ID="TxtRegularTestName" runat="server"></asp:TextBox>
              
              </label>
              </div>
              </div>


              <div class="Form-input clear">
              

                               <div class="one_half">
                <label for="author">
                Date * (Date should be dd-mm-yyyy)<span class="required"></span>
                            <br>
                                <asp:TextBox ID="txtRegularDate"  runat="server" Text=" " class="Ddl_Css tcal"></asp:TextBox>

                            </label>
              </div>
              
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

                            </div>

               <div class="form-input clear">

              <div class="one_half">
                <label for="author">
              File Upload<span class="required"></span>
                            <br>
                                <asp:FileUpload ID="FURegular" runat="server"   />
             <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="FURegular"  Text="* Upload File" />
                            </label>
              </div>

                 <div class="one_half">
                  
            <label for="author">
                Test Syllabus* <span class="required"></span>
                          
                            <asp:TextBox ID="txtRegularSyllabus" TextMode="MultiLine" runat="server" Text=""></asp:TextBox>
                            </label>
                            </div>
         
             </div> 
          
                  <div class="form-input clear">   
                   <asp:Button ID="btnRegularTest" runat="server" Text="Upload" class="button large gradient orange" OnClick="btnRegularTest_Click"  />
                          <asp:Label  ID="lblError" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
                         </div>
                           <div class="form-input clear">

            <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="RegularTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                  </asp:TemplateField>
                     <asp:TemplateField HeaderText="RegNo">
                    <ItemTemplate>
                        <asp:Label ID="lblRegNo" runat="server" Text='<%#Eval("RegNo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                  <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("Name") %>' />
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
                     <asp:TemplateField HeaderText="Percentage">
                    <ItemTemplate>
                        <asp:Label ID="lblPercentage" runat="server" Text='<%#Eval("Percentage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                
                  <asp:TemplateField HeaderText="Rank">
                    <ItemTemplate>
                        <asp:Label ID="lblRank" runat="server" Text='<%#Eval("Rank") %>' />
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
            <Triggers>
            <asp:PostBackTrigger ControlID="btnRegularTest" />
           </Triggers>
           </asp:UpdatePanel>

       <%--End panel for Regular test --%>
         
    </section>
    </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear">
    </div>
</asp:Content>
