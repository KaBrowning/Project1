<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BrowningProject1</title>
    <link href="Styles/CustomerListStyle.css" rel="stylesheet" />
</head>
<body>
    <header>
        <h1>Digital Upscale Manager for Ballgames</h1>
        <h2>"Managing Ballgames with Technology"</h2>
    </header>

    <div id="wrapper">
        <nav>
            <a href="CustomerList.aspx">Home</a>
            <a href="ContactList.aspx">View Contact List</a>
            <a href="CustomerFeedback.aspx">Feedback</a>
        </nav>

        <form id="form1" runat="server">

            <h3>Please select a customer to view their information</h3>
            <asp:DropDownList ID="ddlCustomers" runat="server" DataSourceID="SqlDataSource" DataTextField="Name"
                AppendDataBoundItems="True" DataValueField="CustomerID" OnSelectedIndexChanged="ddlCustomers_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList>


            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>"
                ProviderName="<%$ ConnectionStrings:CustomerConnectionString.ProviderName %>"
                SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] 
            FROM [Customer] ORDER BY [CustomerID]"></asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlDataSourceSelectedItem" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerConnectionString %>"
                ProviderName="<%$ ConnectionStrings:CustomerConnectionString.ProviderName %>"
                SelectCommand="SELECT [CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email] 
            FROM [Customer] WHERE ([CustomerID] = @CustomerID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="ddlCustomers" Name="CustomerID" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

            <br />
            <br />
            <asp:Repeater ID="dlCustomerInfo" runat="server" DataSourceID="SqlDataSourceSelectedItem">
                <ItemTemplate>
                    <label>Customer ID: </label>
                    <asp:Label ID="lblCustomerID" runat="server" Text='<%# Bind("CustomerID") %>'></asp:Label>
                    <br />

                    <label>Name: </label>
                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                    <br />

                    <label>Address: </label>
                    <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                    <br />

                    <label>City: </label>
                    <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                    <br />

                    <label>State: </label>
                    <asp:Label ID="lblState" runat="server" Text='<%# Bind("State") %>'></asp:Label>
                    <br />

                    <label>Zipcode: </label>
                    <asp:Label ID="lblZipcode" runat="server" Text='<%# Bind("Zipcode") %>'></asp:Label>
                    <br />

                    <label>Phone: </label>
                    <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                    <br />

                    <label>Email: </label>
                    <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                    
                </ItemTemplate>
            </asp:Repeater>
            <br/>
            <br/>
            <asp:Button ID="btnAddToContacts" runat="server" Text="Add to Contacts" CssClass="button" OnClick="btnAddToContacts_Click"/>
            <asp:Button ID="btnViewList" runat="server" Text="View Contact List" CssClass="button" OnClick="btnViewList_Click"/>
            <br/>
            <asp:Label ID="lblSuccessfulAdd" runat="server"></asp:Label>
        </form>
    </div>
</body>
</html>
