<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="StudentProgress.aspx.cs" Inherits="Student_StudentProgress" %>
<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
      <!-- ################################################################################################ -->
        <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>Aakriti Test Analysis</b></p>
      </div>
      </div>
      </section>

      <div style="height:20px"></div>

    
    
       <section class="clear">

       <div class="form-input clear">
       <div class="one_half">
       
       <div class="two_third">
       
        <asp:Label ID="lblStudentName" runat="server" CssClass="textbox" Text="" style="width:100%;" ></asp:Label>
        <asp:Label ID="lblFatherName" runat="server" CssClass="textbox" Text="" style="width:100%;" ></asp:Label>
        <asp:Label ID="lblRegistrationNo" runat="server" CssClass="textbox" Text="" style="width:100%;" ></asp:Label>
           <asp:Label ID="lblClass" runat="server" CssClass="textbox" Text="" style="width:100%;" ></asp:Label>
           
           
           <br /><br /><br /><br /><br /><br /><br /><br />
        Highest Marks
        <asp:Image ID="imgHighestMarks" runat="server" ImageUrl="~/images/HighestMarks.png" />
        Student Marks
        <asp:Image ID="imgStudentMarks" runat="server" ImageUrl="~/images/StudentMarks.png" />
       </div>
       <div class="one_third">
      <asp:image ID="ImgPhoto" runat="server" ImageUrl="~/images/gallery-8.png" Width="150px" Height="150px" style="margin: 13px 0 0 0px; border:5px solid rgb(166, 231, 35);"/> 
       </div>
       </div>
       <div class="one_half">
       
        

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
               <%--<asp:DataPoint AxisLabel="JA2001A" YValues="40" />
                 <asp:DataPoint AxisLabel="JA2002A" YValues="30" />
                 <asp:DataPoint AxisLabel="JA2003A" YValues="70" />
                 <asp:DataPoint AxisLabel="JA2004A" YValues="20" />
                 <asp:DataPoint AxisLabel="JA2005A" YValues="90" />--%>
                </Points>
                </asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1">

                <AxisX Title="Test Code">
                </AxisX>
               <AxisY Title="Student Performance"> </AxisY>
                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
    </td>
    
        </tr>
    </table>
        <%--<asp:image ID="Image1" runat="server" ImageUrl="~/images/linechart.png" /> --%>

       
        </figure>

       </div>
   
        <div class="form-input clear">
           
            <asp:Label ID="lblError" runat="server" class="alert-msg red" Visible="false" Text=""></asp:Label>
        </div>
        <%-- Studemt's Name : <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        Studemt's Name : <asp:Label ID="Label3" runat="server" Text=""></asp:Label>--%>
       </div>

          <div style="height:20px"></div>
       <div class="form-input clear">
       <asp:Button ID="btnIIT_JEE_ADVANCE" runat="server" Text="IIT-JEE-ADVANCE" onclick="btnIIT_JEE_ADVANCE_Click" />
        <asp:Button ID="btnJEE_MAINS" runat="server" Text="JEE-MAINS" onclick="btnJEE_MAINS_Click" />
       <asp:Button ID="btnAIPMT" runat="server" Text="AIPMT" onclick="btnAIPMT_Click" />
<asp:Button ID="btnAIIMS" runat="server" Text="AIIMS" onclick="btnAIIMS_Click" />
<asp:Button ID="btnBITS" runat="server" Text="BITS" onclick="btnBITS_Click" />
<asp:Button ID="btnKVPY" runat="server" Text="KVPY" onclick="btnKVPY_Click" />
<asp:Button ID="btnNTSE" runat="server" Text="NTSE" onclick="btnNTSE_Click" />
<asp:Button ID="btnOLYMPIAD" runat="server" Text="OLYMPIAD" onclick="btnOLYMPIAD_Click" />
<asp:Button ID="btnOTHER" runat="server" Text="OTHER" onclick="btnOTHER_Click" />
           
            </div>

             <div style="height:20px"></div>

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
                  <asp:TemplateField HeaderText="Test Code">
                    <ItemTemplate>
                        <asp:Label ID="lblName" runat="server" Text='<%#Eval("DristhiTestName") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Test Date">
                       <ItemTemplate>
                        <asp:Label ID="lblSchool" runat="server" Text='<%#Eval("DristhiTestDate") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                
                 <asp:TemplateField HeaderText="Test Name">
          
                    <ItemTemplate>
                        <asp:Label ID="lblDristhiTestCode" runat="server" Text='<%#Eval("DristhiTestCode") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField HeaderText="Syllabus">
          
                    <ItemTemplate>
                        <asp:Label ID="lblDristhiSyllabus" runat="server" Text='<%#Eval("DristhiSyllabus") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
              
                       <asp:TemplateField HeaderText="Result Sheet">
                             <ItemTemplate>

                             
              <div ID="divCproduct" runat="server" class="customProduct">
                                                  <%--      <a >

                                                <img src="../images/Uopload1.png" title="Upload" border="0"/>
                                              </a>--%>

                                              <a class="Panchal" 
                                                             
                                                            visible="true" href="ShowDristhiReport.aspx?Sid=<%#Eval("DristhiTestResultId") %>">Show Result Sheet </a>
                                                    </div>
                                           
                                </ItemTemplate>
                         </asp:TemplateField>
            
                <%--   <asp:TemplateField HeaderText="ACTION" HeaderStyle-Width="200px">
                       <ItemTemplate>
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

        <div style="height:20px"></div>
       


       <div>
    
    
     </div>
   
        
   

         
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>

</asp:Content>

