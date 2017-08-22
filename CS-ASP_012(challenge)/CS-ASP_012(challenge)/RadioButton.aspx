<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="CS_ASP_012_challenge_.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Your Note Taking Preferences<br />
            <br />
            <asp:RadioButton ID="Pencil" runat="server" GroupName="tools" Text="Pencil" />
            <br />
            <asp:RadioButton ID="Pen" runat="server" GroupName="tools" Text="Pen" />
            <br />
            <asp:RadioButton ID="Phone" runat="server" GroupName="tools" Text="Phone" />
            <br />
            <asp:RadioButton ID="Tablet" runat="server" GroupName="tools" Text="Tablet" />
            <br />
            <br />
            <asp:Button ID="Button" runat="server" OnClick="Button1_Click" Text="Ok" />
            <br />
            <br />
            <asp:ImageButton ID="ImageButton" runat="server" Height="200px" ImageAlign="Left" Width="200px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="label" runat="server"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
