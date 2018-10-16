<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true" CodeFile="SyllabusDetails.aspx.cs" Inherits="Student_SyllabusDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  <div id="container">
      <!-- ################################################################################################ -->
          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>DETAILS OF SYLLABUS COVERED</b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>



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


     <div class="Contact_GridView">
     <asp:GridView ID="gvDetail1" runat="server" AutoGenerateColumns="False" DataKeyNames="SyllabusId"
            HeaderStyle-BackColor="#1A5E6C" HeaderStyle-ForeColor="White" ShowFooter="True"
            EditRowStyle-BorderStyle="None" Style="text-align: center; font-size: 16px; font-weight: normal;
            font-family: arial;" AllowPaging="True" PageSize="1000" Width="100%" CssClass="tabl"
            GridLines="None" CellPadding="4" ForeColor="#7B7B7B"   onrowdeleting="gvDetail1_RowDeleting" 
                    onpageindexchanging="gvDetail1_PageIndexChanging" 
                    onrowediting="gvDetail1_RowEditing" 
                    onrowcancelingedit="gvDetail1_RowCancelingEdit" 
                    onrowupdating="gvDetail1_RowUpdating" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="S No.">
                    <ItemTemplate>
                        <asp:Label ID="lblSNO" runat="server" Text="<%#Container.DataItemIndex+1 %>"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                        <asp:Label ID="lblDate" runat="server" Text='<%#Eval("Date") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Mentor">
                    <ItemTemplate>
                        <asp:Label ID="lblSyllabusDescription" runat="server" Text='<%#Eval("Name") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Chapter/Topic Name">
                      <ItemTemplate>
                        <asp:Label ID="lblContentBy" runat="server" Text='<%#Eval("ContentBy") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Syllabus" HeaderStyle-Width="600px" >
                    <ItemTemplate>
                        <asp:Label ID="lblSyllabusDescription" runat="server" Text='<%#Eval("SyllabusDescription") %>' />
                    </ItemTemplate>
                </asp:TemplateField>

               <%--  <asp:TemplateField HeaderText="Edit">
                             <ItemTemplate>
                                <a href="EditNewsAndEvent.aspx?Sid=<%#Eval("NewsTitleId") %>">Edit
                             </ItemTemplate>
                         </asp:TemplateField>--%>
              <%--     <asp:TemplateField HeaderText="ACTION">
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

        </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

