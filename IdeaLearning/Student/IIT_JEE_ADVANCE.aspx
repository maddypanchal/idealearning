<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="IIT_JEE_ADVANCE.aspx.cs" Inherits="Student_IIT_JEE_ADVANCE" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">

          <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b> <asp:Label ID="lblResults" runat="server" text="RESULTS DETAILS"></asp:Label></b></p>
     </div>
      </div>
    <%--  <table>
     <tr>
     <td>    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" 
             onselectedindexchanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList></td>
     <td>
         <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" 
            onselectedindexchanged="DropDownList2_SelectedIndexChanged">
 </asp:DropDownList>
      </td>
      </tr>
      <tr>
      <td >
      <asp:Chart ID="Chart1" runat="server" Width="350px" >
        <Titles>
         <asp:Title Text="Chart for Student Results"></asp:Title>
         </Titles>
            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1"  ChartType="Pie">
                <Points>
                <asp:DataPoint AxisLabel="phy" YValues="40" />
                <asp:DataPoint AxisLabel="che" YValues="30" />
                <asp:DataPoint AxisLabel="math" YValues="70" />
              
                </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1" >

                <AxisX Title="student name">
                </AxisX>
               <AxisY Title="total marks "> </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
    <td>
    <asp:Chart ID="Chart2" runat="server" Width="350px">
        <Titles>
        <asp:Title Text="Chart for Student Results"></asp:Title>
        </Titles>
            <Series>
                <asp:Series Name="Series2" ChartArea="ChartArea2" ChartType="Pie">
                <Points>
                <asp:DataPoint AxisLabel="phy" YValues="40" />
                <asp:DataPoint AxisLabel="che" YValues="30" />
                <asp:DataPoint AxisLabel="math" YValues="70" />
          
                </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea2">

                <AxisX Title="student name">
                </AxisX>
               <AxisY Title="total marks "> </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
        </tr>
    </table>--%>

     <div style="height:60px;">
      <b> <asp:Label ID="lblMsg" runat="server" text="REGULAR RESULTS DETAILS" CssClass="alert-msg warning" style="color:rgb(28, 213, 9)"></asp:Label></b>
      
      </div>
    FOR CURRENT STUDENT 

     <asp:GridView ID="gvDristhiSheet" runat="server" AutoGenerateColumns="False" DataKeyNames="DristhiTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
           
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

                   <%-- <asp:TemplateField HeaderText="Mm Bio">
                    <ItemTemplate>
                        <asp:Label ID="lblMmBio" runat="server" Text='<%#Eval("MmBio") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                 <%--    <asp:TemplateField HeaderText="Mm GK">
                    <ItemTemplate>
                        <asp:Label ID="lblMmGk" runat="server" Text='<%#Eval("MmGk") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
               <%--      <asp:TemplateField HeaderText="Mm ENG">
                    <ItemTemplate>
                        <asp:Label ID="lblMmEng" runat="server" Text='<%#Eval("MmEng") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                  <%--   <asp:TemplateField HeaderText="Mm Science">
                    <ItemTemplate>
                        <asp:Label ID="lblMmScience" runat="server" Text='<%#Eval("MmScience") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>

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
                      <asp:TemplateField HeaderText="Mo Math">
                     <ItemTemplate>
                        <asp:Label ID="lblMoChe" runat="server" Text='<%#Eval("MoMath") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                
                    <%--<asp:TemplateField HeaderText="MoBio">
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
                </asp:TemplateField>--%>

                 <asp:TemplateField HeaderText="Total Max Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMaxMarks" runat="server" Text='<%#Eval("TotalMaxMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Total Marks Obtained (MO)">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMarks" runat="server" Text='<%#Eval("TotalMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 
                      <asp:TemplateField HeaderText="Cut Of Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblCutOfMarks" runat="server" Text='<%#Eval("CutOfMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="% Mo">
                    <ItemTemplate>
                        <asp:Label ID="lblScross" runat="server" Text='<%#Eval("Percentage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="AIR Rank">
                    <ItemTemplate>
                        <asp:Label ID="lblAIRRank" runat="server" Text='<%#Eval("AIRRank") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Total Marks Of Topper">
                    <ItemTemplate>
                        <asp:Label ID="lblTotolMarkesOfTopper" runat="server" Text='<%#Eval("TotolMarksOfTopper") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
          <%--          <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
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
 
<%-- FOR  TOPPER STUDENT
 <asp:GridView ID="GridViewMax" runat="server" AutoGenerateColumns="False" DataKeyNames="DristhiTestSheetId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B">
            <AlternatingRowStyle BackColor="White"/>
            <Columns>
           
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
                      <asp:TemplateField HeaderText="Mo Math">
                     <ItemTemplate>
                        <asp:Label ID="lblMoChe" runat="server" Text='<%#Eval("MoMath") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

           
                 <asp:TemplateField HeaderText="Total Max Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMaxMarks" runat="server" Text='<%#Eval("TotalMaxMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Total Marks Obtained (MO)">
                    <ItemTemplate>
                        <asp:Label ID="lblTotalMarks" runat="server" Text='<%#Eval("TotalMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 
                      <asp:TemplateField HeaderText="Cut Of Marks">
                    <ItemTemplate>
                        <asp:Label ID="lblCutOfMarks" runat="server" Text='<%#Eval("CutOfMarks") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="% Mo">
                    <ItemTemplate>
                        <asp:Label ID="lblScross" runat="server" Text='<%#Eval("Percentage") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="AIR Rank">
                    <ItemTemplate>
                        <asp:Label ID="lblAIRRank" runat="server" Text='<%#Eval("AIRRank") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                      <asp:TemplateField HeaderText="Total Marks Of Topper">
                    <ItemTemplate>
                        <asp:Label ID="lblTotolMarkesOfTopper" runat="server" Text='<%#Eval("TotolMarksOfTopper") %>' />
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
        </asp:GridView>--%>
        </section>
        </div>
</asp:Content>

