<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="AIIMSToppers.aspx.cs" Inherits="Public_AIIMSToppers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <%--image zoomer script--%>
    <link href="../zoom/css/prettyPhoto.css" rel="stylesheet" type="text/css" />
    <link href="../zoom/css/style5.css" rel="stylesheet" type="text/css" />
    <link href="../zoom/css/reset5.css" rel="stylesheet" type="text/css" />
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <div id="gallery" class="three_quarter first">
       <h2 class="HeadingLable">AIIMS/AIPMT Toppers</h2>
       <div class="NavHero">
            <asp:DataList ID="dtListCategoryTopers" runat="server" RepeatColumns="3" RepeatDirection="vertical">
                <ItemTemplate>
                 <ul >         
                 <li>
              <figure><a  href="../Employee/Toppers/<%#Eval("ImagesName")%>" data-gal="prettyPhoto[prettyPhoto]">
              <img src="../Employee/Toppers/<%#Eval("ImagesName")%>" alt="" style="width:230px; height:185px; border: 3px solid #3DBCE1" /></a></figure>
                 
                                  
                 </li>
                 <li>     <asp:Label ID="lblNametoppers" runat="server" CssClass="lblToppers" Text='<%# Eval("Name")%>'></asp:Label></li>
             <li>   <asp:Label ID="Label1" CssClass="lblToppers" runat="server" Text='<%# Eval("Rank")%>'></asp:Label> </h1></li>
                 </ul>
                </ItemTemplate>
            </asp:DataList>
      </div>
       </div>
       <div id="sidebar_1" class="sidebar one_quarter">
      <aside>
        <!-- ########################################################################################## -->
        <h2 class="YearHeading">Our Toppers</h2>
        <nav>
          <ul>
              <li><a href="#">AIIMS/AIPMT </a>
               <ul>
               <asp:Repeater ID="CategoryNameRP" runat="server">
                               <ItemTemplate>
                                    <div class="accor-heading">
                                        <a nowrap="nowrap" href="AllToppers.aspx?Cid=<%# Eval("YearName")%>">
                                        <%#Eval("YearName")%></a>
                                        </div>
                             </ItemTemplate>
                       </asp:Repeater>
          </ul>
        </nav>
        <!-- /nav -->
        <!-- ########################################################################################## -->
      </aside>
          <a href="JEEMainsTopper.aspx"> <h2> JEE-Mains</h2></a>
       <a href="JEEAdvanceToppers.aspx"> <h2>JEE-ADVANCE</h2></a>
      <a href="OtherExamToppers.aspx">
        <asp:Image ID="Image1" ImageUrl="~/images/ntse.jpg" runat="server" />
        </a>
    </div>
     <div class="NavToppers">
          <h2 class="HeadingLableTopper">Other Toppers of AIIMS/AIPMT</h2>
          <asp:DataList ID="DataList1" runat="server" RepeatColumns="6" RepeatDirection="Horizontal">
                <ItemTemplate>
                   <ul >         
                   <li><a href="#"> <img src="../Employee/Toppers/ImgMain/<%#Eval("ImagesName")%>"  style="width:200px; height:120px; border: 3px solid #3DBCE1"   /></a>
                   <%--<p> <asp:Label ID="Label1" runat="server" Text='<%# Eval("Name")%>'></asp:Label> </p>--%>
                 </li>
                          <li>
                                  <asp:Label ID="lblNametoppers" runat="server" CssClass="lblToppersHeors" Text='<%# Eval("Name")%>'></asp:Label>
                                </li>
                                <li>    <asp:Label ID="Label1" runat="server" CssClass="lblToppersHeors" Text='<%# Eval("Rank")%>'></asp:Label> </li>
               </ul>
                </ItemTemplate>
            </asp:DataList>
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

