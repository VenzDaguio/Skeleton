<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 19px; width: 150px" Text="Customer ID"></asp:Label>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 294px; top: 17px; position: absolute; width: 54px; bottom: 593px;" Text="Find" OnClick="btnFind_Click1" />
            <br />
        </div>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 130px; top: 16px; position: absolute" height="22px"></asp:TextBox>
        <asp:Label ID="txtPayment" runat="server" style="z-index: 1; left: 10px; top: 92px; position: absolute" Text="Customer Payment Info" width="150px"></asp:Label>
        <asp:Label ID="txtAddress" runat="server" style="z-index: 1; left: 8px; top: 50px; position: absolute; bottom: 768px; " Text="Customer Address" width="150px"></asp:Label>
        <asp:Label ID="txtBirth" runat="server" style="z-index: 1; left: 10px; top: 125px; position: absolute; bottom: 688px; width: 150px;" Text="Date Of Birth"></asp:Label>
        <asp:Label ID="txtSignUp" runat="server" style="z-index: 1; left: 10px; top: 163px; position: absolute" Text="Sign Up Date" width="150px"></asp:Label>
        <asp:TextBox ID="txtAdress" runat="server" style="z-index: 1; left: 125px; top: 49px; position: absolute; height: 22px; bottom: 765px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtPaymentInfo" runat="server" style="z-index: 1; left: 156px; top: 87px; position: absolute" width="128px" height="22px"></asp:TextBox>
        <asp:TextBox ID="txtBirthDate" runat="server" style="z-index: 1; left: 109px; top: 123px; position: absolute" height="22px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtSign" runat="server" style="z-index: 1; left: 102px; top: 158px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
        <asp:CheckBox ID="chkOver18" runat="server" style="z-index: 1; left: 13px; top: 212px; position: absolute" Text="Over 18?" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 252px; position: absolute; width: 57px; height: 22px;" Text="Error"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 51px; top: 284px; position: absolute; height: 27px; width: 106px" Text="Cancel" />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; top: 283px; position: absolute; height: 29px; left: 10px; width: 35px;" Text="OK" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
