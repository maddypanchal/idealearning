<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true"
    CodeFile="FeeDetails.aspx.cs" Inherits="Student_FeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
   <div id="container">
      <!-- ################################################################################################ -->

          <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>DETAILS OF FEE </b></p>
      </div>
      </div>
      </section>
      <div style="height:20px"></div>
    <section class="clear">

    <div class="two_half first">
      
      <div id="respond">
         
          <div class="rnd5">
          <p>(Your due Fee and Date Details)</p>
            <div class="form-input clear">
              <label for="author" class="one_half first">Due Date <span class="required">*</span><br>
                <asp:TextBox ID="txtDueDate" runat="server"  Text="Qualification"></asp:TextBox>
              </label>
              <label for="email" class="one_half">Due Payment<span class="required">*</span><br>
             <asp:TextBox ID="txtDuepayment" runat="server"  Text=""></asp:TextBox>
            </label>
            </div>
            </div>
            </div>
            </div>
            

         
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>
