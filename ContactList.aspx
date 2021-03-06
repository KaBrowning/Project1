﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactList.aspx.cs" Inherits="ContactList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact List</title>
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

        <br/>
       <label>Selected Customers:</label>
        <br/>

        <asp:ListBox ID="lbCurrentCustomerList" runat="server" AutoPostBack="True" CssClass="listbox">
            </asp:ListBox>

        
        <br />
        <br />
        <asp:Button ID="btnSelectMore" runat="server" Text="Select Additional Customers" CssClass="button" OnClick="btnSelectMore_Click"/>
        <asp:Button ID="btnRemove" runat="server" Text="Remove Customer" CssClass="button" OnClick="btnRemove_Click"/>
        <asp:Button ID="btnClear" runat="server" Text="Clear List" OnClick="btnClear_Click" CssClass="button"/>
        
        

    </form>
    </div>
</body>
</html>
