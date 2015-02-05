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
        <br/>
        <br/>
        <br/>
        
        <label>How would you rate our service time?</label>
        <asp:RadioButtonList ID="rdoServiceTime" runat="server" RepeatDirection="Vertical" CssClass="rdoButtons">
            <asp:ListItem>Satisfied</asp:ListItem>
            <asp:ListItem>Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem>Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <br/>

        <label>How would you rate our technical efficiency?</label>
        <asp:RadioButtonList ID="rdoTechEfficiency" runat="server" RepeatDirection="Vertical" CssClass="rdoButtons">
            <asp:ListItem>Satisfied</asp:ListItem>
            <asp:ListItem>Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem>Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <br/>
        
        <label>How would you rate our ability to resolve your problems?</label>
        <asp:RadioButtonList ID="rblProbResolution" runat="server" RepeatDirection="Vertical" CssClass="rdoButtons">
            <asp:ListItem>Satisfied</asp:ListItem>
            <asp:ListItem>Neither Satisfied Nor Dissatisfied</asp:ListItem>
            <asp:ListItem>Dissatisfied</asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <br/>
        
        <label>Additional Comments:</label>
        <br/>
        <asp:TextBox ID="txtComments" runat="server" CssClass="txtbox" TextMode="MultiLine"></asp:TextBox>
        <br/>
        <br/>
        
        <label>Would you like to be contacted?</label>
        <br/>
        <asp:CheckBoxList ID="cblContact" runat="server" RepeatDirection="Horizontal" CssClass="rdoButtons">
            <asp:ListItem>Yes</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:CheckBoxList>
        <br/>
        <br/>
        
        <label>How would you like to be contacted?</label>
        <asp:RadioButtonList ID="rblChooseContact" runat="server" RepeatDirection="Vertical" CssClass="rdoButtons">
            <asp:ListItem>Phone</asp:ListItem>
            <asp:ListItem>Email</asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <br/>
        <br/>
        
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />

    </form>
    </div>
</body>
</html>
