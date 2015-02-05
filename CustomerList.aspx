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
            AppendDataBoundItems="True" DataValueField="CustomerID" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True" >
        </asp:DropDownList>
        
        
        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>" 
            ProviderName="<%$ ConnectionStrings:CustomerConnectionString.ProviderName %>" 
            SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] 
            FROM [Customer] ORDER BY [CustomerID]"></asp:SqlDataSource>
        <br/>
        <br/>
        <label>Customer ID: </label>
        <asp:Label ID="lblCustomerID" runat="server"></asp:Label>
        <br/>
      
        <label>First Name: </label>
        <asp:Label ID="lblFirstName" runat="server"></asp:Label>
        <br />

        <label>Last Name: </label>
        <asp:Label ID="lblLastName" runat="server"></asp:Label>
        <br />

        <label>Address: </label>
        <asp:Label ID="lblAddress" runat="server"></asp:Label>
        <br />

        <label>City: </label>
        <asp:Label ID="lblCity" runat="server"></asp:Label>
        <br />

        <label>State: </label>
        <asp:Label ID="lblState" runat="server"></asp:Label>
        <br />

        <label>Zipcode: </label>
        <asp:Label ID="lblZipcode" runat="server"></asp:Label>
        <br />

        <label>Phone: </label>
        <asp:Label ID="lblPhone" runat="server"></asp:Label>
        <br />

        <label>Email: 
        <asp:Label ID="lblEmail" runat="server"></asp:Label>
        </label>

    </form>
        
   </div>
</body>
</html>
