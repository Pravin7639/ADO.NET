<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Home.aspx.cs" Inherits="ADODOTNetWebApp.Home" 
    MasterPageFile="~/MyLayout.Master" %>


<asp:Content ID="ContentPage" runat="server" ContentPlaceHolderID="MainContentHolder">

   
         <form runat="server">
        <h2>Home Page Content</h2>
        <hr />
        <input type="text" id="Text1" runat="server" />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <hr />
        <input type="button" value="Html Button" />
        <asp:Button ID="Button1" runat="server" Text="ASPX Button" OnClick="btnLoad_Click" />
         </form>


</asp:Content>




<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>
   

    <div class="container">
       <form id="form1" runat="server"> --%>

           <%--<div>
               <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/TrainerDashboard.aspx">Trainers</asp:HyperLink>


           </div>--%>

        

<%--               <nav class="navbar navbar-expand-sm bg-dark">

  <div class="container-fluid">
    <!-- Links -->
    <ul class="navbar-nav">
      <li class="nav-item">
<asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Home.aspx" CssClass="nav-link">Home</asp:HyperLink>
      </li>
      <li class="nav-item">
<asp:HyperLink ID="HyperLink2" runat="server" 
    NavigateUrl="~/TrainerDashboard.aspx" CssClass="nav-link">Trainers</asp:HyperLink>
      </li>
      
    </ul>
  </div>

</nav>--%>


         


       

<%--           </form>
        </div>


    <script src="Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>--%>
