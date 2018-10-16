<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="Public_ContactUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="wrapper row3">
        <div id="container">
            <!-- ################################################################################################ -->
            <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d13769.418142434908!2d76.785684!3d30.369289!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xa1ad15326137c221!2sIDEA+LEARNING+ACADEMY+(+IIT-JEE%2FAIIMS)!5e0!3m2!1sen!2sin!4v1522776533430" width="45%" height="300" frameborder="0" style="border: 0; margin: 0 0 20px 27px;"></iframe>
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3450.789195377401!2d77.28882951472937!3d30.128845081851697!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x390efbcc0f4720b3%3A0xec2245c66c1ffd0f!2sIDEA+LEARNING+ACADEMY+YAMUNANAGAR!5e0!3m2!1sen!2sin!4v1534772404562" width="45%" height="300" frameborder="0" style="border: 0; margin: 0 0 20px 27px;"></iframe>
            <div id="contact" class="clear">
                <div class="one_half first">
                    <h1>Contact Us</h1>
                    <div id="respond">
                        <div class="rnd5">
                            <div class="form-input clear">
                                <label class="one_half first" for="author">
                                    Name <span class="required">*</span><br>
                                    <asp:TextBox ID="txtCName" runat="server" Text=""></asp:TextBox>
                                </label>
                                <label class="one_half" for="email">
                                    Email <span class="required">*</span><br>
                                    <asp:TextBox ID="txtCMail" runat="server" Text=""></asp:TextBox>
                                </label>
                            </div>
                            <div class="form-input clear">
                                <div class="form-message">
                                    <label class="" for="email">
                                        Email <span class="required">*</span><br>
                                        <asp:TextBox ID="txtCMessage" runat="server" Text="" placeholder="Message" Rows="10" TextMode="MultiLine"></asp:TextBox>
                                    </label>
                                </div>
                            </div>
                            <p>
                                <asp:Button ID="btnContactSubmit" runat="server" class="button small orange"
                                    Text="Submit" OnClick="btnContactSubmit_Click" />
                                &nbsp;
                                <asp:Button ID="btnContactReset" runat="server" class="button small grey"
                                    Text="Reset" OnClick="btnContactReset_Click" />
                            </p>
                        </div>
                    </div>
                </div>
                <div class="one_half">
                    <div class="map push50">
                        <img src="../images/demo/1200x400.gif" alt="">
                    </div>
                    <section class="contact_details clear">
<h2>IDEA LEARNING ACADEMY</h2>
  <p>                      IIT-JEE | MEDICAL | FOUNDATION</p>
                        <p> IITian Initiative ........................

<%--<p> A Premier Institute for IIT-JEE (MAINS/ADVANCE)PMT/AIIMS)--%>
</p>
<div class="one_half first" style="text-transform:uppercase">
<b>CORPORATE OFFICE CUM R $ D CENTRE:- </b>

<address>

9, Prem Nagar<br/>
AMBALA CITY:<br/>
Near bata showroom<br/>
Ambala, Haryana <br/>
Pin : 134003<br/>
</address>

</div>
<div class="one_half" style="text-transform:uppercase">
<ul class="list none">
<Br/>
<li></li>
<li>Tel:0171-2550-007 </li>
<li>M :+91-92151-41005</li>
<li>M : +91-92151-41004</li>
<li>Email: <a href="#" style="font-size:10px;" >Idea.learning.academy@gmail.com
</a></li>
</ul>
</div>
<div class="one_half first" style="text-transform:uppercase">
<B>BRANCH OFFICE:- </B>
<address>
IDEA LEARNING ACADEMY<br>
2nd FLOOR,<br /> 
NEAR FAWARA CHOWK<br /> 
OPPOSITE BHATIA NAGAR,<br /> 
YAMUNA NAGAR<br />
HARYANA, INDIA<br /> 
PIN: 135001<br /> 
</address>

</div>
<div class="one_half" style="text-transform:uppercase">
<ul class="list none">
<br/>
<li></li>
<li>M : +91-92151-41005 </li>
<li>M : +91-92151-41004</li>
<li>M : +91-99960-21317</li>
<li>Email: <a href="#" style="font-size:10px;">Idea.learning.academy@gmail.com
</a></li>
</ul>
</div>
<div class="one_half first">
<b>SISTER CONCERN OFFICE:- </b>
<address>
IDEA EDUCATION ACADEMY<br/>
SCF-43/44 , SECTOR 13 <br/>
KURUKSHETRA HARYANA<br/>
PIN: 136118
</address>
</div>
<div class="one_half" style="text-transform:uppercase">
<ul class="list none">
<br/>
<li></li>
             
<li>M : 98965-45257</li>
    <li>M : 95728-00150</li>
    <li>T :+91-1744-226768 </li>
<li>Email: <a href="#" style="font-size:10px;">idea.education@gmail.com
</a></li>
</ul>
</div>
</section>
      </div>
      </div>

            <div class="clear"></div>
        </div>
    </div>
</asp:Content>

