<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BrowningProject1</title>
    <link href="Styles/CustomerListStyle.css" rel="stylesheet"/>
</head>
<body>
    <header>
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>
    
    <div id ="wrapper">
    <nav>
        <a href ="CustomerList.aspx">Home</a>
        <a href ="ContactList.aspx">View Contact List</a>
        <a href ="CustomerFeedback.aspx">Feedback</a>
    </nav>

    <form id="form1" runat="server">
        
        <h3>Please select a customer to view their information</h3>
        <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="SqlDataSource" DataTextField="Name" 
            AppendDataBoundItems="True" DataValueField="CustomerID" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" >
            <asp:ListItem>Please Select One</asp:ListItem>
        </asp:DropDownList>
        
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:CustomerConnectionString.ProviderName %>" 
            SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] 
            FROM [Customer] ORDER BY [CustomerID]"></asp:SqlDataSource>
        
    </form>
        
   </div>
</body>
</html>
