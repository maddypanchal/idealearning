<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="DashBord.aspx.cs" Inherits="Employee_DashBord" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

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
               <asp:TextBox ID="txtname" runat="server" ReadOnly="true" Text="Name" CssClass="textbox" ></asp:TextBox>
               </label>   
               <label for="email" class="one_half">
               <asp:TextBox ID="txtDateOfBirth" runat="server" ReadOnly="true" CssClass="textbox" Text="Date Of Birth" ></asp:TextBox>
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first">
               <asp:TextBox ID="txtFatherName" runat="server" ReadOnly="true" CssClass="textbox"  Text="Year" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtGender" runat="server" ReadOnly="true" CssClass="textbox"  Text="Gender" ></asp:TextBox>
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first">
              <asp:TextBox ID="txtWorkLocation" runat="server" ReadOnly="true" CssClass="textbox"  Text="State" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtDateOfRegistration" ReadOnly="true" runat="server" CssClass="textbox"  Text="DateOfRegistration" ></asp:TextBox>
              
              </label>
            </div>

              <div class="form-input clear">
              <label for="author" class="one_half first">
             <asp:TextBox ID="txtQualification" runat="server" ReadOnly="true" CssClass="textbox"  Text="Working City" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtDiscriptions1" runat="server" ReadOnly="true" CssClass="textbox"  Text="Discriptions" ></asp:TextBox>
              
              </label>
            </div>

                   <div class="form-input clear">
              <label for="author" class="one_half first">
            <asp:TextBox ID="txtuserName" runat="server" ReadOnly="true" CssClass="textbox"  Text="User Name" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half"> 
             <asp:TextBox ID="txtmobile" runat="server" ReadOnly="true" CssClass="textbox"  Text="Mobile No." ></asp:TextBox>
              </label>
            </div>



                   <div class="form-input clear">
              <label for="author" class="one_half first">
            <asp:TextBox ID="txtemail" runat="server"  ReadOnly="true" CssClass="textbox" Text="Email" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half">
              <asp:TextBox ID="txtEmployeeCode" runat="server" ReadOnly="true" CssClass="textbox"  Text="Address Line" ></asp:TextBox>
              
              </label>
            </div>

                   <div class="form-input clear">
              <label for="author" class="one_half first">
            <asp:TextBox ID="txtExperience" runat="server" ReadOnly="true" CssClass="textbox"  Text="Experience" ></asp:TextBox>
             
              </label>
              <label for="email" class="one_half"> 
                <asp:TextBox ID="txtStatus" runat="server" ReadOnly="true" CssClass="textbox"  Text="Status" ></asp:TextBox>
              </label>
            </div>

            

            <div class="form-input clear">
          
             <div class="form-message">
                <label for="email" class="">
                 <asp:TextBox ID="txtInterest" runat="server" ReadOnly="true" CssClass="textbox" TextMode="MultiLine"  Text="Interest" ></asp:TextBox>
            
                 </label>
            </div>
              <div class="form-message">
                <label for="email" class="">
                <asp:TextBox ID="txtOtherDuties" runat="server" ReadOnly="true" CssClass="textbox"  TextMode="MultiLine" Text="OtherDuties" ></asp:TextBox>
     <%--    <asp:TextBox ID="TextBox2" runat="server" ReadOnly="true"  Text="Address Line"   CssClass="textbox" ></asp:TextBox>--%>
           
               </label>
            </div>
               </div>
         <div class="form-input clear">
          
             <div class="form-message">
                <label for="email" class="">
               <asp:TextBox ID="txtDiscriptions" runat="server" ReadOnly="true" CssClass="textbox" TextMode="MultiLine"  Text="Discriptions" ></asp:TextBox>
                 </label>
            </div>
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
           <asp:Image ID="imgUser" runat="server" ImageUrl="~/images/stu.jpg"  />
          </div>
        
<p><asp:Label ID="lblDisgnation" runat="server" Text=""></asp:Label><br /></p>

<p><asp:Label ID="lblMentorsOne" runat="server" Text=""></asp:Label><br /></p>
<p><asp:Label ID="lblMentorsTwo" runat="server" Text=""></asp:Label><br /></p>
<p><asp:Label ID="lblMentorsThree" runat="server" Text=""></asp:Label><br /></p>
<p><asp:Label ID="lblMentorsFour" runat="server" Text=""></asp:Label><br /></p>
        
        </div>
      </div>
    
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>

      





</asp:Content>

