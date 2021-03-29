<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute"></asp:TextBox>
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 6px; top: 38px; position: absolute; height: 357px; width: 318px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 10px; top: 401px; position: absolute" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 54px; top: 402px; position: absolute" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 100px; top: 402px; position: absolute; right: 339px;" Text="Delete" OnClick="btn_Click" />
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 124px; top: 438px; position: absolute; height: 24px"></asp:TextBox>
        <asp:Label ID="LblAddress" runat="server" style="z-index: 1; left: 14px; top: 444px; position: absolute; width: 110px; height: 5px" Text="Enter an Address"></asp:Label>
        <asp:Button ID="BtnApply" runat="server" style="z-index: 1; left: 13px; top: 470px; position: absolute" Text="Apply" />
        <asp:Button ID="BtnClear" runat="server" style="z-index: 1; left: 72px; top: 470px; position: absolute; height: 26px; width: 47px" Text="Clear" />
    </form>
</body>
</html>
