<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true"
    CodeFile="RegularTestReport.aspx.cs" Inherits="Student_RegularTestReport" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../SimpalPopUp/fancybox/jquery-1.4.3.min.js" type="text/javascript"></script>
    <script src="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.pack.js" type="text/javascript"></script>
    <link href="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $(".Panchal").fancybox({
                'width': '100%',
                'height': '100%',
                'autoScale': false,
                'transitionIn': 'elastic',
                'transitionOut': 'elastic',
                'type': 'iframe'
            });
        });
        function msg() {
            alert("Entry Done!!!")
            window.parent.location = 'sideForm';
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>Regular Test Analysis</b></p>
      </div>
      </div>
      </section>
        <div style="height: 20px">
        </div>
        <div class="form-input clear">
            <div class="one_half">
                <div class="two_third">
                    <asp:Label ID="lblStudentName" runat="server" CssClass="textbox" style="width:100%;"  Text=""></asp:Label>
                    <asp:Label ID="lblFatherName" runat="server" CssClass="textbox" style="width:100%;"  Text=""></asp:Label>
                    <asp:Label ID="lblRegistrationNo" runat="server" CssClass="textbox" style="width:100%;"  Text=""></asp:Label>
                     <asp:Label ID="lblClass" runat="server" CssClass="textbox" style="width:100%;"  Text=""></asp:Label>  
                    <br /><br /><br /><br /><br /><br /><br /><br />
        Highest Marks
        <asp:Image ID="imgHighestMarks" runat="server" ImageUrl="~/images/HighestMarks.png" />
        Student Marks
        <asp:Image ID="imgStudentMarks" runat="server" ImageUrl="~/images/StudentMarks.png" />
                </div>
                <div class="one_third">
                    <figure class="imgl boxholder">

       <asp:image ID="ImgPhoto" runat="server" ImageUrl="~/images/gallery-8.png" /> 
       </figure>
                </div>
            </div>
            <div class="one_half">
                <figure class="imgl boxholder">

        <table>
    
    <tr>
    <td >
    <asp:Chart ID="Chart1" runat="server" Width="550px" Visible="false">
        <Titles>
        <asp:Title Text=""></asp:Title>
        </Titles>
            <Series>
                <asp:Series Name="Series1" ChartArea="ChartArea1"  ChartType="Spline">
                <Points>
              
                </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">

                <AxisX Title="Test Date">
                </AxisX>
               <AxisY Title="Student Performance"> </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td> 
        </tr>
    </table>
        </figure>
            </div>
        </div>
           <div style="height: 20px">
        </div>
        <asp:Button ID="btnObjective" runat="server" Text="Objective DPP"  OnClick="btnObjective_Click" />
        <asp:Button ID="BtnSubjective" runat="server" Text="Subjective DPP/Test"  OnClick="BtnSubjective_Click" />
        <div style="height: 20px">
        </div>

         <div class="form-input clear">
              <asp:Label ID="lblError1" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
            <asp:Label ID="lblError" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
        </div>
        <div class="form-input clear">
            <figure class="imgl boxholder">

<asp:Button  ID="btnChemistry" runat="server" Text="Chemistry" onclick="btnChemistry_Click" Enabled="true" />
<asp:Button  ID="btnMathsx11" runat="server" Text="Maths(XI to XII)" onclick="btnMathsx11_Click"/>
<asp:Button  ID="btnMathsv11"   runat="server" Text="Maths(VI to X)" onclick="btnMathsv11_Click"/>
<asp:Button  ID="btnSciencex" runat="server" Text="Science(VI to X)" onclick="btnSciencex_Click"/>
<asp:Button  ID="btnEnglishv" runat="server" Text="English(VI to X)" onclick="btnEnglishv_Click"/>
<asp:Button  ID="btnBiological" runat="server" Text="Biology"     onclick="btnBiological_Click" />
<asp:Button  ID="btnPhysics" runat="server" Text="Physics" onclick="btnPhysics_Click" />
</figure>
        </div>
       
        <div class="form-input clear">
            <asp:GridView ID="GvReguler" runat="server" AutoGenerateColumns="False" DataKeyNames="RegularTestId"
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
                    <asp:TemplateField HeaderText="Test Type">
                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server" Text='<%#Eval("TestType") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Test Code">
                        <ItemTemplate>
                            <asp:Label ID="lblTestName" runat="server" Text='<%#Eval("TestName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Date">

                        <ItemTemplate>
                            <asp:Label ID="lblRegularTestDate" runat="server" Text='<%#Eval("RegularTestDate") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Syllabus">
                        <ItemTemplate>
                            <asp:Label ID="lblSyllabus" runat="server" Text='<%#Eval("Syllabus") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Result Sheet">
                        <ItemTemplate>
                            <div id="divCproduct" runat="server" class="customProduct">
                                <%--      <a >

                                                <img src="../images/Uopload1.png" title="Upload" border="0"/>
                                              </a>--%>
                                <a class="Panchal" visible="true" href="ShowRegularResult.aspx?Sid=<%#Eval("RegularTestId") %>">
                                    Show Result Sheet </a>
                                <%--       <a href="ShowRegularResult.aspx?Sid=<%#Eval("RegularTestId") %>">Show Result Sheet </a>--%>
                            </div>
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
    </div>
</asp:Content>
