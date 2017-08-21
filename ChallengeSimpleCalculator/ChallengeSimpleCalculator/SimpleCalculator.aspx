<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="ChallengeSimpleCalculator.SimpleCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Simple Calculator"></asp:Label>
            <br />
            <br />
            First Value:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="firstTextBox" runat="server" Width="75px"></asp:TextBox>
            <br />
            <br />
            Second value:
            <asp:TextBox ID="secondTextBox" runat="server" Width="75px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" BorderStyle="Solid" OnClick="addButton_Click" Text="+" Width="40px" />
            <asp:Button ID="subtractButton" runat="server" BorderStyle="Solid" OnClick="subtractButton_Click" Text="-" Width="40px" />
            <asp:Button ID="multiplyButton" runat="server" BorderStyle="Solid" OnClick="multiplyButton_Click" Text="*" Width="40px" />
            <asp:Button ID="divideButton" runat="server" BorderStyle="Solid" OnClick="divideButton_Click" Text="/" Width="40px" />
            <br />
            <br />
            <asp:Label ID="totalLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
