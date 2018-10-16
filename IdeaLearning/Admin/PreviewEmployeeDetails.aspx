<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="PreviewEmployeeDetails.aspx.cs" Inherits="Admin_PreviewEmployeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

   <link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>
    <script type="text/javascript">
        function init() {
            calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
        }
    </script>

    
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



<div class="wrapper row3">
        <div id="container">
            <!-- ################################################################################################ -->
            <div id="portfolio">
                <%-- <div  class="clear columncolor">
     <p class="emphasise">EMPLOYEE REGISTRATION</p>
      </div>--%>
                <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;">PREVIEW EMPLOYEE DETAILS</b></p>
     </div>
      </div>
    <a href="" target="_blank"
     <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
                <div style="width: 100%; height: 35px;">
                </div>
                <div class="clear">
                </div>
                <div class="form-input clear">
                <div class="one_half first">
                    <div class="form-input clear">
                        <label for="author">
                           <a><b> EMPLOYEE CODE :  </b></a><span class="required"></span>
                   
              <asp:Label ID="lblEmployeeCode" Text="" runat="server"></asp:Label>
              </label>
</div>
</div>

            <div class="one_half first">
                    <div class="form-input clear">
                        <label for="author">
                          <span class="required"></span>
                   
              <asp:Label ID="Label1" Text="" runat="server"></asp:Label>
              </label>
</div>
</div>
</div>

