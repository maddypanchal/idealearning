<%@ Page Title="" Language="C#" MasterPageFile="~/Employee/Employee.master" AutoEventWireup="true" CodeFile="WorkDatails.aspx.cs" Inherits="Employee_WorkDatails" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   <link href="../calander/tcal.css" rel="stylesheet" type="text/css" />
    <script src="../calander/tcal.js" type="text/javascript"></script>
    <script type="text/javascript">
        function init() {
            calendar.set("ctl00_ContentPlaceHolder1_txtDateofBirth");
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div id="container">
      <!-- ################################################################################################ -->
    <section class="clear">

            <section>
      <div class="calltoaction opt4 clear">
      <div style="text-align:center;">
      <p  > <b>ADD WORK DETAILS</b></p>
     </div>
      </div>
    
       <%--<div class="one_third">
       <a href="#" class="button large gradient orange">Contact Us</a></div>--%>

    </section>

   <div style="height:20px;"></div>

    <div class="form-input clear">
        <div class="one_half">
          <label for="author">
                             Date  * <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtTitleDate" runat="server" placeholder="Enter Date" Text="" ReadOnly="true"
                       ></asp:TextBox>
                  </label>
        </div>
            <div class="one_half">

              <label for="author">
                            Last Date Of Complition  * <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtLastDateOfComplate" runat="server" placeholder="Last Date Of Complate"  Text="" CssClass="Ddl_Css tcal" ></asp:TextBox>
                  </label>
       
        </div>
        </div>
         <div class="form-input clear">

            <div class="one_half">
           <label for="author">
                             Instruction/Remark If Any   <span class="required"></span>
                            <br>
                  <asp:TextBox ID="txtInstruction" runat="server" placeholder="Instruction" Text=""></asp:TextBox>
                
                  </label>
               
        </div>
            <div class="one_half">

              <label for="author">
                            Task Given To  * <span class="required"></span>
                            <br>
                  <asp:DropDownList ID="ddlEmployee" runat="server" CssClass="Ddl_Css" >
                  </asp:DropDownList>
                  </label>
  
        </div>
          </div>


          <div class="form-input clear">

            <div class="one_half">
                <label for="author">
                              Task Title/Name   * <span class="required"></span>
                            <br>
                   <asp:TextBox ID="txtTopic" runat="server" placeholder="Enter Topic" Text=""></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="txtTopic"
                        CssClass="validation1" runat="server" Display="Dynamic" ValidationGroup="o1"
                        ErrorMessage="This field is required"></asp:RequiredFieldValidator>
                  </label>
            </div>

           <div style="height:20px;"></div>
          <div class="form-input clear">
              <CKEditor:CKEditorControl ID="CKEditor1" runat="server" >

                    </CKEditor:CKEditorControl>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="validation1" runat="server"
                        Display="Dynamic" ValidationGroup="o1" ErrorMessage="This field is required"
                        ControlToValidate="CKEditor1"></asp:RequiredFieldValidator>
          
          </div>
             <div style="height:20px;"></div>
              <div class="form-input clear">
                 <asp:Button ID="btnSubmit" Text="Submit" runat="server" class="button large gradient orange" ValidationGroup="o1"
                        OnClick="btnSubmit_Click" />
                    <asp:Label ID="lblMsg" runat="server" Text="" ForeColor="Red"></asp:Label>
                    </div>
     </section>
     </div>

    
    <!-- ################################################################################################ -->
    <!-- ################################################################################################ -->
    <div class="clear"></div>
</asp:Content>

