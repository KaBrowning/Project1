<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerFeedback.aspx.cs" Inherits="CustomerFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
    
        <h3>Tell Us of Your Experience</h3>
        <label>Customer ID: </label>
        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
        <br/>
        <br />
        <asp:Button ID="btnGoToFeedback" runat="server" Text="Start Feedback"/>
   
    </form>
    </div>
</body>
</html>
