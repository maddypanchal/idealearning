<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true"
    CodeFile="ShowStudentDetails.aspx.cs" Inherits="Employee_ShowStudentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="container">
        <!-- ################################################################################################ -->
        <section class="clear">

   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
             <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>UPDATE STUDENT REGISTRATION</b></p>
     </div>
      </div>
      <%--<div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>
    <div style="height:20px;"></div>
     <div class="form-input clear">
     

    

        <a class="Panchal" 
                                                            href='../Employee/UpdateStudentAddress.aspx' 
                                                            visible="true">

                                              <asp:Button ID="Button2" runat="server" Text="Update Address" class="button small gradient orange" />
                                              </a>
   <a class="Panchal" 
                                                            href='../Employee/UpdateStudentFristCourses.aspx' 
                                                            visible="true">

<asp:Button ID="Button3" runat="server" Text="Update Frist Course"   class="button small gradient orange" />

</a>

  <a class="Panchal" 
                                                            href='../Employee/UpdateStudentSecondCourses.aspx'
                                                            visible="true">
<asp:Button ID="Button4" runat="server" Text="Update Second Course" PostBackUrl="~/Employee/StudentDetails.aspx"    class="button small gradient orange" />
</a>
  <a class="Panchal" 
                                                            href='../Employee/UpdateStudentThreeCourses.aspx' 
                                                            visible="true">


<asp:Button ID="Button5" runat="server" Text="Update Third Course" PostBackUrl="~/Employee/StudentDetails.aspx"    class="button small gradient orange" /> 
</a>
  <a class="Panchal" 
                                                            href='../Employee/UpdateStudentFourCourses.aspx' 
                                                            visible="true">
            <asp:Button ID="Button1" runat="server" Text="Update Fourth Course" PostBackUrl="~/Employee/StudentDetails.aspx"    class="button small gradient orange" />
   </a>
    </div>
    <asp:UpdatePanel ID="upPanel" runat="server" UpdateMode="Conditional" >
    <ContentTemplate>
    
     <div class="one_half first">
                    <div class="form-input clear">
                        <label for="author">
                           <a><b>STUDENT REGISTRATION NUMBER : </b></a><span class="required"></span>
                   
              <asp:Label ID="lblRegistratoinNo" Text="" runat="server"></asp:Label>
              </label>
</div>

