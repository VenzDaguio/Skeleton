<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrdersDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <asp:Label ID="lblOrderID" runat="server" Text="Order ID:" width="89px"></asp:Label>
        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer ID:" width="89px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateReceived" runat="server" Text="Date Received: " width="89px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkDelivered" runat="server" Text="Delivered" />
            <br />
            <asp:Label ID="lblOrderPrice" runat="server" Text="Order Price: " width="89px"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDetails" runat="server" Text="Order Details: " width="89px"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity: " width="89px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblError" runat="server" Text="Label" width="89px"></asp:Label>
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
