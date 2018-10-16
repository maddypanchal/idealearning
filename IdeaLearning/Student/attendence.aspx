<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="attendence.aspx.cs" Inherits="Student_attendence" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

      <div id="container">
   <div class="page">
   
      <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
         <p><b>DETAILS OF ATTENDENCE</b></p>
        <%-- <asp:Label ID="Label1" runat="server" Text="Label asdas"></asp:Label>--%>
      </div>
      </div>
      </section>
      <div class="form-inpur clear">
         <div class="One_half">
           <h2> <asp:Label ID="lblCoursesOneText" runat="server" Text="" Visible="true"></asp:Label> </h2>
     <asp:Label id="lblSubjectOneText" runat="server" Text="" ></asp:Label>   
     <asp:Button ID="btnCoOneTextSubjectOneText" runat="server" Text="" Visible="true"    onclick="btnCoOneTextSubjectOneText_Click" />
    <asp:Button ID="btnCoOneTextSubjectTwoText" runat="server" Text="" Visible="true"    onclick="btnCoOneTextSubjectTwoText_Click"/>
    <asp:Button ID="btnCoOneTextSubjectThreeText" runat="server" Text="" Visible="true"  onclick="btnCoOneTextSubjectThreeText_Click"/> 
    <asp:Button ID="btnCoOneTextSubjectFourText" runat="server" Text="" Visible="true"   onclick="btnCoOneTextSubjectFourText_Click" />
        </div>
        <div class="One_half">
        
     <h2><asp:Label ID="lblCoursesTwoText" runat="server" Text="" Visible="true"></asp:Label> </h2>
     <asp:Label id="lblSubjectTwoText" runat="server" Text="" ></asp:Label>  
    <asp:Button ID="btnCoTwoTextSubjectOneText" runat="server" Text="" Visible="true"   onclick="btnCoTwoTextSubjectOneText_Click"/>
    <asp:Button ID="btnCoTwoTextSubjectTwoText" runat="server" Text="" Visible="true"   onclick="btnCoTwoTextSubjectTwoText_Click"/>
    <asp:Button ID="btnCoTwoTextSubjectThreeText" runat="server" Text="" Visible="true" onclick="btnCoTwoTextSubjectThreeText_Click"/>
    <asp:Button ID="btnCoTwoTextSubjectFourText" runat="server" Text="" Visible="true"  onclick="btnCoTwoTextSubjectFourText_Click"/>
        </div>
        </div>

          <div class="form-inpur clear">
        <div class="One_half">
        
    <h2> <asp:Label ID="lblCoursesThreeText" runat="server" Text="" Visible="true"></asp:Label> </h2>
    <asp:Label id="lblSubjectThreeText" runat="server" Text="" ></asp:Label>  
    <asp:Button ID="btnCoThreeTextSubjectOneText" runat="server" Text="" Visible="true"   onclick="btnCoThreeTextSubjectOneText_Click"/>
    <asp:Button ID="btnCoThreeTextSubjectTwoText" runat="server" Text="" Visible="true"   onclick="btnCoThreeTextSubjectTwoText_Click"/>
    <asp:Button ID="btnCoThreeTextSubjectThreeText" runat="server" Text="" Visible="true" onclick="btnCoThreeTextSubjectThreeText_Click"/> 
    <asp:Button ID="btnCoThreeTextSubjectFourText" runat="server" Text="" Visible="true"  onclick="btnCoThreeTextSubjectFourText_Click"/>
        </div>
        <div class="One_half">
         <h2> <asp:Label ID="lblCoursesFourText" runat="server" Text="" Visible="true"></asp:Label> </h2>
  <asp:Label id="lblSubjectFourText" runat="server" Text="" ></asp:Label>  
    <asp:Button ID="btnCoFourTextSubjectOneText" runat="server" Text="" Visible="true"    onclick="btnCoFourTextSubjectOneText_Click"/> 
    <asp:Button ID="btnCoFourTextSubjectTwoText" runat="server" Text="" Visible="true"    onclick="btnCoFourTextSubjectTwoText_Click"/> 
    <asp:Button ID="btnCoFourTextSubjectThreeText" runat="server" Text="" Visible="true"  onclick="btnCoFourTextSubjectThreeText_Click"/> 
    <asp:Button ID="btnCoFourTextSubjectFourText" runat="server" Text="" Visible="true"   onclick="btnCoFourTextSubjectFourText_Click"/>
        </div>
        </div>
 


    
   
    </div>
      <!-- ################################################################################################ -->
    <section class="clear">
<div class="wrapper">
  <br />

  <div class="form-inpur clear">
        <div class="OneText_half">
             <asp:Label ID="lblTotalClass" runat="server" Text="" CssClass="alert-msg warning" ForeColor="White" BackColor="#ff897e" Font-Size="24px"></asp:Label>
        </div>
        <div class="OneText_half">
         <asp:Label ID="lblTotalPresent" runat="server" Text="" CssClass="alert-msg warning" ForeColor="White" BackColor="#ff897e" Font-Size="24px"></asp:Label>
        </div>
        </div>
        <div class="form-inpur clear">
        <div class="OneText_half">
        <asp:Label ID="lblTotalAbsent" runat="server" Text="" CssClass="alert-msg warning" ForeColor="White" BackColor="#ff897e" Font-Size="24px"></asp:Label>
        </div>
        <div class="OneText_half">
        <asp:Label ID="lblPercent" runat="server" Text="" CssClass="alert-msg warning" ForeColor="White" BackColor="#ff897e" Font-Size="24px"></asp:Label>
        </div>
        </div>

            <br />
           

     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="AttendanceId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="100"  CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField HeaderText="Date">
                      <ItemTemplate>
                        <asp:Label ID="lblAbsentDate" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Attendence">
                    <ItemTemplate>
                        <asp:Label ID="lblAbsentName" runat="server" Text='<%#Eval("Absent") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
             
            </Columns>
            <HeaderStyle BackColor="Orange" Font-Bold="True" ForeColor="White" />
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

