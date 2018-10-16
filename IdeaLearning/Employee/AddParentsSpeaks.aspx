<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="AddParentsSpeaks.aspx.cs" Inherits="Employee_AddParentsSpeaks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">


      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b style="text-transform: uppercase;"> Add Parents Speaks Details</b></p>
     </div>
      </div>
   
    </section>
    <div style="height:20px;"></div>

    <div class="form-input clear">
      <div class="one_half">

         <label for="author">
                Images   * <span class="required"></span>
                            <br>
                            
             <asp:FileUpload ID="FileUploadOnLocalComputer" runat="server" Font-Italic="True"
                        multiple="true" class="" ToolTip="Upload Product Image Here" />
                            </label>
                            </div>
    </div>

     <div class="form-input clear">
      <div class="one_half">

         <label for="author">
                     Title Name   * <span class="required"></span>
                            <br>
                                 <asp:TextBox ID="txtTitleName" runat="server" Text="" ></asp:TextBox>

                            </label>
                            </div>
                            </div>

                               <div class="form-input clear">
      <div class="one_half">

         <label for="author">
                 Description   * <span class="required"></span>
                            <br>

                                    <asp:TextBox ID="txtDescription" runat="server" Text="" TextMode="MultiLine" ></asp:TextBox>
                            </label>
                            </div>
                            </div>

                               <div class="form-input clear">
      <div class="one_half">

         <label for="author">
                <span class="required"></span>
                            <br>
                             <asp:Button ID="btnSave" runat="server" Text="ADD" class="button large gradient orange"
                        onclick="btnSave_Click"/>
                        <asp:Label ID="lblMsg" runat="server" CssClass="" Text=""></asp:Label>
                            </label>
                            </div>
                            </div>

    

        
      
    </section>
     </div>
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

