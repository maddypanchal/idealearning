<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="AllToppers.aspx.cs" Inherits="Public_AllToppers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--image zoomer script--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
      <div id="gallery" class="three_quarter first">
            <h2 class="HeadingLable">All Toppers</h2>
       <div class="NavHero">
            <asp:DataList ID="dtListCategoryTopers" runat="server" RepeatColumns="3" RepeatDirection="vertical">
                <ItemTemplate>
                   <ul class="gallery clearfix" >         
                   <li>
                     <figure><a  href="../Employee/Toppers/<%#Eval("ImagesName")%>" data-gal="prettyPhoto[prettyPhoto]">
                     <img src="../Employee/Toppers/<%#Eval("ImagesName")%>" alt="" style="width:230px; height:185px; border: 3px solid #3DBCE1" /></a></figure>
                    <p> <asp:Label ID="lblNametoppers" runat="server" CssClass="lblToppers" Text='<%# Eval("Name")%>'></asp:Label></p>
                 
                     <p> <asp:Label ID="lblRank" runat="server" CssClass="lblToppers" Text='<%# Eval("rank")%>'></asp:Label> </h1></p>
               </li>
               <li></li>
             <li></li>
               </ul>
               </ItemTemplate>
            </asp:DataList>
       </div>
       </div>
       <div id="sidebar_1" class="sidebar one_quarter">
       <aside>
        <!-- ########################################################################################## -->
        <h2>Our Toppers</h2>
        <nav>
         <ul>
               <li> 
               <asp:Repeater ID="CategoryNameRP" runat="server">
                               <ItemTemplate>
                                    <div class="accor-heading">
                                        <a nowrap="nowrap" href="AllToppers.aspx?Cid=<%# Eval("YearName")%>">
                                        <%#Eval("YearName")%></a>
                                        </div>
                             </ItemTemplate>
                       </asp:Repeater>
                </li>
            </ul>
        </nav>
        <!-- /nav -->
        <!-- ########################################################################################## -->
        </aside>
        <a href="JEEAdvanceToppers.aspx"> <h2> JEE-Advance</h2></a>
        <a href="JEEMainsTopper.aspx"> <h2> JEE-Mains</h2></a>
        <a href="AIIMSToppers.aspx"> <h2>AIIMS/AIPTM</h2></a>
        <a  href="OtherExamToppers.aspx">
        <asp:Image ID="Image1" ImageUrl="~/images/ntse.jpg" runat="server" />
        </a>
        </div>
     <!-- ################################################################################################ -->
   <div class="clear"></div>
   </div>
</div>

   <script src="../zoom/js/jquery-1.7.1.min.js" type="text/javascript"></script>
    <script src="../zoom/js/jquery.prettyPhoto.js" type="text/javascript"></script>
    <script src="../zoom/js/hover-image.js" type="text/javascript"></script>
    <script src="../zoom/js/jquery.easing.1.3.js" type="text/javascript"></script>
    <script src="../zoom/js/jquery.bxSlider.js" type="text/javascript"></script>
   <script type="text/javascript">
  $(document).ready(function () {
    $('#slider-2').bxSlider({
        pager: true,
        controls: false,
        moveSlideQty: 1,
   });
    $("a[data-gal^='prettyPhoto']").prettyPhoto({
        theme: 'facebook'
    });
});
    </script>
</asp:Content>

 