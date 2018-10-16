﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="Public_Courses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <link href="../css/courses.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <div id="gallery">
      <section>
            
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>COURSES DETAILS</b></p>
     </div>
      </div>
     <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
    </section>

    <div style="height:20px;"></div>

    <asp:DataList ID="dtListCategoryTopers" runat="server" RepeatColumns="3" RepeatDirection="vertical">
                <ItemTemplate>
                <div class="course_detail boxholder">
          
                     <a href="Course_Details.aspx?Cid=<%#Eval("CourseDetailsId")%>" >

                     <img src="../Employee/Toppers/<%#Eval("ImagesName")%>"  alt="" />
                     </a>
                  
                    <p> <asp:Label ID="Label1" runat="server" Text='<%# Eval("Description")%>'></asp:Label> </p> 
             <a href="Course_Details.aspx?Cid=<%#Eval("CourseDetailsId")%>" > <p style="   box-shadow: 0 1px 2px 1px #0d0000;
    color: #710000;
    font-size: 18px;
    margin: 0 2px 2px 5px;
    padding: 7px 3px 7px 9px;"    
    >Click here for more details</p> </a>
                </div>
               </ItemTemplate>
            </asp:DataList>

    </div>
    </div>
     </div>





<%--<div class="course_wrapper">
  <div class="course_contentner">
    <div class="course_head">
     <h1>Courses </h1>
     <div class="course_content">--%>
       
        
          <%--  <div Class="button_more">
 
           <p><a href="Course_Details_aarambh.aspx">Click here for more details</a></p>
           </div>--%>
          
  <%--  <div class="course_detail">
     <a href="Course_Details_aarambh.aspx"><img src="../images/courses/arambh.jpg"  class="course_img" /></a>
     <p> For 8th moving (9th class) students, covers school syllabus  + Competition + NTSE + Olympiad + RMC etc.
      </p>
      <div Class="button_more">
    
     <p><a href="Course_Details_aarambh.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_aadhar.aspx"><img src="../images/courses/aadhar.png"  class="course_img" /></a>
     <p>For 9th moving (10th class) students, covers school syllabus  + Competition + NTSE + Olympiad etc + Test series.
      </p>
      <div Class="button_more">
   
     <p><a href="Course_Details_aadhar.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_parichay.aspx"><img src="../images/courses/parichay.png"  class="course_img" /></a>
     <p>For 10th moving (11th class) students, covers school syllabus + Competition (IIT/JEE Mains & Advance)/ AIIMS/ AIPMT
      </p>
      <div Class="button_more">
   
     <p><a href="Course_Details_parichay.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_pratigyan.aspx"><img src="../images/courses/partigya.png"  class="course_img" /></a>
     <p>For 11th moving (12th class) students, covers school syllabus + Competition (IIT/JEE Mains & Advance)/ AIIMS/ PMT
      </p>
      <div Class="button_more">
 
     <p><a href="Course_Details_pratigyan.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_niryanak.aspx"><img src="../images/courses/nirnayk.png"  class="course_img" /></a>
     <p>For 12th moving (Droppers) students, Fundamentals+ Competition for (IIT/JEE Mains & Advance)/ AIIMS/ PMT
      </p>
      <div Class="button_more">
  
     <p><a href="Course_Details_niryanak.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_shreysth.aspx"><img src="../images/courses/shreysth.png"  class="course_img" /></a>
     <p>For super twenty students of 12th class or droppers. <br />Coverage: JEE-Advance/ AIIMS + KVPY + Olympiad.
      </p>
      <div Class="button_more">
 
     <p><a href="Course_Details_shreysth.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="course_Details_vishisth.aspx"><img src="../images/courses/vishisht.png"  class="course_img" /></a>
     <p>For super twenty students of 11th class or droppers. <br />Coverage: JEE-(Advance + Mains)/ AIIMS/ KVPY/ Olympiad.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      </p>
      <div Class="button_more">
     
     <p><a href="course_Details_vishisth.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_sampurna.aspx"><img src="../images/courses/sampurna.png"  class="course_img" /></a>
     <p>For 8th moving (9th class) students, <br />

Coverage: School Syllabus + Competition Syllabus(JEE-Mains/Advance)/AIIMS + NTSE + Olympiad + KVPY of Class 9th, 10th, 11th & 12th.      </p>
      <div Class="button_more">
     
     <p><a href="Course_Details_sampurna.aspx">Click here for more details</a></p>
       </div>
        </div>
       <div class="course_detail">
     <a href="Course_Details_safal.aspx"><img src="../images/courses/safal.png"  class="course_img" /></a>
     <p>For 9th moving (10th class) students, <br />
Coverage: School Syllabus + Competition Syllabus(JEE-Mains/ Advance)/ AIIMS + NTSE + Olympiad + KVPY of Class 11th & 12th.   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  </p>
      <div Class="button_more">
  
     <p><a href="Course_Details_safal.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_nischit.aspx"><img src="../images/courses/nishchit.png"  class="course_img" /></a>
     <p><p>For 9th moving (10th class) students, <br />

Coverage: School Syllabus + Competition Syllabus(JEE-Mains/Advance)/AIIMS + NTSE + Olympiad + KVPY of Class 9th, 10th, 11th & 12th.      </p>
      </p>
      <div Class="button_more">
 
     <p><a href="Course_Details_nischit.aspx">Click here for more details</a></p>
       </div>
        </div>
        <div class="course_detail">
     <a href="Course_Details_drishti.aspx"><img src="../images/courses/drishti.jpg"  class="course_img" /></a>
     <p>test series for class 9th, 10th, 11th & 12th. 15th test based on
      </p>
      <div Class="button_more">
   
     <p><a href="Course_Details_drishti.aspx">Click here for more details</a></p>
       </div>
        </div>
     <div class="course_detail">
     <a href="Course_Details_sanchhift.aspx"><img src="../images/courses/drishti.jpg"  class="course_img" /></a>
     <p>Short term Course for 11th, 12th & Droppers
      </p>
      <div Class="button_more">
        <p><a href="Course_Details_sanchhift.aspx">Click here for more details</a></p>
       </div>
        </div>--%>
  <%--   </div>
    </div>
   </div>
    </div>--%>
</asp:Content>

