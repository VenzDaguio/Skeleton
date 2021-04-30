<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:ListBox ID="lstStockList" runat="server" Height="300px" Width="379px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="BtnEdit" runat="server" Text="Edit" OnClick="BtnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="height: 35px" Text="Delete" />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Enter a ClothesDescription"></asp:Label>
            <asp:ListBox ID="txtFilter" runat="server" Height="45px" style="margin-top: 21px" Width="263px"></asp:ListBox>
        </p>
        <p>
            <asp:Button ID="BtnApply" runat="server" OnClick="BtnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