</div>
    <div style="height:30px;"></div>

     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                              Date of Reg. -  * <span class="required"></span>
                 <asp:TextBox ID="txtDateOfReg" runat="server" Text="" class="Ddl_Css tcal" ></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">

          <label for="author">
                               Class*  <span class="required"></span>                                           
                <asp:DropDownList ID="ddlClass" runat="server" CssClass="Ddl_Css" AutoPostBack="true"  onselectedindexchanged="ddlClass_SelectedIndexChanged">
                </asp:DropDownList>
                            </label>
                                   </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                              Student Name* <span class="required"></span>               
                <asp:TextBox ID="txtStudentName" runat="server" Text="" ></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">

             Course First* <span class="required"></span>
                           
                        <asp:DropDownList ID="ddlCourselist" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlCourseList_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                       
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                            Father Name*<span class="required"></span>
                           
                    
                <asp:TextBox ID="txtFatherName" runat="server" Text="" ></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">

            Subject First * <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlSubject" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                       
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                              Father Mobile Number (SMS) * <span class="required"></span>
                           
                       <asp:TextBox ID="txtFatherNumber" runat="server" Text="" ></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">
         <label for="author">
                             Subject Second  <span class="required"></span>
         
                <asp:DropDownList ID="ddlSubjectTwo" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                              Date of Birth* <span class="required"></span>
                          
                      <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" class="Ddl_Css tcal"></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                              Subject Third  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlSubjetThree" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>


     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                              Gender*<span class="required"></span>
                          
                <asp:DropDownList ID="ddlGender" runat="server" CssClass="Ddl_Css">
                    <asp:ListItem Value="-1">Select One</asp:ListItem>
                    <asp:ListItem Value="1">Male</asp:ListItem>
                    <asp:ListItem Value="2">Female</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                              Subject Fourth  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlSubjectFour" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>

    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                                Student Mobile No* <span class="required"></span>
                       
                  
                <asp:TextBox ID="txtMobile" runat="server" Text="" ></asp:TextBox>
                          
               
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                         Course Second  <span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourselistSecond" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlCourselistSecond_SelectedIndexChanged"
              >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                                   Due payment* <span class="required"></span>
                                            
                <asp:TextBox ID="txtDuepayment" runat="server" Text=""></asp:TextBox>
                                  
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                                Subject Frist <span class="required"></span>
                           
                        <asp:DropDownList ID="ddlCourse_Second_Subject_Frist" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>

    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                                 Due Date*<span class="required"></span>
                      
                         <asp:TextBox ID="txtDueDate" runat="server" Text="" class="Ddl_Css tcal"></asp:TextBox>
                
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                               Subject Second  <span class="required"></span>
         
                <asp:DropDownList ID="ddlCourse_Second_Subject_Second" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>

     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                             Category * <span class="required"></span>
                           
                     <asp:DropDownList ID="ddlCategory" runat="server" CssClass="Ddl_Css">
                    <asp:ListItem Value="-1">Select One</asp:ListItem>
                    <asp:ListItem Value="1">Gen</asp:ListItem>
                    <asp:ListItem Value="2">OBC</asp:ListItem>
                    <asp:ListItem Value="3">SC</asp:ListItem>
                    <asp:ListItem Value="4">ST</asp:ListItem>
                    <asp:ListItem Value="5">Other</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                                Subject Third  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Second_Subject_third" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                             Email id * <span class="required"></span>
                           
                                 <p>
                    </p>
                <asp:TextBox ID="txtEmail" runat="server" Text="" ></asp:TextBox>
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                          Subject Forth  <span class="required"></span>
                    <asp:DropDownList ID="ddlCourse_Second_Subject_Forth" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
    <div class="form-input clear">
        <div class="one_half">
        <label for="author">
                              Course Duration * <span class="required"></span>
                                       <asp:TextBox ID="txtCourseDuration" runat="server" Text=""></asp:TextBox>
                            </label>
                       
                            </div>
        <div class="one_half">
          <label for="author">
                           Course Third<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_Third" runat="server" CssClass="Ddl_Css" AutoPostBack="true" onselectedindexchanged="ddlCourse_Third_SelectedIndexChanged">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
        <div class="one_half">
           <label for="author">
                                Roll No*<span class="required"></span>
                           
                        <asp:TextBox ID="txtRollNo" runat="server" Text="" ></asp:TextBox>

                           
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                          Subject Frist <span class="required"></span>
                  
                <asp:DropDownList ID="ddlCourse_Third_Subject_Frist" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
        <div class="one_half">
       <label for="author">
                                  Country* <span class="required"></span>
                           
                      <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True" CssClass="Ddl_Css"
                   OnSelectedIndexChanged="ddlCountryRegion_SelectedIndexChanged" >
                </asp:DropDownList>
                          
               
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                               Subject Second  <span class="required"></span>
         
                <asp:DropDownList ID="ddlCourse_Third_Subject_Second" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>



    </div>




     <div class="form-input clear">
        <div class="one_half">
             <label for="author">  State* <span class="required"></span>
                <asp:DropDownList ID="ddlStateRegion" runat="server" CssClass="Ddl_Css" AutoPostBack="true"
                     OnSelectedIndexChanged="ddlStateRegion_SelectedIndexChanged"  >
                    <asp:ListItem>--Select--</asp:ListItem>
              </asp:DropDownList> 
                      
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                               Subject Third  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Third_Subject_Third" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
                               </div>
     <div class="form-input clear">
        <div class="one_half">
             <label for="author">
                              City* <span class="required"></span>
                           
                      <asp:DropDownList ID="ddlCity" runat="server" CssClass="Ddl_Css">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                           Subject fourth  <span class="required"></span>
                           
                    
                <asp:DropDownList ID="ddlCourse_Third_Subject_fourth" runat="server" CssClass="Ddl_Css">
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>

    </div>


    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
               Pin Code*<span class="required"></span>
                           
                  
                <asp:TextBox ID="txtPinCode" runat="server" Text=""> </asp:TextBox>
                             
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                          Course fourth<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_fourth" runat="server" CssClass="Ddl_Css"  onselectedindexchanged="ddlCourse_fourth_SelectedIndexChanged"
                AutoPostBack="true" 
               >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
        <div class="one_half">
        <label for="author">
      User Name* <span class="required"></span>
                           
                       <asp:TextBox ID="txtUserName" runat="server" Text=""></asp:TextBox>
                          
               
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                             Subject Frist<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_fourth_Subject_frist" runat="server" CssClass="Ddl_Css" >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>


    </div>
    <div class="form-input clear">
        <div class="one_half">
    
  <label for="author">
                                    Password* <span class="required"></span>
                           
                     <asp:TextBox ID="txtPassword" runat="server" Text="" ></asp:TextBox>
                          
              
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                              Subject Second<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_fourth_Subject_Second" runat="server" CssClass="Ddl_Css" >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>



    </div>


 
     <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                                       Confirm Password*<span class="required"></span>
                           
                           <%-- <asp:TextBox ID="txtConfirmPasword" runat="server" Text="" TextMode="Password" ></asp:TextBox>--%>
                
                            </label>
                            </div>
        <div class="one_half">
          <label for="author">
                             Subject Third<span class="required"></span>
                           
                  <asp:DropDownList ID="ddlCourse_fourth_Subject_Third" runat="server" CssClass="Ddl_Css"  >
                   <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                            </label>
                            </div>
    </div>
     <div class="form-input clear">
        <div class="one_half">
        
  

  <label for="author">
                      Alert*<span class="required"></span>
                      <asp:TextBox ID="txtAlert" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
                            </label>
     
           
                     
                            </label>
                            </div>
          <div class="one_half">
          <label for="author">
                        Subject Fourth<span class="required"></span>
                      <asp:DropDownList ID="ddlCourse_fourth_Subject_Fourth" runat="server" CssClass="Ddl_Css"  >
                   <asp:ListItem>--Select--</asp:ListItem>
                 </asp:DropDownList>
                            </label>
                            </div>
                            </div>
      <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                    Address* <span class="required"></span>
                    <asp:TextBox ID="txtaddress" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
                            </label>
                            </div>

        <div class="one_half">
         <div class="photo">
    <asp:Image ID="imgUser" runat="server" ImageUrl="~/images/stu.jpg" width="230px" height="200px" />

               <label for="author">
              Upload Image* <span class="required"></span>
                             
                
                    <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                        multiple="true" ForeColor="#FF6600" class="Ddl_Css" ToolTip="Upload Product Image Here" />
                     
                            </label>

<%--  <div ID="divCproduct" runat="server" class="customProduct">
                                                        <a class="Panchal" 
                                                            href='../Admin/Cropimages.aspx' 
                                                            visible="true">

                                                <img src="../images/Uopload1.png" title="Upload" border="0"/>
                                              </a>
                                                    </div>--%>
      
</div>
                            </div>
      </div>
      <div class="form-input clear">
        <div class="one_half">
         <asp:Button ID="btnSubmit" runat="server" Text="UPDATE" class="button large gradient red" OnClick="btnSubmit_Click" />
            <asp:Button ID="btnBack" runat="server" Text="BACK" PostBackUrl="~/Employee/StudentDetails.aspx"    class="button large gradient orange" />

            <p>
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </p>
            </div>
    </ContentTemplate>
    <Triggers> 
       <asp:PostBackTrigger ControlID="btnSubmit" />
    
    </Triggers>
    </asp:UpdatePanel>

  

            <div class="one_half">
                               
            </div>
  
     
        </section>
    </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear">
    </div>
</asp:Content>
