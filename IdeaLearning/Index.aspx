<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Idea Learning Academy</title>
<meta charset="iso-8859-1">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
<link href="css/main.css" rel="stylesheet" type="text/css" media="all">
<link href="../css/layout.css" rel="stylesheet" type="text/css" />
<link href="css/mediaqueries.css" rel="stylesheet" type="text/css" media="all">
<!-- Slider -->
<link href="css/responsiveslides.css" rel="stylesheet" type="text/css" media="all">
<link rel="shortcut icon" href="images/favicon.ico" type="image/x-icon">
<link rel="icon" href="images/favicon.ico" type="image/x-icon">
</head>
<body>
<form id="form1" runat="server">
<div class="wrapper row1">
<header id="header" class="full_width clear">
<div id="hgroup">
<a href="Index.aspx"><img src="images/logo1.png"/></a>
<h2 style="font-size:24px; font-family:candara; float:right; color:#fff;"></h2>
</div>

   <div id="header-contact">
   <a href="http://www.meritmania.com/landing/" target="_blank" >
  <img src="images/TestSeries1.png" />      
   </a>
   <br />
    
 <a href="Login.aspx" target="_blank">
       <img src="images/login_button.png" style="  float:right;" />
 </a>
 </div>
</header>
</div>

<div class="wrapper row2">
<nav id="topnav">
<ul class="clear">
<li class="active"><a href="Index.aspx" title="Homepage">HOME</a></li>
<li><a class="drop" href="Public/Welcome.aspx" title="About Us">ABOUT US</a>
<ul><li><a href="Public/Welcome.aspx" title="Welcome Note">Welcome Note</a></li>
<li><a href="Public/History.aspx" title="History">History</a></li>
<li><a href="Public/visionmission.aspx" title="Vision & Mission">Vision & Mission</a></li>
<li><a href="Public/AboutChairman.aspx" title="Chairman's Message">Chairman's Message</a></li>
<%--<li><a href="Public/AboutDirector.aspx" title="Director's Message">Director's Message</a></li>--%>
</ul>
</li>
<li><a class="drop" href="Public/WhyUs.aspx" title="Why Us">WHY US</a>
<ul> 
<li><a href="Public/WhyUs.aspx" title="Welcome Note">WHY US</a></li>
<li><a href="Public/ParentsSpeaks.aspx" title="PARENTS SPEAKS">PARENTS SPEAKS</a></li>
<li><a href="Public/StudentSpeaks.aspx" title="STUDENT SPEAKS">STUDENT SPEAKS</a></li>
<li><a href="Public/FacilitiesToStudents.aspx" title="FACILITIES TO STUDENTS">FACILITIES TO STUDENTS</a></li>
</ul>
</li>
<li><a class="drop" href="Public/Courses.aspx" title="Courses">COURSES</a>
</li>
<li><a class="drop" href="Public/JEEAdvanceToppers.aspx" title="Our Toppers">Our Toppers</a>
<ul><li><a href="Public/JEEAdvanceToppers.aspx" title="JEE-Advance">JEE-Advance</a></li>
<li><a href="Public/JEEMainsTopper.aspx" title="JEE-Mains">JEE-Mains</a></li>
<li><a href="Public/AIIMSToppers.aspx" title="AIIMS/AIPMT">AIIMS/AIPMT</a></li>
<li><a href="Public/OtherExamToppers.aspx" title="Other Exams">KVPY / NTSE / BOARD / BITS</a></li>
</ul>
</li>
   
