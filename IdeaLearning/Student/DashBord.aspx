<%@ Page Title="" Language="C#" MasterPageFile="~/Student/Student.master" AutoEventWireup="true"
    CodeFile="DashBord.aspx.cs" Inherits="Student_DashBord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  
   <div id="container">
      <!-- ################################################################################################ -->
       <section class="clear">
       <section class="clear">

        <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p> <b>WELCOME TO IDEA LEARNING</b></p>
     </div>
      </div>
     
    </section>
        <div style="height: 20px;">
        </div>

      <div class="two_third first">
   
  <div class="two_half first">
      
      <div id="respond">
         
          <div class="rnd5">
            <div class="form-input clear">
              <label for="author" class="one_half first">
              <asp:TextBox ID="txtStudentName" runat="server"  Text="Name" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtClass" runat="server"  Text="Class" CssClass="textbox"></asp:TextBox>
              
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first"> 
                <asp:TextBox ID="txtCourseDuration" runat="server"  Text="CourseDuration" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
             <asp:TextBox ID="txtFatherName" runat="server"  Text="Father Name" CssClass="textbox"></asp:TextBox>
              
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first"> 
              <asp:TextBox ID="txtDateofBifth" runat="server"  Text="Date Of Bifth" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">

                <asp:TextBox ID="txtGender" runat="server"  Text="Email" CssClass="textbox"></asp:TextBox>
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first">
             <asp:TextBox ID="txtRegistrationNo" runat="server"  Text="RegistrationNo" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
            <asp:TextBox ID="txtStatus" runat="server"  Text="Status" CssClass="textbox"></asp:TextBox>
              
              </label>
            </div>

                   <div class="form-input clear">
              <label for="author" class="one_half first">
          <asp:TextBox ID="txtPinCode" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
             <asp:TextBox ID="txtmobile" runat="server"  Text="Mobile No." CssClass="textbox"></asp:TextBox>
              </label>
            </div>

                   <div class="form-input clear">
              <label for="author" class="one_half first">
          <asp:TextBox ID="txtemail" runat="server"  Text="Email" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtDateOfRegistration" runat="server" ReadOnly="true"  Text="" CssClass="textbox" ></asp:TextBox>
              
              </label>
            </div>

            <div class="form-input clear">
              <label for="author" class="one_half first">
          <asp:TextBox ID="txtRollNo" runat="server"  Text="Email" CssClass="textbox"></asp:TextBox>
          </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtUserName" runat="server" ReadOnly="true"  Text="Address Line" CssClass="textbox" ></asp:TextBox>
              </label>
            </div>

            <div class="form-input clear">
              <label for="author" class="one_half first">
                       <asp:TextBox ID="txtDuePayment" runat="server"  Text="DuePayment" CssClass="textbox"></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtCateGory" runat="server" ReadOnly="true"  Text="Address Line" CssClass="textbox" ></asp:TextBox>
              
              </label>
            </div>

            <div class="form-input clear">
            <label for="author" class="one_half first">
             <asp:TextBox ID="txtDueDate" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
         <%--    <asp:TextBox ID="txtCoOneTextSubjectOneText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoOneTextSubjectTwoText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoOneTextSubjectThreeText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoOneTextSubjectFourText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoTwoTextSubjectOneText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoTwoTextSubjectTwoText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoTwoTextSubjectThreeText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoTwoTextSubjectFourText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoThreeTextSubjectOneText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoThreeTextSubjectTwoText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoThreeTextSubjectThreeText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoThreeTextSubjectFourText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoFourTextSubjectOneText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoFourTextSubjectTwoText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoFourTextSubjectThreeText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>
             <asp:TextBox ID="txtCoFourTextSubjectFourText" runat="server"  Text="" CssClass="textbox"></asp:TextBox>--%>

              </label>
              <label for="email" class="one_half">
           <%--    <asp:TextBox ID="txtCorusesOne" runat="server" ReadOnly="true"  Text="#" CssClass="textbox" ></asp:TextBox>
                <asp:TextBox ID="txtCorusesTwo" runat="server" ReadOnly="true"  Text="#" CssClass="textbox" ></asp:TextBox>
                <asp:TextBox ID="txtCorusesThree" runat="server" ReadOnly="true"  Text="#" CssClass="textbox" ></asp:TextBox>--%>
                 <asp:TextBox ID="txtAlert" runat="server" ReadOnly="true"  Text="#" CssClass="textbox" ></asp:TextBox>
              </label>
            </div>
         <div class="form-input clear">
            <div class="form-message">
                <label for="email" class="">
         <asp:TextBox ID="txtAddress" runat="server" ReadOnly="true"  Text="Address Line"  TextMode="MultiLine" CssClass="textbox" ></asp:TextBox>
           
               </label>
            </div>
               </div>
          </div>
        </div>
      </div>
</div>

      <div class="one_third">
        <div class="calltoaction opt1">
          <div class="push20">
         <asp:Image ID="imgUser" runat="server" ImageUrl="~/images/stu.jpg"  class="lightbox-image" />
          </div>
               <div style="font-size:10px;">
                           <asp:Label ID="lblSname" runat="server"  Text="" ></asp:Label><br/>
                          <%-- <asp:Label ID="lblAlters"  runat="server"  Text=""></asp:Label><br/>--%>
                           <asp:Label ID="lblCorusesOne" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           
                           <asp:Label ID="lblCoOneTextSubjectOneText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoOneTextSubjectTwoText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoOneTextSubjectThreeText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoOneTextSubjectFourText" runat="server" Visible="false" Text=""></asp:Label>  <br/>

                           <asp:Label ID="lblCorusesTwo" runat="server" Visible="false" Text=""></asp:Label><br/>
                           
                           <asp:Label ID="lblCoTwoTextSubjectOneText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoTwoTextSubjectTwoText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoTwoTextSubjectThreeText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoTwoTextSubjectFourText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCorusesThree" runat="server" Visible="false" Text=""></asp:Label><br/>

                           <asp:Label ID="lblCoThreeTextSubjectOneText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoThreeTextSubjectTwoText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoThreeTextSubjectThreeText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoThreeTextSubjectFourText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCorusesFour" runat="server" Visible="false" Text=""></asp:Label><br/>

                           <asp:Label ID="lblCoFourTextSubjectOneText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoFourTextSubjectTwoText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoFourTextSubjectThreeText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                           <asp:Label ID="lblCoFourTextSubjectFourText" runat="server" Visible="false" Text=""></asp:Label>  <br/>
                 </div>        
                                
            </div>
          
      </div>
    
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  
     
    
    
</asp:Content>
