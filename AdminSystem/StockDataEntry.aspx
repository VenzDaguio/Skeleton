<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="iblClothesNo" runat="server" Text="ClothesNo" width="190px"></asp:Label>
        <asp:TextBox ID="txtClothesNo" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <p>
            <asp:Label ID="iblClothesDescription" runat="server" Text="ClothesDescription "></asp:Label>
            <asp:TextBox ID="txtClothesDescription" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="iblPrice" runat="server" Text="Price" width="190px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="iblClothesColour" runat="server" Text="ClothesColour" width="190px"></asp:Label>
            <asp:TextBox ID="txtClothesColour" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="iblDateAdded" runat="server" Text="DateAdded" width="190px"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        </p>
        <asp:Label ID="iblError" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click1" Text="Ok" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