<li><a class="drop" href="Public/ENGINEERING.aspx" title="Top Colleges">TOP COLLEGES</a>
<ul><li><a href="Public/ENGINEERING.aspx" title="Engineering">ENGINEERING</a></li>
<li><a href="Public/MEDICAL.aspx" title="Medical">MEDICAL</a></li>
<li><a href="Public/ARCHITECT.aspx" title="Architect">ARCHITECT</a></li>
</ul>
</li>
<li class="drop"><a href="#" title="Mentors" >MENTORS</a>
<ul>
<li><a href="Public/IIT_JEE_MAINS_ADV_AIIMS_PMT.aspx">IIT-JEE(MAINS/ADV)/AIIMS/PMT </a> </li>
<li><a href="Public/SYLLABUS_11_12.aspx">SYLLABUS +1 & +2</a></li>
<li><a href="Public/SYLLABUS_9TH_10TH.aspx">SYLLABUS 9TH & 10TH</a></li>
<li><a href="Public/NTSE_OLYMPIAD.aspx">NTSE & OLYMPIAD</a></li>
<li><a href="Public/NON_TEACHING_STAFF.aspx">Non-teaching Staff</a></li>
</ul>
</li>
<li><a class="drop" title="Results" href="Public/Results.aspx" target="_bank" >RESULTS</a>  
</li>
   
    
<li class="drop"><a href="Public/Career.aspx" title="Job@Idea">JOB @ IDEA</a>
<ul>
<li><a href="Public/Career.aspx">Introduction</a></li>
<li><a href="Public/Jobs.aspx">ApplyOnline</a></li>
<li><a href="Public/Employee/Document/ScholarshipForm.docx">Apply Offline</a></li>
</ul>
</li>
<li ><a href="Public/Gallery.aspx" title="GALLERY">GALLERY</a></li>
<li ><a href="Public/ContactUs.aspx" title="Contact Us">CONTACT US</a></li>

</ul>
</nav>
</div>
<!-- content -->
<div class="wrapper row3">
<div id="container">  
<marquee class="button large gradient orange" behavior="scroll"   scrollamount="6" 
onmouseover="this.setAttribute('scrollamount', 0, 0);" onmouseout="this.setAttribute('scrollamount', 6, 0);">
<p>

    <div id="SliderRa" runat="server"></div>
<asp:Repeater ID="RptHeading" runat="server">
<ItemTemplate>
<div class="form-input clear">
    <%#Eval("name")%>
<%--<asp:Label ID ="lblHeading" runat="server"  Text='<%#Eval("name")%>'></asp:Label>--%>
<%--&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;--%> 
</div>
</ItemTemplate>
</asp:Repeater>
</p>
</marquee>
<div style="height:10px;"></div>
<!-- ################################################################################################ -->
<div id="homepage" class="clear">
<div class="two_third first">
<!-- ################################################################################################ -->
<section class="main_slider">
<div class="rslides_container clear">
<ul class="rslides clear" id="rslides">

