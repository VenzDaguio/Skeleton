<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>
<script runat="server">

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 357px; width: 318px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
        </div>
    </form>
</body>
</html>