<div style="width: 100%; height: 35px;">
                </div>
                <div class="one_half first">
                    <div class="form-input clear">
                        <label for="author">
                            Employee Type* <span class="required"></span>
                            <br>
                             <%-- <asp:TextBox ID="txtEmployeeCode" runat="server" Text="" ></asp:TextBox>--%>
                            <asp:DropDownList ID="ddlEmpType" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                   <asp:ListItem Value="1">Master Employee</asp:ListItem>
                                <asp:ListItem Value="2">Simple Employee</asp:ListItem>
                            </asp:DropDownList>
                        </label>
                        <label for="email">
                         
                    <%--    <asp:TextBox ID="txtMentorsOne" runat="server" Text="" ></asp:TextBox>--%>

                           Mentors One* <span class="required"></span>
                            <br>
                            <asp:DropDownList ID="ddlmentorsOne" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                <asp:ListItem Value="1">IIT-JEE(MAINS/ADV)/AIIMS/PMT</asp:ListItem>
                                <asp:ListItem Value="2">SYLLABUS +1 & +2</asp:ListItem>
                                <asp:ListItem Value="3">SYLLABUS 9TH & 10TH</asp:ListItem>
                                <asp:ListItem Value="4">NTSE & OLYMPIAD</asp:ListItem>
                                <asp:ListItem Value="5">NON-TEACHING STAFF</asp:ListItem>
                            </asp:DropDownList>

                        </label>
                        <label for="author">
                            Mentors two <span class="required"></span>
                      <%--  <asp:TextBox ID="txtMentorsTwo" runat="server" Text="" ></asp:TextBox>--%>

                          <asp:DropDownList ID="ddlmentorsTwo" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                <asp:ListItem Value="1">IIT-JEE(MAINS/ADV)/AIIMS/PMT</asp:ListItem>
                                <asp:ListItem Value="2">SYLLABUS +1 & +2</asp:ListItem>
                                <asp:ListItem Value="3">SYLLABUS 9TH & 10TH</asp:ListItem>
                                <asp:ListItem Value="4">NTSE & OLYMPIAD</asp:ListItem>
                                <asp:ListItem Value="5">NON-TEACHING STAFF</asp:ListItem>
                            </asp:DropDownList>
                        </label>
                        <label for="email">
                            Mentors Three<span class="required"></span>
                      <%-- <asp:TextBox ID="txtMentorsThree" runat="server" Text="" ></asp:TextBox>--%>

                        <asp:DropDownList ID="ddlmentorsThree" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                <asp:ListItem Value="1">IIT-JEE(MAINS/ADV)/AIIMS/PMT</asp:ListItem>
                                <asp:ListItem Value="2">SYLLABUS +1 & +2</asp:ListItem>
                                <asp:ListItem Value="3">SYLLABUS 9TH & 10TH</asp:ListItem>
                                <asp:ListItem Value="4">NTSE & OLYMPIAD</asp:ListItem>
                                <asp:ListItem Value="5">NON-TEACHING STAFF</asp:ListItem>
                            </asp:DropDownList>

                        </label>
                        <label for="email">
                            Mentors Four<span class="required"></span>
                      <%-- <asp:TextBox ID="txtMentorsFour" runat="server" Text="" ></asp:TextBox>--%>
                        <asp:DropDownList ID="ddlmentorsFour" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                <asp:ListItem Value="1">IIT-JEE(MAINS/ADV)/AIIMS/PMT</asp:ListItem>
                                <asp:ListItem Value="2">SYLLABUS +1 & +2</asp:ListItem>
                                <asp:ListItem Value="3">SYLLABUS 9TH & 10TH</asp:ListItem>
                                <asp:ListItem Value="4">NTSE & OLYMPIAD</asp:ListItem>
                                <asp:ListItem Value="5">NON-TEACHING STAFF</asp:ListItem>
                            </asp:DropDownList>
                        </label>
                        <label for="email">
                            Employee Name*<span class="required"></span>
                            <asp:TextBox ID="txtEmployeeName" runat="server" Text=""></asp:TextBox>
                        </label>
                        <label for="email">
                            Father Name* <span class="required"></span>
                            <asp:TextBox ID="txtFatherName" runat="server" Text=""></asp:TextBox>
                        </label>
                        <label for="email">
                            Gender* <span class="required"></span>
                            <asp:DropDownList ID="ddlGender" runat="server" CssClass="Ddl_Css">
                                <asp:ListItem Value="-1">Select One</asp:ListItem>
                                <asp:ListItem Value="1">Male</asp:ListItem>
                                <asp:ListItem Value="2">Female</asp:ListItem>
                            </asp:DropDownList>
                        </label>
                        <label for="email">
                            Country*<span class="required"></span>
                            <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True" CssClass="Ddl_Css"
                                OnSelectedIndexChanged="ddlCountryRegion_SelectedIndexChanged">
                            </asp:DropDownList>
                        </label>
                        <label for="email">
                            State*<span class="required"></span>
                            <asp:DropDownList ID="ddlStateRegion" runat="server"  CssClass="Ddl_Css" AutoPostBack="true"
                                OnSelectedIndexChanged="ddlStateRegion_SelectedIndexChanged">
                                <asp:ListItem>--Select--</asp:ListItem>
                            </asp:DropDownList>
                        
                        </label>
                        <label for="email">
                            City*<span class="required"></span>
                            <asp:DropDownList ID="ddlCity" runat="server"  CssClass="Ddl_Css">
                                <asp:ListItem>--Select--</asp:ListItem>
                            </asp:DropDownList>
                            
                        </label>
                      <%--  <label for="email">
                            Country*<span class="required"></span>
                           <asp:TextBox ID="txtCountry" runat="server" Text=""> </asp:TextBox>
                         </label>
                        <label for="email">
                            State*<span class="required"></span>
                                 
                        </label>
                        <label for="email">
                            City*<span class="required"></span>
                             <asp:TextBox ID="txtCity" runat="server" Text="" ></asp:TextBox>
                        </label>--%>
                        <label for="email">
                            Address*<span class="required"></span>
                            <asp:TextBox ID="txtAddress" runat="server" Text="" TextMode="MultiLine"></asp:TextBox>
                        </label>
                        <label for="email">
                            Descriptions*<span class="required"></span><br>
                            <asp:TextBox ID="txtDiscriptions" runat="server" Text="" TextMode="MultiLine"></asp:TextBox>
                        </label>
                    </div>
                </div>
                <div class="one_half">
                    <article class="clear">
         <div class="form-input clear">
            
              <label for="author" >Designation* <span class="required"></span><br> 
                  
                <asp:TextBox ID="txtDisgnation" runat="server" Text="" ></asp:TextBox>
               </label>   
               <label for="email" >Work Location*<span class="required"></span><br>
                 
                <asp:TextBox ID="txtWorkLocation" runat="server" Text="" ></asp:TextBox>
              </label>
          
           
         
              <label for="author" >Qualification*<span class="required"></span><br>
            
                <asp:TextBox ID="txtQualification" runat="server" Text="" ></asp:TextBox>
             
              </label>
              <label for="email" >Experience*<span class="required"></span><br>
               
                <asp:TextBox ID="txtExperience" runat="server" Text="" ></asp:TextBox>
              </label>

               <label for="author" >Other Duties*<span class="required"></span> 
                <asp:TextBox ID="txtOtherDuties" runat="server" Text="" ></asp:TextBox>
               </label>   
               <label for="email" >Interest *<span class="required"></span>
                <asp:TextBox ID="txtInterest" runat="server" Text="" ></asp:TextBox>
              </label>
          
              <label for="email" >Email id*<span class="required"></span>
                        
                <asp:TextBox ID="txtEmail" runat="server" Text="" ></asp:TextBox>
              </label>
         
              <label for="author" >Mobile No*<span class="required"></span><br>
             <asp:TextBox ID="txtMobile" runat="server" Text="" ></asp:TextBox>
             
              </label>
              <label for="email" >User Name*<span class="required"></span><br>
                   
         <asp:TextBox ID="txtuserName" runat="server" Text="" ></asp:TextBox>
              </label>
         
              <label for="email" >Password*<span class="required"></span><br>
                    <asp:TextBox ID="txtPassword" runat="server" Text="" ></asp:TextBox>
              </label>

             <%-- <label for="email" >Confirm Password* <span class="required"></span><br>
                <asp:TextBox ID="txtConfirm" runat="server" Text="" TextMode="Password" ></asp:TextBox>
              </label>--%>
       
               <label for="email">
                            Date of Joining*<span class="required"></span>
                            <asp:TextBox ID="txtDateOfjoin" runat="server" Text="" CssClass="Ddl_Css tcal"></asp:TextBox>
                        </label>

              <label for="email" > Date of Birth*<span class="required"></span><br>
                          <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" CssClass="Ddl_Css tcal"></asp:TextBox>
              </label>
              <label for="email" > Sequence Number*<span class="required"></span><br>
                          <asp:TextBox ID="txtSequenceNumber" runat="server" Text="" CssClass="Ddl_Css"></asp:TextBox>
              </label>
              <label for="email" >Upload Image*<span class="required"></span><br>
                        <asp:Image ID="imgUser" runat="server" Height="100" Width="100" ImageUrl="~/UploadedFile/Defultuser.png" />
                <a href="#">
                    <p>
                      Update Image*</p>
                </a>
             
           
              </label>

                  <div ID="divCproduct" runat="server" class="customProduct">
                                                        <a class="Panchal" 
                                                            href='Cropimages.aspx' 
                                                            visible="true">

                                                <img src="../images/Uopload1.png" title="Upload" border="0"/>

                                                
                                                        </a>
                                                    </div>
                        <%--<asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                        multiple="true" ForeColor="#FF6600" class="UploadFile" ToolTip="Upload Product Image Here" />--%>
              </label>
            
            </div>
                <asp:Button ID="btnSubmit" runat="server" Text="UPDATE" 
                        CssClass="button small orange" onclick="btnSubmit_Click"
                    />
          </article>
                </div>
            </div>
            <!-- ################################################################################################ -->
            <div class="clear">
            </div>
        </div>
    </div>








    <%--<div class="center">
        <h1>
            Employee Registration
        </h1>
        <div class="info">

        <div class="student">
                <p>
                    Mentors*</p>
                <asp:TextBox ID="txtMentors" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>

             <div class="student">
                <p>
                    Disgnation*</p>
                <asp:TextBox ID="txtDisgnation" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>
             <div class="student">
                <p>
                    Discriptions*</p>
                <asp:TextBox ID="txtDiscriptions" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>

            
        <div class="student">
                <p>
                    Employee Code*</p>
                <asp:TextBox ID="txtEmployeeCode" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>
              <div class="student">
                <p>
                    Date Of Registration*</p>
                <asp:TextBox ID="txtDateOfRegistration" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>
            <div class="student">
                <p>
                    Employee Name*</p>
                <asp:TextBox ID="txtEmployeeName" runat="server" Text="" class="name_Contact"></asp:TextBox>
            
            </div>
            <div class="student">
                <p>
                    Father Name*</p>
                <asp:TextBox ID="txtFatherName" runat="server" Text="" class="name_Contact"></asp:TextBox>
        
            </div>
            <div class="student">
                <p>
                    Date of Birth*</p>
                <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" class="name_Contact"></asp:TextBox>
           
            </div>
            <div class="student">
                <p>
                    Gender*</p>
                <asp:DropDownList ID="ddlGender" runat="server" class="gender">
                    <asp:ListItem Value="-1">Select One</asp:ListItem>
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="2">Female</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="student">
                <p>
                    Address*</p>
                <asp:TextBox ID="txtAddress" runat="server" Text="" TextMode="MultiLine" class="message_Contact"></asp:TextBox>
            </div>
        
        </div>
        <div class="info">

              <div class="student margin">
              
            </div>
      

         
            <div class="student margin">
                <p>
                    Email id*</p>
                <asp:TextBox ID="txtEmail" runat="server" Text="" class="name_Contact"></asp:TextBox>
            </div>
           
            <div class="student margin">
                <p>
                    Mobile No*</p>
                <asp:TextBox ID="txtMobile" runat="server" Text="" class="name_Contact"></asp:TextBox>
            </div>
            <div class="student margin">
                <p>
                    User Name*</p>
                <asp:TextBox ID="txtuserName" runat="server" Text="" class="name_Contact"></asp:TextBox>
            </div>
            <div class="student margin">
                <p>
                    Password*</p>
                <asp:TextBox ID="txtPassword" runat="server" Text="" class="name_Contact"></asp:TextBox>
            </div>

               
            <div class="student margin">
            <br />
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" class="submit" 
                onclick="btnUpdate_Click"/>
         </div>
        </div>
    </div>--%>
</asp:Content>

