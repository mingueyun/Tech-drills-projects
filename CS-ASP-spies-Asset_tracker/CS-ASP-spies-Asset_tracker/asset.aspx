<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="asset.aspx.cs" Inherits="CS_ASP_spies_Asset_tracker.asset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>
                <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/Resources/epic-spies-logo.jpg" Width="122px" />
                <br />
                <br />
                Asset Performance Tracker</h4>
            <p>
                Asset Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </p>
            <p>
                Elections Rigged:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <p>
                Acts of Subterfuge performed:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button" runat="server" Height="27px" OnClick="Button_Click" Text="Add Asset" Width="125px" />
            </p>
            <p>
                <asp:Label ID="Label" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
