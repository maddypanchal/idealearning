<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="UpdateStudentAddress.aspx.cs" Inherits="Employee_UpdateStudentAddress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <div class="form-input clear">
        <div class="one_half">
       <label for="author">
                                  Country* <span class="required"></span>
                           
                      <asp:DropDownList ID="ddlCountryRegion" runat="server" AutoPostBack="True" CssClass="Ddl_Css"
                   OnSelectedIndexChanged="ddlCountryRegion_SelectedIndexChanged" >
                </asp:DropDownList>
                          
               
                            </label>
                            </div>
        



    </div>




     <div class="form-input clear">
        <div class="one_half">
             <label for="author">  State* <span class="required"></span>
                <asp:DropDownList ID="ddlStateRegion" runat="server" CssClass="Ddl_Css" AutoPostBack="true"
                     OnSelectedIndexChanged="ddlStateRegion_SelectedIndexChanged"  >
                    <asp:ListItem>--Select--</asp:ListItem>
              </asp:DropDownList> 
                      
                            </label>
                            </div>
       
                               </div>
     <div class="form-input clear">
        <div class="one_half">
             <label for="author">
                              City* <span class="required"></span>
                           
                      <asp:DropDownList ID="ddlCity" runat="server" CssClass="Ddl_Css">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                
                            </label>
                            </div>
      

    </div>

    <div class="form-input clear">
        <div class="one_half">
         <asp:Button ID="btnSubmit" runat="server" Text="UPDATE" class="button large gradient red" OnClick="btnSubmit_Click" />
         

            <p>
      <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
            </p>
            </div>
   

</asp:Content>

