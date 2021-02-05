<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 19px; width: 150px" Text="Customer Address"></asp:Label>
            <br />
        </div>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 130px; top: 16px; position: absolute" height="22px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 92px; position: absolute" Text="Street" width="150px"></asp:Label>
        <asp:Label ID="txtHouseNo" runat="server" style="z-index: 1; left: 10px; top: 52px; position: absolute; bottom: 564px" Text="House No" width="150px"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 11px; top: 130px; position: absolute; bottom: 487px" Text="Town" width="150px"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 11px; top: 167px; position: absolute; bottom: 450px" Text="Post Code" width="150px"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 12px; top: 202px; position: absolute; width: 150px; bottom: 415px" Text="County"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 12px; top: 226px; position: absolute" Text="Date added" width="150px"></asp:Label>
        <asp:TextBox ID="txtHousNo" runat="server" style="z-index: 1; left: 82px; top: 47px; position: absolute; height: 22px; bottom: 565px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtStreet" runat="server" style="z-index: 1; left: 55px; top: 89px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 60px; top: 130px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 82px; top: 166px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtCounty" runat="server" style="z-index: 1; left: 67px; top: 199px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 85px; top: 225px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 9px; top: 262px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 15px; top: 294px; position: absolute; width: 57px" Text="Error"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 49px; top: 314px; position: absolute; height: 27px; width: 106px" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 316px; position: absolute; height: 26px;" Text="OK" />
    </form>
</body>
</html>
