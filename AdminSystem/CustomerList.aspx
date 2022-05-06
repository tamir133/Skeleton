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
        &nbsp;
            <asp:Button ID="btnEdit" runat="server" Height="33px" OnClick="btnEdit_Click" Text="Edit" Width="67px" />
&nbsp;
            <asp:Button ID="btnDelete" runat="server" Height="33px" OnClick="btnDelete_Click" Text="Delete" Width="67px" />
        </div>
        <br />
        <asp:Label ID="lblNotice" runat="server" Text="Please enter the name"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server" Width="238px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
