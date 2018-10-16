<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="StudentSpeaks.aspx.cs" Inherits="Public_StudentSpeaks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="container">
    <!-- ################################################################################################ -->
    <div id="gallery">

      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p><b>IDEA LERANING STUDENT SPEAKS </b></p>
      </div>
      </div>
      <%-- <div class="one_third">
      <a href="#" class="button large gradient orange">Contact Us</a></div>--%>
      </section>
      <div style="height:20px;"></div>

      <section>
      <figure>
     <%--<h2>Gallery Title Goes Here</h2>--%>
          <ul class="clear">
          <asp:DataList ID="dtListCategoryTopers" runat="server" RepeatColumns="1" RepeatDirection="vertical">
                        <ItemTemplate>
                            <ul class="gallery clearfix">
                                <li>
                                  <figure><a  href="../Employee/Toppers/<%#Eval("ImageName")%>" data-gal="prettyPhoto[prettyPhoto]">
                                  <img src="../Employee/Toppers/<%#Eval("ImageName")%>" alt="" style="width:100%;" class="lightbox-image"  /></a></figure>
                                  <%-- <p> <asp:Label ID="lblNametoppers" runat="server" Text='<%# Eval("TitleName")%>'></asp:Label></p>--%>
                                  <%-- <p> <asp:Label ID="Label1" runat="server" CssClass="lblToppers" Text='<%# Eval("Description")%>'></asp:Label></h1></p>--%>
                                </li>
                            </ul>
                        </ItemTemplate>
                    </asp:DataList>

        <%--<li class="one_half first"><a href="#"><img src="../images/demo/gallery.gif" alt=""></a></li>
            <li class="one_half"><a href="#"><img src="../images/demo/gallery.gif" alt=""></a></li>
            <li class="one_half first"><a href="#"><img src="../images/demo/gallery.gif" alt=""></a></li>
            <li class="one_half"><a href="#"><img src="../images/demo/gallery.gif" alt=""></a></li>--%>
          </ul>
        </figure>
        </section>
      <!-- ####################################################################################################### -->
      <%-- <nav class="pagination">
          <ul>
          <li  class="prev"><a href="#">« Previous</a></li>
          <li> <a href="#">1</a></li>
          <li> <a href="#">2</a></li>
          <li  class="splitter"><strong>…</strong></li>
          <li> <a href="#">6</a></li>
          <li  class="current"><strong>7</strong></li>
          <li> <a href="#">8</a></li>
          <li  class="splitter"><strong>…</strong></li>
          <li> <a href="#">14</a></li>
          <li> <a href="#">15</a></li>
          <li  class="next"><a href="#">Next »</a></li>
        </ul>
      </nav>--%>
    </div>
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  </div>
</asp:Content>

