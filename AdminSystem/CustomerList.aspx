<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="238px" Width="318px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="btnAdd" runat="server" Height="33px" OnClick="btnAdd_Click" Text="Add" Width="67px" />
        </div>
    </form>
</body>
</html>