<asp:Repeater ID="SliderImages" runat="server">
<ItemTemplate>
<li><img src="UploadedFile/ImgMain/<%#Eval("ImagesName")%>"/></li>
</ItemTemplate>
</asp:Repeater>
</ul>
</div>
</section>
<!-- #### -->
<div class="one_half first">
<article class="push30">
<div class="tab-wrapper1 clear">
<h1> News & Events</h1>
<div class="tab-container1">
<!-- Tab Content -->
<marquee behavior="scroll" direction="up" scrollamount="3" width="100%" height="380px" onmouseover="this.setAttribute('scrollamount', 0, 0);" onmouseout="this.setAttribute('scrollamount', 6, 0);">
<asp:Repeater ID="Repeater" runat="server">
<HeaderTemplate>
</HeaderTemplate>
<ItemTemplate>
<div id="tab-4" class="tab-content1 clear">
<article class="clear push20">
<h2 class="font-medium nospace"><a href="Public/Results.aspx" target="_blank"> <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("TitleName") %>' Font-Bold="true"/></a></h2>
<p class="nospace"> <asp:Label ID="lblComment" runat="server" Text='<%#Eval("Description") %>'/></p> <p> Modified Date : <asp:Label ID="lblDate" runat="server" Text='<%#Eval("TitleDate") %>'/></p>
</article>
</h2>
<p>
</p>
</div>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
</marquee>
<!-- / Tab Content -->
</div>
</div>
</article>
</div>
<div class="one_half">
<article class="push30">
<div class="one_quarter1">
<h2 class="footer_title">Let us Contact You </h2>
<div class="rnd5"   >
<div class="form-input clear">
<label for="ft_author">Name <span class="required">*</span><br>
<asp:TextBox ID="txtCName"  runat="server" Text=""></asp:TextBox>
</label>
<label for="ft_email">Email <span class="required">*</span><br>
<asp:TextBox ID="txtCEmail"  runat="server" Text=""></asp:TextBox>
</label>
<label for="ft_email">Mobile No. <span class="required">*</span><br>
<asp:TextBox ID="txtCPhone"  runat="server" Text=""></asp:TextBox>
</label>
</div>
<label for="ft_email">Message <span class="req">*</span><br>
<div class="form-message">
<asp:TextBox ID="txtCMessage"  runat="server" TextMode="MultiLine" Text="" cols="25" rows="10"></asp:TextBox>
</div>
</label>
<p>
<asp:Button ID="btnCsubmit" runat="server" Text="Submit" 
class="button small orange" onclick="btnCsubmit_Click"/>
&nbsp;
<asp:Button ID="btnCReset" runat="server" Text="Reset" class="button small grey" 
onclick="btnCReset_Click"/>
</p>
</div>
</div>
</article>
</div>
<div class="clear push30"></div>
<article class="clear push50">
<div class="one_half first"><img src="images/eng.png" alt=""></div>
<div class="one_half">
<h2 class="nospace">ENGINEERINGNEERING</h2>
<p>The creative application of scientific principles to design or develop structures, machines, apparatus, or manufacturing processes, or works utilizing them singly or in combination; or to construct or operate the same with full cognizance of their design</p>
<footer><a href="Public/ENGINEERING.aspx">Read More &raquo;</a></footer>
</div>
</article>
<article class="clear">
<div class="one_half first"><img src="images/medi.png" alt=""></div>
<div class="one_half">
<h2 class="nospace">MEDICAL</h2>
<p>These institutions may vary from stand-alone colleges that train doctors to conglomerates that offer training related in all aspects of medical care.</p>
<footer><a href="Public/MEDICAL.aspx">Read More &raquo;</a></footer>
</div>
</article>
<!-- #### -->
<div class="divider2"></div>
<div class="one_half first">
<article class="push30">
<div class="boxholder push20"><img src="images/1200x400.png" alt=""></div>
<h2 class="nospace">FOUNDATION</h2>
<p>We at IDEA Learning train for IIT (JEE-Mains/JEE-Advance),AIEEE,AIIMS & CBSE PMT WITH TEAM OF EXPERT IITian's & Doctors & producing amazing results which is ever produced in India.
We help Scores of Students to shape their career in Engineering , Medical, Architechture etc.</p>
          
<footer><a href="#">Read More &raquo;</a></footer>
</article>
     
</div>
<div class="one_half">
<article class="push30">
<div class="boxholder push20"><img src="images/arc.png" alt=""></div>
<h2 class="nospace">ARCHITECT</h2>
<p>An architect is a person who plans, designs, and oversees the construction of buildings. To practice architecture means to provide services in connection with the design and construction of buildings and the space within the site surrounding the buildings</p>
<footer><a href="Public/ARCHITECT.aspx">Read More &raquo;</a></footer>
</article>
       
</div>
<!-- #### -->
<div class="clear"></div>
<!-- ################################################################################################ -->
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="one_third">
<div class="clear">
<h2 class="nospace font-medium push20" style="border: 1px solid rgb(210, 116, 9);
text-align: center;
padding: 5px 0px 5px 3px;
background: rgb(210, 116, 9);
color: rgb(255, 255, 255);
width: 350px;
font-family: arial black;
text-shadow: 4px 1px 2px #000;
font-size: 30px;
margin: 0 0 5px 0px;">Our Heroes</h2>

