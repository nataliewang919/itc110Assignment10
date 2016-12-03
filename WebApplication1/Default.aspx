<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pizza</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Order Menu</h1>
<h2>Pizza</h2>
        <asp:CheckBoxList ID="PPizza" runat="server"></asp:CheckBoxList>
<h2>Size</h2>
        <asp:CheckBoxList ID="PSize" runat="server"></asp:CheckBoxList>
<h2>Toppings</h2>
        <asp:CheckBoxList ID="PTopping" runat="server"></asp:CheckBoxList>      
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
