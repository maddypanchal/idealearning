<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="OurCourses.aspx.cs" Inherits="Public_OurCourses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/courses.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
<div class="course_wrapper">
  <div class="course_contentner">
    <div class="course_head">
     <h1  >Courses (For Career Counselling)  </h1>
     <div class="course_content">
    <div class="course_detail">
     <a href="Course_Details_aarambh.aspx"><img src="../images/courses/arambh.jpg"  class="course_img" /></a>
     <p> For 8th moving (9th class) students, covers school syllabus  + Competition + NTSE + Olympiad + RMC etc.
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_aarambh.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_aadhar.aspx"><img src="../images/courses/aadhar.png"  class="course_img" /></a>
     <p>For 9th moving (10th class) students, covers school syllabus  + Competition + NTSE + Olympiad etc + Test series.
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_aadhar.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_parichay.aspx"><img src="../images/courses/parichay.png"  class="course_img" /></a>
     <p>For 10th moving (11th class) students, covers school syllabus + Competition (IIT/JEE Mains & Advance)/ AIIMS/ AIPMT
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_parichay.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_pratigyan.aspx"><img src="../images/courses/partigya.png"  class="course_img" /></a>
     <p>For 11th moving (12th class) students, covers school syllabus + Competition (IIT/JEE Mains & Advance)/ AIIMS/ PMT
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_pratigyan.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_niryanak.aspx"><img src="../images/courses/nirnayk.png"  class="course_img" /></a>
     <p>For 12th moving (Droppers) students, Fundamentals+ Competition for (IIT/JEE Mains & Advance)/ AIIMS/ PMT
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_niryanak.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_shreysth.aspx"><img src="../images/courses/shreysth.png"  class="course_img" /></a>
     <p>For super twenty students of 12th class or droppers. <br />Coverage: JEE-Advance/ AIIMS + KVPY + Olympiad.
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_shreysth.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="course_Details_vishisth.aspx"><img src="../images/courses/vishisht.png"  class="course_img" /></a>
     <p>For super twenty students of 11th class or droppers. <br />Coverage: JEE-(Advance + Mains)/ AIIMS/ KVPY/ Olympiad.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="course_Details_vishisth.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_sampurna.aspx"><img src="../images/courses/sampurna.png"  class="course_img" /></a>
     <p>For 8th moving (9th class) students, <br />

Coverage: School Syllabus + Competition Syllabus(JEE-Mains/Advance)/AIIMS + NTSE + Olympiad + KVPY of Class 9th, 10th, 11th & 12th.      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_sampurna.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_safal.aspx"><img src="../images/courses/safal.png"  class="course_img" /></a>
     <p>For 9th moving (10th class) students, <br />

Coverage: School Syllabus + Competition Syllabus(JEE-Mains/ Advance)/ AIIMS + NTSE + Olympiad + KVPY of Class 11th & 12th.   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_safal.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_nischit.aspx"><img src="../images/courses/nishchit.png"  class="course_img" /></a>
     <p><p>For 9th moving (10th class) students, <br />

Coverage: School Syllabus + Competition Syllabus(JEE-Mains/Advance)/AIIMS + NTSE + Olympiad + KVPY of Class 9th, 10th, 11th & 12th.      </p>
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_nischit.aspx">Click here for more details</a></p>
       </div>
        </div>

        <div class="course_detail">
     <a href="Course_Details_drishti.aspx"><img src="../images/courses/drishti.jpg"  class="course_img" /></a>
     <p>test series for class 9th, 10th, 11th & 12th. 15th test based on
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_drishti.aspx">Click here for more details</a></p>
       </div>
        </div>

    <div class="course_detail">
     <a href="Course_Details_sanchhift.aspx"><img src="../images/courses/drishti.jpg"  class="course_img" /></a>
     <p>Short term Course for 11th, 12th & Droppers
      </p>
      <div Class="button_more">
     <%--  <asp:Button ID="btnmore" runat="server" Text="Click here for more detail" />--%>
     <p><a href="Course_Details_sanchhift.aspx">Click here for more details</a></p>
       </div>
        </div>
     </div>
        
        
 
    </div>
   </div>
    </div>
 
</asp:Content>

