<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; width: 278px" Text="Are You sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 60px; top: 39px; position: absolute; width: 30px" Text="No" />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 9px; top: 39px; position: absolute" Text="Yes" />
        </div>
    </form>
</body>
</html>
