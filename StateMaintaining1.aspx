<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateMaintaining1.aspx.cs" Inherits="ADODOTNetWebApp.StateMaintaining1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <%--<asp:HiddenField ID="hdnNumber" runat="server" Value="0" />

            Number : <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncrement" runat="server" Text="Increment Number" OnClick="btnIncrement_Click"/>

            <hr />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/StateMaintaining2.aspx">State Maintaining 2 Page </asp:HyperLink>--%>



            <table>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnRedirect" runat="server" Text="State Maintaining 2 Page" 
                             OnClick="btnRedirect_Click"/>
                    </td>
                </tr>
            </table>






        </div>
    </form>
</body>
</html>
