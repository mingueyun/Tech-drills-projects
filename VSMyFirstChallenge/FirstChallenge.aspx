<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstChallenge.aspx.cs" Inherits="MyFirstChallange.FirstChallange" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            How old are you?
            <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
        </div>
        <br />
        <br />
        How much money do you have in your pocket?<asp:TextBox ID="moneyTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="nowButton" runat="server" Text="wanna know how much i have" />
        <br />
        <br />
        <asp:Label ID="outPutLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