<asp:DataList ID="dtListCategoryTopers" runat="server" RepeatColumns="2" RepeatDirection="vertical">
<ItemTemplate>

<ul class="nospace spacing clear">
<li class="one_half_Home">
<figure><a class="lightbox-image" href="Employee/Toppers/<%#Eval("ImagesName")%>" target="_blank" data-gal="prettyPhoto[prettyPhoto]">
<img src="Employee/Toppers/<%#Eval("ImagesName")%>" alt="" style="width:158px; height:160px; border: 3px solid rgb(210, 116, 9);" /></a></figure>
<h2 class="font-medium nospace">&nbsp;<asp:Label ID="lblName" runat="server" CssClass="homeLable"  Text='<%# Eval("Name")%>'></asp:Label></h2>
<p> &nbsp;<asp:Label ID="lblRank" runat="server" CssClass="homeLable" Text='<%# Eval("Rank")%>' ></asp:Label></p>
</li>
</ul>
</ItemTemplate>
</asp:DataList>
<%--    <ul class="nospace spacing clear">
<li class="one_half first">
<a href="#">
<img src="Employee/Toppers/HO-139659.jpg" style="border: 1px solid #e6e6e6" alt="">
</a>
<h2 class="font-medium nospace">&nbsp; &nbsp; &nbsp; &nbsp;Mandeep</h2>
<p class="font-medium nospace"> &nbsp; &nbsp; &nbsp;AIPMT, AIR-2</p>
                    

</li>
<li class="one_half first">
<a href="#">
<img src="images/topper_1.png" style="border: 1px solid #e6e6e6" alt="">
</a>
<h2 class="font-medium nospace">&nbsp; &nbsp; &nbsp; &nbsp;Mandeep</h2>
<p class="font-medium nospace"> &nbsp; &nbsp; &nbsp;AIPMT, AIR-2</p>
</li>
<li class="one_half">
<a href="#">
<img src="images/topper_2.png" style="border: 1px solid #e6e6e6" alt="">
</a>
<h2 class="font-medium nospace">&nbsp; &nbsp; &nbsp;Kamal Gupta</h2>  <p class="font-medium nospace"> &nbsp; &nbsp; IIT-AIR-308</p></li>
<li class="one_half first"><a href="#"><img src="images/topper_3.png" style="border: 1px solid #e6e6e6" alt=""></a>
<h2 class="font-medium nospace">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Raaisa</h2>  <p class="font-medium nospace"> &nbsp; &nbsp; &nbsp;IIT-AIR-505</p></li>
<li class="one_half"><a href="#"><img src="images/topper_4.png" style="border: 1px solid #e6e6e6" alt=""></a>
<h2 class="font-medium nospace">&nbsp; &nbsp; &nbsp; Aman Goyal</h2>  <p class="font-medium nospace"> &nbsp; &nbsp; &nbsp;IIT-AIT-743</p></li>
</ul>--%>
</div>
<!-- ################################################################################################ -->
<div class="tab-wrapper clear">
<ul class="tab-nav clear">
<h1>Important Downloads</h1>
</ul>
<div class="tab-container">
<!-- Tab Content -->
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>
<%--       <marquee behavior="scroll" direction="up" scrollamount="3" width="100%" height="100%" onmouseover="this.setAttribute('scrollamount', 0, 0);" onmouseout="this.setAttribute('scrollamount', 6, 0);">
    
</marquee>--%>

