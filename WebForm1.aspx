<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ADODOTNetWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>WebForm 1 Page Content </h1>
            <asp:HyperLink ID="HyperLink1" runat="server"
                NavigateUrl="https://www.google.com">Google.com</asp:HyperLink>   || 

            <asp:HyperLink ID="HyperLink2" runat="server"
                NavigateUrl="WebForm2.aspx">WebForm 2 Page </asp:HyperLink>
            <hr />

            <asp:Button id="Button1" runat="server" Text="Google.com" PostBackUrl="http://www.google.com" />  || 
            <asp:Button id="Button2" runat="server" Text="WebForm 2 Page" PostBackUrl="~/WebForm2.aspx" />
           <hr />

             <asp:Button id="btnGoogle" runat="server" Text="Google.com" OnClick="btnGoogle_Click" />  || 
            <asp:Button id="btnWebForm" runat="server" Text="WebForm 2 Page" OnClick="btnWebForm_Click" />
           <hr />

            <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
            <hr />

            <asp:Button id="Button3" runat="server" Text="Google.com" OnClientClick="window.open('https://www.google.com')" />  || 
            <asp:Button id="Button4" runat="server" Text="WebForm 2 Page" OnClientClick="window.open('WebForm2.aspx')" />
           <hr />

             

        </div>
    </form>
</body>
</html>
