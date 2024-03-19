<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="ValidationDemo.aspx.cs" Inherits="ADODOTNetWebApp.ValidationDemo"
    MasterPageFile="~/MyLayout.Master" %>



<asp:Content ID="mainPage" runat="server" ContentPlaceHolderID="MainContentHolder">
        <form id="form1" runat="server">

        <h1>Create Employeee</h1>

       <table>
           <tr>
               <td>Name</td>
               <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                       ControlToValidate="txtName" ForeColor="Red" Display="Dynamic"
                       runat="server" ErrorMessage="Please Enter Name">
                   </asp:RequiredFieldValidator>

               </td>
           </tr>

           <tr>
               <td>Age</td>
               <td>
                   <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                       ControlToValidate="txtAge" ForeColor="Red" Display="Dynamic"
                       runat="server" ErrorMessage="Please Enter Age">
                   </asp:RequiredFieldValidator>

                   <asp:RangeValidator ID="RangeValidator1"  runat="server"
                       ControlToValidate="txtAge" MinimumValue="1" Display="Dynamic"
                         MaximumValue="150" Type="Integer" ForeColor="Red"
                        ErrorMessage="Enter age between 1 and 150" >
                   </asp:RangeValidator>


                   <asp:CustomValidator ID="CustomValidator1" runat="server"
                        ControlToValidate="txtAge" Display="Dynamic" ForeColor="Red"
                       ErrorMessage="Please enter only Even Numbers"
                       OnServerValidate="CustomValidator1_ServerValidate"
                       ClientValidationFunction="validateAgeAsEven"
                       EnableClientScriept="true">
                   </asp:CustomValidator>


               </td>
           </tr>

           <tr>
               <td>Email</td>
               <td>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                       ControlToValidate="txtEmail" ForeColor="Red" Display="Dynamic"
                       runat="server" ErrorMessage="Please Enter Email">
                   </asp:RequiredFieldValidator>

                   <asp:RegularExpressionValidator 
                       ID="RegularExpressionValidator1"  runat="server"
                       ControlToValidate="txtEmail" ForeColor="Red"  Display="Dynamic"
                       ErrorMessage="Invalid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">

                   </asp:RegularExpressionValidator>

               </td>
           </tr>

           <tr>
               <td>ConfirmEmail</td>
               <td>
                   <asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator4"
                       ControlToValidate="txtConfirmEmail" ForeColor="Red" Display="Dynamic"
                       runat="server" ErrorMessage="Please Enter Confirm Email">
                   </asp:RequiredFieldValidator>

                   <asp:CompareValidator ID="CompareValidator1" runat="server" 
                       ControlToValidate="txtConfirmEmail" ForeColor="Red" Display="Dynamic"
                       ControlToCompare="txtEmail" Operator="Equal"
                       ErrorMessage="Email and Confirm Email should be same"></asp:CompareValidator>


               </td>
           </tr>

           <tr>
               <td colspan="2">
                   <asp:Button ID="Button1" runat="server" Text="Create" OnClick="btnCreate_Click" />
               </td>
           </tr>

           
           <tr>
               <td colspan="2">
                   <asp:Label ID="lblMessage" runat="server" ForeColor="DarkRed"></asp:Label>
               </td>
           </tr>

       </table>

    </form>



    <script>

        function validateAgeAsEven(obj, args) {

            if (args.Value % 2 == 0) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }

        }


    </script>



</asp:Content>



<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h1>Create Employeee</h1>

       <table>
           <tr>
               <td>Name</td>
               <td>
                   <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
               </td>
           </tr>

           <tr>
               <td>Age</td>
               <td>
                   <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
               </td>
           </tr>

           <tr>
               <td>Email</td>
               <td>
                   <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
               </td>
           </tr>

           <tr>
               <td>ConfirmEmail</td>
               <td>
                   <asp:TextBox ID="txtConfirmEmail" runat="server"></asp:TextBox>
               </td>
           </tr>

           <tr>
               <td>
                   <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
               </td>
           </tr>


       </table>
    </form>
</body>
</html>--%>
