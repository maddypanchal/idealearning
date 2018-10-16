<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.master" AutoEventWireup="true" CodeFile="ShowOnlineStudentDetails.aspx.cs" Inherits="Admin_ShowOnlineStudentDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="wrapper row3">
        <div id="container">
            <div class="clear columncolor">
                <p class="emphasise" style="text-transform: uppercase;">
                   SHOW ONLINE STUDENT DETAILS</p>
             
       
                        <div class="form-input clear">
                            <div class="one_half">
                             <label>  <p>
                                        Student Name*</p>
                                    <asp:TextBox ID="txtStudentName" runat="server" Text=""></asp:TextBox>
                                
                                        </label>
                            </div>
                            <div class="one_half">
                                <p>
                                        Father Name*</p>
                                    <asp:TextBox ID="txtFatherName" runat="server" Text="" ></asp:TextBox>
                                    
                            </div>
                        </div>
                        <div class="form-input clear">
                            <div class="one_half">
                              <p>
                                        Mother Name*</p>
                                    <asp:TextBox ID="txtMotherName" runat="server" Text="" ></asp:TextBox>
                                   
                            </div>
                            <div class="one_half">
                               <p>
                                        Date of Birth*</p>
                                    <asp:TextBox ID="txtDateOfBirth" runat="server" Text="" class="name_Contact1 tcal"></asp:TextBox>
                                 
                            </div>
                        </div>
                        

                    

                        <div class="form-input clear">
                            <div class="one_half">
                                      <p>
                                        Email Id*</p>
                                    <asp:TextBox ID="txtEmail" runat="server" Text="" ></asp:TextBox>
                              
                            </div>
                            <div class="one_half">
                          
                                <p>
                                        User Name*</p>
                                    <asp:TextBox ID="txtUserName" runat="server" Text="" ></asp:TextBox>
                                
                            </div>
                        </div>


                            <div class="form-input clear">
                            <div class="one_half">
                              <p>
                                        Mobile No*</p>
                                    <asp:TextBox ID="txtMobile" runat="server" Text="" ></asp:TextBox>
                                
                            </div>
                            <div class="one_half">
                              <p>
                                        Password*</p>
                                    <asp:TextBox ID="txtPassword" runat="server" Text=""  ></asp:TextBox>
                                
                            </div>
                        </div>

                        <div class="form-input clear">
                            <div class="one_half">
                                <p>Gender*</p>
                                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Male</asp:ListItem>
                                        <asp:ListItem Value="2">Female</asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                            <div class="one_half">
                                <p>Category*</p>
                                    <asp:DropDownList ID="ddlCategory" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                        <asp:ListItem Value="1">Gen</asp:ListItem>
                                        <asp:ListItem Value="2">OBC</asp:ListItem>
                                        <asp:ListItem Value="3">SC</asp:ListItem>
                                        <asp:ListItem Value="4">ST</asp:ListItem>
                                        <asp:ListItem Value="5">Other</asp:ListItem>
                                    </asp:DropDownList>
                            </div>
                        </div>
                    <div class="form-input clear">
                            <div class="one_half">
                                 <p>
                                        Country*</p>

                    <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True" CssClass="dropdownlist"
                    OnSelectedIndexChanged="ddlCountryRegion_SelectedIndexChanged">
                    </asp:DropDownList>
                    </div>

                    <div class="one_half"> 
                    
                         <p>
                                        State*</p>

                                           <asp:DropDownList ID="ddlStateRegion" runat="server" CssClass="dropdownlist" AutoPostBack="true"
                     OnSelectedIndexChanged="ddlStateRegion_SelectedIndexChanged">
                    <asp:ListItem>--Select--</asp:ListItem>
              </asp:DropDownList> 
                    
                    </div>
                    </div>


                        <div class="form-input clear">
                            <div class="one_half">
                                 <p>
                                        City*</p>
                                         <asp:DropDownList ID="ddlCity" runat="server" CssClass="dropdownlist">
                                         <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                                   
                            </div>
                            <div class="one_half">
                                   <p>
                                        Course*</p>
                                    <asp:DropDownList ID="ddlCourse" runat="server" CssClass="dropdownlist">
                                        <asp:ListItem Value="-1">Select One</asp:ListItem>
                                  
                                    </asp:DropDownList>
                         
                            </div>
                        </div>
                        <div class="form-input clear">
                          
                                 <p>
                                        Address*</p>
                                    <asp:TextBox ID="txtaddress" runat="server" Text=""  TextMode="MultiLine"></asp:TextBox>
                              
                           
                        
                        </div>
                          <div class="form-input clear">
                             <div class="one_half">
                                <code class="code">
                              Photo
                                   <asp:Image ID="imgPhoto" runat="server" ImageUrl="~/images/stu.jpg"  />
                                <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                              
                                </code>
                            </div>
                            <div class="one_half">
                                <code class="code">
                                Singnature
                                  <asp:Image ID="ImgSign" runat="server" ImageUrl="~/images/stu.jpg"  />
                                </code>
                            </div>
                            </div>
                            
                       
                         
                       
                  
                    
           </div>
        </div>
    </div>
</asp:Content>

