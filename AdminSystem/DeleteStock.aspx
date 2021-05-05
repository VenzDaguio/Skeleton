<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Are you sure you want to delete this record"></asp:Label>
        </div>
        <p>
            <asp:Button ID="BtnYES" runat="server" OnClick="Button2_Click" Text="YES" />
            <asp:Button ID="BtnNo" runat="server" Text="NO" OnClick="BtnNo_Click" />
        </p>
    </form>
</body>
</html>
