<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true"
    CodeFile="IIT_JEE_MAINS_ADV_AIIMS_PMT.aspx.cs" Inherits="Public_IIT_JEE_MAINS_ADV_AIIMS_PMT" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.css" rel="stylesheet" type="text/css" />
    <script src="../SimpalPopUp/fancybox/jquery.fancybox-1.3.4.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".Panchal").fancybox({
                'width': '45%',
                'height': '70%',
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
    <div class="wrapper row3">
        <div id="container">
            <!-- ################################################################################################ -->
                 <div id="gallery">
                  <div class="calltoaction opt4 clear">
                    <div style="text-align: center;">
                        <p>
                            <b>Our Mentors of IIT-JEE(MAINS & ADVANCE)/AIIMS/PMT</b></p>
                    </div>
                  </div>
                 <asp:DataList ID="DTTeachingStaff" runat="server" RepeatColumns="1" RepeatDirection="Horizontal">
                     <ItemTemplate>
                        <section class="calltoaction opt1 clear">
                     <div class="one_third ">
                        <figure class="imgl boxholder">
                      <img src="../CroppedImages/<%#Eval("UploadImages")%>" style="width:300px !important; height:250px !important;"  alt="">
                     </figure>
                       <div class="clear columncolor">
                     <div class="alert-msg success">
                         Name :  <%#Eval("Name")%></div>
                     </div>
                       <div class="alert-msg success">
                      Designation :  <%#Eval("Designation")%></div>
                    </div>
                    </div>
                   
                    <div class="two_third">
                        <div class="one_quarter first">
                           <br />
                        </div>
                        <div class="three_fifth">
                             <br />
                        </div>
                      
                        <div class="one_quarter">
                            WorkLocation
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                               <%#Eval("WorkLocation")%></div>
                        </div>
                        <div class="one_quarter">
                            Qualification
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                                <%#Eval("Qualification")%></div>
                        </div>
                        <div class="one_quarter">
                            OtherDuties
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                                <asp:Label ID="lblOtherDuties" runat="server" Height="100%" Text='<%#Eval("OtherDuties")%>'></asp:Label></div>
                        </div>
                        <div class="one_quarter">
                            Experience
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                                <asp:Label ID="lblExperience" runat="server" Height="100%" Text='<%#Eval("Experience")%>'></asp:Label></div>
                        </div>
                        <div class="one_quarter">
                            Interest
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                                <asp:Label ID="lblInterest" runat="server" Height="100%" Text='<%#Eval("Interest")%>'></asp:Label></div>
                          </div>
                         <div class="one_quarter">
                            Descriptions
                        </div>
                        <div class="three_fifth">
                            <div class="Menter-msg warning">
                                <asp:Label ID="lblDescriptions" runat="server"   Height="100%" Text='<%#Eval("Descriptions")%>'></asp:Label></div>
                        </div>
                         <div class="button large gradient yellow">
                         <a  class="Panchal" style="color: #4d4d4f; margin: 0 0 0 454px;"  href="EmailContact.aspx">Contact Me</a>
                         </div>
                        <section class="clear">
                    </section>
                    </div>
                    </section>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <!-- ################################################################################################ -->
            <div class="clear">
            </div>
        </div>
    </div>
</asp:Content>
