<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerId" runat="server" Text="Customer Id" width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerId" runat="server" Width="319px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnFind" runat="server" Height="30px" OnClick="btnFind_Click" Text="Find" Width="49px" />
        <br />
        <asp:Label ID="lblCustomerFullName" runat="server" Text="Customer FullName" width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerFullName" runat="server" Width="319px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerGender" runat="server" Text="Customer Gender" width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlCustomerGender" runat="server" Height="16px" width="319px">
            <asp:ListItem Value="False">Female</asp:ListItem>
            <asp:ListItem Value="True">Male</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblCustomerDateOfBirth" runat="server" Text="Customer Date Of Birth"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerDateOfBirth" runat="server" Width="319px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email" width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerEmail" runat="server" Width="319px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Customer Address" width="145px"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCustomerAddress" runat="server" Width="319px"></asp:TextBox>
        <p>
            <asp:Label ID="lblError" runat="server" Width="420px"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
