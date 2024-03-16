<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateMaintaining2.aspx.cs" Inherits="ADODOTNetWebApp.StateMaintaining2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>State Maintaining 2 Page </h1>

            <hr />

<%--            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>--%>



            <table>
                <tr>
                    <td>Name</td>
                    <asp:Label ID="lblName" runat="server" ></asp:Label>
                </tr>
                 <tr>
                    <td>Email</td>
                    <asp:Label ID="lblEmail" runat="server" ></asp:Label>
                </tr>

            </table>


        </div>
    </form>
</body>
</html>
