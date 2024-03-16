<%--<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="TrainerDashboard.aspx.cs" 
    Inherits="ADODOTNetWebApp.TrainerDashboard
    MasterPageFile="~/MyLayout.Master" %>--%>


<%--﻿<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="TrainerDashboard.aspx.cs" Inherits="ADODOTNetWebApp.TrainerDashboard" 
    MasterPageFile="~/MyLayout.Master" %>--%>

<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="TrainerDashboard.aspx.cs" Inherits="ADODOTNetWebApp.TrainerDashboard" 
    MasterPageFile="~/MyLayout.Master" %>


<asp:Content ID="ContentPage" runat="server" ContentPlaceHolderID="MainContentHolder">

     <div>
         <form runat="server">
            <h1>ALL Trainers</h1>

           <asp:GridView ID="gvTrainers" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            
               <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
       
               </asp:GridView>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
             </form>
        </div>



</asp:Content>



<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="Content/bootstrap.min.css" rel="stylesheet" />

</head>
<body>

  
   <%--  <div>
             <asp:HyperLink ID="HyperLink1" runat="server" 
                NavigateUrl="~/Home.aspx">Home</asp:HyperLink>

        </div>--%>




<%--    <div class="container">

    <form id="form1" runat="server">--%>

           <%--<nav class="navbar navbar-expand-sm bg-dark">

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

        
       <%-- <div>
            <h1>ALL Trainers</h1>

           <asp:GridView ID="gvTrainers" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>--%>

   <%-- </form>

        </div>
       
        <script src="Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>--%>