<div style="height:380px">
<asp:Repeater ID="Repeater1" runat="server">
<HeaderTemplate>
</HeaderTemplate>
<ItemTemplate>
<div id="tab-1" class="tab-content clear">
<article class="clear push20">
<!-- <div class="imgl"><img src="images/50x50.gif" alt=""></div>-->
<h2 class="font-medium nospace"><a href="#" > <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("EventName") %>' Font-Bold="true"/></a></h2>
<p class="nospace"><a href="UploadedFile/<%#Eval("Description")%>"> Download</a> </p>
<asp:Label ID="lblComment" runat="server" Text='<%#Eval("EventDate") %>'/>
</article>
</h2>
<p>
</p>
   
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>
</div>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
</div>
<!-- / Tab Content -->
</div>
</div>
<div class="clear push30"></div>
     
<div class="divider2"></div>
<div class="clear">
<h2 class="nospace font-medium push20">Courses</h2>

<asp:DataList ID="CoursesName" runat="server" RepeatColumns="2" RepeatDirection="vertical">
<ItemTemplate>
<ul class="nospace spacing clear">
<li class="one_half_Home first">
<figure><a class="lightbox-image" href="Public/Courses.aspx" data-gal="prettyPhoto[prettyPhoto]">
<img src="Employee/Toppers/<%#Eval("ImagesName")%>" alt="" style="width:160px; height:125px; border: 1px solid #e6e6e6" /></a></figure>
</li>
</ul>
</ItemTemplate>
</asp:DataList>
<ul class="nospace spacing clear">
<h3>Student of Idea Learning Academy</h3>
<br />
<asp:DataList ID="DataListYoutube" runat="server" RepeatColumns="2" RepeatDirection="Vertical">
<ItemTemplate>
<ul class="nospace spacing clear">
<li>
    <iframe style="width: 160px; height: 125px;" src="https://www.youtube.com/embed/<%#Eval("Link")%>" frameborder="0" allowfullscreen></iframe>
</li>
</ul>
</ItemTemplate>
</asp:DataList>
<p>
    <asp:Label ID="lblVisiter" class="button small gradient  red rnd8" runat="server" Text=""></asp:Label>
</p>
</div>
</div>
<div class="clear"></div>
</div>
</div>
<!-- Footer --> 
<div>                                                                                                                                                                                                                                                                   <div class="wrapper row2">
<div id="footer" class="clear">
<div class="one_quarter first">
<h2 class="footer_title">Footer Navigation</h2>
<nav class="footer_nav">
<ul class="nospace">
<li><a href="index.aspx">Home Page</a></li>
<li><a href="Public/Welcome.aspx">About Us</a></li>
<li><a href="Public/WhyUs.aspx">Why Us</a></li>
<li><a href="Public/OurCourses.aspx">Courses</a></li>
<li><a href="Public/JEEAdvanceToppers.aspx">Our Toppers</a></li>
<li><a href="Index.aspx">E-Shop ( Coming Soon )</a></li>
<li><a href="Public/IIT_JEE_MAINS_ADV_AIIMS_PMT.aspx">Mentors</a></li>
<li><a href="Public/ContactUs.aspx">Contact Us</a></li>
</ul>
</nav>
</div>
<div class="one_quarter">
<h2 class="footer_title">Latest Gallery</h2>

<div class="clear">
</div>
<div style="float: left; margin: 0px; width: 100%;">
   
</div>

   
<ul id="ft_gallery" class="nospace spacing clear">

<asp:DataList ID="DataListGalery" runat="server" RepeatColumns="2" RepeatDirection="Vertical">
<ItemTemplate>
<ul id="" class="nospace spacing clear">
<li style="width: 120px; height: 100px; border: 0px solid #E6E6E6; padding: 0px 0px 0px 0px; margin:12px 0px -9px 1px;  " > <a  href="Public/Gallery.aspx">
<img src="Employee/Toppers/ImgMain/<%#Eval("ImageName")%>" alt="" style=" border: 0px solid #E6E6E6;" /></a>
                            

</li>
</ul>
</ItemTemplate>
</asp:DataList>
       
        

