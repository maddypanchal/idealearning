<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="AllNews.aspx.cs" Inherits="Public_AllNews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="wrapper">
        <div class="laest_News_text">
            <h1>
                 All latest News Here </h1>
            <div class="">
           <asp:Repeater ID="Repeater" runat="server">
    <HeaderTemplate>
    </HeaderTemplate>
    <ItemTemplate>
     <div class="news_main_bg_all">
        <div class="news_main_all">
          <h2>
         <asp:Label ID="lblSubject" runat="server" Text='<%#Eval("TitleName") %>' Font-Bold="true"/>
          </h2>
          <p>
               <asp:Label ID="lblComment" runat="server" Text='<%#Eval("Description") %>'/>
         </p>
         </div>
      
      </div>
     </ItemTemplate>
    <FooterTemplate>
    </table>
    </FooterTemplate>
    </asp:Repeater>
                
            </div>
        </div>
    </div>
</asp:Content>

