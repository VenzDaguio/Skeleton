<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" width="133px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" width="133px"></asp:Label>
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateReceived" runat="server" Text="Date Received: " width="133px"></asp:Label>
            <asp:TextBox ID="txtDateReceived" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderPrice" runat="server" Text="Order Price: " width="133px"></asp:Label>
            <asp:TextBox ID="txtOrderPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDescription" runat="server" Text="Description:" width="133px"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity: " width="133px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivered" width="133px"/>
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" width="263px" Height="104px"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        </form>
</body>
</html>
