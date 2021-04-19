<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="lblError">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblStaffID" runat="server" Text="StaffID"></asp:Label>
            <asp:TextBox ID="txtStaffID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblSalary" runat="server" Text="Salary"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkAdmin" runat="server" Text="Admin" />
        <asp:CheckBox ID="chkMemberOfStaff" runat="server" Text="Member of Staff" />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOk" runat="server" Text="OK" />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