</ul>
</div>
<div class="one_quarter">
<h2 class="footer_title">Social Link</h2>
<div class="tweet-container">
<ul class="list none">
<li><strong><a href="https://www.facebook.com/ideaacademy.in/?ref=br_rs" target="_blank"><img src="images/fb-icon.png"></a></strong>
<span class="tweet_text"><a href="https://www.facebook.com/ideaacademy.in/?ref=br_rs">Click To communicate with Toppers of Idea Learning Academy</a></span> 
</li>
<li><strong><a href="https://www.linkedin.com/company/idea-learning-academy/" target="_blank"><img src="images/link.png">Welcome to the Idea Learning linkedin page!</a></strong>
<span class="tweet_text"><a href="#"></a></span>
</li>
<li><strong><a href="https://plus.google.com/u/1/114753958127499032618" target="_blank"><img src="images/skype.png"</a></strong>
<span class="tweet_text"><a href="https://plus.google.com/u/1/114753958127499032618"> Thanks for posting your reviews of Idea Learning Academy at Google plus!</a></span>
</li>
<li><strong><a href="https://twitter.com/RNTiwari_iitd" target="_blank"><img src="images/twitter.png"></a></strong>
<span class="tweet_text"><a href="https://twitter.com/RNTiwari_iitd"> The IDEA Learning seeks to improve teaching Standand through research, discussion & your valuable suggestions.</a></span> 
</li>
</ul>
</div>
</div>
<div class="one_quarter">
<h2 class="footer_title">Contact Us</h2>
<div class="rnd5">
<div class="form-input clear">
<label for="ft_author">Name <span class="required">*</span><br>
<asp:TextBox ID="txtName" runat="server" Text=""></asp:TextBox>
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>
</label>
<label for="ft_email">Email <span class="required">*</span><br>
<asp:TextBox ID="txtMail" runat="server" Text=""></asp:TextBox>
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>
</label>
<label for="ft_mobile">Mobile No. <span class="required">*</span><br>
<asp:TextBox ID="txtMobile" runat="server" Text=""></asp:TextBox>
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>
</label>
</div>
<label for="ft_email">Message <span class="required">*</span><br>
<div class="form-message">
<asp:TextBox ID="txtMessage" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
</div>
</label>
<p>
<asp:Button ID="btnSubmit"  runat="server" Text="Submit" 
class="button small orange" onclick="btnSubmit_Click" />
<%--   <div class="content_left_button_ab"> <a href="AllNews.aspx">READ MORE</a> </div>--%>&nbsp;
<asp:Button ID="btnReset"  runat="server" Text="Reset" class="button small grey" onclick="btnReset_Click" />
<%--<input type="text" name="ft_author" id="ft_author1" value="" size="22">--%>
</p>
</div>
</div>
</div>
</div>
<div class="wrapper row4">
<div id="copyright" class="clear">
<p class="fl_left">Copyright &copy; 2015 - All Rights Reserved - <a href="#">OraExperts</a></p>
  
<p class="fl_right"> <a href="http://oraexperts.in/"  target="_blank"> Developed & Design by OraExperts</a></p>
</div>
</div>
<!-- Scripts -->
<div id="fb-root"></div>
<script>    (function (d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s); js.id = id;
        js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.0";
        fjs.parentNode.insertBefore(js, fjs);
    }(document, 'script', 'facebook-jssdk'));</script>

<!--<script src="http://code.jquery.com/jquery-latest.min.js"></script>
<script src="http://code.jquery.com/ui/1.10.1/jquery-ui.min.js"></script>-->
<script>    window.jQuery || document.write('<script src="js/jquery-latest.min.js"><\/script>\
<script src="js/jquery-ui.min.js"><\/script>')</script>
<script>    jQuery(document).ready(function ($) { $('img').removeAttr('width height'); });</script>
<script src="js/responsiveslides.min.js"></script>
<script src="js/jquery-mobilemenu.min.js"></script>
<script src="js/custom.js"></script>
</form>
</body>
</html>
