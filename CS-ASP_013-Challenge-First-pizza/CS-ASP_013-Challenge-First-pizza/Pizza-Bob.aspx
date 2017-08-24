<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pizza-Bob.aspx.cs" Inherits="CS_ASP_013_Challenge_First_pizza.Pizza_Bob" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #FF0000;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="panel" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False">
                <asp:ImageButton ID="ImageButton1" runat="server" BackColor="White" BorderStyle="None" Height="244px" ImageUrl="~/Resources/PapaBob.png" OnClick="ImageButton1_Click" Width="230px" />
                &nbsp;Papa Bob&#39;s Pizza and Software</asp:Panel>
            <br />
            <asp:RadioButton ID="BabySize" runat="server" GroupName="Size" Text="Baby Bob Size (10&quot;) - $10" />
            <br />
            <asp:RadioButton ID="MamaSize" runat="server" GroupName="Size" Text="Mama Bob Size (13&quot;) - $13" />
            <br />
            <asp:RadioButton ID="PapaSize" runat="server" GroupName="Size" Text="Papa Bob Size (16&quot;) - $16" />
            <br />
            <br />
            <asp:RadioButton ID="ThinCrust" runat="server" GroupName="Crust" Text="Thin Crust" Checked="True" />
            <br />
            <asp:RadioButton ID="DeepDish" runat="server" GroupName="Crust" Text="Deep Dish (+$2)" />
            <br />
            <br />
            <asp:CheckBox ID="Pepperoni" runat="server" Text="Pepperoni (+$1.50)" ValidationGroup="Toppings" />
            <br />
            <asp:CheckBox ID="Onions" runat="server" Text="Onions (+$0.75)" ValidationGroup="Toppings" />
            <br />
            <asp:CheckBox ID="GreenPeppers" runat="server" Text="Green Peppers (+$0.50)" ValidationGroup="Toppings" />
            <br />
            <asp:CheckBox ID="RedPeppers" runat="server" Text="Red Peppers (+$0.75)" ValidationGroup="Toppings" />
            <br />
            <asp:CheckBox ID="Anchovies" runat="server" Text="Anchovies (+$2.00)" ValidationGroup="Toppings" />
            <br />
            <br />
            <h3>Papa Bob&#39;s<span class="auto-style1"> Special Deal</span></h3>
            <br />
            <br />
            <asp:Label ID="saveLabel" runat="server" Text="Save $2.00 when you add Peperoni, Green Peppers and Anchovies OR  Pepperoni, Red Pepers and Onions to your Pizza."></asp:Label>
            <br />
            <br />
            <asp:Button ID="purchaseButton" runat="server" OnClick="purchaseButton_Click" Text="Purchase" />
            <br />
            <br />
            <asp:Label ID="totalLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="sorrylabel" runat="server" Text="Sorry, at this time you can only order one pizza online, and pick-up only.... we need a better website!"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
