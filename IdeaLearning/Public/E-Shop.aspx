<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="E-Shop.aspx.cs" Inherits="Public_E_Shop" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper row3">
  <div id="container">
    <!-- ################################################################################################ -->
    <div id="gallery">
      <section>
        <figure>
          <h2>E-book </h2>
          <asp:DataList ID="dlEbook" runat="server" RepeatColumns="3" RepeatDirection="vertical">
                        <ItemTemplate>
           <ul class="clear">

            <li class="one_quarter first" style="width:100%;">
            <a href="../Employee/EBook/<%#Eval("Pdffile")%>">
            <img src="../Employee/EBook/<%#Eval("CoverPage")%>"  style="width:100%; height:400px; border:4px solid;">
            </iframe>
            </a></li>
           
          </ul>
           </ItemTemplate>
                    </asp:DataList>
        </figure>
      </section>
      <!-- ####################################################################################################### -->
      <nav class="pagination">
      <%--  <ul>
          <li class="prev"><a href="#">&laquo; Previous</a></li>
          <li><a href="#">1</a></li>
          <li><a href="#">2</a></li>
          <li class="splitter"><strong>&hellip;</strong></li>
          <li><a href="#">6</a></li>
          <li class="current"><strong>7</strong></li>
          <li><a href="#">8</a></li>
          <li class="splitter"><strong>&hellip;</strong></li>
          <li><a href="#">14</a></li>
          <li><a href="#">15</a></li>
          <li class="next"><a href="#">Next &raquo;</a></li>
        </ul>--%>
      </nav>
    </div>
    <!-- ################################################################################################ -->
    <div class="clear"></div>
  </div>
</div>
</asp:Content>

